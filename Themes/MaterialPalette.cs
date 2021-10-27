using System;
using System.Drawing;
using System.Collections.Generic;

namespace Themes
{
    /// <summary>
    /// Содержит именованный выходной набор цветов заданной цветовой схемы
    /// </summary>
    public interface IPalette
    {
        Dictionary<string, string> Colors { get; set; }
        public string PaletteName { get; }
    }

    public class MaterialPalette : IPalette
    {
        string _name;
        Dictionary<string, string> _colors;
        public MaterialPalette(string name)
        {
            _name = name;
        }
        public Dictionary<string, string> Colors
        {
            get => _colors;
            set
            {
                _colors = new Dictionary<string, string>
                {

                };
            }
        }
        string IPalette.PaletteName => _name;
    }

    public class TailwindPalette : IPalette
    {
        string _name;
        Dictionary<string, string> _colors;
        public TailwindPalette(string name)
        {
            _name = name;
        }
        public Dictionary<string, string> Colors
        {
            get => _colors;
            set
            {
                _colors = new Dictionary<string, string>
                {

                };
            }
        }
        string IPalette.PaletteName => _name;
    }
}
