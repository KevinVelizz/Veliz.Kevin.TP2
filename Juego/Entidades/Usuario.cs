
using System.Text;

namespace Entidades
{
    public class Usuario
    {
        private string nombre;
        private string correo;
        private string clave;

        public Usuario() { }

        public Usuario(string nombre,string correo, string clave)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.clave = clave;

            if (this.CompararEmail(correo))
            {
                throw new Exception("Ya existe un usuario con ese email.");
            }
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Clave { get => clave; set => clave = value; }


        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Correo: {this.correo}");
            sb.AppendLine($"Clave: {this.clave}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        private bool CompararEmail(string email)
        {
            bool retorno = false;
            foreach (Usuario usuario in Soporte.usuariosJson.Deserealizar(Soporte.usuariosJson.PathUsuarios))
            {
                if (usuario.Correo == email)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }


    }
}
