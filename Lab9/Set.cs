using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Set : ISet<Image>
    {

        public List<Image> images { get; set; } = new List<Image>();
        public int Count => images.Count;

        public bool IsReadOnly => false;

        public Set() { }

        public Set(Image image) 
        {
        images.Add(image);
        }

        public bool Add(Image item)
        {
            foreach(var image in images)
            {
                if(image.Equals(item))
                {
                    Console.WriteLine($"Невозможно добавить элемент {item}");
                    return false;
                }
            }
            Console.WriteLine($"Добавлен элемент {item}");
            images.Add(item);
            return true;
        }

        public void ShowSet()
        {
            Console.WriteLine("Все изображения:");
            foreach(Image item in images)
            {
                Console.WriteLine(item);
            }
        }

        public bool Remove(Image item)
        {
            foreach (var image in images)
            {
                if (image.Equals(item))
                {
                    Console.WriteLine($"Элемент{item} удалён");
                    images.Remove(item);
                    return true;
                }
            }
            Console.WriteLine($"Элемент{item} невозможно удалить");
            return false;

        }

        public void Search(int i)
        {

            try
            {
                Console.WriteLine($">{images[i]}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Элемент не найден");
            }
                
            
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Image item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Image[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public void ExceptWith(IEnumerable<Image> other)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Image> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void IntersectWith(IEnumerable<Image> other)
        {
            throw new NotImplementedException();
        }

        public bool IsProperSubsetOf(IEnumerable<Image> other)
        {
            throw new NotImplementedException();
        }

        public bool IsProperSupersetOf(IEnumerable<Image> other)
        {
            throw new NotImplementedException();
        }

        public bool IsSubsetOf(IEnumerable<Image> other)
        {
            throw new NotImplementedException();
        }

        public bool IsSupersetOf(IEnumerable<Image> other)
        {
            throw new NotImplementedException();
        }

        public bool Overlaps(IEnumerable<Image> other)
        {
            throw new NotImplementedException();
        }

      

        public bool SetEquals(IEnumerable<Image> other)
        {
            throw new NotImplementedException();
        }

        public void SymmetricExceptWith(IEnumerable<Image> other)
        {
            throw new NotImplementedException();
        }

        public void UnionWith(IEnumerable<Image> other)
        {
            throw new NotImplementedException();
        }

        void ICollection<Image>.Add(Image item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
