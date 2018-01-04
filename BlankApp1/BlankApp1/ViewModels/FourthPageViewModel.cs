using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlankApp1.ViewModels
{
	public class FourthPageViewModel : BindableBase
	{
        public FourthPageViewModel()
        {
			System.Diagnostics.Debug.Write("FourthPageViewModel Constructor. " + DateTime.Now.ToString("hh:mm.ss.fff") + System.Environment.NewLine);
        }
	}
}
