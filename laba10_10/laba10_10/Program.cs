using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace laba10_10
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Pictures<string>> list1 = new LinkedList<Pictures<string>>();
            Pictures<string> img1 = new Pictures<string>("img1", ".jpg");
            Pictures<string> img2 = new Pictures<string>("img2", ".png");
            Pictures<string> img3 = new Pictures<string>("img3", ".svg");
            Pictures<string> img4 = new Pictures<string>("img4", ".psd");
            Pictures<string> img5 = new Pictures<string>("img5", ".jpg");
            Pictures<string> img6 = new Pictures<string>("img6", ".png");
            //доабвление разными способами
            list1.AddFirst(img1);
            list1.AddAfter(list1.Last, img2);
            list1.AddAfter(list1.Last, img3);
            list1.AddAfter(list1.Last, img4);
            list1.AddLast(img6);
            list1.AddBefore(list1.Last, img5);
            Console.WriteLine("Изначальная коллекция:");
            //a. Выведите коллекцию на консоль
            foreach (Pictures<string> i in list1)
            {
                Console.WriteLine(i);
            }
            //удаление
            list1.Remove(img6);
            Console.WriteLine("Удаляем 1 элемент:");
            foreach (Pictures<string> i in list1)
            {
                Console.WriteLine(i);
            }
            //b. Удалите из коллекции n последовательных элементов
            for (int i = 1; i < 3; i++)
            { 
                list1.Remove(list1.ElementAt(2));
            }
     
            Console.WriteLine("Удаляем несколько последовательных:");
            foreach (Pictures<string> i in list1)
            {
                Console.WriteLine(i);
            }
            
            //. Создайте вторую коллекцию
            List<Pictures<string>> list2 = new List<Pictures<string>>();
           
            foreach (Pictures<string> i in list1) /////запись элементов второй коллекции в третью
            {
                list2.Add(i);
            }
            Console.WriteLine("Запись эллементов во вторую коллекцию:");
            foreach (var i in list2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Поиск эллемента по значению поля:");
            var item = list2.Find(o => o.Name == "img2");
            Console.WriteLine(item);
            ObservableCollection<Pictures<string>> obs = new ObservableCollection<Pictures<string>>();
            obs.CollectionChanged += StaticClass.Method;
            obs.Add(img1);
            obs.Add(img2);
            obs.Add(img3);
            obs.Add(img4);
            obs.Add(img5);
            obs.Add(img6);
            obs.Remove(img3);
            obs.Remove(img5);
            Console.WriteLine("Конечная просматриваемая коллекция: ");
            foreach (var i in obs)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    } 
}
