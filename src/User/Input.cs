using System;
using VcComHubCLI.src.Menu.MenuTemplates.Main;
using VcComHubCLI.src.Menu;

namespace VcComHubCLI.src.User
{
    internal class Input
    {
        public void RunKeyListener()
        {
            MenuManager menuManager = new MenuManager(new src.Menu.Menu("Main menu", TMainMenu.items, 0));

            menuManager.Render();

            int entry = 0;

            while (true)
            {
                ConsoleKey code = Console.ReadKey().Key;

                if (code == ConsoleKey.DownArrow)
                {
                    entry++;
                }
                else if (code == ConsoleKey.UpArrow)
                {
                    entry--;
                }
                else if (code == ConsoleKey.Enter || code == ConsoleKey.Spacebar)
                {
                    menuManager.menuHandler.Handle();
                }

                menuManager.ChangeChoosenEntry(entry);
                menuManager.Render(true);
            }
        }
    }
}
