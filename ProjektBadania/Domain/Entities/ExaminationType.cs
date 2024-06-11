using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ProjektBadania.Domain.Entities
{
    public class ExaminationType
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public virtual ObservableCollectionListSource<Examination> Examinations { get; set; } = [];
    }
}
