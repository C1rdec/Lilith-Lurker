using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using LilithLurker.Models;
using ProcessLurker;

namespace LilithLurker.Helpers
{
    public class DockingHelper : IDisposable
    {
        #region Fields

        private const uint GainMouseCapture = 8;
        private const uint LostMouseCapture = 9;
        private const uint MoveEnd = 11;

        private readonly uint _windowProcessId;
        private readonly uint _windowOwnerId;
        private readonly Native.WinEventDelegate _winEventDelegate;

        private readonly Process _myProcess;
        private readonly CancellationTokenSource _tokenSource;
        private readonly IntPtr _hook;
        private readonly IntPtr _windowHandle;
        private readonly Process _process;
        private bool _foreground;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DockingHelper" /> class.
        /// </summary>
        /// <param name="processId">The process identifier.</param>
        /// <param name="settingsService">The settings service.</param>
        public DockingHelper(int processId)
        {
            _process = ProcessService.GetProcessById(processId);
            if (_process != null)
            {
                _myProcess = Process.GetCurrentProcess();
                _tokenSource = new CancellationTokenSource();
                _windowHandle = _process.GetWindowHandle();

                _windowOwnerId = Native.GetWindowThreadProcessId(_windowHandle, out _windowProcessId);
                _winEventDelegate = WhenWindowMoveStartsOrEnds;
                _hook = Native.SetWinEventHook(0, MoveEnd, _windowHandle, _winEventDelegate, _windowProcessId, _windowOwnerId, 0);
                WindowInformation = GetWindowInformation();
            }
        }

        #endregion

        #region Events

        /// <summary>
        /// Occurs when [on window move].
        /// </summary>
        public event EventHandler<WindowInformation> OnWindowMove;

        /// <summary>
        /// Occurs when [on lost mouse capture].
        /// </summary>
        public event EventHandler OnLostMouseCapture;

        /// <summary>
        /// Occurs when [on mouse capture].
        /// </summary>
        public event EventHandler OnMouseCapture;

        /// <summary>
        /// Occurs when [on foreground change].
        /// </summary>
        public event EventHandler<bool> OnForegroundChange;

        #endregion

        #region Properties

        /// <summary>
        /// Gets a value indicating whether this instance is window in foreground.
        /// </summary>
        public bool IsWindowInForeground => _windowHandle == Native.GetForegroundWindow();

        /// <summary>
        /// Gets the window information.
        /// </summary>
        public WindowInformation WindowInformation { get; private set; }

        #endregion

        #region Methods

        /// <summary>
        /// Sets the foreground.
        /// </summary>
        /// <param name="handle">The handle.</param>
        public static void SetForeground(IntPtr handle)
        {
            _ = Native.SetForegroundWindow(handle);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Sets the foreground.
        /// </summary>
        public void SetForeground()
        {
            SetForeground(_windowHandle);
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _myProcess.Dispose();
                _tokenSource.Cancel();
                Native.UnhookWinEvent(this._hook);
            }
        }

        /// <summary>
        /// Whens the window move starts or ends.
        /// </summary>
        /// <param name="hWinEventHook">The h win event hook.</param>
        /// <param name="eventType">Type of the event.</param>
        /// <param name="hwnd">The HWND.</param>
        /// <param name="idObject">The identifier object.</param>
        /// <param name="idChild">The identifier child.</param>
        /// <param name="dwEventThread">The dw event thread.</param>
        /// <param name="dwmsEventTime">The DWMS event time.</param>
        private void WhenWindowMoveStartsOrEnds(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime)
        {
            if (_windowHandle != hwnd)
            {
                return;
            }

            switch (eventType)
            {
                case MoveEnd:
                    this.InvokeWindowMove();
                    break;
                case GainMouseCapture:
                    this.Invoke(this.OnMouseCapture);
                    break;
                case LostMouseCapture:
                    this.Invoke(this.OnLostMouseCapture);
                    break;
            }
        }

        /// <summary>
        /// Watches the foregound.
        /// </summary>
        public Task WatchForegoundAsync()
        {
            return Task.Run(async () =>
            {
                var token = _tokenSource.Token;
                while (true)
                {
                    try
                    {
                        if (token.IsCancellationRequested)
                        {
                            return;
                        }

                        var inForeground = false;
                        var foregroundWindow = Native.GetForegroundWindow();
                        _ = Native.GetWindowThreadProcessId(foregroundWindow, out var processId);

                        var style = Native.GetWindowLong(_windowHandle, -16);

                        if (processId == _myProcess.Id || foregroundWindow == _windowHandle)
                        {
                            inForeground = true;
                        }

                        if (_foreground != inForeground)
                        {
                            _foreground = inForeground;
                            OnForegroundChange?.Invoke(this, _foreground);
                        }

                        await Task.Delay(500);
                    }
                    catch
                    {
                    }
                }
            });
        }

        /// <summary>
        /// Invokes the specified handler.
        /// </summary>
        /// <param name="handler">The handler.</param>
        private void Invoke(EventHandler handler)
        {
            handler?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Invokes the window move.
        /// </summary>
        private void InvokeWindowMove()
        {
            WindowInformation = GetWindowInformation();
            OnWindowMove?.Invoke(this, WindowInformation);
        }

        /// <summary>
        /// Gets the window information.
        /// </summary>
        /// <returns>The poe window information.</returns>
        private WindowInformation GetWindowInformation()
        {
            var position = HandleWideScreen();
            double width = position.Right - position.Left;
            double height = position.Bottom - position.Top;

            return new WindowInformation()
            {
                Height = height,
                Width = width,
                Position = position,
            };
        }

        private Native.Rect HandleWideScreen()
        {
            Native.Rect position = default;
            Native.GetWindowRect(_windowHandle, ref position);

            return position;
        }

        #endregion
    }
}
