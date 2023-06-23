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
    public partial class Registro : ContentPage
    {
        string usuario;
        public Registro( string usuario)
        {
            InitializeComponent();
            lblusur.Text = "Usuario Connectado" + usuario;
            this.usuario = usuario;
        }

       

        private void txtdato_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            
        }

        private void btnresumen_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Resumen(usuario));
        }

        private void txtdatos_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double dato = Convert.ToDouble(txtdatos.Text);
                if (dato > 0)
                {
                    DisplayAlert("alert", "fuera de rango", "ok");
                    txtdatos.Text = "";
                }
            }
            catch { }
        }
    }
}