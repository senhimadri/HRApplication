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
}
