using Splendor.Domain;
using System;

namespace Splendor.Forms
{
    public static class GameActionViewFactory
    {
        public static IGameActionView Create(GameAction gameActionInfo, string playername)
        {
            if (gameActionInfo is BuyDevelopment buy) return new PurchasedDevelopmentView(buy, playername);
            if (gameActionInfo is ReserveDevelopment reserve) return new ReservedDevelopmentView(reserve, playername);
            if (gameActionInfo is TakeGems takeGems) return new TakenGemsView(takeGems, playername);
            throw new NotImplementedException();
        }
    }
}
