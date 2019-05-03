using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DynamicForms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabPage : TabbedPage
    {
        public TabPage ()
        {
            InitializeComponent();
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
        }
    }
}