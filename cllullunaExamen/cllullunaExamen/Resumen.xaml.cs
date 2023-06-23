using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cllullunaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        string usuario;
        public Resumen(string usuario)
        {
            InitializeComponent();
            lblusur.Text = "Usuario Connectado" + usuario;
            this.usuario = usuario;
        }

        private void txtdato_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double dato = Convert.ToDouble(txtdato.Text);
                if (dato > 0)
                {
                    DisplayAlert("alert", "fuera de rango", "ok");
                    txtdato.Text = "";
                }
            }
            catch { }
        }
    }
}