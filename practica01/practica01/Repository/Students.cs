
using practica01.Data;
using practica01.Models;
using practica01.Service;

namespace practica01.Repository
{
    public class Students : IEstudiante
    {
        //especificar la conexion con la base de datos solamente una vez
        //aplicationdbcontext se encargara por nosotros para trabajar con las entidades
        //entidades son las tablas de la base de datos
        private ApplicationDBContext app;
        public Students(ApplicationDBContext app)
        {
            this.app = app;
        }

        public void AddStudent(Estudiantes es)
        {
            //app pertenece a dbcontext
            //en dbcontext
            //existe un dbset el cual tiene como nombre estudiante
            //que a su vez es una representacion de la tabla de la bd
            app.Estudiantes.Add(es);
            app.SaveChanges();
            //thow new no implementedexception();
            
        }

        public void DeleteStudent(Estudiantes es)
        {
            app.Estudiantes.Remove(es);
            app.SaveChanges();
           // throw new NotImplementedException();
        }

        public List<Estudiantes> GetAll()
        {
            return new List<Estudiantes>();
           // throw new NotImplementedException();
        }

        public void UpdateStudent(Estudiantes es)
        {
            app.Estudiantes.Update(es);
            app.SaveChanges();
            //throw new NotImplementedException();
        }
    }
}
