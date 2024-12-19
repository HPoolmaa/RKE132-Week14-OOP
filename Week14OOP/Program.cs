Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();

Dog myDog = new Dog(myDogName); // klass - objekt 
//myDog._name = "Good Boy"; - rida asendatud constructori andmetega ning lsatud dog myDog reale, hiljem lisatud võimalus kasutajale ise nimi panna läbi CW "name your dog"

Dog neighboursDog = new Dog("Good Girl");
//neighboursDog._name = "good girl"; - rida asendatud constructori andmetega ning lsatud dog myDog reale

Console.WriteLine($"my dogs name is {myDog.Name}");
Console.WriteLine($"my neighbours dogs name is {neighboursDog.Name}");

myDog.Rename("Bad Boy");
Console.WriteLine($"Level of {myDog} happiness is {myDog.LevelOfHapiness}");

myDog.Bark();
Console.WriteLine($"Level of {myDog} happiness is {myDog.LevelOfHapiness}");

while (myDog.LevelOfHapiness != 5)
{
    myDog.Bark();
}

myDog.WagTail();
Console.WriteLine($"Level of {myDog} happiness is {myDog.LevelOfHapiness}");

class Dog
{
    private string _name = "Koer"; // (Field ehk väli) Private - andmeid ei saa klassi väliselt kätte.
    private int _levelOfHapiness = 0;

    //constructor
    public Dog(string name) // name - laseb kasutajal määrata koera nime
    {
        _name = name;
        _levelOfHapiness = 0;
    }
    //getter
    public string Name
    {
        get { return _name; }
    }
    public int LevelOfHapiness
    {
        get { return _levelOfHapiness; }
    }
    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to {newName}.");
    }
    public void Bark()
    {
        Console.WriteLine("Woof-Woof");
        _levelOfHapiness++;
    }

   public void WagTail()
    {
        Console.WriteLine("wiggle-wiggle");
        _levelOfHapiness++;
    }
}