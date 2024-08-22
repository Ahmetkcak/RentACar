using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails;

public class InternalServerErrorProblemDetails : ProblemDetails
{
    public InternalServerErrorProblemDetails(string detail)
    {
        Title = "Intterval Server Error";
        Detail = "Intterval Server Error";
        Status = StatusCodes.Status500InternalServerError;
        Type = "https://httpstatuses.com/500";
    }
}
