namespace SchoolDemoApi.Models
{
    public class StudentEnrollmentModel
    {
        public short ProjectYear { get; set; }
        public DateTime Date { get; set; }
        public string? VisitorName { get; set; }
        public bool ReCollectData { get; set; }
        public bool Verified { get; set; }
        public List<StudentEnrollmentDetailModel> listStudentEnrollmentDetails { get; set; }
    }
}
