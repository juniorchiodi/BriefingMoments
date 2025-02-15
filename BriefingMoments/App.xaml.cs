﻿using BriefingMoments.Model;
using Syncfusion.Licensing;
using System.IO;

namespace BriefingMoments
{
    public partial class App : Application
    {
        public List<ListaModel> tipo_colegio = new List<ListaModel>
        {
            new ListaModel()
            {
                Descricao = "Escola/Colégio Particular"
            },
            new ListaModel()
            {
                Descricao = "Escola Pública"
            },
            new ListaModel()
            {
                Descricao = "Escola Municipal"
            },
            new ListaModel()
            {
                Descricao = "Escola Estadual"
            },
            new ListaModel()
            {
                Descricao = "Faculdade"
            }
        };

        public List<ListaModel> tipo_prod = new List<ListaModel>
        {
            new ListaModel()
            {
                Descricao = "Somente Fotografia"
            },
            new ListaModel()
            {
                Descricao = "Somente Evento"
            },
            new ListaModel()
            {
                Descricao = "Fotografia + Evento(Completo)"
            }
        };

        public App()
        {
            InitializeComponent();
            SyncfusionLicenseProvider.RegisterLicense("MzY4NzQ3N0AzMjM4MmUzMDJlMzBZYzFxZmFXYlFXUU1IM250bXBCUEkwTFpJaklyaFZyRzkvbVVZRDdHNU5nPQ==");

            MainPage = new NavigationPage(new MainPage());
                /*{ BarBackgroundColor = Color.FromHex("#5c0303"), /*BarTextColor = Color.w}*/ 
        }
    }
}
