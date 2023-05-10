using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppCalendar
{
    public class DataContextSingleton
    {
        private static readonly DataClasses2DataContext instance = new DataClasses2DataContext();

        public static DataClasses2DataContext GetInstance()
        {
            return instance;
        }
    }

}