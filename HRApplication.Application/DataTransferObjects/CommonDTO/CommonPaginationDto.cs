namespace HRApplication.Application.DataTransferObjects.CommonDTO;

public class CommonPaginationDto
{
    public int PageNo { get; set; }
    public int PageSize { get; set; }
    public bool IsAscending { get; set; }
}