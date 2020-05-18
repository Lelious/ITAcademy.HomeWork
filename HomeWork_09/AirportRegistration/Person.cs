namespace Airport_Registration
{
    public class Person
    {
        private string _firstName { get; set; }
        private string _secondName { get; set; }
        private string _passportId { get; set; }
        private bool _checkInStatus { get; set; }
        private bool _securityCheck { get; set; }
        private bool _passportCheck { get; set; }
        public string FirstName
        {
            get
            {
                return this._firstName;
            }
            set
            {
                this._firstName = value;
            }
        }
        public string SecondName
        {
            get
            {
                return this._secondName;
            }
            set
            {
                this._secondName = value;
            }
        }
        public string PassportID
        {
            get
            {
                return this._passportId;
            }
            set
            {
                this._passportId = value;
            }
        }
        public bool CheckInStatus
        {
            get
            {
                return this._checkInStatus;
            }
            set
            {
                this._checkInStatus = true;
            }
        }
        public bool SecurityCheck
        {
            get
            {
                return this._securityCheck;
            }
            set
            {
                this._securityCheck = true;
            }
        }
        public bool PassportCheck
        {
            get
            {
                return this._passportCheck;
            }
            set
            {
                this._passportCheck = true;
            }
        }
    }
}
