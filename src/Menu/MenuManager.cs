using System;
using System.Runtime.CompilerServices;

namespace VcComHubCLI.src.Menu
{
    internal class MenuManager
    {
        public Menu CurrentMenu { get; private set; }

        public int CurrentEntry { get; private set; }

        public int MaxEntry { get; private set; }

        public MenuHandler menuHandler;

        public MenuManager(Menu initialMenu)
        {
            this.menuHandler = new MenuHandler(this);
            ChangeMenu(initialMenu);
        }
        
        public void ChangeMenu(Menu menu)
        {
            CurrentMenu = menu;
            MaxEntry = menu.MenuItems.Length;
            CurrentEntry = 0;
        }

        public void ChangeChoosenEntry(int entry)
        {
            if (entry < 0)
            {
                entry = MaxEntry - 1;
            }
            else if (entry >= MaxEntry)
            {
                entry = 0;
            }

            this.CurrentEntry = entry;
        }

        public MenuItem GetMenuItemByEntry(int entry)
        {
            return CurrentMenu?.MenuItems[entry];
        }

        public void Render(bool clearBefore = false)
        {
            if (clearBefore)
            {
                Console.Clear();
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("| " + CurrentMenu.Title);
            Console.WriteLine("------------------------------");

            for (int item = 0; item < CurrentMenu.MenuItems.Length; item++)
            {
                if (item == CurrentEntry)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }

                Console.WriteLine(CurrentMenu.MenuItems[item].Name);
            }

            Console.WriteLine("------------------------------");
        }
    }
}
