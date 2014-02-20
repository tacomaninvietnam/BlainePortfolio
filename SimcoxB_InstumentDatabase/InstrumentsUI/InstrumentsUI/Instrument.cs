///<summary>
///Blaine Simcox II
///CIT 255
///Jeff Straw
///Final Exam
///12/5/2013
///Instrument Class
///Class is For building 
///and Storing validated 
///Instrument Objects
///</summary>
using System;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Windows.Forms;

namespace InstrumentsUI
{
    /// <summary>
    /// Class for Storing Instruments
    /// </summary>
    public class Instrument
    {
        #region Fields And Properties
        /// <summary>
        /// Public Property Name enforced by two methods:
        /// alphabeticalCheck() And enforceStringBoundries()
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { enforceStringBoundries(); }
        }

        /// <summary>
        /// Property for holding instrument category such as brass, etc...
        /// </summary>
        public Section Category { get; set; }

        /// <summary>
        /// Field for holding and Manipulating
        /// Name Property
        /// </summary>
        public string _name; 
        #endregion

        #region Data Validation
        /// <summary>
        /// Strats With Trimming the _name Field, Uppercasing 
        /// with CultureInfo class and using a Regex Algorithm
        /// to verify data type
        /// </summary>
        /// <returns>fully formatted _name field or defaults when Data Fails</returns>
        private string enforceStringBoundries()
        {
            _name = _name.Trim();
            _name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_name);
            if (alphabeticalCheck(_name))
            {
                return _name;
            }
            else
                return "default";

        }

        /// <summary>
        /// regex expression for validating only letters and spaces
        /// </summary>
        /// <param name="word">Makes the code reusable in Property validation</param>
        /// <returns>Whether string is Valid</returns>
        public static bool alphabeticalCheck(string word)//checks for alphabetical only pattern
        {
            string stringToCheck = word;
            Regex pattern = new Regex("^[a-zA-Z ]+$");
            try
            {
                return pattern.IsMatch(stringToCheck);
            }
            catch (FormatException)
            {
                return false;
            }
        } 
        #endregion

        #region Constructors and ToString() Override
        /// <summary>
        /// Fully specified constructor
        /// </summary>
        /// <param name="name">fills the Field _name that feeds Property Name, 
        /// effectively setting Name property to parameter</param>
        /// <param name="category">Sets Category to specified parameter</param>
        public Instrument(string name, Section category)
        {
            this._name = name;
            this.Name = _name;
            this.Category = category;
        }

        /// <summary>
        /// Default Contstructor Calls Constants within itself,
        /// then sets fully specified constructor to these parameters
        /// </summary>
        public Instrument()
        {
            string name = "Baritone";
            Section category = Section.Brass;

            new Instrument(name, category);
        }

        /// <summary>
        /// Overridden ToString Method For Instrument Class
        /// </summary>
        /// <returns>Formatted Class String</returns>
        public override string ToString()
        {
            return String.Format("Instrument:    {0}\nCategory:      {1}\n\n", this.Name, this.Category.ToString());
        }
    } 
        #endregion
}
