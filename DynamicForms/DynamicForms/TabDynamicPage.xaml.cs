
namespace DynamicForms
{
    using System;
    using System.Collections.Generic;
    using DynamicForms.Customs;
    using DynamicForms.Fields;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TabDynamicPage : TabbedPage
	{
        private List<object> listDynamic;
        public TabDynamicPage ()
		{
			InitializeComponent ();
            listDynamic = new List<object>();
            createPage();
            CreatePageTwo();
        }
        

        private void createPage()
        {
            var PageDynamic = new ContentPage();
            
            Button CurrentButton = new Button()
            {
                Text = "Button"
            };
            EntryCustoms entryT = new EntryCustoms("123456");
            PickerCustoms picker = new PickerCustoms("454545");

            picker.createPicker("Goku es el guerrero mas fuerte de todos los universos y mató.");
            picker.createPicker("Vegeta");
            picker.createPicker("Gohan");
            CurrentButton.Clicked += OnButtonClicked;
            StackLayout stack = new StackLayout();
            //button.Clicked += OnButtonClicked;
            
            entryT.Title = "Primer campo";
            PageDynamic.Title = "Pagina 1";
            stack.Children.Add(entryT);
            stack.Children.Add(picker);
            stack.Children.Add(CurrentButton);
            PageDynamic.Content = stack;
            listDynamic.Add(entryT);
            this.Children.Add(PageDynamic);
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            Button ClickedButton = (Button)sender;
            if(listDynamic != null && listDynamic.Count > 0)
            {
                for(int i = 0; i < listDynamic.Count; i++)
                {
                    ClickedButton.Text = "You clicked the button with id " + ClickedButton.StyleId;
                }
            }
            
        }

        private void CreatePageTwo()
        {
            var PageDynamic = new ContentPage();
            var entryT = new EntryCustoms("654321");
            entryT.Title = "Otro campo";
            PageDynamic.Title = "Pagina 2";
            PageDynamic.Content = entryT;
            listDynamic.Add(entryT);
            this.Children.Add(PageDynamic);
        }
    }
}