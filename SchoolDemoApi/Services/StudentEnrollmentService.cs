using SchoolDemoApi.Data.Entities;
using SchoolDemoApi.Data.Repositories;

namespace SchoolDemoApi.Services
{
    public interface IStudentEnrollmentService
    {
        Task<bool> Insert(StudentEnrollment studentEnrollment);
        Task<bool> Remove(StudentEnrollment studentEnrollment);
        Task<bool> Update(StudentEnrollment studentEnrollment);
    }

    public class StudentEnrollmentService : IStudentEnrollmentService
    {
        private readonly IStudentEnrollmentRepository _repository;

        public StudentEnrollmentService(IStudentEnrollmentRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> Insert(StudentEnrollment studentEnrollment)
        {
            try
            {
                var status = await _repository.Add(studentEnrollment);
                return status;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
        public async Task<bool> Update(StudentEnrollment studentEnrollment)
        {
            try
            {
                var status = await _repository.Update(studentEnrollment);
                return status;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
        public async Task<bool> Remove(StudentEnrollment studentEnrollment)
        {
            try
            {
                var status = await _repository.Remove(studentEnrollment);
                return status;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
