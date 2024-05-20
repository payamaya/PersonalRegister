
Console.WriteLine("Register a new employee: ");
Console.WriteLine("1. Add employee");
Console.WriteLine("2. Add Sallary");
Console.WriteLine("3. Show result");
Console.WriteLine("4. Exit application");


string addNewEmployee = Console.ReadLine();



    switch (addNewEmployee)
    {
        case "1":
            Console.WriteLine("Please add a name");
            string name= Console.ReadLine();    
            Console.WriteLine("Please add a salary");
           int salary= int.Parse(Console.ReadLine());
            break;


        case "3":
            Console.WriteLine("Employee info");
            break;

        default:
            Console.WriteLine(" Invalid Input");
            break;
    }
 while (addNewEmployee != "4");

Console.WriteLine("Closing application");
Console.ReadLine();
//2 krav 
// ta emot och lagra anställda med namn och lön
//skriv ut i konsol
