namespace TravelListApp.Domain.Entities;

public class Travel
{
    public Guid Id { get; private set; }
    public string Destination { get; private set; }
    public DateTime StartDate { get; private set; }
    public DateTime EndDate { get; private set; }
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