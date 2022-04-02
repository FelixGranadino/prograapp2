using practica01.Models;

namespace practica01.Service
{
    public interface IOperaciones
    {
        Double Suma(Acciones acciones);
        Double Resta(Acciones acciones);
        Double Multiplicacion(Acciones acciones);
        Double Division(Acciones acciones);
    }
}
