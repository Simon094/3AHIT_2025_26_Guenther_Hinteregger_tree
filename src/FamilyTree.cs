namespace FamilytreesLib;

public class FamilyTree
{
    /// <summary>
    /// "_person" is for saving a list of the persons on the familytree
    /// </summary>
    private List<Person> _person = new List<Person>();
    /// <summary>
    /// "_name" is for saving the name as a string
    /// </summary>
    private string _name;

    /// <summary>
    /// Constructor for making the FamilyTree object
    /// </summary>
    /// <param name="name"></param> parameter "name" is for giving the name as a string
    public FamilyTree(string name)
    {
        _name = name;
    }
    /// <summary>
    /// function "getName" is for giving out the name of a familytree as string
    /// </summary>
    /// <returns></returns> returns the name of the familytree as string
    public string getName()
    {
        return _name;
    }
    /// <summary>
    /// function "AddPerson" is for adding a person to the familytree (List)
    /// </summary>
    /// <param name="person"></param> parameter "person" is for giving the person as a person-object to add to the familytree
    public void AddPerson(Person person)
    {
        _person.Add(person);
    }
    /// <summary>
    /// function "RemovePerson" is for removing a person from the familyt ree
    /// </summary>
    /// <param name="person"></param> parameter "person" is for giving the person as a person-object to remove from the familytree
    public void RemovePerson(Person person)
    {
        _person.Remove(person);
    }

    
}