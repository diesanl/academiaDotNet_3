using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXamarin2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page : ContentPage
    {
        public Page()
        {
            InitializeComponent();

            btnExecutar.Clicked += BtnExecutar_Clicked;
        }

        private void BtnExecutar_Clicked(object sender, EventArgs e)
        {
            int valor = int.Parse(entryValor.Text);

            string resp = "O número " + valor;
            if (valor % 2 == 0)
            {
                resp += " é par";
                lblResposta.Text = resp;
            }
            else
            {
                resp += " é ímpar";
                lblResposta.Text = resp;
            }

        }
    }
}