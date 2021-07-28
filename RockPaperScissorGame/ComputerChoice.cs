using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorGame
{
    public class rock
    {
        public static int count = 0;
        public rock() => count++;
    }

    public class paper 
    {
        public static int count = 0;
        public paper() => count++;
    }

    public class scissors 
    {
        public static int count = 0;
        public scissors() => count++;
    }
}
