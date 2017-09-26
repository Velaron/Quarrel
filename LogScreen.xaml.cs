﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Security.Credentials;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Discord_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LogScreen : Page
    {
        public LogScreen()
        {
            this.InitializeComponent();
        }

        private async void LogIn(object sender, RoutedEventArgs e)
        {
            if (await RESTCalls.Login(Username.Text, Password.Password))
            {
                PasswordCredential credentials = new PasswordCredential("LogIn", Username.Text, Password.Password);
                Storage.PasswordVault.Add(credentials);
                Frame.Navigate(typeof(MainPage));
            } else
            {
                //TODO: Some kind of message
            }
        }
    }
}