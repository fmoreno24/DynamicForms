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
    public partial class PickerCustoms : FlexLayout
    {
        //private Picker pickerT;

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

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == TitleProperty.PropertyName)
            {
                //title.Text = Title;
            }
        }

        public PickerCustoms()
        {
            InitializeComponent();
            //title.Text = Title;
        }

        public PickerCustoms(string id)
        {
            InitializeComponent();
            //title.Text = Title;
            this.id = id;
        }

        public void createPicker(string item)
        {
            //pickerT = new Picker();
            picker.Items.Add(item);
            //picker = pickerT;
        }

        public void selectedItem()
        {
            //picker.SelectedItem();
        }
    }
}