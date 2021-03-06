﻿using BlankApp1.ViewModels;
using BlankApp1.Views;
using Microsoft.Practices.Unity;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace BlankApp1 {


	public partial class App : PrismApplication {
		public static DateTime StartTime { get; set; }
		public static DateTime FinishTime { get; set; }
		/* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
		public App() : this(null) { }

		public App(IPlatformInitializer initializer) : base(initializer) { }

		protected override async void OnInitialized() {
			InitializeComponent();

			await NavigationService.NavigateAsync("MainPage");
		}

		protected override void RegisterTypes() {
			Container.RegisterTypeForNavigation<NavigationPage>();
			Container.RegisterTypeForNavigation<MainPage>();
			Container.RegisterTypeForNavigation<PrismTabbedPage1>();
			Container.RegisterTypeForNavigation<HomePage>();
			Container.RegisterTypeForNavigation<ThirdPage>();
			Container.RegisterTypeForNavigation<MenuPage>();
			Container.RegisterTypeForNavigation<FourthPage>();
		}
	}
}
