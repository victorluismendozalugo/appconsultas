using AppConsultas.Models;
using Nancy.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppConsultas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //inicializaServiciosBack();
            NavigationPage.SetHasNavigationBar(this, false); //quita la barra de navegacion de la parte posterior de la pantalla
        }

        Principal principal = new Principal();

        private async void Button_Clicked(object sender, EventArgs e)
        { //localNotification();



            UsuariosModel usuario = new UsuariosModel
            {
                Pwd = Contraseña.Text,
                Usuario = Usuario.Text
            };



            //Uri RequestUri = new Uri("http://10.10.162.1/api/seguridad/login");
            Uri RequestUri = new Uri("http://kssystems-001-site4.dtempurl.com/api/seguridad/login");

            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("api-key", "123");
            var json = JsonConvert.SerializeObject(usuario);
            var contentJson = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(RequestUri, contentJson);//genera la consulta a la API


            if (response.StatusCode == HttpStatusCode.OK)
            {
                var jsonConvert = response.Content.ReadAsStringAsync().Result;

                var result = JObject.Parse(jsonConvert);

                if (result["data"]["codigoError"].ToString() != "0")
                {
                    await DisplayAlert("Mensaje", result["data"]["mensajeBitacora"].ToString(), "OK");
                }
                else
                {
                    await Navigation.PushAsync(new Principal());
                }

            }
            else
            {
                await DisplayAlert("Mensaje", response.StatusCode.ToString(), "OK");
            }

            //{

            //    if (result["data"]["codigoError"].ToString() != "0")
            //    {
            //        await DisplayAlert("Mensaje", result["data"]["mensajeBitacora"].ToString(), "OK");
            //    }
            //    else
            //    {
            //        
            //    }

            //    //await DisplayAlert("Mensaje", "Datos invalidos", "OK");
            //}
            //else
            //{
            //    await DisplayAlert("Mensaje", "Error en el servicio, favor de reportarlo con el administrador", "OK");
            //}
        }

        public void inicializaServiciosBack()
        {


        }

        public void localNotification()
        {

            //CrossLocalNotifications.Current.Show("Titulo notificacion", "Cuerpo Notificacion", 0);

        }
    }
}
