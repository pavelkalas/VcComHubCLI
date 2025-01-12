namespace VcComHubCLI.src.Menu
{
    internal class Menu
    {
        public string Title { get; private set; }

        public long UUID { get; private set; }

        public MenuItem[] MenuItems { get; private set; }

        public Menu(string title, MenuItem[] menuItems, long uUID)
        {
            this.Title = title;
            MenuItems = menuItems;
            UUID = uUID;
        }
    }
}
