using System;

namespace LilithLurker.Models
{
    public class WindowInformation : EventArgs
    {
        #region Properties

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        public Native.Rect Position { get; set; }

        #endregion
    }
}
