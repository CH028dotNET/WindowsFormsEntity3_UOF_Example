using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbModel;
using DbModel.DTO;

namespace DAL
{
    interface IGroupToSubject
    {
        IEnumerable <DTOGroupToSubject> ShowGroupToSubjects();
        void AddRowToGroupToSubject(int groupid, int subjectid);
        void DelRowInGroupToStudent(int groupSubjectIdFirst, int groupSubjectIdSecond);
    }
}
