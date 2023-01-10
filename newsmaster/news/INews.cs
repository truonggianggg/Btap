// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Solution_Practical3_Exercise2
{
    internal interface INews
    {
        int ID { get; set; }
        String Title { get; set; }
        DateTime PublishDate { get; set; }
        String Author { get; set; }
        String Content { get; set; }
        float AverageRate { get; }
        void Display();
    }
}