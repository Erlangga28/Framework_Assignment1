using Microsoft.VisualBasic;

namespace BindingSVMM
{
    public class DataModel
    {
        public DataModel(Type type, string title, string description)
        {
            Data = type;
            Name = title;
            Description = description;
        }

        public Type Data { private set; get; }

        public string Name { private set; get; }

        public string Description { private set; get; }

        static DataModel()
        {
            All = new List<DataModel>
            {
  

                //Get current date and time.
                new DataModel(typeof(DateTime), "DateTime", "Obtain the current DateTime and display it"),

                new DataModel(typeof(ClockPage),"Clock", "Dynamically display current time"),

                new DataModel(typeof(HSLColorScrollPage),"Color", "Configuration the color"),

                new DataModel(typeof(KeypadPage),"Keypad", "Keypad Number"),

                new DataModel(typeof(AccountPage),"Account", "About this account"),

            };
        }
        public static IList<DataModel> All { private set; get; }

    }
}