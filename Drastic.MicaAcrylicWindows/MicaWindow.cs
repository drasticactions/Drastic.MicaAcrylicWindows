// <copyright file="MicaWindow.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using Microsoft.UI.Composition.SystemBackdrops;

namespace Drastic.UI.Xaml
{
    /// <summary>
    /// Mica Window.
    /// </summary>
    public class MicaWindow : BaseWindow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MicaWindow"/> class.
        /// </summary>
        /// <param name="config"><see cref="SystemBackdropConfiguration"/>, Optional.</param>
        public MicaWindow(SystemBackdropConfiguration? config = null)
            : base(new MicaController(), config)
        {
        }
    }
}
