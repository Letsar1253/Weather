using Weather.Resources.WeatherModel;

namespace Weather;

public partial class App : Application {
	private static readonly Dictionary<DateTime, MainPage> WeatherPages = new();
	private static WeatherGetter weatherGetter = new WeatherGetter();
    public App() {
		InitializeComponent();
		MainPage = new MainPage();
	}

    public static async Task<MainPage> GetPageByDay( DateTime day ) {
		if( WeatherPages.TryGetValue( day, out MainPage weatherPage ) ) {
			return weatherPage;
        } else {
			// var weatherData = await Метод, которым получаем данные о погоде дня...
			var weatherData = await weatherGetter.GetData(day);
            var newPage = new MainPage();
			newPage.setupPage(weatherData);

            WeatherPages[day] = newPage;

            return newPage;
        }
	}
}
