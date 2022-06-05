// <copyright file="AcrylicWindow.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using Microsoft.UI.Composition.SystemBackdrops;

namespace Drastic.UI.Xaml
{
    /// <summary>
    /// Acrylic Window.
    /// </summary>
    public class AcrylicWindow : BaseWindow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcrylicWindow"/> class.
        /// </summary>
        /// <param name="config"><see cref="SystemBackdropConfiguration"/>, Optional.</param>
        public AcrylicWindow(SystemBackdropConfiguration? config = null)
            : base(new DesktopAcrylicController(), config)
        {
        }
    }
}
