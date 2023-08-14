namespace Calificacion_del_alumno;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

    private void CalcularButton_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(Calificacion1Entry.Text, out double calif1) &&
            double.TryParse(Calificacion2Entry.Text, out double calif2) &&
            double.TryParse(Calificacion3Entry.Text, out double calif3) &&
            double.TryParse(Calificacion4Entry.Text, out double calif4) &&
            double.TryParse(Calificacion5Entry.Text, out double calif5))
        {
            double promedio = (calif1 + calif2 + calif3 + calif4 + calif5) / 5;
            ResultadoLabel.Text = "El promedio de calificaciones es: " + promedio.ToString("0.00");
        }
        else
        {
            ResultadoLabel.Text = "Por favor, ingrese calificaciones válidas en todos los campos.";
        }
    }
}

