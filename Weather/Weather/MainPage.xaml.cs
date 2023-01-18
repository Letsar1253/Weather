using Microsoft.Maui.Controls;

namespace Weather;

enum WeatherType {
    Sunny,
    Rain,
    Haze,
    Cloudly,
    Overcast_Cloudly,
    Sleet,
    Snow,
    Thunder,
    Thunder_Rain
};

public partial class MainPage : ContentPage
{
    readonly Dictionary<WeatherType, string> weatherTypeImages = new() {
        { WeatherType.Sunny,            "sunny" },
        { WeatherType.Rain,             "rain" },
        { WeatherType.Haze,             "haze" },
        { WeatherType.Cloudly,          "cloudly" },
        { WeatherType.Overcast_Cloudly, "overcast_cloudly" },
        { WeatherType.Sleet,            "sleet" },
        { WeatherType.Snow,             "snow" },
        { WeatherType.Thunder,          "thunder" },
        { WeatherType.Thunder_Rain,     "thunder_rain" }
    };

	readonly Color ColdColor = Color.FromRgb( 212, 244, 255 );
	readonly Color WarmColor = Color.FromRgb( 255, 236, 225 );
	readonly double ColdBorder = -40, WarmBorder = 50;

	private void setDayData( DateTime date ) {

	}

    private void setTemperature( double temperature ) { 
        MainPageObject.BackgroundColor = getGradientColor(
            ( temperature - ColdBorder ) / ( WarmBorder - ColdBorder ) );
    }

    private void setWeatherImage( WeatherType weatherType ) {
        Image weatherImage = new() {
            Source = weatherTypeImages[ weatherType ] + ".png",
            HeightRequest = 150,
            HorizontalOptions = LayoutOptions.Start,
            Margin = 12
        };
        WeatherImageLayout.Children.Add( weatherImage );
    }

    private Color getGradientColor( double value ) {
		if( value > 1 ) return WarmColor;
        if( value < 0 ) return ColdColor;

		double r = WarmColor.Red * value + ColdColor.Red * ( 1 - value );
        double g = WarmColor.Green * value + ColdColor.Green * ( 1 - value );
        double b = WarmColor.Blue * value + ColdColor.Blue * ( 1 - value );

        return Color.FromRgb( r, g, b );
	}

    int i = 0;
    Easing[] Easings = new Easing[]
    {
        Easing.Linear,
        Easing.SinOut,
        Easing.SinIn,
        Easing.SinInOut,
        Easing.CubicIn,
        Easing.CubicOut,
        Easing.CubicInOut,
        Easing.BounceOut,
        Easing.BounceIn,
        Easing.SpringIn,
        Easing.SpringOut,
    };
    private async void Button_Clicked(object sender, EventArgs e)
    {
        //передаваемое значение температуры
        var tempValue = 50;

        var thermometerBarStart = ThermometerBarLayout.Margin.Top;
        var thermometerBarEnd = ThermometerLayout.Height - 20;

        var thermometerBarValue = (thermometerBarEnd - thermometerBarStart) * (tempValue - ColdBorder) / (WarmBorder - ColdBorder);
        var animationThermometer = new Animation((value) =>
        {
            ThermometerBar.HeightRequest = value;
        }, ThermometerBar.Height, thermometerBarValue - thermometerBarStart, Easing.Linear);

        ThermometerBar.Animate("HeightRequest", animationThermometer, length: 1000);

        ThermometerBarValue.Text = tempValue.ToString();

        var animationValue = new Animation((value) =>
        {
            ThermometerBarValue.Opacity = value;
        }, 0, 1);
        ThermometerBarValue.Animate("Opacity", animationValue, length: 1000);
    }

    public MainPage()
	{
        InitializeComponent();

        // WheaterData Какая погода, градусы, дата
        WeatherType weatherType = WeatherType.Sunny;
		double temperature = 31.5;
		DateTime date = new();

		setDayData( date );
		setTemperature( temperature );
		setWeatherImage( weatherType );
    }
}

