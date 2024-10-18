using HRApplication.Application.DataTransferObjects.CommonDTO;
using System.Data.Entity;

namespace HRApplication.Application.Helper;

public static class Paginations
{
    public static IQueryable<T> Pagination<T>(this IQueryable<T> data, int pageNo, int pageSize)
    {
        int skippedRow = pageNo - 1 * pageSize;
        int takenRow = pageSize;

        data.Skip(skippedRow).Take(takenRow);

        return data;
    }

    public static async Task<GetLandingPagination<T>> ToPagination<T>(this IQueryable<T> data, int pageNo, int pageSize)
    {
        var result = new GetLandingPagination<T>()
        {
            PageNo = pageNo,
            PageSize = pageSize,
            TotalCount = await data.CountAsync(),
            Data = await data.Pagination(pageNo, pageSize).ToListAsync()
        };

        return result;
    }
}
