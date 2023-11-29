namespace poc_maui.Views;

public partial class CardPage : ContentPage
{
    public CardPage()
    {
        InitializeComponent();

        DeviceDisplay.Current.MainDisplayInfoChanged += DeviceDisplay_MainDisplayInfoChanged;
    }

    private void DeviceDisplay_MainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
    {
        if (DeviceDisplay.MainDisplayInfo.Orientation == DisplayOrientation.Landscape)
        {
            image1.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? (DeviceInfo.Platform == DevicePlatform.iOS ? 190 : 210)
                                    : (DeviceInfo.Idiom == DeviceIdiom.Phone ? 210 : 300);
            image2.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? (DeviceInfo.Platform == DevicePlatform.iOS ? 190 : 210)
                                   : (DeviceInfo.Idiom == DeviceIdiom.Phone ? 210 : 300);
            image3.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? (DeviceInfo.Platform == DevicePlatform.iOS ? 190 : 210)
                                    : (DeviceInfo.Idiom == DeviceIdiom.Phone ? 210 : 300);
            image4.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? (DeviceInfo.Platform == DevicePlatform.iOS ? 190 : 210)
                                    : (DeviceInfo.Idiom == DeviceIdiom.Phone ? 210 : 300);
            image5.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? (DeviceInfo.Platform == DevicePlatform.iOS ? 190 : 210)
                                    : (DeviceInfo.Idiom == DeviceIdiom.Phone ? 210 : 300);
            image6.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? (DeviceInfo.Platform == DevicePlatform.iOS ? 190 : 210)
                                    : (DeviceInfo.Idiom == DeviceIdiom.Phone ? 210 : 300);
            image7.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? (DeviceInfo.Platform == DevicePlatform.iOS ? 190 : 210)
                                    : (DeviceInfo.Idiom == DeviceIdiom.Phone ? 210 : 300);
            image8.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? (DeviceInfo.Platform == DevicePlatform.iOS ? 190 : 210)
                                    : (DeviceInfo.Idiom == DeviceIdiom.Phone ? 210 : 300);
            image9.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? (DeviceInfo.Platform == DevicePlatform.iOS ? 190 : 210)
                                    : (DeviceInfo.Idiom == DeviceIdiom.Phone ? 210 : 300);
            image10.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? (DeviceInfo.Platform == DevicePlatform.iOS ? 190 : 210)
                                    : (DeviceInfo.Idiom == DeviceIdiom.Phone ? 210 : 300);
            image11.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? (DeviceInfo.Platform == DevicePlatform.iOS ? 190 : 210)
                                    : (DeviceInfo.Idiom == DeviceIdiom.Phone ? 210 : 300);
            image12.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? (DeviceInfo.Platform == DevicePlatform.iOS ? 190 : 210)
                                    : (DeviceInfo.Idiom == DeviceIdiom.Phone ? 210 : 300);
            image13.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? (DeviceInfo.Platform == DevicePlatform.iOS ? 190 : 210)
                                    : (DeviceInfo.Idiom == DeviceIdiom.Phone ? 210 : 300);
            image14.WidthRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? (DeviceInfo.Platform == DevicePlatform.iOS ? 190 : 210)
                                    : (DeviceInfo.Idiom == DeviceIdiom.Phone ? 210 : 300);
            image15.WidthRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? (DeviceInfo.Platform == DevicePlatform.iOS ? 190 : 210)
                                    : (DeviceInfo.Idiom == DeviceIdiom.Phone ? 210 : 300);
            bottomDeck.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? (DeviceInfo.Platform == DevicePlatform.iOS ? 190 : 210)
                                    : (DeviceInfo.Idiom == DeviceIdiom.Phone ? 210 : 300);
            //image1.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 210 : 300; 
            //image2.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 210 : 300; 
            //image3.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 210 : 300; 
            //image4.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 210 : 300; 
            //image5.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 210 : 300; 
            //image6.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 210 : 300; 
            //image7.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 210 : 300; 
            //image8.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 210 : 300; 
            //image9.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 210 : 300; 
            //image10.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 210 : 300; 
            //image11.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 210 : 300;
            //image12.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 210 : 300;
            //image13.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 210 : 300;
            //image14.WidthRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 210 : 300; 
            //image15.WidthRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 210 : 300;
            //bottomDeck.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 210 : 300;
        }
        else
        {
            image1.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 90 : 210; 
            image2.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 90 : 210;
            image3.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 90 : 210;
            image4.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 90 : 210;
            image5.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 90 : 210;
            image6.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 90 : 210;
            image7.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 90 : 210;
            image8.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 90 : 210;
            image9.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 90 : 210;
            image10.HeightRequest =(DeviceInfo.Idiom == DeviceIdiom.Phone) ? 90 : 210;
            image11.HeightRequest =(DeviceInfo.Idiom == DeviceIdiom.Phone) ? 90 : 210;
            image12.HeightRequest =(DeviceInfo.Idiom == DeviceIdiom.Phone) ? 90 : 210;
            image13.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 90 : 210;
            image14.WidthRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 90 : 210;
            image15.WidthRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 90 : 210;
            bottomDeck.HeightRequest = (DeviceInfo.Idiom == DeviceIdiom.Phone) ? 100 : 210;
        }
    }
}
