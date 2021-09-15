﻿using System;

using MicaSample.ViewModels;

using Windows.UI.Xaml.Controls;

namespace MicaSample.Views
{
    public sealed partial class WebViewPage : Page
    {
        public WebViewViewModel ViewModel { get; } = new WebViewViewModel();

        public WebViewPage()
        {
            InitializeComponent();
            ViewModel.Initialize(webView);
        }
    }
}
