
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace _10Head;

class Program
{
    static void Main(string[] args)
    {
        string xmlText = string.Empty;

        List<Employee> employees = new List<Employee>
        {
            new Employee {EmployeeID = 1, FirstName = "Goga", LastName = "Jaja", Age = 10 },
            new Employee {EmployeeID = 2, FirstName = "Zura", LastName = "Kaka", Age = 11 },
            new Employee {EmployeeID = 3, FirstName = "Vaja", LastName = "Baba", Age = 12 }

        };

        XmlSerializer xmlWriter = new XmlSerializer(typeof(List<Employee>));
        using (StringWriter sw = new StringWriter())
        {
            xmlWriter.Serialize(sw, employees);
            xmlText = sw.ToString();
            Console.WriteLine(xmlText);
        }

        XmlSerializer xmlReader = new XmlSerializer(typeof(List<Employee>));
        using (StringReader sr = new StringReader(xmlText))
        {
            List<Employee> tempList = (List<Employee>)xmlReader.Deserialize(sr);
            foreach (var employee in tempList)
            {
                Console.WriteLine(employee.EmployeeID);
                Console.WriteLine(employee.FirstName);
                Console.WriteLine(employee.LastName);
                Console.WriteLine(employee.Age);
                Console.WriteLine("----------");
            }
        }
    }
}
[Serializable]
public class Employee
{
    private int employeeID;
    private string firstName;
    private string lastName;
    private int age;

    public int EmployeeID
    {
        get { return employeeID; }
        set { employeeID = value; }
    }
    //[XmlElement("Employee Name")]
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }
    //[XmlIgnore]
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
}
