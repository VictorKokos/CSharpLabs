using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
  
    public class CollectionEvent
    {

        public static void  Image_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: // если добавление
                    if (e.NewItems?[0] is Image newImage)
                        Console.WriteLine($"Добавлен новый объект: {newImage.name}");
                    break;
                case NotifyCollectionChangedAction.Remove: // если удаление
                    if (e.OldItems?[0] is Image oldImage)
                        Console.WriteLine($"Удален объект: {oldImage.name}");
                    break;
                case NotifyCollectionChangedAction.Replace: // если замена
                    if ((e.NewItems?[0] is Image replacingImage) &&
                        (e.OldItems?[0] is Image replacedImage))
                        Console.WriteLine($"Объект {replacedImage.name} заменен объектом {replacedImage.name}");
                    break;
            }
        }

    }
}
