using BLL.Interfaces;
using DAL;
using DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL.Implementations
{
    public class GroupManager: BaseManager, IGroupManager
    {

        public GroupManager(UnitOfWork uof) : base(uof) { }

        public Groups AddGroup(Groups group)
        {
            uof.GroupRepository.Insert(group);
            uof.Save();
            return group;
        }


        public IEnumerable<Groups> GetGroups()
        {
            return uof.GroupRepository.All.ToList();
        }
    }
}
