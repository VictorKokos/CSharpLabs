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

