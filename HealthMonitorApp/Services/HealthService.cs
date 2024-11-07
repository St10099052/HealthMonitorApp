using System;
using System.Collections.Generic;
using System.Linq;
using HealthMonitorApp.Models;

namespace HealthMonitorApp.Services
{
    public class HealthService
    {
        private readonly HealthMonitorDbContext _context;

        public HealthService(HealthMonitorDbContext context)
        {
            _context = context;
        }

        // Add a new health record
        public void AddHealthRecord(HealthRecord record)
        {
            _context.HealthRecords.Add(record);
            _context.SaveChanges();
        }

        // Retrieve health records for a specific user
        public List<HealthRecord> GetHealthRecordsByUser(string userId)
        {
            return _context.HealthRecords
                           .Where(r => r.UserId == userId)
                           .OrderByDescending(r => r.DateRecorded)
                           .Take(10)  // Limit to the last 10 records
                           .ToList();
        }

        // Check for alerts based on predefined thresholds
        public List<string> CheckForAlerts(HealthRecord record)
        {
            List<string> alerts = new List<string>();

            if (record.HeartRate > 100)
            {
                alerts.Add("Warning: High Heart Rate!");
            }

            if (record.BloodPressureSystolic > 140 || record.BloodPressureDiastolic > 90)
            {
                alerts.Add("Warning: High Blood Pressure!");
            }

            if (record.Weight > 100)
            {
                alerts.Add("Warning: High Weight!");
            }

            return alerts;
        }
    }
}
