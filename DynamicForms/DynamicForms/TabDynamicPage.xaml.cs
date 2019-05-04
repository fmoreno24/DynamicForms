
namespace DynamicForms
{
    using System;
    using DynamicForms.Customs;
    using DynamicForms.Fields;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TabDynamicPage : TabbedPage
	{
		public TabDynamicPage ()
		{
			InitializeComponent ();
            createPage();
            CreatePageTwo();
        }
        
        private void createPage()
        {
            var PageDynamic = new ContentPage();
            //var label = new Label();
            //label.Text = "Fuck yeah!!!!!!!";

            //var ContentStack = new StackLayout
            //{
            //    Orientation = StackOrientation.Horizontal,
            //    Children =
            //    {
            //        label
            //    }
            //};

            //PageDynamic.Title = "Fuck";
            

            var entryT = new EntryCustoms();
            entryT.Title = "Primer campo";
            PageDynamic.Content = entryT;
            this.Children.Add(PageDynamic);

            
        }

        private void CreatePageTwo()
        {
            var PageDynamic = new ContentPage();
            var label2 = new Label();
            label2.Text = "Fuck yeah!!!!!!! 2";
            var entryCustom = new EntryCustom();
            var ContentStack2 = new FlexLayout
            {
                Direction = FlexDirection.Column,
                Children =
                {
                    label2,
                    entryCustom
                }
            };
            var FrameCustom = new FrameCustom {
                Content = ContentStack2
            };
            
            var ContentFlexLayout = new FlexLayoutCustom
            {
                Children =
                {
                    FrameCustom
                }
            };
           

            

            PageDynamic.Title = "Fuck2";
            PageDynamic.Content = ContentFlexLayout;


            this.Children.Add(PageDynamic);
        }
    }
}