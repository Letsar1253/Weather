namespace Weather;

public partial class App : Application {
	private static readonly Dictionary<DateTime, MainPage> WeatherPages = new();
    public App() {
		InitializeComponent();
		MainPage = new MainPage();
	}

    public static async Task<MainPage> GetPageByDay( DateTime day ) {
		if( WeatherPages.TryGetValue( day, out MainPage weatherPage ) ) {
			return weatherPage;
        } else {
			// var weatherData = await Метод, которым получаем данные о погоде дня...
			var newPage = new MainPage();
			newPage.setupPage();

            WeatherPages[day] = newPage;

            return newPage;
        }
	}
}
