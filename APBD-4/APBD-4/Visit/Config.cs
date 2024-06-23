namespace APBD_4.Visit;

public static class Config
{
    public static void RegisterEndpointsForVisits(this IEndpointRouteBuilder app)
    {
        app.MapGet("/api/v1/visits/{id:int}", (IVisitService service, int id) =>
        {
            var result = service.GetVisitsByAnimalId(id);

            return result == null ? Results.NotFound() : TypedResults.Ok(result);
        });
        
        app.MapPost("api/v1/visits", (IVisitService service, Visit visit) =>
        { 
            service.AddVisit(visit);

            return TypedResults.Created("GetVisits", visit);
        });
    }
}