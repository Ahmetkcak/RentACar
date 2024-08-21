using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class FuelRepository(BaseDbContext context) : EfRepositoryBase<Fuel, Guid, BaseDbContext>(context), IFuelRepository
{
}
