using Xamarin.Forms;

namespace BlankApp1.Views
{
    public partial class FourthPage : ContentPage
    {
        public FourthPage()
        {
            InitializeComponent();
			System.Diagnostics.Debug.Write("FourthPageView Constructor. " + System.DateTime.Now.ToString("hh:mm.ss.fff"));
		}
	}
}
