namespace FitMentor_API.Dtos.AppointmentDtos
{
    public class ResultAppointmentDto
    {
        public int DateID { get; set; }
        public int UserID { get; set; }
        public int ServiceID { get; set; }
        public DateTime tarih { get; set; }
        public string saat { get; set; }
    }
}
