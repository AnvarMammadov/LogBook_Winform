using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBook_Winform
{
    public class User
    {
        public string Fullname { get; set; }
        public Image UserImage { get; set; }
        public DateTime LastSeen { get; set; }
        public bool IsTakePart { get; set; }
        public bool IsLater { get; set; }
        public bool IsAbsent { get; set; }
        public bool IsOnline { get; set; }
        public int TestScore { get; set; }
        public int ClassScore { get; set; }
        public  int DiamondCount { get; set; }
        public string Comment { get; set; }
    }
}
