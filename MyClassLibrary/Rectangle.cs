using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Rectangle
    {
        #region Fields and Properties
        /// <summary>
        /// The length
        /// </summary>
        private double length;
        /// <summary>
        /// The height
        /// </summary>
        private double height;

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public double Length { get => length; set => length = value; }
        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        public double Height { get => height; set => height = value; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="length">The length.</param>
        /// <param name="height">The height.</param>
        public Rectangle(double length, double height)
        {
            this.Length = length;
            this.Height = height;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Gets the area.
        /// </summary>
        /// <value>
        /// The area.
        /// </value>
        public double Area
        {
            get { return this.length * this.height; }
        }
        #endregion
    }
}
