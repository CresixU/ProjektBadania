using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ProjektBadania.Domain.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public string? Pesel { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public string? Street { get; set; }
        public string? HouseNumber { get; set; }
        public virtual ObservableCollectionListSource<Examination> Examinations { get; set; } = [];
    }
}
