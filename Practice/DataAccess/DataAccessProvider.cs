using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice.Models;

namespace Practice.DataAccess
{
    public class DataAccessProvider : IDataAccessProvider
    {
        private readonly PostgreSqlContext _context;

        public DataAccessProvider(PostgreSqlContext context)
        {
            _context = context;
        }

        public void AddGroupsRecord(Groups groups)
        {

            _context.groups.Add(groups);
            _context.SaveChanges();
        }

        public void UpdateGroupsRecord(Groups groups)
        {
            _context.groups.Update(groups);
            _context.SaveChanges();
        }

        public void DeleteGroupsRecord(int id)
        {
            var entity = _context.groups.FirstOrDefault(t => t.id == id);
            _context.groups.Remove(entity);
            _context.SaveChanges();
        }

        public Groups GetGroupsSingleRecord(int id)
        {
            return _context.groups.FirstOrDefault(t => t.id == id);
        }

        public List<Groups> GetGroupsRecords()
        {
            return _context.groups.ToList();
        }
        public void AddStudentsRecord(Students students)
        {

            _context.students.Add(students);
            _context.SaveChanges();
        }

        public void UpdateStudentsRecord(Students epartments)
        {
            _context.students.Update(epartments);
            _context.SaveChanges();
        }

        public void DeleteStudentsRecord(int id)
        {
            var entity = _context.students.FirstOrDefault(t => t.id == id);
            _context.students.Remove(entity);
            _context.SaveChanges();
        }

        public Students GetStudentsSingleRecord(int id)
        {
            return _context.students.FirstOrDefault(t => t.id == id);
        }

        public List<Students> GetStudentsRecords()
        {
            return _context.students.ToList();
        }

    }
}
