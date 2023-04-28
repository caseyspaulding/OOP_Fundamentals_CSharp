namespace ConsoleUI
{
    public class PersonModel
    {
        public string FirstName { private get; set; }
        public string LastName { get; private set; }
        //public int Age { get; set; }

        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    _age = value;
                }
                else
                {
                    throw new System.ArgumentException("Age must be between 0 and 100");
                }

            }
        }

        // public string SSN { get; set; } // Social Security Number (SSN) 

        private string _ssn;

        public string SSN
        {
            get
            {
                string output = "XXX-XX-" + _ssn.Substring(_ssn.Length - 4);
                return output;
            }
            set { _ssn = value; }
        }

        public PersonModel()
        {

        }




    }
}
