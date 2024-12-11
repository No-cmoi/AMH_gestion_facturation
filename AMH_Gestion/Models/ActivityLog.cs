namespace AMH_Gestion.Models;

public class ActivityLog
{
    public int Id { get; set; }
    public int CompanyId { get; set; }
    public string Action { get; set; }
    public int EntityId { get; set; }
    public string EntityType { get; set; }
    public DateTime TimeStamp { get; set; }
}