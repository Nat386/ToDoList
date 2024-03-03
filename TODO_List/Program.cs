using System.Text;

class Program
{
  
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;
     
           
        List<string> toDoList = new List<string>();


        while (true)
        {
            Console.WriteLine("To Do List");
            Console.WriteLine($"Here is the list of things you need to do:");
            foreach (string task in toDoList)
            {                
                Console.WriteLine("- " + task);
            }

            Console.WriteLine($"Please choose the option from the menu:");
            Console.WriteLine($"1. Add the task");
            Console.WriteLine($"2. Remove the task");
            Console.WriteLine($"3. Exit");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Please enter the task that you want to add to the list.");
                    string newTask = Console.ReadLine();
                    toDoList.Add(newTask);
                    break;

                case 2:
                    Console.WriteLine($"Please enter the task that you want to remove from the list.");
                    int taskNum = int.Parse(Console.ReadLine());

                    if (taskNum >= 1 && taskNum <= toDoList.Count)
                    {
                        toDoList.RemoveAt(taskNum - 1);
                    }
                    else
                    {
                        Console.WriteLine("Error.Please choose a valid task number.");
                    }
                    break;


                case 3:
                    Console.WriteLine($"Thank you using our program. See you next time!");
                    return;


                default:
                    Console.WriteLine($"Please choose the correct option from 1 to 3");
                    break;
            }
                   
                
           
         
        }
    }
}