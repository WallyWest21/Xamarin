﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace HeadsUp
{
  
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
  
    public sealed partial class MainPage : Page
    {
        List<String> list = new List<String>();
        public MainPage()
        {
            this.InitializeComponent();

            
            list.Add("Kanye West");
            list.Add("Jay Z");
            list.Add("John Legend");
            list.Add("Adele");
        }

       

        private void MainPage1_Loaded(object sender, RoutedEventArgs e)
        {


        }
    }

       

       
    }

