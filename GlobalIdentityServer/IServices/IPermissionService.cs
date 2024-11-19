using GlobalIdentityServer.DataTransferObject.Global;
using GlobalIdentityServer.DataTransferObject.Permission;
using HRApplication.GlobalIdentityServer.Results;

namespace GlobalIdentityServer.IServices;

public interface IPermissionService
{
    Task<Result> CreatePermission(CreatePermissionDto input);
    Task<Result> UpdatePermission(UpdatePermissionDto input);
    Task<Result> DeletePermission(Guid id);
    Task<PermissionGetByIdDto> GetPermissionById(Guid id);
    Task<GetLandingPagination<PermissionLandingDto>> PermissionsLandingPagination(string searchText);
}
