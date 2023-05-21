

namespace Bus4All;

public partial class SelecionarPercurso : ContentPage
{
    private List<string> paragemList;
    public SelecionarPercurso()
	{
		InitializeComponent();

        paragemList = new List<string>
        {
            "UTAD REITORIA",
            "UTAD ENGENHARIAS",
            "UTAD PEDAGOGICO",
            "UTAD LIVRARIA",
            "PRA�A GALIZA",
            "AV.UNIVERSIDADE",
            "CARREIRA LONGA ",
            "R.AUGUSTO C�SAR",
            "R.MANUEL SANTOS",
            "ESCOLAS ARAUC�RIA",
            "IGREJA ST� ANT�NIO",
            "C.SA�DE MATEUS ",
            "R.GASPAR SAMEIRO (2)",
            "R.GASPAR SAMEIRO (1)",
            "MATEUS         ",
            "B� DO ALEM     ",
            "ABAMBRES       ",
            "COOPERATIVA    ",
            "LUGAR DO BOQUE ",
            "B� ST�A MARIA  ",
            "RIO CORGO      ",
            "CURVA DA TIMPEIRA",
            "PR. 25 DE ABRIL",
            "CEMIT�RIO      ",
        };

        pembarquePicker.ItemsSource = paragemList;
        pdesembarquePicker.ItemsSource = paragemList;

    }


  private void Button_Clicked(object sender, EventArgs e)
   {
        string selectedPembarque = pembarquePicker.SelectedItem as string;
        string selectedPdesembarque = pdesembarquePicker.SelectedItem as string;

            
            DisplayAlert("PERCURSO SELECIONADO", $"Embarque: {selectedPembarque}\n\nDesembarque: {selectedPdesembarque}", "CONFIRMAR", "CANCELAR");
    }
}