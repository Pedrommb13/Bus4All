

namespace Bus4All;

public partial class Selecionarfav : ContentPage
{
    private List<string> paragemList;

    public bool fav= true;

    public Selecionarfav()
	{
		InitializeComponent();

        paragemList = new List<string>
        {
            "UTAD REITORIA",
            "UTAD ENGENHARIAS",
            "UTAD PEDAG�GICO",
            "UTAD LIVRARIA",
            "PRA�A GALIZA",
            "AV.UNIVERSIDADE",
            "CARREIRA LONGA ",
            "R. AUGUSTO C�SAR",
            "R. MANUEL SANTOS",
            "ESCOLAS ARAUC�RIA",
            "IGREJA ST� ANT�NIO",
            "C. SA�DE MATEUS ",
            "R. GASPAR SAMEIRO (2)",
            "R. GASPAR SAMEIRO (1)",
            "MATEUS         ",
            "B� DO ALEM     ",
            "ABAMBRES       ",
            "COOPERATIVA    ",
            "LUGAR DO BOQUE ",
            "B� ST�A MARIA  ",
            "RIO CORGO      ",
            "CURVA DA Timpeira",
            "PR. 25 DE ABRIL",
            "CEMIT�RIO      ",
        };

        pembarquePicker.ItemsSource = paragemList;
        pdesembarquePicker.ItemsSource = paragemList;

        if(fav) {
            pembarquePicker.SelectedItem = "UTAD ENGENHARIAS";
            pdesembarquePicker.SelectedItem = "ESCOLAS ARAUC�RIA";
        }

    }


    private async void Button_Clicked(object sender, EventArgs e)
    {
        string selectedPembarque = pembarquePicker.SelectedItem as string;
        string selectedPdesembarque = pdesembarquePicker.SelectedItem as string;

        var result = await DisplayAlert("PERCURSO SELECIONADO", $"Embarque: {selectedPembarque}\n\nDesembarque: {selectedPdesembarque}", "CONFIRMAR", "CANCELAR");

        if (result)
        {
            await Shell.Current.GoToAsync("..");
            await Shell.Current.GoToAsync("map");
        }
    }
}