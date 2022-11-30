
// сравнение изумрудов по их имени и хеш-коду

Console.WriteLine("Hello, World!");
Lab4.Emerald em1 = new();
Lab4.Emerald em2 = new();
em1.name = "Изумруд дорогой";
em1.price = 40000;
em1.weight = 5;
em2.name = "Изумруд дорогой";
em2.price = 60000;
em2.weight = 8;
em2.transparency = 0.4;
Console.WriteLine(em1.ToString());
Console.WriteLine(em2.ToString());
Console.WriteLine(em1.GetHashCode());
Console.WriteLine(em2.GetHashCode());
Lab4.Emerald em3 = new();
em3.name = "Изумруд имитация";
em3.price = 300;
em3.weight = 2;
em3.transparency = 0.1;
Console.WriteLine(em2.Equals(em3));


// разница в реализации метода PrintInfo у классов Thread и Stone



// ателье разматывает нитку и зашивает одежду


// покупаем камни

Lab4.Stones stone = new();
Lab4.Ruby rb = new();
rb.transparency = 0.3;
Lab4.Diamond dia = new();
dia.transparency = 0.3;
dia.name = "diamond";
dia.price = 599;
dia.color = "blue";
dia.weight = 3;
stone.BuyStone();
em1.BuyStone();
rb.BuyStone();
dia.BuyStone();

// Идентификация типов объектов
Console.WriteLine($"{em1 is Lab4.Emerald}");
Console.WriteLine($"{em1 is Lab4.Stones}");
Console.WriteLine($"{em1 is Lab4.Ruby} \n\n\n");







//ЛАБА 5 -------------------------------------------------------------
Console.WriteLine("LABA 5 \n\n\n\n");
//Перечисления
Lab4.PreciousStones preciousStone = new();
Lab4.Thread oneThread = new();



// ателье разматывает нитку и зашивает одежду


Lab4.Thread nitka = new();
nitka.name = "Нить для шитья";
nitka.price = 10;
nitka.lenth = 4;
nitka.PrintInfo();




Lab4.Clothes kurtka = new();
kurtka.name = "куртка";
kurtka.price = 500;
kurtka.wear = 70;

kurtka.PrintInfo();




Lab4.FashionStudio fashion1 = new();
fashion1.name = "Заплатка";
fashion1.price = 660000;
fashion1.numberOfEmployees = 15;

fashion1.PrintInfo();

fashion1.UnwindThread(nitka);
fashion1.Repair(kurtka);

nitka.PrintInfo();
kurtka.PrintInfo();


Lab4.Necklace ozherelie = new();
ozherelie.set(rb);

ozherelie.set(dia);

ozherelie.set(em2);


ozherelie.set(em3);

ozherelie.Print();

ozherelie.del(0);

ozherelie.Print();

Lab4.NecklaceController controller = new();

Console.WriteLine("Общий вес ожерелья: " + controller.WeightCount(ozherelie));
Console.WriteLine("Общая стоимость ожерелья: " + controller.PriceCount(ozherelie));

controller.SortNecklace(ozherelie);
ozherelie.Print();

Console.WriteLine("\n\n\n");
controller.findTransparency(ozherelie, 0.2, 0.4);