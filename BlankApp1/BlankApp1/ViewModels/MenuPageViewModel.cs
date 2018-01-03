using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlankApp1.ViewModels
{
	public class MenuPageViewModel : BindableBase
	{
        public MenuPageViewModel()
        {
			System.Diagnostics.Debug.Write("MenuPageViewModel Constructor. " + DateTime.Now.ToString("hh:mm.ss.fff"));

		}
	}
}
