using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Movies
    {
        public string Moviename;
        public Movies(string name)
        {
            Moviename=name;
        }
        public override string ToString()
        {
            return Moviename;
        }
    }
}
