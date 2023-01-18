namespace Weather;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute("mainpage", typeof(MainPage));
        Routing.RegisterRoute("past1", typeof(MainPage));
        Routing.RegisterRoute("past2", typeof(MainPage));
        Routing.RegisterRoute("past3", typeof(MainPage));
        Routing.RegisterRoute("future1", typeof(MainPage));
        Routing.RegisterRoute("future2", typeof(MainPage));
        Routing.RegisterRoute("future3", typeof(MainPage));
    }
}