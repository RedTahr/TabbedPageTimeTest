using BlankApp1.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlankApp1.ViewModels {
	public class MainPageViewModel : ViewModelBase {

		public DelegateCommand GotoTabbedPageCommand { get; set; }

		public MainPageViewModel(INavigationService navigationService)
			: base(navigationService) {
			Title = "Main Page";			
			GotoTabbedPageCommand = new DelegateCommand(GotoTabbedPage);

		}

		private async void GotoTabbedPage() {
			System.Diagnostics.Debug.Write("GotoTabbedPage fired. " + DateTime.Now.ToString("hh:mm.ss.fff") + System.Environment.NewLine);
			BlankApp1.App.StartTime = System.DateTime.Now;

			await NavigationService.NavigateAsync(nameof(PrismTabbedPage1));
		}
	}
}
