using System.Drawing;
using System.Windows;
namespace FamilytreesLib;

public class Person
{
  private string _name;
  private DateTime _birthdate;
  private DateTime _deathdate;
  private bool _married;
  private bool _isDead;
  private List<Person> _children = new List<Person>();

  public Person(string name, DateTime birthdate, bool married)
  {
    _name = name;
    _birthdate = birthdate;
    _married = married;

  }

  public void addChild(Person child)
  {
    _children.Add(child);
  }

  public void addDeathdate(DateTime date)
  {
    _deathdate = date;
  }

  public void changeMariageStatus()
  {
    if (_married == false)
    {
      _married = true;
    }
    else if (_married == true)
    {
      _married = false;
    }
    else
    {
      throw new Exception("Keine Ahnung Bruder");
    }
  }

  public string getName()
    {
        return _name;
    }

  public DateTime getBirthdate()
    {
      return _birthdate;  
    }

  public DateTime getDeathdate()
    {
      return _deathdate;
    }
}
