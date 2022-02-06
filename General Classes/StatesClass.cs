using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SonarSUPREME.General_Classes
{
    public class State
    {
        public State(string title, string value)
        {
            Title = title;
            Value = value;
        }

        public string Title { get; private set; }
        public string Value { get; private set; }
    }

    public static class StatesClass
    {
        public static List<State> States = new List<State>();

        static StatesClass()
        {
            States.Add(new State("Alabama", "1"));
            States.Add(new State("Alaska", "2"));
            States.Add(new State("American Samoa", "3"));
            States.Add(new State("Arizona", "4"));
            States.Add(new State("Arkansas", "5"));
            States.Add(new State("Armed Forces Africa", "6"));
            States.Add(new State("Armed Forces Americas", "7"));
            States.Add(new State("Armed Forces Canada", "8"));
            States.Add(new State("Armed Forces Europe", "9"));
            States.Add(new State("Armed Forces Middle East", "10"));
            States.Add(new State("Armed Forces Pacific", "11"));
            States.Add(new State("California", "12"));
            States.Add(new State("Colorado", "13"));
            States.Add(new State("Connecticut", "14"));
            States.Add(new State("Delaware", "15"));
            States.Add(new State("District of Columbia", "16"));
            States.Add(new State("Federated States Of Micronesia", "17"));
            States.Add(new State("Florida", "18"));
            States.Add(new State("Georgia", "19"));
            States.Add(new State("Guam", "20"));
            States.Add(new State("Hawaii", "21"));
            States.Add(new State("Idaho", "22"));
            States.Add(new State("Illinois", "23"));
            States.Add(new State("Indiana", "24"));
            States.Add(new State("Iowa", "25"));
            States.Add(new State("Kansas", "26"));
            States.Add(new State("Kentucky", "27"));
            States.Add(new State("Louisiana", "28"));
            States.Add(new State("Maine", "29"));
            States.Add(new State("Marshall Islands", "30"));
            States.Add(new State("Maryland", "31"));
            States.Add(new State("Massachusetts", "32"));
            States.Add(new State("Michigan", "33"));
            States.Add(new State("Minnesota", "34"));
            States.Add(new State("Mississippi", "35"));
            States.Add(new State("Missouri", "36"));
            States.Add(new State("Montana", "37"));
            States.Add(new State("Nebraska", "38"));
            States.Add(new State("Nevada", "39"));
            States.Add(new State("New Hampshire", "40"));
            States.Add(new State("New Jersey", "41"));
            States.Add(new State("New Mexico", "42"));
            States.Add(new State("New York", "43"));
            States.Add(new State("North Carolina", "44"));
            States.Add(new State("North Dakota", "45"));
            States.Add(new State("Northern Mariana Islands", "46"));
            States.Add(new State("Ohio", "47"));
            States.Add(new State("Oklahoma", "48"));
            States.Add(new State("Oregon", "49"));
            States.Add(new State("Palau", "50"));
            States.Add(new State("Pennsylvania", "51"));
            States.Add(new State("Puerto Rico", "52"));
            States.Add(new State("Rhode Island", "53"));
            States.Add(new State("South Carolina", "54"));
            States.Add(new State("South Dakota", "55"));
            States.Add(new State("Tennessee", "56"));
            States.Add(new State("Texas", "57"));
            States.Add(new State("Utah", "58"));
            States.Add(new State("Vermont", "59"));
            States.Add(new State("Virgin Islands", "60"));
            States.Add(new State("Virginia", "61"));
            States.Add(new State("Washington", "62"));
            States.Add(new State("West Virginia", "63"));
            States.Add(new State("Wisconsin", "64"));
            States.Add(new State("Wyoming", "65"));

        }
    }
}
