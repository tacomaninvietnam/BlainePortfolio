/*******************************************************************************
 * Generic custom class to investigate Unit Tests in Visual Studio
 * Jeff Straw | Northwestern Michigan College
 * 01/26/2014: Initial
 ******************************************************************************/
using System;
using System.Globalization;

namespace ExperimentBase
{
    /// <summary>
    /// Generic multi-property custom object
    /// </summary>
    
    public class Foo
    {
        #region [ Business rules and local configuration ]
        private TextInfo usTextInfo = new CultureInfo("en-US", false).TextInfo;   // Select among global options

        private const string DefaultName = "";
        private const int DefaultRating = 1;
        private const bool DefaultRegistered = false;
        private readonly static DateTime DefaultWhenRegistered = DateTime.Today;
        #endregion

        #region [ Fields ]
        private string _name;
        private int  _rating;
        private DateTime _whenPurchased;
        #endregion

        #region [ Properties ]
        /// <summary>
        /// Common name of this Foo using U.S. English title case
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value == null ? null : usTextInfo.ToTitleCase(value.Trim()); }
        }

        /// <summary>
        /// Number of stars - 1 through 5
        /// </summary>
        public int Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }

        /// <summary>
        /// Whether or not this Foo has been licensed and registered with the manufacturer
        /// </summary>
        public bool Registered { get; set; }

        /// <summary>
        /// Date when current owner purchased this Foo
        /// </summary>
        public DateTime WhenPurchased
        {
            get { return _whenPurchased; }
            set { _whenPurchased = value.Date; }    // Strip time of day detail
        }
        #endregion

        #region [ Constructors ]
        /// <summary>
        /// Generic multi-property custom object
        /// </summary>
        public Foo()
            : this(DefaultName, DefaultRating, DefaultRegistered, DefaultWhenRegistered)
        {
        }

        /// <summary>
        /// Generic multi-property custom object
        /// </summary>
        /// <param name="name">Common name of this Foo</param>
        /// <param name="rating">Number of stars - 1 through 5</param>
        public Foo(string name, int rating)
            : this(name, rating, DefaultRegistered, DefaultWhenRegistered)
        {
        }

        /// <summary>
        /// Generic multi-property custom object
        /// </summary>
        /// <param name="name">Common name of this Foo</param>
        /// <param name="rating">Number of stars - 1 through 5</param>
        /// <param name="registered">Whether or not this Foo has been licensed and registered with the manufacturer</param>
        /// <param name="whenPurchased">Date when current owner purchased this Foo</param>
        public Foo(string name, int rating, bool registered, DateTime whenPurchased)
        {
            this.Name = name;
            this.Rating = rating;
            this.Registered = registered;
            this.WhenPurchased = whenPurchased;
        } 
        #endregion

        #region [ Methods ]
        /// <summary>
        /// Custom text representation of a Foo object
        /// </summary>
        /// <returns>String representation of this Foo</returns>
        public override string ToString()
        {
            return string.Format("{0} purchased {1:MM/dd/yyyy} {2} ({3})",
                this.Name,
                this.WhenPurchased,
                this.Registered ? "is registered" : "is not registered",
                new string('*', this.Rating));
        } 
        #endregion
    }
}