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

    const double ThermometerImageHeight = 560;
    double thermometerScale = 1;

    private double getFloatTemperature( double temp ) => ( temp - ColdBorder ) / ( WarmBorder - ColdBorder );

    private void calcThermometerScale() => thermometerScale = Height / ThermometerImageHeight;

    private void setDayData( DateTime date ) {

	}

    private void setTemperature( double temperature ) { 
        MainPageObject.BackgroundColor = getGradientColor( getFloatTemperature( temperature ) );
        setThermometerBar( temperature );
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

    //Easing.Linear,
    //Easing.SinOut,
    //Easing.SinIn,
    //Easing.SinInOut,
    //Easing.CubicIn,
    //Easing.CubicOut,
    //Easing.CubicInOut,
    //Easing.BounceOut,
    //Easing.BounceIn,
    //Easing.SpringIn,
    //Easing.SpringOut,

    private void Button_Clicked(object sender, EventArgs e) {
        setTemperature( 50 );
    }

    private void setThermometerBar( double temp ) {
        var thermometerBarStart = thermometerScale * 111;
        var thermometerBarEnd = ( ThermometerImageHeight - 20 ) * thermometerScale;
        var thermometerBarValue = ( thermometerBarEnd - thermometerBarStart )
                                    * getFloatTemperature( temp )
                                    * thermometerScale;

        var animationThermometer = new Animation(
            value => ThermometerBar.HeightRequest = value,
            ThermometerBar.Height,
            thermometerBarValue - thermometerBarStart,
            Easing.Linear
        );

        ThermometerBar.Margin = new Thickness( 0, 0, 0, (int)thermometerBarStart );

        //ThermometerBar.Animate( "HeightRequest", animationThermometer, rate: 16, length: 1000);

        //ThermometerBarValue.Text = temp.ToString();

        //var animationValue = new Animation( value => ThermometerBarValue.Opacity = value, 0, 1);
        //ThermometerBarValue.Animate( "Opacity", animationValue, length: 300 );
    }

    public MainPage() {
        InitializeComponent();

        // WheaterData Какая погода, градусы, дата
        WeatherType weatherType = WeatherType.Sunny;
		double temperature = 31.5;
		DateTime date = new();

        calcThermometerScale();

        setDayData( date );
		setTemperature( temperature );
		setWeatherImage( weatherType );
    }

    protected override void OnSizeAllocated( double width, double height ) {
        base.OnSizeAllocated( width, height );
        calcThermometerScale();
    }
}
