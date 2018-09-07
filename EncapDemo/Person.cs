using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapDemo {
    class Person {
        #region Private Variables
        private string _FirstName;
        private string _LastName;
        private DateTime _DateOfBirth;
        private Colors _HairColor;
        #endregion

        #region Enums
        public enum Colors {
            Black, // enums are stored as numbers and start at 0
            Red,    // this has a value of 1 because 0 + 1 = 1. 
            Brown = 10, // you can set the value.
            Blonde // this now equals 11
        }
        #endregion

        #region Public Properties
        // Properties should always match the associated variable in name and data type.
        /// <summary>
        /// Get and Set the Person's First Name
        /// </summary>
        public string FirstName {
            get {
                return _FirstName;
            }
            set {
                // Make sure the first name is in the following format:
                // Xxxxxxx
                // Jack ( if jAck was entered)
                // Jill ( if jill was entered)
                // Mary ( if MARY was entered)
                string newName = value[0].ToString().ToUpper();
                if (value.Length > 1) {
                    newName += value.Substring(1).ToLower();
                }
                _FirstName = newName;
            }
        }
        /// <summary>
        /// Get and Set the Person's First Name
        /// </summary>
        public string LastName {
            get {
                return _LastName;
            }
            set {
                _LastName = value;
            }
        }
        /// <summary>
        /// Get and Set the Person's Date of Birth
        /// </summary>
        public DateTime DateOfBirth {
            get {
                return _DateOfBirth;
            }
            set {
                _DateOfBirth = value;
            }
        }
        /// <summary>
        /// Get and Set the Person's First Name
        /// </summary>
        /// <remarks>This uses the enum.</remarks>
        public Colors HairColor {
            get {
                return _HairColor;
            }
            set {
                _HairColor = value;
            }
        }
        /// <summary>
        /// Can create readonly properties
        /// Get how old a person is based on their birth date.
        /// </summary>
        public int Age {
            get{
                // getters can include code. They are like a method.
                // We do this to "protect our data" like said in class. 
                TimeSpan howLongAlive = DateTime.Now - DateOfBirth;
                double daysAlive = howLongAlive.TotalDays;
                int yearsAlive = (int)(daysAlive / 365);
                return yearsAlive;
            }
        }

        #endregion

        #region Public Methods
        /// <summary>
        /// Always have a description on methods.
        /// Person shouts a message.
        /// </summary>
        /// <returns></returns>
        public string Shout() {
            return "Hey!";
        }
        #endregion


    }
}
