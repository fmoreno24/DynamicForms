namespace DynamicForms.Customs
{
    using Xamarin.Forms;
    public class FrameCustom: Frame
    {
        public FrameCustom()
        {
            BackgroundColor = Color.FromHex("#fdfdfd");
            BorderColor = Color.FromHex("#e5e5e5");
            WidthRequest = 300;
            HeightRequest = 100;
            Margin = new Thickness(20, 10, 20, 10);
            CornerRadius = 15;
            Opacity = 0.7;
        }
    }
}
