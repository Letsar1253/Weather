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


        // Настроить градусник
    }

    private void setWeatherImage( WeatherType weatherType ) {
        Image weatherImage = new() {
            Source = weatherTypeImages[ weatherType ] + ".png",
            HeightRequest = 150,
            HorizontalOptions = LayoutOptions.Start,
            Margin = 8
        };
        //MainPageLayout.Children.Add( weatherImage );
        WeatherImageLayout.Children.Add( weatherImage );

        //Image thermometerImage = new()
        //{
        //    Source = "thermometer.png",
        //    HeightRequest = 500,
        //    HorizontalOptions = LayoutOptions.Center,
        //    Margin = 10
        //};
        //ThermometerLayout.Children.Add( thermometerImage );
    }

    private Color getGradientColor( double value ) {
		if( value > 1 ) return WarmColor;
        if( value < 0 ) return ColdColor;

		double r = WarmColor.Red * value + ColdColor.Red * ( 1 - value );
        double g = WarmColor.Green * value + ColdColor.Green * ( 1 - value );
        double b = WarmColor.Blue * value + ColdColor.Blue * ( 1 - value );

        return Color.FromRgb( r, g, b );
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

	private void OnCounterClicked(object sender, EventArgs e) {
        
    }
}

