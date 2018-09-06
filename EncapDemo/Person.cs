using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapDemo {
    class Person {
        #region Private Variables
        public string _FirstName;
        private string _LastName;
        private DateTime _DateOfBirth;
        //private Colors _HairColor;
        #endregion

        #region
        public string FirstName {
            get {
                return _FirstName;
            }
            set {
                _FirstName = value;
            }
        }
        public string LastName {
            get {
                return _LastName;
            }
            set {
                _LastName = value;
            }
        }
        #endregion


    }
}
