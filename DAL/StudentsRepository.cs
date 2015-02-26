using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbModel;
using DbModel.DTO;

namespace DAL
{
    public class StudentsRepository : IStudent 
    {
        private UniversityContext context;

        public StudentsRepository(UniversityContext cont)
        {
            context = cont;
        }

       public  IEnumerable <DTOStudents> ShowStudents()
        {
           // var studentsTable = context.Students.AsEnumerable();

           // return studentsTable;

            var list = context.Students.Select(item => new DTOStudents()
            {
                Id = item.Id,
                FirstName = item.FirstName,
                LastName = item.LastName,
                Age = item.Age,
                GroupName = item.Groups.Name
            });
            return list;
        }

        public void AddRowToStudent(Students Student)
        {
            context.Students.Add(Student);
            context.SaveChanges();
        }

        public void DelRowInStudent(int studentId)
        {
            Students Student = context.Students.Find(studentId);

            context.Students.Remove(Student);
            context.SaveChanges();
        }

        public void UpdRowInStudent(string firstname, string lastname, int age, string groupId, int IdofName)
        {
            throw new NotImplementedException();
        }
    }
}
