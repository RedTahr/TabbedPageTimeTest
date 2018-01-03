using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlankApp1.ViewModels
{
	public class HomePageViewModel : BindableBase
	{
        public HomePageViewModel()
        {
			System.Diagnostics.Debug.Write("HomePageViewModel Constructor. " + DateTime.Now.ToString("hh:mm.ss.fff"));

		}
	}
}
