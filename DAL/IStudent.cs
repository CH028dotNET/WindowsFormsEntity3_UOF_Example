using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbModel;
using DbModel.DTO;

namespace DAL
{
    interface IStudent
    {
        IEnumerable<DTOStudents> ShowStudents(); // show table Students

        void AddRowToStudent(Students Student); // add new Student into table
        
        void DelRowInStudent(int studentId); // Delete Student in table

        void UpdRowInStudent(string firstname, string lastname, int age, string groupId, int IdofName); // Update Student in Students table        
            
    }
}
