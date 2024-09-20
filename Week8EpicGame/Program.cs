
string folderPath = "C:\\Users\\hellu\\Desktop\\Katrin\\Data";
string heroFile = "heroes.txt";
string villainsFile = "villains.txt";
string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainsFile));

//string[] heroes = { "Herakles", "Harry Potter", "Luke Skywalker", "Lara Croft", "Snowman" };
//string[] villains = { "Voldemort", "Batman", "Ironman", "Dracula", "Joker" };

string[] weapon = { "magic wand", "plastic fork", "banana", "sword" };


string hero = GetRandomValueFromArray(heroes);
String heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");


string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} with {villainWeapon} tries to take over the world!");

static string GetRandomValueFromArray(string[] someArray)
{
    Random random = new Random();
    int randomIndeks = random.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndeks];
    return randomStringFromArray;
}
