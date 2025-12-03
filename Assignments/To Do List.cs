using System.Runtime.InteropServices;

var todos = new List<string>();

Console.WriteLine("Hello!");

bool shallExit = false;

while (!shallExit)
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee to-do list");
    Console.WriteLine("[A]dd a new to-do item");
    Console.WriteLine("[R]emove a to-do item");
    Console.WriteLine("[E]xit");

    var userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "s":
        case "S":
            SeeAllTodos();
            break;
        case "a":
        case "A":
            AddTodo();
            break;
        case "r":
        case "R":
            RemoveTodo();
            break;
        case "e":
        case "E":
            Console.WriteLine("Exiting the application...");
            break;
        default:
            Console.WriteLine("Invalid choice!");
            break;
    }
}

void AddTodo()
{
    string description;
    do
    {
        Console.WriteLine("Enter the TODO description");
        description = Console.ReadLine();
    }
    while (!IsDescriptionValid(description));

    todos.Add(description);
}

void SeeAllTodos()
{

    if (todos.Count == 0)
    {
        ShowNoTodosMessage();
        return;
    }

    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {todos[i]}");
    }

}

bool IsDescriptionValid(string description)
{
    if (description == "")
    {
        Console.WriteLine("The to-do item cannot be empty!");
        return false;
    }
    else if (todos.Contains(description))
    {
        Console.WriteLine("This to-do item already exists!");
        return false;
    }
    else
    { 
        Console.WriteLine("To-do item added successfully!");
    }
    return true;
}


void RemoveTodo()
{
    if (todos.Count == 0)
    {
        ShowNoTodosMessage();
        return;

    }

    int index;
    do
    {
        Console.WriteLine("Select the index of the TODO you want to remove");
        SeeAllTodos();
    } while (!TryReadIndex(out index));

    RemoveTodoAtIndex(index - 1);
}

void RemoveTodoAtIndex(int index)
{
    var todoToBeRemoved = todos[index];
    todos.RemoveAt(index);
    Console.WriteLine("TODO removed: " + todoToBeRemoved);
}


bool TryReadIndex(out int index)
{
    var userInput = Console.ReadLine();
    if (userInput == "")
    {
        index = 0;
        Console.WriteLine("Seleceted index cannot be empty");
        return false;
    }
    if (int.TryParse(userInput, out  index) &&
    index >= 1 &&
    index <= todos.Count)
    {
        return true;
    }

    Console.WriteLine("The given index is not valid");
    return false;
}



void ShowNoTodosMessage()
{
    Console.WriteLine("No TODOs have been added yet.");
}