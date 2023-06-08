using System;
using System.Windows;

namespace LilithLurker.Views
{
    /// <summary>
    /// Interaction logic for OverlayView.xaml
    /// </summary>
    public partial class OverlayView : Window
    {
        #region Fields

        private Window _parent;

        #endregion

        #region Constructors

        public OverlayView()
        {
            InitializeComponent();
            HideFromAltTab();
        }

        #endregion

        #region Methods

        protected override void OnClosed(EventArgs e)
        {
            _parent.Close();
            base.OnClosed(e);
        }

        private void HideFromAltTab()
        {
            _parent = new Window
            {
                Top = -100,
                Left = -100,
                Width = 1,
                Height = 1,

                WindowStyle = WindowStyle.ToolWindow, // Set window style as ToolWindow to avoid its icon in AltTab
                ShowInTaskbar = false,
            };

            _parent.Show();
            Owner = _parent;
            _parent.Hide();
        }

        #endregion
    }
}
