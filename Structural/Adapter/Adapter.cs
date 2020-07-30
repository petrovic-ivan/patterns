using System;
using System.Linq;


namespace Adapter
{
    public class Adapter : ITarget
    {
        private readonly IAdaptee _adaptee;
        public Adapter(IAdaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public PersonApiModel GetPerson() 
        {
            var personUi = _adaptee.GetPersonData();
            var personApi = new PersonApiModel();
            personApi.FirstName = personUi.FullName.Split(' ').First();
            personApi.LastName = personUi.FullName.Split(' ').Skip(1).First();
            personApi.Id = Convert.ToInt32(personUi.Identifier);
            personApi.DoB = Convert.ToDateTime(personUi.DateOfBirth);

            return personApi;
        }
    }
}