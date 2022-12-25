using SchoolDemoApi.Data.Entities;
using SchoolDemoApi.Data.Repositories;

namespace SchoolDemoApi.Services
{
    public interface IStudentEnrollmentDetailService
    {
        Task<bool> Insert(StudentEnrollmentDetail studentEnrollmentDetail);
        Task<bool> Remove(StudentEnrollmentDetail studentEnrollmentDetail);
        Task<bool> Update(StudentEnrollmentDetail studentEnrollmentDetail);
    }

    public class StudentEnrollmentDetailService : IStudentEnrollmentDetailService
    {
        private readonly IStudentEnrollmentDetailRepository _repository;

        public StudentEnrollmentDetailService(IStudentEnrollmentDetailRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> Insert(StudentEnrollmentDetail studentEnrollmentDetail)
        {
            try
            {
                var status = await _repository.Add(studentEnrollmentDetail);
                return status;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
        public async Task<bool> Update(StudentEnrollmentDetail studentEnrollmentDetail)
        {
            try
            {
                var status = await _repository.Update(studentEnrollmentDetail);
                return status;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
        public async Task<bool> Remove(StudentEnrollmentDetail studentEnrollmentDetail)
        {
            try
            {
                var status = await _repository.Remove(studentEnrollmentDetail);
                return status;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
