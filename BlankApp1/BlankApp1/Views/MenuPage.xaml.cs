using Xamarin.Forms;

namespace BlankApp1.Views
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
			System.Diagnostics.Debug.Write("MenuPageView Constructor. " + System.DateTime.Now.ToString("hh:mm.ss.fff") + System.Environment.NewLine);
		}
	}
}
