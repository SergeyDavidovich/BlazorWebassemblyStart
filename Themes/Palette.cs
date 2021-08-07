using System;
using System.Drawing;

namespace Themes
{
    public class MaterialPalette
    {
       readonly string _name;
        public MaterialPalette(string name) { _name = name; }
        public string Name
        {
            get { return _name; }
        }

        public string PrimaryColor { get; set; }
        public string AcceptColor { get; set; }
    }
}
