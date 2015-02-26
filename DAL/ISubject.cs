using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbModel;
using DbModel.DTO;

namespace DAL
{
    interface ISubject
    {
        IEnumerable<DTOSubjects> ShowSubjects(); // show table Subjects
        void AddRowToSubjects(Subjects Subject); // add new Subject name into table
        void DeleteRowInSubjects(int SubjectID); // Delete Subject name in table
        void UpdateRowInSubjects(string updSubjectName, int IdOfName); // Update Subject name in Subjects table
    }
}
