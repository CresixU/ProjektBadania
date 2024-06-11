namespace ProjektBadania.Domain.Entities
{
    public class Examination
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; } = string.Empty;
        public DateTime? DateOfExamination { get; set; } = DateTime.Now;

        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
        public int ExaminationTypeId { get; set; }
        public virtual ExaminationType ExaminationType { get; set; }
    }
}
