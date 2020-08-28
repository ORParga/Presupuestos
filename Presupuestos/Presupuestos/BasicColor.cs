using System;
using System.Collections.Generic;
using System.Drawing;

namespace Presupuestos
{
    class BasicColor
    {

        List<Color> _ListAllColors;
        List<Color> basicColor;
        public Dictionary<String, UInt32> map = new Dictionary<string, UInt32>();

        public BasicColor()
        {
            Array array=Enum.GetValues(typeof(KnownColor));
            int a=(int)array.GetValue(1);
            map.Add("Black", 0xFF000000);
            map.Add("White", 0xFFFFFFFF);
            map.Add("Red", 0xFFFF0000);
            map.Add("Green", 0xFF00FF00);
            map.Add("Blue", 0xFF0000FF);
            map.Add("Orange", 0xFFFFA500);
            map.Add("Maroon", 0xFF800000);
            map.Add("Lime", 0xFF00FF00);
            map.Add("Magenta", 0xFFFF00FF);
            map.Add("SkyBlue", 0xFF87CEEB);
            map.Add("Turquoise", 0xFF40E0D0);
            map.Add("Violet", 0xFFEE82EE);
            map.Add("Yellow", 0xFFFFFF00);
            map.Add("Pink", 0xFFFFC0CB);
            map.Add("Salmon", 0xFFFA8072);
            map.Add("Purple", 0xFF800080);
            map.Add("Cyan", 0xFF00FFFF);
            map.Add("Brown", 0xFFA52A2A);
            //map.Add("Beige", 0xFFF5F5DC);
        }
    }
}
