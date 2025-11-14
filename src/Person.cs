using System.Drawing;
using System.Threading.Tasks.Dataflow;
using System.Windows;
using Microsoft.VisualBasic;
using Microsoft.Win32;
namespace FamilytreesLib;

public class Person
{
    private string _name;
    private DateTime _birthdate;
    private DateTime? _deathdate;
    private bool _married;
    private List<Person> _children = new List<Person>();
    private string _job;
    private string _school;
    private string _base64Image;
    
    public Person(string name, DateTime birthdate, bool married, string job, string school, DateTime deathdate, string base64Image)
    {
        _name = name;
        _birthdate = birthdate;
        _married = married;
        _job = job;
        _school = school;
        DateTime today = DateTime.Today;
        _deathdate = deathdate;
        _base64Image = base64Image;
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

    public string getSchool()
    {
        return _school;
    }
    public bool IsAdult()
    {
        DateTime today = DateTime.Today;
        int age = today.Year - _birthdate.Year;

        if (_birthdate.Date > today.AddYears(-age))
            age--;

        return age >= 18;
    }

    public int getAge()
    {
        DateTime today = DateTime.Today;
        int age = today.Year - _birthdate.Year;
        return age;
    }

    public string getBase64Image
    {
        get => _base64Image;
        set => _base64Image = value;
    }

    
}
