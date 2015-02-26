using DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IGroupManager
    {
        Groups AddGroup(Groups group);
        IEnumerable<Groups> GetGroups();
    }
}
