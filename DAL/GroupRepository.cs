using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DbModel;
using DbModel.DTO;


namespace DAL
{
    public class GroupRepository : IGroup 
    {
        private UniversityContext context;

        public GroupRepository(UniversityContext cont)
        {
            context = cont;
        }

        public  IEnumerable <DTOGroups> ShowGroups()
        {       
           //var groupTable = context.Groups.AsEnumerable();
           //return groupTable;
            
           var list = context.Groups.Select(item => new DTOGroups()
           {
               Id = item.Id,
               Name = item.Name
           });
           return list;

        }

        public void AddRowToGroup(Groups GroupName)
        {
            context.Groups.Add(GroupName);
            context.SaveChanges();

        }

        public void DeleteRowInGroup(int groupId)
        {
            Groups group = context.Groups.Find(groupId);

            context.Groups.Remove(group);
            context.SaveChanges();
        }

        public void UpdateRowInGroup(string updGroupName, int IdOfName)
        {
            Groups currentGroup = context.Groups.FirstOrDefault(group => group.Id == IdOfName);

            if(currentGroup == null)
            {

            }

            currentGroup.Name = updGroupName;

            context.Entry(currentGroup).State = System.Data.Entity.EntityState.Modified;

            context.SaveChanges();
        }
    }
}
