﻿namespace PatientWarningApp.Api.MedicalRecords.Models
{
    public class MedicalRecordModel
    {
        public int Id { get; set; }
        public string StartDate { get; set; }
        public string SeizureTypes { get; set; }
        public string SeizureFrequencies { get; set; }
        public string SeizureTimes { get; set; }
        public string SeizureTriggers { get; set; }
        public string SideEffects { get; set; }
        public string Notes { get; set; }
    }
}
