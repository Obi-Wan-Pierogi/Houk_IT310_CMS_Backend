using System.Runtime.InteropServices;

namespace Houk_IT310_CMS_Backend.Models
{
    public enum VisibilityStatus
    {
        Visible = 0,
        Invisible = 100,
        FlaggedForModeration = 500,
        AdminsOnly = 1000
    }
}