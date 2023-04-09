string folderPath = @"C:\data";
string fileName = "shopingList.txt";
string filePath = Path.Combine(folderPath, fileName);
List<string> myShopingList = new List<string>();

if (File.Exists(filePath))
{
    ShowItemsFrimList(myShopingList);
    File.WriteAllLines(filePath, myShopingList);
}
else
{
   File.Create(filePath).Close();
    Console.WriteLine($"File{fileName} has been greated.");
    ShowItemsFrimList(myShopingList);
    File.WriteAllLines(filePath, myShopingList);
}


List<string> myShoppingList = GetItemsFromUser();
ShowItemsFrimList(myShoppingList);
static List<string> GetItemsFromUser()
{
    List<string> myShopingList = new List<string>();

    while (true)
    {
        Console.WriteLine("Add an item (add)/Exit ");
        string userChoice = Console.ReadLine();

        if (userChoice == "add")
        {
            Console.WriteLine("Enter an item");
            string userItem = Console.ReadLine();
            myShopingList.Add(userItem);
        }
        else
        {
            Console.WriteLine("Bye!");
            break;
        }
    }
    return myShopingList;
}

static void ShowItemsFrimList(List<string> someList)
{
Console.Clear();
int listLenght = someList.Count;
Console.WriteLine($"You have added {listLenght} items to your shopping list.");

int i = 1;

foreach(string item in someList)
{

    Console.WriteLine($"{i}. {item}");
    i++;
}
}


