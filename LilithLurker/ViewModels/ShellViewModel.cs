using System.Threading.Tasks;
using Caliburn.Micro;
using LilithLurker.Helpers;
using ProcessLurker;

namespace LilithLurker.ViewModels;

public class ShellViewModel : Conductor<IScreen>.Collection.AllActive
{
    #region Fields

    private DockingHelper _dockingHelper;
    private OverlayViewModel _overlayViewModel;
    private LilithViewModel _lilithViewModel;
    private ProcessService _processService;
    private IWindowManager _windowManager;
    private IEventAggregator _eventAggregator;

    #endregion

    #region Constructors

    public ShellViewModel(IWindowManager windowManager, IEventAggregator eventAggregator)
    {
        _windowManager = windowManager;
        _eventAggregator = eventAggregator;

        _ = WaitForDiablo();
    }

    #endregion

    public async void Close()
    {
        if (_overlayViewModel != null )
        {
            await _overlayViewModel.TryCloseAsync();
            _overlayViewModel = null;
        }

        await TryCloseAsync();
    }

    private async Task WaitForDiablo()
    {
        _processService = new ProcessService("Diablo IV");
        _processService.ProcessClosed += ProcessService_ProcessClosed;

        var windowHandle = await _processService.WaitForProcess(true, 0);
        _dockingHelper = new DockingHelper(windowHandle);
        _ = _dockingHelper.WatchForegoundAsync();

        Execute.OnUIThread(async () => 
        { 
            _overlayViewModel = new OverlayViewModel(_dockingHelper, _eventAggregator);
            await _windowManager.ShowWindowAsync(_overlayViewModel);

            _lilithViewModel = new LilithViewModel(_dockingHelper, _eventAggregator);
            await _windowManager.ShowWindowAsync(_lilithViewModel);
        });
    }

    private async void ProcessService_ProcessClosed(object sender, System.EventArgs e)
    {
        _processService.ProcessClosed -= ProcessService_ProcessClosed;
        _processService.Dispose();

        if (_overlayViewModel != null)
        {
            _overlayViewModel.Dispose();
            await _overlayViewModel.TryCloseAsync();

            _lilithViewModel.Dispose();
            await _lilithViewModel.TryCloseAsync();
        }

        _ = WaitForDiablo();
    }
}
