using Xamarin.Forms;

namespace BlankApp1.Views
{
    public partial class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            InitializeComponent();
			System.Diagnostics.Debug.Write("ThirdPageView Constructor. " + System.DateTime.Now.ToString("hh:mm.ss.fff"));
		}
	}
}
