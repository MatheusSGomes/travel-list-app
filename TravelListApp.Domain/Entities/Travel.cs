using System.ComponentModel.DataAnnotations.Schema;

namespace TravelListApp.Domain.Entities;

[Table("travels", Schema = "public")]
public class Travel
{
    [Column("id")]
    public Guid Id { get; private set; }

    [Column("destination")]
    public string Destination { get; private set; }
    
    [Column("start_date")]
    public DateTime StartDate { get; private set; }
    
    [Column("end_date")]
    public DateTime EndDate { get; private set; }
    
    [Column("cost")]
    public decimal Cost { get; private set; }

    public Travel(string destination, DateTime startDate, DateTime endDate, decimal cost)
    {
        Id = Guid.NewGuid();
        Destination = destination;
        StartDate = startDate;
        EndDate = endDate;
        Cost = cost;
    }
    
    public void UpdateDetails(string destination, DateTime startDate, DateTime endDate, decimal cost)
    {
        Destination = destination;
        StartDate = startDate;
        EndDate = endDate;
        Cost = cost;
    }
}