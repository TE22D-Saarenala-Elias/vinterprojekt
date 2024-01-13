
//int[,] map = new int[3, 4]; 
//map[1] = 1;
//for(int y = 0; y < map.GetLength(1); y++){
//    for(int x = 0; x< map.GetLength(0); x++){
//        Console.WriteLine(map[x,0]);
//        Count++;
//    }
//}
//int [] numbers = {1, 2, 3, 4, 5};
//string name = "micke";
//numbers[0] = 25;

//char[] letters = {'e'};
//Console.WriteLine(numbers[]);
//Console.ReadLine();
//(int hp,string name) character =(100,"elias");
//static () saygodbye(int inrehp){}




//string[]playerName= {};
//-----------------------------------------------------------------------------------------------------
// bool classLoop = false;
// while (!classLoop)
// {

//     for (int i = 1; i < 5; i++)
//     {
//         // int.TryParse(Console.ReadLine(), out int userInput);


//         if (i.ToString() == Console.ReadLine())
//         {
//             classLoop=true;
//             int test=i;
//         }
//     }

// }

// if(i=1){Console.WriteLine("");} if(i=2){Console.WriteLine("");} if(i=2){Console.WriteLine("");} if(i=2){Console.WriteLine("");} 
//---------------------------------------------------------------------------------------------------------------------------------------
// foreach (var item in collection)
// {
//     if (nameof.Length> 4){
//         Console.WriteLine();
//     }

// }


// (string name , int streangth)

Console.WriteLine("hello and welcome to my DnD cheet creator \nName your charachter and Press Enter");
string characterName = Console.ReadLine().ToLower();
while (string.IsNullOrEmpty(characterName) || string.IsNullOrWhiteSpace(characterName))   //kollar så att namnet man väljer inte är tomt ->"" eller består av 
{                                                                                         //ett mellanslag och i så fall upprepar frågan tills man skrivit något. 
    Console.WriteLine("Name your character");
    characterName = Console.ReadLine();
}
Console.WriteLine("\n          your name is " + characterName );

bool raceLoop = true;
string race="";
while (string.IsNullOrEmpty(race) || string.IsNullOrWhiteSpace(race) || raceLoop)    //kollar samma sak som ovanstående kommentar samt ifall "raceLopp" är på för att köra while-           
{                                                                                    //loopen vilket bryts när ett alternativ är valt genom att ändra "raceLoop" till false.
    Console.WriteLine( "\n\nSelect your race by pressing the number" +
                                                       " of your race and then pressing ENTER \n\n 1. Dragonborn" +
                                                                                             "\n 2. Human" +
                                                                                             "\n 3. Dwarf" +
                                                                                             "\n 4. Elf" +
                                                                                             "\n 5. Tiefling");
    race = Console.ReadLine();

    if (race == "1" || race == "1." || race == "1.dragonborn" || race == "dragonborn")
    {
        race = "Dragonborn";
        raceLoop = false;
    }
    else if (race == "2" || race == "2." || race == "2.human" || race == "human")
    {
        race = "Human";
        raceLoop = false;
    }
    else if (race == "3" || race == "3." || race == "3.dwarf" || race == "dwarf")
    {
        race = "Dwarf";
        raceLoop = false;
    }
    else if (race == "4" || race == "4." || race == "4.elf" || race == "elf")
    {
        race = "Elf";
        raceLoop = false;
    }
    else if (race == "5" || race == "5." || race == "5.tiefling" || race == "tiefling")
    {
        race = "Tiefling";
        raceLoop = false;
    }
}
Console.WriteLine("\n          youre race is " + race); 

