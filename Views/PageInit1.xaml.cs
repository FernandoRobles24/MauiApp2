namespace MauiApp2.Views;

public partial class PageInit1 : ContentPage
{
	public PageInit1()
	{
		InitializeComponent();
	}

    private async void btnaceptar_Clicked(object sender, EventArgs e)
    {
        var person = new Models.Personas
        {
            Nombres = Nombres.Text,
            Apellidos = Apellidos.Text,
            FechaNac = FechaNac.Date,
            Telefono = Telefono.Text
        };

        if (await App.DataBase.StorePerson(person) > 0)
        {
            await DisplayAlert("Aviso", "Registro ingresado con exito!!", "OK");
        }
    }
}