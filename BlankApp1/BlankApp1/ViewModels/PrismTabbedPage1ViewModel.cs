﻿using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlankApp1.ViewModels
{
	public class PrismTabbedPage1ViewModel : BindableBase
	{
        public PrismTabbedPage1ViewModel()
        {
			System.Diagnostics.Debug.Write("PrismTabbedPage1ViewModel Constructor. " + DateTime.Now.ToString("hh:mm.ss.fff") + System.Environment.NewLine);

		}
	}
}
