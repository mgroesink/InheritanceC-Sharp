using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{

    /// <summary>
    /// Class Circle inherits Point
    /// </summary>
    /// <seealso cref="MyClassLibrary.Point" />
    public class Circle : Point
    {
        #region Fields and Properties
        /// <summary>
        /// The radius
        /// </summary>
        private double radius;

        /// <summary>
        /// Gets or sets the radius.
        /// </summary>
        /// <value>
        /// The radius.
        /// </value>
        public double Radius { get => radius; set => radius = value; }

        /// <summary>
        /// Gets the area.
        /// </summary>
        /// <value>
        /// The area.
        /// </value>
        public double Area
        {
            get { return Math.PI * Radius * Radius; }
        }


        /// <summary>
        /// Gets the circumference.
        /// </summary>
        /// <value>
        /// The circumference.
        /// </value>
        public double Circumference
        {
            get { return 2 * Radius * Math.PI; }
        }


        #endregion

        #region Constructors
        public Circle()
        {

        }
        #endregion

        #region Methods

        #endregion
    }



}
