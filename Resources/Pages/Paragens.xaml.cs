using System.Runtime.InteropServices;
using System;

namespace Bus4All;

public partial class Paragens : ContentPage
{

    private List<string> paragemList;
    public Paragens()
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
            "ESCOLAS ARAUC�R",
            "IGREJA ST� ANT�",
            "C.SAUDE MATEUS ",
            "R.GASPAR SAMEIR",
            "R.GASPAR SAMEIR",
            "MATEUS         ",
            "B� DO ALEM     ",
            "ABAMBRES       ",
            "COOPERATIVA    ",
            "LUGAR DO BOQUE ",
            "B� ST�A MARIA  ",
            "RIO CORGO      ",
            "CURVA DA TIMPEI",
            "PR. 25 DE ABRIL",
            "CEMIT�RIO      ",
        };
        
    }
    
}