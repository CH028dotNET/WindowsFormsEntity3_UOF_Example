using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbModel;
using DbModel.DTO;

namespace DAL
{
    public class GroupToSubjectRepository : IGroupToSubject
    {
        private UniversityContext context;

        public GroupToSubjectRepository(UniversityContext cont)
        {
            context = cont;
        }

        public IEnumerable <DTOGroupToSubject> ShowGroupToSubjects()
        {
            //var GroupToSubjectsTable = context.GroupToSubject.AsEnumerable();

            //return GroupToSubjectsTable;

            var list = context.GroupToSubject.Select(item => new DTOGroupToSubject()
            {
                GroupName = item.Groups.Name,
                SubjectName = item.Subjects.Name
            });
            return list;
        }

        void IGroupToSubject.AddRowToGroupToSubject(int groupid, int subjectid)
        {
            throw new NotImplementedException();
        }

        void IGroupToSubject.DelRowInGroupToStudent(int groupSubjectIdFirst, int groupSubjectIdSecond)
        {
            throw new NotImplementedException();
        }
    }
}
