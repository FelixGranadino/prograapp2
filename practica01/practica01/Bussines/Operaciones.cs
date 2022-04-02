using practica01.Models;
using practica01.Service;
namespace practica01.Bussines
{
    public class Operaciones : IOperaciones
    {
        public double Division(Acciones acciones)
        {
            return acciones.Dato1 / acciones.Dato2;
        }

        public double Multiplicacion(Acciones acciones)
        {
            return acciones.Dato1 * acciones.Dato2;
        }

        public double Resta(Acciones acciones)
        {
            return acciones.Dato1 - acciones.Dato2;
        }

        public double Suma(Acciones acciones)
        {
            return acciones.Dato1 + acciones.Dato2;
        }
    }
}
