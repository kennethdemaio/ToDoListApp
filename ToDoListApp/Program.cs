using System.Collections.Generic;
Console.WriteLine("Welcome to my Todo list program!");
Console.WriteLine("Please select from the options below.");
List<string> ToDoList = new List<string>();

bool RunProgram = true;
while (RunProgram){
    Console.WriteLine("\nPlease type 1 to add to your list");
    Console.WriteLine("Please type 2 to remove from your list");
    Console.WriteLine("Please type 3 to view your list");
    Console.WriteLine("Please type 4 to mark a task as complete");
    Console.WriteLine("Please type 5 to end program");
    string Response = Console.ReadLine();
        switch (Response){

            case "1":
                Console.WriteLine("Please enter the task you would like to add to your todo list.");
                string AddToList = Console.ReadLine();
                if (!string.IsNullOrEmpty(AddToList)){
                    ToDoList.Add(AddToList);
                }
                else{
                    Console.WriteLine("Please input a valid response and not null");
                }
               break;

            case "2":
                 Console.WriteLine("this is where i'll print the array of todos");
                 Console.WriteLine("Please enter the task you would like to be removed from your todo list");
                break;

            case "3":
                foreach (string number in ToDoList)
                {
                    Console.WriteLine(number);
                }
                break;

            case "4":
                Console.WriteLine("this is where i'll print the array of todos");
                Console.WriteLine("Please enter the task you would like to be marked as complete.");
                break;

            case "5":
                Console.WriteLine("test5");
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
}