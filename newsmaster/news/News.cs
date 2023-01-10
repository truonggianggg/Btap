// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Solution_Practical3_Exercise2
{
     class News : INews
    {
        int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        String title;
        public String Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        DateTime pulishdate;
        public DateTime PulishDate
        {
            get
            {
                return pulishdate;
            }
            set
            {
                pulishdate = value;
            }
        }
        String author;
        public String Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        String content;
        public String Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }
        float averagerate;
        public float AverageRate
        {
            get
            {
                return averagerate;
            }
        }
        public void Display()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Pulish Date: " + PulishDate);
            Console.WriteLine("Author " + Author);
            Console.WriteLine("Content: " + Content);
            Console.WriteLine("Averate Rate" + AverageRate);
        }
        int[] RateList = new int[3];
        public int this[int index]
        {
            get
            {
               return RateList[index];
            }
            set
            {
                RateList[index] = value;
            }
        }
        public void Calculate()
        {
            averagerate = (float)(RateList[0] + RateList[1]+ RateList[2]);
        }
    }
}