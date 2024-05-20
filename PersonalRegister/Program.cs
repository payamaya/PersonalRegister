using PersonalRegister;




class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();

        bool programmRuning = true;

        while (programmRuning)
        {
            Console.WriteLine("Register a new employee: ");
            Console.WriteLine("1. Add employee & Sallary");
            Console.WriteLine("2. Show result");
            Console.WriteLine("3. Exit application");


            /*      Console.WriteLine("4. Exit application");*/

            string addNewEmployee = Console.ReadLine();

            switch (addNewEmployee)
            {
                case "1":
                    Console.WriteLine("Please add a name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Please add a salary");
                    int salary = int.Parse(Console.ReadLine());

                    employees.Add(new Employee { Name = name, Salary = salary });
                    break;

                case "2":
                    Console.WriteLine("Employee info");
                    foreach (var employee in employees)
                    {
                        Console.WriteLine("Name: {0}, Salary {1}", employee.Name, employee.Salary);
                    }
                        Console.WriteLine();
                        break;  

                    case "3":
                    programmRuning= false;
                    Console.WriteLine("Closing application");
                    break;  
            
                default:
                    Console.WriteLine(" Invalid Input");
                    break;
            }
          

            //2 krav 
            // ta emot och lagra anställda med namn och lön
            //skriv ut i konsol
        }

    }
}

