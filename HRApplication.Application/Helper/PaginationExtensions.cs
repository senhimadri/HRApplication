using HRApplication.Application.DataTransferObjects.CommonDTO;
using System.Data.Entity;

namespace HRApplication.Application.Helper;

public static class PaginationExtensions
{
    public static IQueryable<T> Paginate<T>(this IQueryable<T> data, int pageNo, int pageSize)
    {
        pageNo = Math.Max(1, pageNo); ;
        pageSize = Math.Max(1, pageSize);

        int skippedRow = (pageNo - 1) * pageSize ;
        data.Skip(skippedRow).Take(pageSize);

        return data;
    }

    public static async Task<GetLandingPagination<T>> ToPaginatedResultAsync <T>(this IQueryable<T> data, int pageNo, int pageSize)
    {
        var totalCount = await data.CountAsync();
        var paginatedData = await data.Paginate(pageNo, pageSize).ToListAsync();

        return new GetLandingPagination<T>
        {
            PageNo = pageNo,
            PageSize = pageSize,
            TotalCount = totalCount,
            Data = paginatedData
        };
    }
}
