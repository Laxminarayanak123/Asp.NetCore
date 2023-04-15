using System;
using System.Collections;
using System.Collections.Generic;

namespace Music
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList arr1= new ArrayList();
            List<Song> l1 = new List<Song>();
            Hashtable ht= new Hashtable();
            for(int i = 0; i <= 1; i++)
            {
                Console.WriteLine("enter song details:"+(i+1));
                string[] s1 = Console.ReadLine().Split(',');
                Song song= new Song();
                song._Title= s1[0];
                song._Genre= s1[1];
                song._Duration= s1[2];
                song._Rating = double.Parse(s1[3]);
                l1.Add(song);
            }

            //compare two songs
            bool x = compare(l1);
            if (x)
            {
                int j = 0;
                Console.WriteLine("                               ");
                foreach (Song song in l1)
                {
                    j = j + 1;
                    Console.WriteLine("Song "+ j);
                    Console.WriteLine("title: "+song._Title);
                    Console.WriteLine("genre: "+song._Genre);
                    Console.WriteLine("duration: "+song._Duration);  
                    Console.WriteLine("rating: "+song._Rating);
                    Console.WriteLine("                               ");
                }
            }
            else
            {
                Console.WriteLine("songs are not equal");
            }



        }
        static public bool compare(List<Song> list)
        {
            int s1 = 0;
            int s2 = 1;
            if (list[s1]._Title != list[s2]._Title)
            {
                return false;
            }
            if (list[s1]._Duration != list[s2]._Duration)
            {
                return false;
            }
            if (list[s1]._Rating != list[s2]._Rating)
            {
                return false;
            }
            if (list[s1]._Genre != list[s2]._Genre)
            {
                return false;
            }
            return true;
            //List<Song> l = new List<Song>();
            //l.Add(list[0]);
            //Console.WriteLine(!l[0].Equals(list[0]));
            //for(int i =1;i<list.Count;i++)
            //{
            //    if (!l[0].Equals(list[i]))
            //    {
            //        Console.WriteLine("hello");
            //        return false; 
            //    }
            //}
            //Console.WriteLine("help");
            //return true;
        }
    }
}
