using ExamenParcial2.ViewModels;

namespace ExamenParcial2.Views;

public partial class PreguntasPage : ContentPage
{
	public PreguntasPage(PreguntasViewModel preguntasViewModel)
	{
		InitializeComponent();
        BindingContext = preguntasViewModel;
    }
}