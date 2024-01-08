
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




Console.WriteLine("hello and welcome to my DnD cheet creator \nName your charachter and Press Enter");
string characterName = Console.ReadLine().ToLower();
while ( string.IsNullOrEmpty (characterName) ||string.IsNullOrWhiteSpace (characterName)){
    Console.WriteLine("Name your character");
    characterName = Console.ReadLine();
}
 Console.WriteLine("youre name is " + characterName + ".\n\nSelect your race by pressing the number"+
                                                        " of your race and then pressing ENTER \n 1. Dragonborn"+
                                                                                              "\n 2. Human"+
                                                                                              "\n 3. Dwarf"+
                                                                                              "\n 4. Elf"+
                                                                                              "\n 5. Tiefling" );
 
 string race = Console.ReadLine();
 while ( string.IsNullOrEmpty (race) ||string.IsNullOrWhiteSpace (race)){
    Console.WriteLine("pick your characters race!!\n 1. Dragonborn \n 2. Human \n 3. Dwarf \n 4. Elf \n 5. Tiefling");
    race = Console.ReadLine();
}  if (race== "1" || race=="1."|| race=="1.dragonborn" || race=="dragonborn"){
    race="Dragonborn";

   }
   else if (race== "2"||race== "2."|| race== "2.   "||race== ""){
    race="Human";
    
   }
    else if (race== "3"||race== "3."|| race== "2.   "||race== ""){
    race="Dwarf";
    
   }
    else if (race== "4"||race== "4."|| race== "2.   "||race== ""){
    race="Elf";
    
   }
    else if (race== "5"||race== "5."|| race== "2.   "||race== ""){
    race="Tiefling";
    
   }

    Console.WriteLine("youre race is " + race + ".\n\nSelect your class by pressing the number"+
                                                        " of your class and then pressing ENTER \n 1. Barbarian"+
                                                                                              "\n 2. Bard"+
                                                                                              "\n 3. Druid"+
                                                                                              "\n 4. Paladin"+
                                                                                              "\n 5. Wizard"+
                                                                                              "\n 6. Rogue" );
 
 string characterClass = Console.ReadLine();
 while ( string.IsNullOrEmpty (characterClass) ||string.IsNullOrWhiteSpace (characterClass)){
    Console.WriteLine("pick your characters class!!\n 1. Barbarian \n 2. Bard \n 3. Druid \n 4. Paladin \n 5. Wizard \n 6. Rogue ");
    characterClass = Console.ReadLine();
}  if (characterClass== "1" || characterClass=="1."|| characterClass=="1.barbarian" || characterClass=="barbarian"){
    characterClass="Barbarian";

   }
   else if (characterClass== "2"||characterClass== "2."|| characterClass== "2.   "||characterClass== ""){
    characterClass="Bard";
    
   }
    else if (characterClass== "3"||characterClass== "3."|| characterClass== "2.   "||characterClass== ""){
    characterClass="Druid";
    
   }
    else if (characterClass== "4"||characterClass== "4."|| characterClass== "2.   "||characterClass== ""){
    characterClass="Paladin";
    
   }
    else if (characterClass== "5"||characterClass== "5."|| characterClass== "2.   "||characterClass== ""){
    characterClass="Wizard";
    
   }
      
    else if (characterClass== "6"||characterClass== "6."|| characterClass== "2.   "||characterClass== ""){
    characterClass="Rogue";
    
   }





Console.ReadLine();
