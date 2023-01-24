
object[] values = new object[] { "June", "July", "May",
"December", "January", "February", "April", "March ", "September ",
    "October ", "November ", "August "  };
IEnumerable<string> strings = values.OfType<string>().Where(i => i.Length == 4); 
Console.WriteLine(strings);
// извлекаем все строки, которые начинаются на A