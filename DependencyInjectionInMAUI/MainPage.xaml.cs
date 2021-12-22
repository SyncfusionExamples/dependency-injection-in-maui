using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace DependencyInjectionInMAUI
{
	public partial class MainPage : ContentPage
	{
		public MainPage( ViewModel viewModel)
		{
			InitializeComponent();
			this.BindingContext = viewModel;
		}

	}
}
