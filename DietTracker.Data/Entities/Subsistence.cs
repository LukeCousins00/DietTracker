using DietTracker.Shared.Enums;
using System.ComponentModel;

namespace DietTracker.Data.Entities;

public class Subsistence
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
    // [DefaultValue(2000)]
    public int CalorieAmount { get; set; }
    public double FatAmount { get; set; }
    public double CarbAmount { get; set; }
    public double ProteinAmount { get; set; }
    public UnitOfMeasure UnitOfMeasure { get; set; }
    public int DefaultPortionSize { get; set; }

    public List<Target> Targets { get; set; }
    public List<SubsistenceTarget> SubsistenceTargets { get; set; }
}
