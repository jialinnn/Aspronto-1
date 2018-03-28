using System;
using SQLite;

namespace Aspronto.Model
{
    public class Profile
    {
        [PrimaryKey, AutoIncrement]
        public iny Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
        
        public DateTime DateOfBirth
        {
            get;
            set;
        }

        public string Gender
        {
            get;
            set;
        }

        public string Suburb
        {
            get;
            set;
        }
    }
}
