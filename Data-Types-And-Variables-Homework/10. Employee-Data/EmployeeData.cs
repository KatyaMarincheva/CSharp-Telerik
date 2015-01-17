//Problem 10. Employee Data

/* A marketing company wants to keep record of its employees. Each record would have the following characteristics:

    First name
    Last name
    Age (0...100)
    Gender (m or f)
    Personal ID number (e.g. 8306112507)
    Unique employee number (27560000…27569999)

Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
 * Use descriptive names. Print the data at the console. */

using System;
using System.Collections.Generic;
using System.Linq;

class EmployeeData
{
    // the variables below are the parameters of the object-shaper EmployeeData class - 
    //the class is the "cookie cutter", which will later be used to create (cut) multiple employeeData objects (cookies)
    public string FirstName;
    public string LastName;
    public byte Age;
    public string Gender;
    public long PersonalIdNumber;
    public int EmployeeId;

    public void PrintEmployeeData()  // this method prints all the properties of any EmplyeeData object created or called in the Main method below
    {
        Console.Clear(); //clears the console of any previous text
        Console.WriteLine("Employee ID: {0} \nName: {1} {2} \nAge: {3} \nGender: {4} \nPersonal ID Number: {5}",
                EmployeeId, FirstName, LastName, Age, Gender, PersonalIdNumber);
    }
}
class Employees
{
    #region Generate Unique Employee ID
    // the code below (line 41 to 89 and 99 to 101) generates the unique employee ID
    static Random random = new Random();

    // Note, max is exclusive here!
    public static List<int> GenerateRandom(int count, int min = 27560000, int max = 27569999)
    {
        if (max <= min || count < 0 ||
            // max - min > 0 required to avoid overflow
                (count > max - min && max - min > 0))
        {
            throw new ArgumentOutOfRangeException("Range or count " + count + " is illegal");
        }

        // generate count random values.
        HashSet<int> candidates = new HashSet<int>();

        // start count values before max, and end at max
        for (int top = max - count; top < max; top++)
        {
            // May strike a duplicate.
            // Need to add +1 to make inclusive generator
            // +1 is safe even for MaxVal max value because top < max
            if (!candidates.Add(random.Next(min, top + 1)))
            {
                // collision, add inclusive max.
                // which could not possibly have been added before.
                candidates.Add(top);
            }
        }

        // load them in to a list, to sort
        List<int> result = candidates.ToList();

        // shuffle the results because HashSet has messed
        // with the order, and the algorithm does not produce
        // random-ordered results (e.g. max-1 will never be the first value)
        for (int i = result.Count - 1; i > 0; i--)
        {
            int k = random.Next(i + 1);
            int tmp = result[k];
            result[k] = result[i];
            result[i] = tmp;
        }
        return result;
    }

    public static List<int> GenerateRandom(int count)
    {
        return GenerateRandom(count, 27560000, 27569999);
    }
    #endregion  // the code inside this region generates an unique employee ID number

    public static void Main()
    {
        List<object> employees = new List<object>(); // list into which we will be entering the new employee objects

        EmployeeData newEmployee = new EmployeeData(); // generates new employee objects (containing all data (properties) for a particular employee)
        Console.Clear();

        List<int> randomId = GenerateRandom(1); // generates one random number per employee
        string sequence = string.Join(", ", randomId.ToArray()); // the list of one elements is convered to string
        newEmployee.EmployeeId = Convert.ToInt32(sequence); // converts the above string to an int newEmployee.employeeId

        // input of the employee data
        Console.Write("New Employee Form: \n\nFirst Name:\t\t");
        newEmployee.FirstName = Console.ReadLine();

        Console.Write("Last Name:\t\t");
        newEmployee.LastName = Console.ReadLine();

        Console.Write("Age:\t\t\t");
        bool age = false;
        age = byte.TryParse(Console.ReadLine(), out newEmployee.Age);

        while (!age || newEmployee.Age <5 || newEmployee.Age > 150) //validates the age input
        {
            Console.WriteLine("Wrong input! {0} is not a valid age. \nPlease enter a number between 5 amd 150:");
            age = byte.TryParse(Console.ReadLine(), out newEmployee.Age);
        }

        Console.Write("Gender: F/M?\t\t");
        newEmployee.Gender = Console.ReadLine();

        // validates the gender input
        while (!newEmployee.Gender.Equals("f", StringComparison.OrdinalIgnoreCase) && !newEmployee.Gender.Equals("female", StringComparison.OrdinalIgnoreCase) && !newEmployee.Gender.Equals("m", StringComparison.OrdinalIgnoreCase) && !newEmployee.Gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Wrong input! Please enter F for female or M for male.");
            newEmployee.Gender = Console.ReadLine();
        }

        // if Female
        if (newEmployee.Gender.Equals("f", StringComparison.OrdinalIgnoreCase) || newEmployee.Gender.Equals("female", StringComparison.OrdinalIgnoreCase))
        {
            newEmployee.Gender = "Female";
        }

        // if Male
        else if (newEmployee.Gender.Equals("m", StringComparison.OrdinalIgnoreCase) || newEmployee.Gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
        {
            newEmployee.Gender = "Male";
        }
        
        Console.Write("Personal ID Number:\t");
        bool personalId = false;
        string id = Console.ReadLine();
        personalId = long.TryParse(id, out newEmployee.PersonalIdNumber);

        while ( !personalId || id.Length < 10 || id.Length > 10 )  // validates the personal ID number input
        {
        Console.WriteLine("Wrong input! The personal ID is a 10-digit number, please try again: ");
        id = Console.ReadLine();
        personalId = long.TryParse(id, out newEmployee.PersonalIdNumber);
        }

        // print new employee data
        Console.Clear();
        newEmployee.PrintEmployeeData(); // calls the above created printEmployeeData() method to print all newEmployee data

        // add the new employee to the employees list
        if (!employees.Contains(newEmployee.EmployeeId))
        {
            employees.Add(newEmployee);
        }
        Console.WriteLine("\nPlease, write down this employee ID: {0}, \nlater you can use it to retrieve your employee data.", newEmployee.EmployeeId);

        // uses the previously generated unique employee ID to call all employee data for the particular employee
        //(the same algorithm can call the employee data by Last name, personal ID number, etc - I just didn't want my code to get so long)
        Console.Write("\n\nPlease, enter your employee ID to get access to your employee data: \n");
        bool input = false;
        int inputOut;
        input = int.TryParse(Console.ReadLine(), out inputOut);

        while (!newEmployee.EmployeeId.Equals(inputOut)) //valiates the employee ID input
        {
            Console.WriteLine("\nThere is no employee data entered under this empolyee ID, please check your notes and re-enter your correct employee ID: \n");
            input = int.TryParse(Console.ReadLine(), out inputOut);
        }
        if (newEmployee.EmployeeId.Equals(inputOut))
        {
            newEmployee.PrintEmployeeData();
            Console.WriteLine("\nThank you for testing my program!");
        }
        Console.CursorVisible = false;
        Console.ReadLine();
    }
}


