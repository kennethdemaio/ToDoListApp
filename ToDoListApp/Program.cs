using System.Collections.Generic;
Console.WriteLine("Welcome to my Todo list program!");
Console.WriteLine("Please select from the options below.");
List<string> ToDoList = new List<string>();

bool RunProgram = true;
while (RunProgram){
    Console.WriteLine("\nPlease type 1 to add to your list"); // Complete
    Console.WriteLine("Please type 2 to remove from your list"); // String literal complete, index balue ot complete
    Console.WriteLine("Please type 3 to view your list"); // Complete
    Console.WriteLine("Please type 4 to mark a task as complete"); //Complete
    Console.WriteLine("Please type 5 to end program"); // Complete

    string Response = Console.ReadLine();
        switch (Response){

            case "1":
                Console.WriteLine("\nPlease enter the task you would like to add to your todo list.");
                string AddToList = Console.ReadLine();
                if (!string.IsNullOrEmpty(AddToList)){

                    ToDoList.Add(AddToList);

                }
                else{

                    Console.WriteLine("Please input a valid response and not null");

                }
               break;

            case "2":
                foreach (string number in ToDoList)
                {
                    Console.WriteLine(number);
                }
                Console.WriteLine("\nPlease enter the task you would like to be removed from your todo list");
                string RemoveFromList = Console.ReadLine();
                if (ToDoList.Contains(RemoveFromList)){

                    ToDoList.Remove(RemoveFromList);
                    Console.WriteLine($"{RemoveFromList} was removed from your todo list");

                }
                else{

                    Console.WriteLine("Value not found, you have to type the string literal");

                }
                break;

            case "3":
                foreach (string number in ToDoList)
                {
                    Console.WriteLine(number);
                }
                break;

            case "4":
                foreach (string number in ToDoList)
                {
                    Console.WriteLine(number);
                }
                Console.WriteLine("\nPlease enter the task you would like to be marked as complete.(first item is value 0");
                string CompleteTask = Console.ReadLine();
                int CompleteTaskIndex = Convert.ToInt32(CompleteTask);
                if(CompleteTaskIndex >= 0 && CompleteTaskIndex < ToDoList.Count){
    
                    string CurrentItem = ToDoList[CompleteTaskIndex];

                    string UpdatedString = " ✓";

                    ToDoList[CompleteTaskIndex] = CurrentItem + UpdatedString;
                    Console.WriteLine("Updated ToDoList: ");
                    foreach (string number in ToDoList){
                        Console.WriteLine(number);
                    }
            }
                break;

            case "5":
                Console.WriteLine("\nHave a nice day!");
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("\nInvalid input");
                break;
        }
}