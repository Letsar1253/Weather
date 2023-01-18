using Microsoft.Maui;

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
    const double ThermometerTopBorder = ThermometerImageHeight - 18;
    const double ThermometerBottomBorder = 186;

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

    private void Button_Clicked(object sender, EventArgs e) {
        setTemperature( 50 );
    }

    private void setThermometerBar( double temp ) {
        var thermometerBarStart = ThermometerBottomBorder * thermometerScale;
        var thermometerBarEnd   = ThermometerTopBorder * thermometerScale;
        var thermometerBarValue = ( thermometerBarEnd - thermometerBarStart )
                                    * getFloatTemperature( temp );

        var animationThermometer = new Animation(
            value => ThermometerBar.HeightRequest = value, 0, thermometerBarValue );

        var barWidth = 44 * thermometerScale;
        ThermometerBar.WidthRequest = 44 * thermometerScale;
        ThermometerBar.Margin = new Thickness( 0, 0, 0, (int)thermometerBarStart );

        ThermometerBar.Animate( "HeightRequest",
            animationThermometer,
            length: 1200,
            easing: Easing.CubicOut,
            finished: ( v, c ) => {
                ThermometerBarValue.Text = temp.ToString();

                var positionValueAnim = new Animation( 
                    value => ThermometerBarValue.Margin = new Thickness( 2 * barWidth, 0, 0, value ),
                    thermometerBarStart + thermometerBarValue - 100,
                    thermometerBarStart + thermometerBarValue - 44,
                    easing: Easing.CubicOut
                );
                var opacityValueAnim = new Animation( value => ThermometerBarValue.Opacity = value, 0, 1 );

                ThermometerBarValue.Animate( "Margin", positionValueAnim, length: 700 );
                ThermometerBarValue.Animate( "Opacity", opacityValueAnim, length: 400 );
            } );
    }

    public MainPage() {
        InitializeComponent();

        // WheaterData Какая погода, градусы, дата
        WeatherType weatherType = WeatherType.Sunny;
		double temperature = 31.5;
		DateTime date = new();

        calcThermometerScale();

        setDayData( date );
		//setTemperature( temperature );
		setWeatherImage( weatherType );
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("past1");
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("future1");
    }


    protected override void OnSizeAllocated( double width, double height ) {
        base.OnSizeAllocated( width, height );
        calcThermometerScale();
    }
}
