using DietTracker.Shared.Enums;

namespace DietTracker.Data.Entities;

public class SubsistenceTarget
{
    public MealPeriod MealPeriod { get; set; }
    public int PortionSize { get; set; }

    public int TargetId { get; set; }
    public Target Target { get; set; }

    public int SubsistenceId { get; set; }
    public Subsistence Subsistence { get; set; }
}
