namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }


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

        public Customer Retrieve(int customerId)
        {
            // code that retrives the defined customer
            return new Customer();
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
