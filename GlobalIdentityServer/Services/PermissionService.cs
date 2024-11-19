using GlobalIdentityServer.DataTransferObject.Global;
using GlobalIdentityServer.DataTransferObject.Permission;
using GlobalIdentityServer.IServices;
using GlobalIdentityServer.Models;
using GlobalIdentityServer.Repository;
using HRApplication.GlobalIdentityServer.Results;

namespace GlobalIdentityServer.Services;

public class PermissionService(IRepository<Permission> permissionRepository) : IPermissionService
{
    private readonly IRepository<Permission> _permissionRepository = permissionRepository;
    public async Task<Result> CreatePermission(CreatePermissionDto input)
    {
        var isExist = await _permissionRepository.IsExist(x => x.Name == input.Name);

        if (isExist)
            return Errors.NewError(400, "Permission Name already exists.");

        var newPermission = new Permission
        {
            Id = Guid.NewGuid(),
            Name = input.Name,
            Description = input.Description
        };

        await _permissionRepository.CreateAsync(newPermission);

        return Result.Success();
    }
    public async Task<Result> UpdatePermission(UpdatePermissionDto input)
    {
        var existingPermission = await _permissionRepository.GetAsync(input.Id);

        if (existingPermission == null)
            return Errors.ContentNotFound;

        existingPermission.Name = input.Name;
        existingPermission.Description = input.Description;


        await _permissionRepository.UpdateAsync(existingPermission);

        return Result.Success();
    }
    public async Task<Result> DeletePermission(Guid id)
    {
        var existingPermission = await _permissionRepository.GetAsync(id);

        if (existingPermission == null)
            return Errors.ContentNotFound;

        existingPermission.IsActive = false;

        await _permissionRepository.UpdateAsync(existingPermission);

        return Result.Success();
    }
    public async Task<PermissionGetByIdDto> GetPermissionById(Guid id)
    {
        var permission = await _permissionRepository.GetAsync(id);

        if (permission == null)
            return new PermissionGetByIdDto();

        return new PermissionGetByIdDto
        {
            Id = permission.Id,
            Name = permission.Name,
            Description = permission.Description,
        };
    }
    public Task<GetLandingPagination<PermissionLandingDto>> PermissionsLandingPagination(string searchText)
    {
        throw new NotImplementedException();
    }
}
