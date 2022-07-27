﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PrimeiroApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int count = 0;

        private void btnCliqueAqui_Clicked(object sender, EventArgs e)
        {
           count++;
           ((Button)sender).Text = "Você Clicou" + count.ToString() + "Vezes";
        }

        private void btnVerificar_Clicked(object sender, EventArgs e)
        {
            string texto = $"O nome tem{txtNome.Text.Length} caracteres";
            DisplayAlert("Mensagem", texto, "Ok");
        }

        private async void btnLimpar_Clicked(object sender, EventArgs e)
        {
            if (await DisplayAlert("Pergunta", "Deseja realmente limpar a tela?", "Yes", "No"))
            {
                txtNome.Text = string.Empty;
                btnCliqueAqui.Text = "Clique aqui";
            }
        }

    }
}
