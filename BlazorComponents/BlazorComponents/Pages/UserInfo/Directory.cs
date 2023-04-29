using BlazorComponents.Models;

namespace BlazorComponents.Pages.UserInfo
{
    public partial class Directory
    {
        public List<PersonModel> People { get; set; } = new List<PersonModel>();

        public Directory()
        {
            People = new List<PersonModel>
        {
            new PersonModel
            {
                FirstName = "John",
                LastName = "Doe",
                Addresses = new List<AddressModel>
                {
                    new AddressModel
                    {
                        AddressType = "Home",
                        Street = "123 Main St",
                        City = "Anytown",
                        State = "CA",
                        ZipCode = "12345"
                    },
                    new AddressModel
                    {
                        AddressType = "Work",
                        Street = "456 Main St",
                        City = "Anytown",
                        State = "CA",
                        ZipCode = "12345"
                    }
                }
            },

        };
        }

    }
}
