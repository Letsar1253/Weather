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

public partial class MainPage : ContentPage {
    /** Коллекция изображений погоды. */
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

    /** Цвет самой холодной отображаемой температуры. */
    readonly Color ColdColor = Color.FromRgb( 212, 244, 255 );
    /** Цвет самой тёплой отображаемой температуры. */
    readonly Color WarmColor = Color.FromRgb( 255, 236, 225 );

    /** Границы самой холодной и самой тёплой температуры. */
	readonly double ColdBorder = -40, WarmBorder = 50;

    /** Исходный размер изображения термометра. */
    private const double ThermometerImageHeight = 560;

    /** Высота столбца максимальной отображаемой температуры. */
    private const double ThermometerTopBorder = ThermometerImageHeight - 18;

    /** Высота столбца минимальной отображаемой температуры. */
    private const double ThermometerBottomBorder = 186;

    /** Соотношение исходной высоты термометра и высоты страницы. */
    private double thermometerScale = 1;

    /** Метод, возвращающий значение от 0 до 1 для отображаемой температуры. */
    private double getFloatTemperature( double temp ) => ( temp - ColdBorder ) / ( WarmBorder - ColdBorder );

    /** Функция, возвращающая значение от 0 до 1 для отображаемой температуры. */
    private void calcThermometerScale() => thermometerScale = Height / ThermometerImageHeight;

    /** Функция определяет соотношение исходного размера термометра с размерами страницы. */
    private void setInfoPanel( DateTime date ) {
        DateInfo.Text = "Четверг, 14 июля";
        TemperatureInfo.Text = "30 ℃";
    }

    /**
     * Функция, устанавливающая значение температуры на странице.
     * Изменяет фоновый цвет страницы по градиенту.
     * Устанавливает значение столбца термометра.
     * */
    private void setTemperature( double temperature ) { 
        MainPageObject.BackgroundColor = getGradientColor( getFloatTemperature( temperature ) );
        setThermometerBar( temperature );
    }

    /** Метод устанавливает текущее изображение погоды. */
    private void setWeatherImage( WeatherType weatherType ) {
        Image weatherImage = new() {
            Source = weatherTypeImages[ weatherType ] + ".png",
            HeightRequest = 150,
            HorizontalOptions = LayoutOptions.Start,
            Margin = 12
        };
        WeatherImageLayout.Children.Add( weatherImage );
    }

    /** Метод возвращает цвет теплоты в зависимости от принимаемого значения. */
    private Color getGradientColor( double value ) {
		if( value > 1 ) return WarmColor;
        if( value < 0 ) return ColdColor;

		double r = WarmColor.Red * value + ColdColor.Red * ( 1 - value );
        double g = WarmColor.Green * value + ColdColor.Green * ( 1 - value );
        double b = WarmColor.Blue * value + ColdColor.Blue * ( 1 - value );

        return Color.FromRgb( r, g, b );
	}

    /** Метод заполняет шкалу термометра. */
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
    }

    /** */
    public void setupPage() {
        setWeatherImage( WeatherType.Sunny );
        setTemperature( 31.5 );
        setInfoPanel( new DateTime() );
    }

    /** Метод срабатывает по нажатию на кнопку перехода на предыдущий день. */
    private async void OnClickPreviousDayButton( object _, EventArgs __ ) {
        await Navigation.PushModalAsync( await App.GetPageByDay( DateTime.Now ) );
    }

    /** Метод срабатывает по нажатию на кнопку перехода на следующий день. */
    private async void OnClickNextDayButton( object _, EventArgs __ ) {
        await Navigation.PushModalAsync( await App.GetPageByDay( DateTime.Now ) );
    }

    /** 
     * Метод вызывается при измении размеров окна приложения.
     * Актуализирует соотношение исходного размера термометра с размерами окна.
     * */
    protected override void OnSizeAllocated( double width, double height ) {
        base.OnSizeAllocated( width, height );
        calcThermometerScale();
    }
}
