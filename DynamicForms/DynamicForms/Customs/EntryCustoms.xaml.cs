using DynamicForms.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DynamicForms.Customs
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EntryCustoms : FlexLayout
    {
        private string id;
        public string ID
        {
            get { return this.id; }
            set { SetValue(ref this.id, value); }
        }

        protected void SetValue<T>(ref T backingField, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingField, value))
            {
                return;
            }

            backingField = value;
            OnPropertyChanged(propertyName);
        }

        public EntryCustoms ()
		{
			InitializeComponent ();
            title.Text = Title;
            entry.Text = Text;
            entry.TextChanged += OnTextChanged;
        }

        public EntryCustoms(string id)
        {
            InitializeComponent();
            title.Text = Title;
            entry.Text = Text;
            entry.TextChanged += OnTextChanged;
            this.id = id;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            Text = e.NewTextValue;
        }

        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(EntryCustoms), default(string), Xamarin.Forms.BindingMode.OneWay);
        public string Title
        {
            get
            {
                return (string)GetValue(TitleProperty);
            }

            set
            {
                SetValue(TitleProperty, value);
            }
        }
        
        public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(EntryCustoms), default(string), BindingMode.TwoWay);
        public string Text
        {
            get
            {
                return (string)GetValue(TextProperty);
            }

            set
            {
                SetValue(TextProperty, value);
            }
        }

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == TitleProperty.PropertyName)
            {
                title.Text = Title;
            }

            else if (propertyName == TextProperty.PropertyName)
            {
                entry.Text = Text;
            }
        }

    }
}