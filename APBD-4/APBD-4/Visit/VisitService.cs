namespace APBD_4.Visit;

public class VisitService : IVisitService
{
    private List<Visit> _visits = new List<Visit>();

    public VisitService()
    {
        _visits.Add(new Visit(new DateTime(2022, 1, 1), 1, "Visit 1", 1009));
        _visits.Add(new Visit(new DateTime(2021, 1, 2), 1, "Visit 2", 435));
        _visits.Add(new Visit(new DateTime(2021, 1, 3), 2, "Visit 3", 1523));
        _visits.Add(new Visit(new DateTime(2021, 1, 2), 1, "Visit 4", 342));
        _visits.Add(new Visit(new DateTime(2021, 1, 3), 2, "Visit 5", 133));
    }
    

    public IEnumerable<Visit> GetVisitsByAnimalId(int animalId)
    {
        return _visits.FindAll(x => x.AnimalId == animalId);
    }
    
    public Visit AddVisit(Visit visit)
    {
        _visits.Add(visit);
        return visit;
    }
}