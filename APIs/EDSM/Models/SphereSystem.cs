namespace EDCalculations.APIs.EDSM.Models;

public class SphereSystem
{
    public int distance { get; set; }
    public int bodyCount { get; set; }
    public string name { get; set; }
    public Coordinants coords { get; set; }
    public bool coordsLocked { get; set; }
    public SysInfo information { get; set; }
    public PrimaryStar primaryStar { get; set; }

}

public class Coordinants
{
    public float x { get; set; }
    public float y { get; set; }
    public float z { get; set; }
}


public class SysInfo
{
    public string? allegiance { get; set; }
    public string? government { get; set; }
    public string? faction { get; set; }
    public string? factionState { get; set; }
    public int population { get; set; }
    public string? security { get; set; }
    public string? economy { get; set; }
    public string? secondEconomy { get; set; }
    public string? reserve { get; set; }
}

public class PrimaryStar
{
    public string type { get; set; }
    public string name { get; set; }
    public bool isScoopable { get; set; }
}