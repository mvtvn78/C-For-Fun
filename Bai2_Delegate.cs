using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp
{
    class Nguoi
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public bool IsEqualAge (Nguoi a, Nguoi b ) { return a.Age == b.Age; }
        public bool IsEqualWidth(Nguoi a, Nguoi b) { return a.Width == b.Width; }
        public bool IsEqualHeight(Nguoi a, Nguoi b) { return a.Height == b.Height; }
    }
    internal class Bai2_Delegate
    {

    }
}
