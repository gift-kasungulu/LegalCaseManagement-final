namespace LegalCaseManagement.Models
{
    public class Case
    {
        public int CaseId { get; set; }
        public DateTime  StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string CaseType { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Pertitioner { get; set; } = string.Empty;
        public string Respondent { get; set; } = string.Empty; //The respondent is the defendant
        public string CourtName { get; set; } = string.Empty;

        public int ClientId { get; set; }
        public  Client Client { get; set; }

    }
}
