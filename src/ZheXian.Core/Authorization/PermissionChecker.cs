using Abp.Authorization;
using ZheXian.Authorization.Roles;
using ZheXian.Authorization.Users;

namespace ZheXian.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
