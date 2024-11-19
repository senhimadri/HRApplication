using GlobalIdentityServer.DataTransferObject.Global;
using GlobalIdentityServer.DataTransferObject.Role;
using GlobalIdentityServer.IServices;
using GlobalIdentityServer.Models;
using GlobalIdentityServer.Repository;
using HRApplication.GlobalIdentityServer.Results;

namespace GlobalIdentityServer.Services;

public class RoleService(IRepository<Role> roleRepository) : IRoleService
{
    private readonly IRepository<Role> _roleRepository= roleRepository;

    public async Task<Result> CreateRole(CreateRoleDto input)
    {
        var isExist = await _roleRepository.IsExist(x => x.Name == input.Name);

        if (isExist)
            return Errors.NewError(400, "Role Name already exists.");

        var newRole = new Role
        {
            Id = Guid.NewGuid(),
            Name = input.Name,
            Description = input.Description
        };
        await _roleRepository.CreateAsync(newRole);

        return Result.Success();
    }

    public async Task<Result> UpdateRole(UpdateRoleDto input)
    {
        var existingRole = await _roleRepository.GetAsync(input.Id);

        if (existingRole == null)
            return Errors.ContentNotFound;

        existingRole.Name = input.Name;
        existingRole.Description = input.Description;

        await _roleRepository.UpdateAsync(existingRole);

        return Result.Success();
    }

    public async Task<Result> DeleteRole(Guid id)
    {
        var existingRole = await _roleRepository.GetAsync(id);

        if (existingRole == null)
            return Errors.ContentNotFound;

        existingRole.IsActive = false;

        await _roleRepository.UpdateAsync(existingRole);

        return Result.Success();
    }

    public async Task<RoleGetByIdDto> GetRoleById(Guid id)
    {
        var role = await _roleRepository.GetAsync(id);

        if (role == null)
            return new RoleGetByIdDto();

        return new RoleGetByIdDto
        {
            Id = role.Id,
            Name = role.Name,
            Description = role.Description
        };
    }

    public Task<GetLandingPagination<RoleLandingDto>> RolesLandingPagination(string searchText)
    {
        throw new NotImplementedException();
    }
}
