using SchoolDemoApi.Data.Entities;
using SchoolDemoApi.Data.Repositories;

namespace SchoolDemoApi.Services
{
    public interface ISchoolService
    {
        Task<School> GetSchoolById(int id, bool includeDetails = false);
        Task<List<School>> GetSchools(bool includeDetails = false);
        Task<bool> Insert(School school);
        Task<bool> Remove(School school);
        Task<bool> Update(School school);
    }

    public class SchoolService : ISchoolService
    {
        private readonly ISchoolRepository _repository;

        public SchoolService(ISchoolRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> Insert(School school)
        {
            try
            {
                var status = await _repository.Add(school);
                return status;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
        public async Task<bool> Update(School school)
        {
            try
            {
                var status = await _repository.Update(school);
                return status;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
        public async Task<bool> Remove(School school)
        {
            try
            {
                var status = await _repository.Remove(school);
                return status;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
        public async Task<List<School>> GetSchools(bool includeDetails = false)
        {
            try
            {
                var items = await _repository.GetSchools();
                return items;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
        public async Task<School> GetSchoolById(int id, bool includeDetails = false)
        {
            try
            {
                var item = await _repository.GetSchoolById(id);
                return item;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
