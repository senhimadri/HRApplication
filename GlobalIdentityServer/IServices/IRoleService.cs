using GlobalIdentityServer.DataTransferObject.Global;
using GlobalIdentityServer.DataTransferObject.Role;
using HRApplication.GlobalIdentityServer.Results;

namespace GlobalIdentityServer.IServices;

public interface IRoleService
{
    Task<Result> CreateRole(CreateRoleDto input);
    Task<Result> UpdateRole(UpdateRoleDto input);
    Task<Result> DeleteRole(Guid id);
    Task<RoleGetByIdDto> GetRoleById(Guid id);
    Task<GetLandingPagination<RoleLandingDto>> RolesLandingPagination(string searchText);
}
