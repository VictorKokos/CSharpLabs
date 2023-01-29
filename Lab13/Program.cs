using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;
using Lab4;
using Lab13;
using System.Xml.Serialization;
using System.Xml;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;



//BinaryFormatter formatter = new BinaryFormatter();
//using (FileStream fs = new FileStream("stone.dat", FileMode.OpenOrCreate))
//{
//    formatter.Serialize(fs, stone);

//    Console.WriteLine("Объект сериализован");
//}

//using (FileStream fs = new FileStream("stone.dat", FileMode.OpenOrCreate))
//{
//    Stone stone2 = (Stone)formatter.Deserialize(fs);

//    Console.WriteLine("Объект десериализован");
//    Console.WriteLine($"Имя: {stone2.Name} --- Цена: {stone2.Price} ---  Цвет: {stone2.Color}");
//}

//// сохранение данных
//using (FileStream fs1 = new FileStream("stones.json", FileMode.OpenOrCreate))
//{
//    Stone stone3 = new Stone("Stone", 200, "Серый");
//    await JsonSerializer.SerializeAsync<Stone>(fs1, stone3);
//    Console.WriteLine("Data has been saved to file");
//}

//// чтение данных
//using (FileStream fs1 = new FileStream("stones.json", FileMode.OpenOrCreate))
//{
//    Stone? stone4 = await JsonSerializer.DeserializeAsync<Stone>(fs1);
//    Console.WriteLine($"Имя: {stone4.Name}");
//}


//Stone stone5 = new Stone("Мрамор", 1000, "белый");
//XmlSerializer xmlSerializer = new XmlSerializer(typeof(Stone));

//using (FileStream fs1 = new FileStream("stones.xml", FileMode.OpenOrCreate))
//{
//    xmlSerializer.Serialize(fs1, stone5);
//}

//using (FileStream fs1 = new FileStream("stones.xml", FileMode.OpenOrCreate))
//{
//    Stone? stone6 = xmlSerializer.Deserialize(fs1) as Stone;
//    Console.WriteLine($"Name: {stone6?.Name}  Цвет: {stone6?.Color}");
//}








//Stone stone7 = new Stone("Песчаник", 10, "коричневый");
//SoapFormatter soapFormatter = new SoapFormatter();
//using (FileStream fs1 = new FileStream("stones.soap", FileMode.OpenOrCreate))
//{
//    soapFormatter.Serialize(fs1, stone7);
//}

//using (FileStream fs1 = new FileStream("stones.soap", FileMode.OpenOrCreate))
//{
//    Stone stone8 = (Stone)formatter.Deserialize(fs1);



//    Console.WriteLine("Имя: {0} --- Возраст: {1}", stone8.Name, stone8.Color);

//}

Stone stone = new Stone("Кремень", 500, "Серый");

Serializer.Serialize(stone, "bin", "stone");

Console.WriteLine(Serializer.Deserialize<Stone>("bin", "stone").Name);


Serializer.Serialize(stone, "xml", "stone");

Console.WriteLine(Serializer.Deserialize<Stone>("xml", "stone").Name);

Serializer.Serialize(stone, "json", "stone");

Console.WriteLine(Serializer.Deserialize<Stone>("xml", "stone").Name);


int [] arrayOfInt = new int[5];
arrayOfInt[0] = 1;
arrayOfInt[1] = 2;
arrayOfInt[2] = 3;
arrayOfInt[3] = 4;
arrayOfInt[4] = 5;


Serializer.ArrayJSONSerialize(arrayOfInt, "arrayOfInt");

int[] secondArray = Serializer.ArrayJSONDeserialize<int>("arrayOfInt");

Console.WriteLine(secondArray[2]);





XmlDocument xDoc = new XmlDocument();
xDoc.Load("stone.xml");
XmlElement? xRoot = xDoc.DocumentElement;

// выбор всех дочерних узлов
XmlNodeList? nodes = xRoot?.SelectNodes("*");
if (nodes is not null)
{
    foreach (XmlNode node in nodes)
        Console.WriteLine(node.OuterXml);
}

XmlNodeList? node2 = xRoot?.SelectNodes("Price");

Console.WriteLine(node2[0].InnerText);


Stone[] kamushki = new Stone[3];


Stone stone2 = new Stone("Мрамор", 1000, "Белый");
Stone stone3 = new Stone("Гранит", 800, "Серый");

kamushki[0] = stone;
kamushki[1] = stone2;
kamushki[2] = stone3;

Serializer.ArrayJSONSerialize(kamushki, "Kamushki");
Stone[] kamni = Serializer.ArrayJSONDeserialize<Stone>("Kamushki");

System.Console.WriteLine(kamni[1].Name);




using (StreamReader reader = File.OpenText(@"D:\Work\CSharpLabs\Lab13\bin\Debug\net6.0\Kamushki.json"))
{
    JArray o = (JArray)JToken.ReadFrom(new JsonTextReader(reader));
    string firstKamPrice = (string)o[2]["Price"];
    string secondKamColor = (string)o[1]["Color"];
    string thirdKamName = (string)o[2]["Name"];

    Console.WriteLine(firstKamPrice);
    Console.WriteLine(secondKamColor);
    Console.WriteLine(thirdKamName);
}
