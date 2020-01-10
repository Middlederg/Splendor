using System;

namespace Splendor.Domain
{
    public enum MoveType
    {
        [Display("Take gems")]
        TakeGems,

        [Display("Buy development")]
        BuyDevelopment,

        [Display("Reserve development")]
        ReserveDevelopment,
    }
}
