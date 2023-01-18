using Weather.Resources.WeatherModel;

namespace Weather;

public partial class MainPage : ContentPage {
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
    private static double thermometerScale = 1;

    /** Метод, возвращающий значение от 0 до 1 для отображаемой температуры. */
    private double getFloatTemperature( double temp ) => ( temp - ColdBorder ) / ( WarmBorder - ColdBorder );

    /** Метод устанавливает текущее  */
    private static void calcThermometerScale( double pageHeight ) {
        if( pageHeight > 0 ) {
            thermometerScale = pageHeight / ThermometerImageHeight;
        }
    }

    /** Функция определяет соотношение исходного размера термометра с размерами страницы. */
    private void setInfoPanel( DateTime date, double temperature ) {
        //DateInfo.Text = "Четверг, 14 июля";
        //TemperatureInfo.Text = "30 ℃";
        DateInfo.Text = date.DayOfWeek.ToString() + ", " + date.Day + " " + date.Month;
        TemperatureInfo.Text = Math.Round( temperature, 1 ).ToString() + " ℃";
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
    private void setWeatherImage( string weatherType ) {
        Image weatherImage = new() {
            Source = weatherType + ".png",
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
        calcThermometerScale( Height );
        setupPage( new WeatherModel() {
            Day = DateTime.Now,
            TemperatureValue = 34,
            WeatherTypeName = "sunny"
        });
    }

    /** Метод устанавливает элементы страницы по данным. */
    public void setupPage( WeatherModel weatherData ) {
        setWeatherImage( weatherData.WeatherTypeName );
        setTemperature( weatherData.TemperatureValue );
        setInfoPanel( weatherData.Day, weatherData.TemperatureValue );
    }
    private static DateTime dayNumber = DateTime.Now;
    /** Метод срабатывает по нажатию на кнопку перехода на предыдущий день. */
    private async void OnClickPreviousDayButton( object _, EventArgs __ ) {
        dayNumber = dayNumber.AddDays( -1 );
        await Navigation.PushModalAsync( await App.GetPageByDay( dayNumber ) );
    }

    /** Метод срабатывает по нажатию на кнопку перехода на следующий день. */
    private async void OnClickNextDayButton( object _, EventArgs __ ) {
        dayNumber = dayNumber.AddDays( 1 );
        await Navigation.PushModalAsync( await App.GetPageByDay( dayNumber ) );
    }

    /** 
     * Метод вызывается при измении размеров окна приложения.
     * Актуализирует соотношение исходного размера термометра с размерами окна.
     * */
    protected override void OnSizeAllocated( double width, double height ) {
        base.OnSizeAllocated( width, height );
        calcThermometerScale( Height );
    }
}
