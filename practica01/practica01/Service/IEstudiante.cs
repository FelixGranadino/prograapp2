using practica01.Models;

namespace practica01.Service
{
    public interface IEstudiante
    {
        public void AddStudent(Estudiantes es);

        public void UpdateStudent(Estudiantes es);

        public void DeleteStudent(Estudiantes es);

        public List<Estudiantes> GetAll ();
    }
}
