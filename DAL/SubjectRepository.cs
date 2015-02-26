using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbModel;
using DbModel.DTO;


namespace DAL
{
    public class SubjectRepository : ISubject 
    {
        private UniversityContext context;

        public SubjectRepository(UniversityContext cont)
        {
            context = cont;
        }

        public IEnumerable <DTOSubjects> ShowSubjects()
        {
            //var subjectsTable = context.Subjects.AsEnumerable();
            //   return subjectsTable;
            var list = context.Subjects.Select(item => new DTOSubjects()
            {
                Id = item.Id,
                Name = item.Name
            });
            return list;

        }

        public void AddRowToSubjects(Subjects Subject)
        {
            context.Subjects.Add(Subject);
            context.SaveChanges();
        }

        public void DeleteRowInSubjects(int SubjectID)
        {
            Subjects Subject = context.Subjects.Find(SubjectID);

            context.Subjects.Remove(Subject);
            context.SaveChanges();
        }

        public void UpdateRowInSubjects(string updSubjectName, int IdOfName)
        {
            Subjects currentSubject = context.Subjects.FirstOrDefault(subject => subject.Id == IdOfName);

            if (currentSubject == null)
            {

            }

            currentSubject.Name = updSubjectName;

            context.Entry(currentSubject).State = System.Data.Entity.EntityState.Modified;

            context.SaveChanges();
        }
    }
}
