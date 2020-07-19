using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice.Models;

namespace Practice.DataAccess
{
    public interface IDataAccessProvider
    {
        void AddGroupsRecord(Groups groups);
        void UpdateGroupsRecord(Groups groups);
        void DeleteGroupsRecord(int id);
        Groups GetGroupsSingleRecord(int id);
        List<Groups> GetGroupsRecords();

        void AddStudentsRecord(Students students);
        void UpdateStudentsRecord(Students students);
        void DeleteStudentsRecord(int id);
        Students GetStudentsSingleRecord(int id);
        List<Students> GetStudentsRecords();
    }
}
