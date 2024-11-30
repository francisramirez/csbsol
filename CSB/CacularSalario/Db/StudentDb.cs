

using CacularSalario.Class;
using CacularSalario.Exception;

namespace CacularSalario.Db
{
    public class StudentDb
    {
        public List<Student> students;
        public StudentDb()
        {
            students = new List<Student>();
        }
        public void SaveStudent(Student student)
        {
            if (student is null)
            {
                throw new StudentException("El estudiante es requerido.");
            }

            if (string.IsNullOrEmpty(student.FirstName))
            {
                throw new StudentException("El nombre del estudiante es requerido.");
            }

            this.students.Add(student);
        }
        public void RemoveStudent(Student student)
        {
            Student stuentToRemove = this.students.FirstOrDefault(cd => cd.Id == student.Id);

            if (stuentToRemove is null)
            {
                throw new StudentException("El estudiante no se encuentra registrado para realizar esta operación.");
            }

            this.students.Remove(student);
        }
        public Student GetStudent(int id)
        {
            if (id <= 0)
            {
                throw new StudentException("El Id del es inválido.");

            }
            return this.students.FirstOrDefault(st => st.Id == id);
        }
        public List<Student> GetStudents() 
        { 
            return this.students;
        }
        public void UpdateStudent(Student student) 
        {
            if (student is null) 
            {
                throw new StudentException("El estudiante es requerido.");
            }

            this.RemoveStudent(student);

            this.students.Add(student);
        }
    }
}
