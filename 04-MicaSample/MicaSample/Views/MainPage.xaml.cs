using System;

using MicaSample.ViewModels;

using Windows.UI.Xaml.Controls;

namespace MicaSample.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
