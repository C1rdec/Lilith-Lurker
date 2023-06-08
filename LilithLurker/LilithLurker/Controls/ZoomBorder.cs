using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace LilithLurker.Controls;

public class ZoomBorder : Border
{
    #region Fields

    private UIElement child = null;
    private Point origin;
    private Point start;

    #endregion

    #region Properties

    public override UIElement Child
    {
        get { return base.Child; }
        set
        {
            if (value != null && value != Child)
            {
                Initialize(value);
            }

            base.Child = value;
        }
    }

    #endregion

    #region Methods

    public void Initialize(UIElement element)
    {
        child = element;
        if (child != null)
        {
            var group = new TransformGroup();
            var st = new ScaleTransform();
            group.Children.Add(st);
            var tt = new TranslateTransform();
            group.Children.Add(tt);
            child.RenderTransform = group;
            child.RenderTransformOrigin = new Point(0.0, 0.0);
            MouseWheel += Child_MouseWheel;
            MouseLeftButtonDown += Child_MouseLeftButtonDown;
            MouseLeftButtonUp += Child_MouseLeftButtonUp;
            MouseMove += Child_MouseMove;
            PreviewMouseRightButtonDown += new MouseButtonEventHandler(Child_PreviewMouseRightButtonDown);
        }
    }

    public void Reset()
    {
        if (child != null)
        {
            // reset zoom
            var st = GetScaleTransform(child);
            st.ScaleX = 1.0;
            st.ScaleY = 1.0;

            // reset pan
            var tt = GetTranslateTransform(child);
            tt.X = 0.0;
            tt.Y = 0.0;
        }
    }

    private static TranslateTransform GetTranslateTransform(UIElement element)
    {
        return (TranslateTransform)((TransformGroup)element.RenderTransform)
          .Children.First(tr => tr is TranslateTransform);
    }

    private static ScaleTransform GetScaleTransform(UIElement element)
    {
        return (ScaleTransform)((TransformGroup)element.RenderTransform)
          .Children.First(tr => tr is ScaleTransform);
    }

    private void Child_MouseWheel(object sender, MouseWheelEventArgs e)
    {
        if (child != null)
        {
            var st = GetScaleTransform(child);
            var tt = GetTranslateTransform(child);

            var zoom = e.Delta > 0 ? .2 : -.2;
            if (!(e.Delta > 0) && (st.ScaleX < .4 || st.ScaleY < .4))
            {
                return;
            }

            var relative = e.GetPosition(child);
            double absoluteX;
            double absoluteY;

            absoluteX = relative.X * st.ScaleX + tt.X;
            absoluteY = relative.Y * st.ScaleY + tt.Y;

            st.ScaleX += zoom;
            st.ScaleY += zoom;

            tt.X = absoluteX - relative.X * st.ScaleX;
            tt.Y = absoluteY - relative.Y * st.ScaleY;
        }
    }

    private void Child_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        if (child != null)
        {
            var tt = GetTranslateTransform(child);
            start = e.GetPosition(this);
            origin = new Point(tt.X, tt.Y);
            Cursor = Cursors.Hand;
            child.CaptureMouse();
        }
    }

    private void Child_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
        if (child != null)
        {
            child.ReleaseMouseCapture();
            Cursor = Cursors.Arrow;
        }
    }

    private void Child_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
    {
        Reset();
    }

    private void Child_MouseMove(object sender, MouseEventArgs e)
    {
        if (child != null)
        {
            if (child.IsMouseCaptured)
            {
                var tt = GetTranslateTransform(child);
                Vector v = start - e.GetPosition(this);
                tt.X = origin.X - v.X;
                tt.Y = origin.Y - v.Y;
            }
        }
    }

    #endregion
}
