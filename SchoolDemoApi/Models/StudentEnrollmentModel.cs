namespace SchoolDemoApi.Models
{
    public class StudentEnrollmentModel
    {
        public short ProjectYear { get; set; }
        public DateTime VisitDate { get; set; }
        public string? VisitorName { get; set; }
        public short SchoolId { get; set; }
        public short Quarter { get; set; }
        public List<StudentEnrollmentDetailModel> StudentEnrollmentDetails { get; set; }
    }
}
