using Xamarin.Forms;

namespace BlankApp1.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
			System.Diagnostics.Debug.Write("HomePageView Constructor. " + System.DateTime.Now.ToString("hh:mm.ss.fff"));
		}
	}
}
