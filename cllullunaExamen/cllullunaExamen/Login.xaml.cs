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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btningresar_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2023";
            string pass = "uisrael2023";
            if (txtuser.Text == usuario && txtcontrse.Text == pass)
            {
                Navigation.PushAsync(new Registro(usuario));

            }
            else
            {
                DisplayAlert("alerta", "usuario incorrecto", "ok");
            }

        }
    }
}