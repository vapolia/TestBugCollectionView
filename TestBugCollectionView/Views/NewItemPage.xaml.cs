﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using TestBugCollectionView.Models;
using TestBugCollectionView.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestBugCollectionView.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}