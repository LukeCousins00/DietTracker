namespace DietTracker.Data.Entities;

public class Target
{
    public int Id { get; set; }
    public DateTime DiaryDate { get; set; }
    public int CalorieTarget { get; set; }
    public double FatTarget {get; set; }
    public double CarbTarget { get; set; }
    public double ProteinTarget { get; set; }

    public List<Subsistence> Sustenance { get; set; }
    public ApplicationUser User { get; set; }
    public List<SubsistenceTarget> SubsistenceTargets { get; set; }
}
