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
            "UTAD PEDAG�GICO",
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
        
    }
    
}