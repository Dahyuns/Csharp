using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

class Item
{
    string mName;
    int mGold;
    /*
        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }
        public int Gold
        {
            get { return mGold; }
            set { mGold = value; }
        }*/

    public Item(string _Name ,int _Gold)
    {
        mName = _Name;
        mGold = _Gold;
    }
}
