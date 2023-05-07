﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SetProtectedProperty
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            //InitializeComponent();
        }

        protected string Prop { get; set; }

    }

    public partial class Window2 : Window1
    {
        public Window2()
        {
            InitializeComponent();
        }

        public string GetProtectedProperty()
        {
            return Prop;
        }
    }
}