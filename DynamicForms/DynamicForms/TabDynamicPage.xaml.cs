
namespace DynamicForms
{
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TabDynamicPage : TabbedPage
	{
		public TabDynamicPage ()
		{
			InitializeComponent ();
            createPage();
        }

        private void createPage()
        {
            var PageDynamic = new ContentPage();
            var label = new Label();
            label.Text = "Fuck yeah!!!!!!!";

            var ContentStack = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    label
                }
            };

            PageDynamic.Title = "Fuck";
            PageDynamic.Content = ContentStack;
            this.Children.Add(PageDynamic);

            var PageDynamic2 = new ContentPage();
            var label2 = new Label();
            label2.Text = "Fuck yeah!!!!!!! 2";

            var ContentStack2 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    label2
                }
            };

            PageDynamic2.Title = "Fuck2";
            PageDynamic2.Content = ContentStack2;

            
            this.Children.Add(PageDynamic2);
        }
    }
}