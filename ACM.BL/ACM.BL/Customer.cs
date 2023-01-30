namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }

        public string FirstName { get; set; }


        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }

        }


        public string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }


        //  Validates the customer data.
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrEmpty(EmailAddress)) isValid = false;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;

            return isValid;
        }

        public static int InstanceCount { get; set; }
    }
}
