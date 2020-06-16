using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDetailsAndProviders.Classes
{
    static class MyTableSqlCommands
    {
        public static string AboutDetails { get; } = "Select * From Details";
        public static string EasyAboutDetails { get; } = "Select Dname AS Деталь,Dprice AS Цена From Details";

        public static string AboutProviders { get; } = "Select * From Providers";
        public static string EasyAboutProviders { get; } = "Select pname AS Фамилия From Providers";

        public static string AboutDelivery { get; } = "Select * FROM Delivery";
        public static string EasyAboutDelivery { get; } = 
                                  "Select pname AS Фамилия,Dname AS Деталь,volume AS Объём,date AS [Время сдачи]" +
                                  " FROM Delivery Join Providers ON Delivery.pnum = Providers.pnum" +
                                  " Join Details ON Delivery.dnum = Details.Dnum";
    }
}
