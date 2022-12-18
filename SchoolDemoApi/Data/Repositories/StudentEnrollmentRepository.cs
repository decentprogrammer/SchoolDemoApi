using Microsoft.EntityFrameworkCore;
using SchoolDemoApi.Data.Entities;

namespace SchoolDemoApi.Data.Repositories
{
    public interface IStudentEnrollmentRepository
    {
        Task<bool> Add(object entity);
        Task<bool> Remove(object entity);
        Task<bool> SaveChanges();
        Task<bool> Update(object entity);
    }

    public class StudentEnrollmentRepository : IStudentEnrollmentRepository
    {
        private readonly ApplicationDbContext _context;

        public StudentEnrollmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Add(object entity)
        {
            try
            {
                _context.Add(entity);
                return await SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Adding Data to Database", ex);
            }
        }

        public async Task<bool> Remove(object entity)
        {
            try
            {
                _context.Remove(entity);
                return await SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Removing Data from Database", ex);
            }
        }

        public async Task<bool> Update(object entity)
        {
            try
            {
                _context.Update(entity);
                return await SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Updating Database Data", ex);
            }
        }

        public async Task<bool> SaveChanges()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
