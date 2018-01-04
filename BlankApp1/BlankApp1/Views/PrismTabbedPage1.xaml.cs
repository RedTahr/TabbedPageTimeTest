using Xamarin.Forms;

namespace BlankApp1.Views
{
    public partial class PrismTabbedPage1 : TabbedPage
    {
        public PrismTabbedPage1()
        {
            InitializeComponent();
			App.FinishTime = System.DateTime.Now;
			System.Diagnostics.Debug.Write("PrismTabbedPage1View Constructor. " + System.DateTime.Now.ToString("hh:mm.ss.fff") + System.Environment.NewLine);

			System.Diagnostics.Debug.WriteLine("Time taken to load TabbedPage: " + (App.FinishTime - App.StartTime));
		}
	}
}
