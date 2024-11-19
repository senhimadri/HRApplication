﻿namespace GlobalIdentityServer.DataTransferObject.Global;

public class GetLandingPagination<T>
{
    public int PageNo { get; set; }
    public int PageSize { get; set; }
    public int TotalCount { get; set; }
    public List<T?>? Data { get; set; }
}