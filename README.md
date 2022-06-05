# Drastic.MicaAcrylicWindows

![スクリーンショット 2022-06-04 223812](https://user-images.githubusercontent.com/898335/172033236-27f1048e-1d58-4890-a460-8ffd7bfcc3b6.png)

This is a simple library for creating a WinUI Window with a Acrylic or Mica style backdrop.

## How to use

`MicaWindow` and `AcyrlicWindow` are `Window` types that can be used like any other WinUI Window. Just create one and fill it with content. Any other settings (Like extending the titlebar) can be done just as you would with any other Window.

From Code

```
  var window = new Drastic.UI.Xaml.MicaWindow() { };
  window.Activate();
```

```
  var window = new Drastic.UI.Xaml.AcyrlicWindow() { };
  window.Activate();
```

From XAML

Window.xaml
```
<drastic:MicaWindow
    xmlns:drastic="using:Drastic.UI.Xaml"
    x:Class="Drastic.MicaAcrylicWindows.Sample.TestWindow"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:local="using:Drastic.MicaAcrylicWindows.Sample"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    mc:Ignorable="d">
</drastic:MicaWindow>
```

Window.xaml.cs
```
using Drastic.UI.Xaml;

namespace Drastic.MicaAcrylicWindows.Sample
{
    public sealed partial class TestWindow : MicaWindow
    {
        public TestWindow()
        {
            this.InitializeComponent();
        }
    }
}
```