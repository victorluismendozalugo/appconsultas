using AppConsultas.Models;
using Nancy.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppConsultas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Principal : ContentPage
    {
        List<UsuariosModel> Usuarios = new List<UsuariosModel>();
        public Principal()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            ObtenerUsuarios();
        }

        public async void ObtenerUsuarios()
        {
            UsuariosModel usuario = new UsuariosModel
            {
                IdUsuario = 0,
                IdSucursal = 0
            };

            //Uri RequestUri = new Uri("http://10.10.162.1/api/usuarios/web/consultar");
            Uri RequestUri = new Uri("http://kssystems-001-site4.dtempurl.com/api/usuarios/web/consultar");

            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("api-key", "123");
            var json = JsonConvert.SerializeObject(usuario);
            var contentJson = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(RequestUri, contentJson);

            if (response.IsSuccessStatusCode)
            {

                var contents = response.Content.ReadAsStringAsync().Result;
                var result = JObject.Parse(contents);
                var data1 = result["data"]["data"];
                Usuarios = data1.ToObject<List<UsuariosModel>>();

                listaUsuarios.ItemsSource = Usuarios;

            }
        }

        private void listaUsuarios_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            eventoSelect(e);
        }

        public async void eventoSelect(SelectedItemChangedEventArgs e)
        {
            var item = (UsuariosModel)e.SelectedItem;
            var res = await DisplayAlert("Mensaje", item.Nombre, "Ok", "Cancel");

            //if (res)
            //{

            //}
        }
    }
}