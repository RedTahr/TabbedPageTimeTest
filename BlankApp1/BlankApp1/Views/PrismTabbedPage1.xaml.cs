using Xamarin.Forms;

namespace BlankApp1.Views
{
    public partial class PrismTabbedPage1 : TabbedPage
    {
        public PrismTabbedPage1()
        {
            InitializeComponent();
			System.Diagnostics.Debug.Write("PrismTabbedPage1View Constructor. " + System.DateTime.Now.ToString("hh:mm.ss.fff"));
		}
	}
}
