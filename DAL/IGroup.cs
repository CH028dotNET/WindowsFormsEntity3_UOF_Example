using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbModel;
using DbModel.DTO;

namespace DAL
{
    interface IGroup  
    {
         IEnumerable <DTOGroups> ShowGroups(); // show table Groups
         void AddRowToGroup(Groups GroupName); // add new Group name into table
         void DeleteRowInGroup(int groupId); // Delete Group name in table
         void UpdateRowInGroup(string updGroupName, int IdOfName); // Update group name in Group table

    }
}
