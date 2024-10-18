namespace HRApplication.Application.DataTransferObjects.CommonDTO;

public class CommonPaginationParamsDto
{
    public int PageNo { get; set; }
    public int PageSize { get; set; }
    public bool IsAscending { get; set; }
}
