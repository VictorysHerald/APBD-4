namespace APBD_4.Visit;

public interface IVisitService
{
    IEnumerable<Visit> GetVisitsByAnimalId(int animalId);
    Visit AddVisit(Visit visit);
}