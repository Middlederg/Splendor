using System;

namespace Splendor.Domain
{
    public enum MoveType
    {
        [Display(Name = "Take gems")]
        TakeGems,

        [Display(Name = "Buy development")]
        BuyDevelopment,

        [Display(Name = "Reserve development")]
        ReserveDevelopment,
    }
}
