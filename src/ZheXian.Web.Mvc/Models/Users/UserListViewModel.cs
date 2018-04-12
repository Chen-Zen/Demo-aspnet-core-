using System.Collections.Generic;
using ZheXian.Roles.Dto;
using ZheXian.Users.Dto;

namespace ZheXian.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
