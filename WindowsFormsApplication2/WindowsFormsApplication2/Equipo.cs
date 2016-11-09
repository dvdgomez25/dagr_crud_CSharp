using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{

    public class Equipo:Estudiante
    {
        public string nombreEq { get; set; }
        public string deporte { get; set; }

        public Equipo():base() { }

        public Equipo(int pId, string pNombre, string pApellido1, string pApellido2, string pCodigo, string pPosicion, string nombreEq, string deporte):base(pId, pNombre, pApellido1, pApellido2, pCodigo, pPosicion) {
            this.nombreEq = nombreEq;
            this.deporte = deporte;
        }
    }
}
