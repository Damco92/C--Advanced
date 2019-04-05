using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAdvanced_Class4.Interfaces;

namespace CSharpAdvanced_Class4
{
    public class Category
    {
        public static List<Part> HDD { get; set; }
        public static List<Part> MotherBoards { get; set; }
        public static List<Part> CPU { get; set; }
        public static List<Part> Cables { get; set; }
        public static List<Part> GraphicCards { get; set; }
        public static List<Part> Rams { get; set; }
        public static List<Part> Monitors { get; set; }
    }
}
