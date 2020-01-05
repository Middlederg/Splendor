using System;
using System.Linq;
using System.Windows.Forms;

namespace Splendor.Forms
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainContainer());
            //Application.Run(new MainView());
            //Application.Run(new Views.TestView());
            //Application.Run(new NoblesView(Nobles.GetNobles(5), true, "Hola"));
            //Application.Run(new PurchasedDevelopmentView(new BuyDevelopment(DevelopmentsFactory.GetDeck().First(), null), "player"));
            //Application.Run(new TakenGemsView(new TakeGems(new List<Gem>() { Gems.Emerald, Gems.Emerald }, null), "player"));
            //Application.Run(new TakenGemsView(new TakeGems(new List<Gem>() { Gems.Emerald, Gems.Sapphire, Gems.Ruby }, null), "player"));
            //Application.Run(new TakenGemsView(new TakeGems(new List<Gem>() { Gems.Emerald, Gems.Sapphire, Gems.Ruby }, Nobles.FrancisOfFrance), "player"));
        }
    }
}
