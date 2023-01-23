using Lab9;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

Set images = new Set();




Image kartinka1 = new Image();
kartinka1.SetInf("Девятый вал", 500, 600);

Image kartinka2 = new Image();
kartinka2.SetInf("Три медведя в лесу", 1000, 500);

Image kartinka3 = new Image();
kartinka3.SetInf("Девочка с персиком", 2000, 3000);

Image kartinka4 = new Image();
kartinka4.SetInf("Девочка с персиком", 2000, 3000);

images.Add(kartinka1);
images.Add(kartinka2);
images.Add(kartinka3);
images.Add(kartinka4);

images.ShowSet();


images.Remove(kartinka1);

images.ShowSet();

images.Search(2);
images.Search(1);


// Task2


var count = new List<int> { 2,3,5,6,2,6,23,76,2345,7,325,979654};

LinkedList<int> numbers = new LinkedList<int>(count);
foreach (int number in numbers)
{
    Console.WriteLine(number);
}


Console.WriteLine("Введите количество удаляемых элементов");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    numbers.RemoveFirst();
}
foreach(int number in numbers)
{
    Console.WriteLine(number);
}
LinkedListNode<int> node;
numbers.AddLast(500);
for (node = numbers.First; node != null; node = node.Next)
{
    if (node.Value == 500)
    {
        numbers.AddAfter(node, 300);
     }
}
for (node = numbers.First; node != null; node = node.Next)
{
    if (node.Value == 300)
    {
        numbers.AddBefore(node, 800);
    }
}

numbers.AddFirst(9);
numbers.AddLast(8);
Console.WriteLine("Вывод:");
foreach (int number in numbers)
{
    Console.WriteLine(number);
}


List<int> numbersList = new List<int>(numbers);
Console.WriteLine("Вывод списка:");
foreach (int number in numbersList)
{
    Console.WriteLine(number);
}

Console.WriteLine("Введите число, которое вы ищете");
int a = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(numbersList.Find(number => number == a));



//Task 3

var imageCol = new ObservableCollection<Image>()
{
   kartinka1, kartinka2, kartinka3
};
// подписываемся на событие изменения коллекции
imageCol.CollectionChanged += CollectionEvent.Image_CollectionChanged;

imageCol.Add(new Image("Черный квадрат", 400,400));  // добавляем новый элемент

imageCol.RemoveAt(1);                 // удаляем элемент
imageCol[0] = new Image("Мона Лиза", 800, 400);   // заменяем элемент

Console.WriteLine("\nСписок картин:");
foreach (var image in imageCol)
{
    Console.WriteLine(image.name);
}
// обработчик изменения коллекции