bool charachterClassloop = true;
string characterClass = "";
while (string.IsNullOrEmpty(characterClass) || string.IsNullOrWhiteSpace(characterClass) || charachterClassloop)
{
    Console.WriteLine("\n\nSelect your class by pressing the number" +
                                                   " of your class and then pressing ENTER \n 1. Barbarian" +
                                                                                          "\n 2. Bard" +
                                                                                          "\n 3. Druid" +
                                                                                          "\n 4. Paladin" +
                                                                                          "\n 5. Wizard" +
                                                                                          "\n 6. Rogue");
    characterClass = Console.ReadLine();

    string[] barbarianOptions = {"1", "1.", "1.barbarian", "1. barbarian", "barbarian", "Barbarian"}; 
        string[] bardOptions = {"2", "2.", "2.bard", "2. bard", "bard", "Bard"};
            string[] druidOptions = {"3", "3.", "3.druid", "3. druid", "druid", "Druid"};
                string[] paladinOptions = {"4", "4.", "4.paladin", "4. paladin", "paladin", "Paladin"};
                    string[] wizardOptions = {"5", "5.", "5.wizard", "5. wizard", "wizard", "Wizard"};
                        string[] rogueOptions = {"6", "6.", "6.rogue", "6. rogue", "rogue", "Rogue"};


    if (barbarianOptions.Contains(characterClass))
    {
        characterClass = "Barbarian";
        charachterClassloop = false;
    }
     else if (bardOptions.Contains(characterClass))
    {
        characterClass = "Bard";
        charachterClassloop = false;
    }
     else if (druidOptions.Contains(characterClass))
    {
        characterClass = "Druid";
        charachterClassloop = false;
    }
     else if (paladinOptions.Contains(characterClass))
    {
        characterClass = "Paladin";
        charachterClassloop = false;
    }
     else if (wizardOptions.Contains(characterClass))
    {
        characterClass = "Wizard";
        charachterClassloop = false;
    }
     else if (rogueOptions.Contains(characterClass))
    {
        characterClass = "Rogue";
        charachterClassloop = false;
    }
    
}
Console.WriteLine("Your class is " + characterClass);

bool weaponloop = true;
string weapon = "";
while (string.IsNullOrEmpty(weapon) || string.IsNullOrWhiteSpace(weapon) || weaponloop)
{
    Console.WriteLine("\n\nChose your weapon by pressing the number" +
                                                  " of the weapon you want and then pressing ENTER" +
        "\n 1. Greataxe ()            2. Lute                 3. Longsword            4. Wand                   5. dager"+
        "\n damage: 1d12             |damage: 12d12          |damage: 1d8            |damage: 1d1              |damage: 1d4                           "+ 
        "\n damage type: slashing    |damage type:bad music  |damage type: slashing  |damage type: poking      |damage type: piercing                 "+
        "\n properties: heavy,       |properties: two handed |properties: versatile  |properties:one hand      |properties: Finesse, light,"+
        "\n            two handed    |only useful for a bard |                       |only useful for a wizard |             range, thrown   " );
    weapon = Console.ReadLine();

    string[] greataxeOptions = {"1", "1.", "1.greataxe", "1. greataxe", "Greataxe"};
     string[] luteOptions = {"2", "2.", "2.lute", "2. lute", "Lute"};
      string[] longswordOptions = {"3", "3.", "3.longsword", "3. longsword", "Longsword"};
       string[] wandOptions = {"4", "4.", "4.wand", "4. wand", "Wand"};
        string[] daggerOptions = {"5", "5.", "5.dagger", "5. dagger", "Dagger"};

    if (greataxeOptions.Contains(weapon))
    {
        weapon = "Greataxe";
        weaponloop = false;
    }
    else if (luteOptions.Contains(weapon))
    {
        weapon = "Lute";
        weaponloop = false;
    }
    else if (longswordOptions.Contains(weapon))
    {
        weapon = "Longsword";
        weaponloop = false;
    }
    else if (wandOptions.Contains(weapon))
    {
        weapon = "Wand";
        weaponloop = false;
    }
    else if (daggerOptions.Contains(weapon))
    {
        weapon = "Dagger";
        weaponloop = false;
    }
}
Console.WriteLine("Your weapon is a "+ weapon);
Console.ReadLine();