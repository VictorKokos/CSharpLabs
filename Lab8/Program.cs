using Lab8;
Programmer programmer = new Programmer();
programmer.Deleted += programmer.DisplayMessage;

programmer.AddItem("item1");
programmer.AddItem("item2");
programmer.AddItem("item3");


programmer.DeleteItem(1);


programmer.Mutated += programmer.DisplayAll;
programmer.Replace(0, "dww");


programmer.Mutated -= programmer.DisplayAll;
programmer.Mutated += programmer.Sortirovka;
programmer.Mutated += programmer.DisplayAll;
programmer.Replace(1, "abc");

programmer.Mutated -= programmer.DisplayAll;
programmer.Mutated += programmer.ClearList;
programmer.Mutated += programmer.DisplayAll;
programmer.Replace(2, "xxx");

Programmer programmer2 = new Programmer();

programmer2.AddItem("First");
programmer2.AddItem("Second");
programmer2.AddItem("Third");



programmer2.Deleted += programmer2.LeftAndRight;

programmer2.DeleteItem(1);


//Task2


StringProcessing String1= new StringProcessing();
String1.str = "Ах, как красиво!";
String1.DelPunctuation();
String1.Insert(2,"ахахах" );
String1.ToUpperCase();
String1.FirstWord();
String1.Pad();
Console.WriteLine(String1.str);

String1.action += String1.DelPunctuation;
String1.action += String1.ToUpperCase;
String1.action += String1.FirstWord;
String1.func += String1.Insert;
String1.str = "Боже, какая шутка!";

String1.action();
String1.func(4, "ВОООО");
Console.WriteLine(String1.str);

