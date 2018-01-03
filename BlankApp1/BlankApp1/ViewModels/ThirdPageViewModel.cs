using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlankApp1.ViewModels
{
	public class ThirdPageViewModel : BindableBase
	{
        public ThirdPageViewModel()
        {
			System.Diagnostics.Debug.Write("ThirdPageViewModel Constructor. " + DateTime.Now.ToString("hh:mm.ss.fff"));

		}
	}
}
