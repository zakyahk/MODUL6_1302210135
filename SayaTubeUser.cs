using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODUL6_1302210135
{
    internal class SayaTubeUser
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeUser(string title)
        {
            this.title = title;
        }

        public IncreasePlayCount(int playCount)
        {
            this.playCount = playCount;
        }
    }
     
}
