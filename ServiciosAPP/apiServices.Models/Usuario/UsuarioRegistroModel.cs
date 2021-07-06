namespace apiServices.Models.Usuario
{
    public class UsuarioRegistroModel
    {
        public int IDUsuario { get; set; }
        public string Usuario { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Nombre { get; set; }
        public string FechaInicio { get; set; }
        public string FechaTermino { get; set; }
        public string FechaModificacion { get; set; }
        public string Estatus { get; set; }
        public int QuienAutoriza { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
        public int RequiereToken { get; set; }
        public string Salt { get; set; }
        public string Contrasena { get; set; }
        public string NombreCompleto { get; set; }
        public int SucursalID { get; set; }
        public int RolID { get; set; }
    }
}