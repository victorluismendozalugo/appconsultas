using System;
using System.Collections.Generic;
using System.Text;

namespace AppConsultas.Models
{
    public class UsuariosModel
    {
        public string Usuario { get; set; }

        public int IdRow { get; set; }
        public int IdUsuario { get; set; }
        public int IdTipoUsuario { get; set; }
        public string UsuarioRegistro { get; set; }
        public string Login { get; set; }
        public string Nombre { get; set; }

        public string Estatus { get; set; }
        public string Pwd { get; set; }
        public string email { get; set; }
        public string Puesto { get; set; }
        public string Area { get; set; }

        public int IdSucursal { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Telefono { get; set; }

        public int IdPersonal { get; set; }
        public string Pass { get; set; }


    }
}


