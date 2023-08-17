using MauiWeather.MVVM.ViewsModels;

namespace MauiWeather.MVVM.Views;

public partial class WeatherView : ContentPage
{
	public WeatherView()
	{
		InitializeComponent();
		BindingContext = new WeatherViewModel();
	}
}