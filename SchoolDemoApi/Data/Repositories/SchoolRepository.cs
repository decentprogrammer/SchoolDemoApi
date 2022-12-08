using Microsoft.EntityFrameworkCore;
using SchoolDemoApi.Data.Models;

namespace SchoolDemoApi.Data.Repositories
{
    public interface ISchoolRepository
    {
        Task<bool> Add(object entity);
        Task<School> GetSchoolById(int id, bool includeDetails = false);
        Task<List<School>> GetSchools(bool includeDetails = false);
        Task<bool> Remove(object entity);
        Task<bool> SaveChanges();
        Task<bool> Update(object entity);
    }

    public class SchoolRepository : ISchoolRepository
    {
        private readonly ApplicationDbContext _context;

        public SchoolRepository(ApplicationDbContext context)
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


        public async Task<List<School>> GetSchools(bool includeDetails = false)
        {
            try
            {
                List<School> items = null;
                if (includeDetails)
                {
                    items = await _context.Schools
                                     .Include(p => p.BaselinePst)
                                     .Include(p => p.EssSiting)
                                     .ToListAsync();
                    return items;
                }

                items = await _context.Schools
                                 .ToListAsync();
                return items;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Getting Schools from Database", ex);
            }
        }

        public async Task<School> GetSchoolById(int id, bool includeDetails = false)
        {
            try
            {
                School item = null;
                if (includeDetails)
                {
                    item = await _context.Schools
                                    .Include(p => p.BaselinePst)
                                     .Include(p => p.EssSiting)
                                    .SingleOrDefaultAsync(x => x.Sid == id);
                    return item;
                }

                item = await _context.Schools.SingleOrDefaultAsync(x => x.Sid == id);
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Getting Single School from Database", ex);
            }
        }
    }
}
