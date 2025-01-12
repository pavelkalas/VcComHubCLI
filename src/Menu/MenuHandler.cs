using System;
using System.Threading;

namespace VcComHubCLI.src.Menu
{
    internal class MenuHandler
    {
        private MenuManager menuManager;
        public MenuHandler(MenuManager menuManager)
        {
            this.menuManager = menuManager;
        }

        public void Handle()
        {
            long MENU_ID = menuManager.CurrentMenu.UUID;
            int MENU_ITEM_ID = menuManager.CurrentEntry;

            if (MENU_ID == 0)
            {
                if (MENU_ITEM_ID == 1)
                {
                    Console.WriteLine("Quitting...");
                    Thread.Sleep(500);
                    Environment.Exit(0);
                }
            }
        }
    }
}
