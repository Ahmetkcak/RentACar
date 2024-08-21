using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class TransmissionRepository(BaseDbContext context) : EfRepositoryBase<Transmission, Guid, BaseDbContext>(context), ITransmissionRepository
{
}
