namespace Adapter
{
    public class Adaptee : IAdaptee
    {
        public PersonUiModel GetPersonData()
        {
            var personUi = new PersonUiModel();
            personUi.Identifier = "1234";
            personUi.FullName = "Ivan Petrovic";
            personUi.DateOfBirth = "2020/01/01";
            
            return personUi;
        }
    }
}