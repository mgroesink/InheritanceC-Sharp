using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Point
    {
        #region Fields and Properties
        private int intX;
        private int intY;

        public int IntX { get => intX; set => intX = value; }
        public int IntY { get => intY; set => intY = value; }
        #endregion

        #region Constructors
        public Point(int intX, int intY)
        {
            this.IntX = intX;
            this.IntY = intY;
        }

        public Point()
        {
            intX = 0;
            intY = 0;
        }
        #endregion

        #region Methods

        #endregion
    }
}
