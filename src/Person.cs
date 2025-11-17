using System.Drawing;
using System.Reflection;
using System.Threading.Tasks.Dataflow;
using System.Windows;
using Microsoft.VisualBasic;
using Microsoft.Win32;
namespace FamilytreesLib;

public class Person
{
    /// <summary>
    /// "_name" is for saving the name as a string
    /// </summary>/
    private string _name;
    /// <summary>
    /// "_birthdate" is for saving the birthdate as DateTime
    /// </summary>
    private DateTime _birthdate;
    /// <summary>
    /// "_deathdate" is for saving the deathdate as DateTime
    /// </summary>
    private DateTime? _deathdate;
    /// <summary>
    /// "_married" is a bool to say if the person is married
    /// </summary>
    private bool _married;
    /// <summary>
    /// "_child" is a bool to see if the person is over 18 or not
    /// </summary>/
    private bool _child;
    /// <summary>
    /// "_job" is for saving the job
    /// </summary>
    private string _job;
    private string _school;
    private bool _ifTrueThanItIsMaleIfItIsFalseThanItIsFemaleNoOtherGendersAllowed;
    
    private List<Person> _children = new List<Person>();

    private Image _personImage;
    public Person(string name, DateTime birthdate, bool married, bool child, DateTime deathdate, Image personImage, string school = "", string job = "Arbeitslos")
    {
        _name = name;
        _birthdate = birthdate;
        _married = married;
        _job = job;
        DateTime today = DateTime.Today;
        _deathdate = deathdate;
        _personImage = personImage;
        _school = school;
        if(this.IsAdult() == true)
        {
            _child = false;
        } else
        {
            _child = true;
        }
    }

    public void addChild(Person child)
    {
        _children.Add(child);
    }

    public void addDeathdate(DateTime date)
    {
        _deathdate = date;
    }

    public void changeMarriageStatus()
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
            throw new Exception("Beziehungstatus nicht bekannt");
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

    public DateTime? getDeathdate()
    {
        return _deathdate;
    }

    public bool getMariageStatus()
    {
        return _married;
    }

    public string getJob()
    {
        return _job;
    }

    public Image getPersonImage()
    {
        return _personImage;
    }
   public bool IsAdult()
{
    DateTime today = DateTime.Today;
    int age = today.Year - _birthdate.Year;
    if (_birthdate.Date > today.AddYears(-age))
    {
        age--;
    }

    if (age >= 18)
    {
        return true;
    }
    else
    {
        return false;
    }
}

    public int getAge()
    {
        DateTime today = DateTime.Today;
        int age = today.Year - _birthdate.Year;
        return age;
    }

    public string getSchool(Person person)
    {
        if (person.IsAdult())
        {
            return "Die Person ist entweder kein Kind oder geht nicht zur Schule!";
        }
        return _school;
    }
    
}
