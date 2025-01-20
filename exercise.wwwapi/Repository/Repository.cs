using exercise.wwwapi.Data;
using exercise.wwwapi.Models;


namespace exercise.wwwapi.Repository
{
    public class StudentRepository
    {
        private StudentCollection _studentCollection;

        public StudentRepository(StudentCollection studentCollection)
        {
            _studentCollection = studentCollection;
        }

        public Student AddEntity(Student entity)
        {
            _studentCollection.Add(entity);
            return entity;
        }

        public Student DeleteEntity(string name)
        {
            return _studentCollection.Delete(name);
        }

        public List<Student> GetCollection()
        {

            return _studentCollection.getAll();
       
           
        }

        public Student GetEntity(string name)
        {
            return _studentCollection.GetStudent(name);
        }

        public Student UpdateEntity(string name,string newfirstname,string newlastname)
        {
            return _studentCollection.UpdateStudent(name, newfirstname, newlastname);
        }

     
        
    }
}
