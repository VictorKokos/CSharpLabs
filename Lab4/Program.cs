
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
Console.WriteLine(em1.ToString());
Console.WriteLine(em2.ToString());
Console.WriteLine(em1.GetHashCode());
Console.WriteLine(em2.GetHashCode());
Lab4.Emerald em3 = new();
em3.name = "Изумруд имитация";
em3.price = 300;
em3.weight = 2;
Console.WriteLine(em2.Equals(em3));


// разница в реализации метода PrintInfo у классов Thread и Stone
Lab4.Thread nitka = new();
nitka.name = "Нить для шитья";
nitka.price = 10;
nitka.lenth = 4;
nitka.PrintInfo();
em1.PrintInfo();


// ателье разматывает нитку и зашивает одежду

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

// покупаем камни

Lab4.Stones stone = new();
Lab4.Ruby rb = new();
Lab4.Diamond dia = new();
stone.BuyStone();
em1.BuyStone();
rb.BuyStone();
dia.BuyStone();

// Идентификация типов объектов
Console.WriteLine($"{em1 is Lab4.Emerald}");
Console.WriteLine($"{em1 is Lab4.Stones}");
Console.WriteLine($"{em1 is Lab4.Ruby} \n\n\n");