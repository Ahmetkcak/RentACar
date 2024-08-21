using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class CarRepository(BaseDbContext context) : EfRepositoryBase<Car, Guid, BaseDbContext>(context), ICarRepository
{
}
