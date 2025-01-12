namespace VcComHubCLI.src.Menu
{
    internal class MenuItem
    {
        public string Name { get; private set; }
        
        public string UName { get; private set; }

        public long Id { get; private set; }

        public MenuItem(string name, string uname, long id)
        {
            this.Name = name;
            this.UName = uname;
            this.Id = id;
        }
    }
}
