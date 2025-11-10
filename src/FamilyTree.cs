namespace FamilytreesLib;

public class FamilyTree
{
    private List<Person> _person = new List<Person>();
    private string _name;

    public FamilyTree(string name, List<Person> person)
    {
        _name = name;
        _person = person;
    }
    public string getName()
    {
        return _name;
    }
    public void AddPerson(Person person)
    {
        _person.Add(person);
    }

    public void RemovePerson(Person person)
    {
        _person.Remove(person);
    }

    
}