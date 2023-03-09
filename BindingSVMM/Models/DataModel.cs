﻿using Microsoft.VisualBasic;

namespace BindingSVMM
{
    public class DataModel
    {
        public DataModel(Type type, string title, string description)
        {
            Type = type;
            Title = title;
            Description = description;
        }

        public Type Type { private set; get; }

        public string Title { private set; get; }

        public string Description { private set; get; }

        static DataModel()
        {
            All = new List<DataModel>
            {
  

                //Get current date and time.
                new DataModel(typeof(DateTime), "DateTime", "Obtain the current DateTime and display it"),

                new DataModel(typeof(ClockPage),"Clock", "Dynamically display current time"),

                new DataModel(typeof(Information),"Information", "Information About ME!"),

            };
        }
        public static IList<DataModel> All { private set; get; }

    }
}