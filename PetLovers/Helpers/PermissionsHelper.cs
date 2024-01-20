using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetLovers.Helpers
{
    public static class PermissionsHelper
    {
        public static async Task<bool> CheckIfGranted<T>() where T : Permissions.BasePermission, new()
        {
            var status = await Permissions.CheckStatusAsync<T>();

            return status == PermissionStatus.Granted;
        }

        public static async Task<bool> RequestPermission<T>() where T : Permissions.BasePermission, new()
        {
            var status = await Permissions.CheckStatusAsync<T>();

            if (status != PermissionStatus.Granted)
            {
                // Permission is not granted, so request it
                status = await Permissions.RequestAsync<T>();
            }

            // Return the final status of the permission
            return status == PermissionStatus.Granted;
        }
    }
}
