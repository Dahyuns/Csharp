using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Item
{
    int Gold;
    string Name;

    public Item(int _gold, string _name)
    {
        Gold = _gold;
        Name = _name;
    }

    public string GetName()
    {
        return Name;
    }
    public int GetGold()
    {
        return Gold;

    }
}
