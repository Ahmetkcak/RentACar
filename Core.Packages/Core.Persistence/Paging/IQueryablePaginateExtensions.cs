using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Paging;

public static class IQueryablePaginateExtensions
{
    public static async Task<Paginate<T>> ToPaginateAsync<T>(
        this IQueryable<T> query,
        int index,
        int size,
        CancellationToken cancellationToken = default
    )
    {
        int count = await query.CountAsync(cancellationToken).ConfigureAwait(false);
        List<T> items = await query.Skip(index * size).Take(size).ToListAsync();

        return new Paginate<T>
        {
            Size = size,
            Index = index,
            Count = count,
            Pages = (int)Math.Ceiling(count / (double)size),
            Items = items
        };
    }

    public static Paginate<T> ToPaginate<T>(this IQueryable<T> source, int index, int size)
    {
        int count = source.Count();
        var items = source.Skip(index * size).Take(size).ToList();

        return new Paginate<T>
        {
            Size = size,
            Index = index,
            Count = count,
            Pages = (int)Math.Ceiling(count / (double)size),
            Items = items
        };
    }
}
