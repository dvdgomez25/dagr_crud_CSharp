using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Codigo { get; set; }
        public string Posicion { get; set; }

        public Estudiante() { }

        public Estudiante(int pId, string pNombre, string pApellido1, string pApellido2, string pCodigo, string pPosicion)

        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Apellido1 = pApellido1;
            this.Apellido2 = pApellido2;
            this.Codigo = pCodigo;
            this.Posicion = pPosicion;
        }
    }
}
