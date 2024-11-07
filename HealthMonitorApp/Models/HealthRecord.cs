namespace HealthMonitorApp.Models
{
    public class HealthRecord
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime DateRecorded { get; set; }
        public double HeartRate { get; set; }
        public double BloodPressureSystolic { get; set; }
        public double BloodPressureDiastolic { get; set; }
        public double Weight { get; set; }
    }
}
