namespace catcart;

public partial class AppShell : Shell
{
    private readonly CatCart MainPage;

    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(CatCart), typeof(CatCart));
        MainPage = new CatCart();
    }
}
