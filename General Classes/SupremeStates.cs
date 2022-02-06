using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Serialization;

namespace SonarSUPREME.General_Classes
{
    public class CheckoutState
    {
        public CheckoutState(string title, string value)
        {
            Title = title;
            Value = value;
        }

        public string Title { get; private set; }
        public string Value { get; private set; }

    }
    public static class SupremeStates
    {
        public static List<CheckoutState> States = new List<CheckoutState>();

        static SupremeStates()
        {
            States.Add(new CheckoutState("AL", "Alabama"));
            States.Add(new CheckoutState("AK", "Alaska"));
            States.Add(new CheckoutState("AS", "American Samoa"));
            States.Add(new CheckoutState("AZ", "Arizona"));
            States.Add(new CheckoutState("AR", "Arkansas"));
            States.Add(new CheckoutState("AA", "Armed Forces America"));
            States.Add(new CheckoutState("AE", "Armed Forces Europe"));
            States.Add(new CheckoutState("AP", "Armed Forces Pacific"));
            States.Add(new CheckoutState("CA", "California"));
            States.Add(new CheckoutState("CO", "Colorado"));
            States.Add(new CheckoutState("CT", "Connecticut"));
            States.Add(new CheckoutState("DE", "Delaware"));
            States.Add(new CheckoutState("DC", "Dist Of Columbia"));
            States.Add(new CheckoutState("FL", "Florida"));
            States.Add(new CheckoutState("GA", "Georgia"));
            States.Add(new CheckoutState("GU", "Guam"));
            States.Add(new CheckoutState("HI", "Hawaii"));
            States.Add(new CheckoutState("ID", "Idaho"));
            States.Add(new CheckoutState("IL", "Illinois"));
            States.Add(new CheckoutState("IN", "Indiana"));
            States.Add(new CheckoutState("IA", "Iowa"));
            States.Add(new CheckoutState("KS", "Kansas"));
            States.Add(new CheckoutState("KY", "Kentucky"));
            States.Add(new CheckoutState("LA", "Louisiana"));
            States.Add(new CheckoutState("ME", "Maine"));
            States.Add(new CheckoutState("MH", "Marshall Islands"));
            States.Add(new CheckoutState("MD", "Maryland"));
            States.Add(new CheckoutState("MA", "Massachusetts"));
            States.Add(new CheckoutState("MI", "Michigan"));
            States.Add(new CheckoutState("FM", "Micronesia, Federated States Of"));
            States.Add(new CheckoutState("MN", "Minnesota"));
            States.Add(new CheckoutState("MS", "Mississippi"));
            States.Add(new CheckoutState("MO", "Missouri"));
            States.Add(new CheckoutState("MT", "Montana"));
            States.Add(new CheckoutState("NE", "Nebraska"));
            States.Add(new CheckoutState("NV", "Nevada"));
            States.Add(new CheckoutState("NH", "New Hampshire"));
            States.Add(new CheckoutState("NJ", "New Jersey"));
            States.Add(new CheckoutState("NM", "New Mexico"));
            States.Add(new CheckoutState("NY", "New York"));
            States.Add(new CheckoutState("NC", "North Carolina"));
            States.Add(new CheckoutState("ND", "North Dakota"));
            States.Add(new CheckoutState("MP", "Northern Mariana Islands"));
            States.Add(new CheckoutState("OH", "Ohio"));
            States.Add(new CheckoutState("OK", "Oklahoma"));
            States.Add(new CheckoutState("OR", "Oregon"));
            States.Add(new CheckoutState("PW", "Palau (Micronesia)"));
            States.Add(new CheckoutState("PA", "Pennsylvania"));
            States.Add(new CheckoutState("PR", "Puerto Rico"));
            States.Add(new CheckoutState("RI", "Rhode Island"));
            States.Add(new CheckoutState("SC", "South Carolina"));
            States.Add(new CheckoutState("SD", "South Dakota"));
            States.Add(new CheckoutState("TN", "Tennessee"));
            States.Add(new CheckoutState("TX", "Texas"));
            States.Add(new CheckoutState("UM", "U S Minor Outlying Islands"));
            States.Add(new CheckoutState("UT", "Utah"));
            States.Add(new CheckoutState("VT", "Vermont"));
            States.Add(new CheckoutState("VI", "Virgin Islands Of The United States"));
            States.Add(new CheckoutState("VA", "Virginia"));
            States.Add(new CheckoutState("WA", "Washington"));
            States.Add(new CheckoutState("WV", "West Virginia"));
            States.Add(new CheckoutState("WI", "Wisconsin"));
            States.Add(new CheckoutState("WY", "Wyoming"));
        }
    }
        
}
