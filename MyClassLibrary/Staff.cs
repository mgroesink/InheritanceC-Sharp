using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Staff:Rectangle
    {
        private double depth;

        #region Constructors
        public Staff() : base(10, 10)
        {
            this.depth = 10;
        }

        public Staff(double depth) : base(10, 10)
        {
            this.depth = depth;
        }

        public Staff(double length, double height, double depth) : base(length, height)
        {
            this.Length = length;
            this.Height = height;
            this.depth = depth;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Gets the volume.
        /// </summary>
        /// <value>
        /// The volume.
        /// </value>
        public double Volume
        {
            get { return Length * Height * depth; }
        }
        #endregion
    }
}
