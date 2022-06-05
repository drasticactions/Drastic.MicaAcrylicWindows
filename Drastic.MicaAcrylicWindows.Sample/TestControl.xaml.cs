// <copyright file="TestControl.xaml.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.
namespace Drastic.MicaAcrylicWindows.Sample
{
    /// <summary>
    /// Test Control.
    /// Used to launch new windows.
    /// </summary>
    public sealed partial class TestControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestControl"/> class.
        /// </summary>
        public TestControl()
        {
            this.InitializeComponent();
        }

        private void CreateWindow_Click(object sender, RoutedEventArgs e)
        {
            var window = new Window() { Content = new TestControl() };
            window.Activate();
        }

        private void CreateMicaWindow_Click(object sender, RoutedEventArgs e)
        {
            var window = new Drastic.UI.Xaml.MicaWindow() { Content = new TestControl() };
            window.Activate();
        }

        private void CreateAcrylicWindow_Click(object sender, RoutedEventArgs e)
        {
            var window = new Drastic.UI.Xaml.AcrylicWindow() { Content = new TestControl() };
            window.Activate();
        }
    }
}
