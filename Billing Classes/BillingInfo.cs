using Newtonsoft.Json.Linq;

namespace SonarSUPREME
{
    public enum CardType
    {
        Visa,
        MasterCard,
        AmericanExpress,
        Solo
    }

    public class BillingInfo
    {
        public BillingInfo(string firstName, string lastName, string dateOfBirth, string contactNumber, string email, string houseNumber, string addressLine1, string addressLine2, string addressLine3, string city, string zipOrPostalCode, string stateOrCounty, string country, string cardtype, string cardName,string cardNumber, string cardExpiryMonth, string cardExpiryYear, string cardCvv)
        {
            CardType cType = CardType.Visa;
            if (cardtype.Contains("Visa"))
            {
                cType = CardType.Visa;
            }
            if (cardtype.Contains("MasterCard"))
            {
                cType = CardType.MasterCard;
            }
            if (cardtype.Contains("AmericanExpress"))
            {
                cType = CardType.AmericanExpress;
            }
            if (cardtype.Contains("Solo"))
            {
                cType = CardType.Solo;
            }

            FirstName = firstName;
            LastName = lastName;
            FullName = FirstName + " " + LastName;
            DateOfBirth = dateOfBirth;
            ContactNumber = contactNumber;
            Email = email;
            HouseNumber = houseNumber;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            AddressLine3 = addressLine3;
            City = city;
            ZipOrPostalCode = zipOrPostalCode;
            StateOrCounty = stateOrCounty;
            Country = country;
            cardType = cType;
            CardName = cardName;
            CardNumber = cardNumber;
            CardExpiryMonth = cardExpiryMonth;
            CardExpiryYear = cardExpiryYear;
            CardCVV = cardCvv;
        }

        // Personal Info
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FullName { get; private set; }
        public string DateOfBirth { get; private set; }
        public string ContactNumber { get; private set; }
        public string Email { get; private set; }
        // Shipping Info
        public string HouseNumber { get; private set; }
        public string AddressLine1 { get; private set; }
        public string AddressLine2 { get; private set; }
        public string AddressLine3 { get; private set; }
        public string City { get; private set; }
        public string ZipOrPostalCode { get; private set; }
        public string StateOrCounty { get; private set; }
        public string Country { get; private set;  }
        // Billing Info
        public CardType cardType { get; private set; }
        public string CardName { get; private set; }
        public string CardNumber { get; private set; }
        public string CardExpiryMonth { get; private set; }
        public string CardExpiryYear { get; private set; }
        public string CardCVV { get; private set; }

        public JObject ToJObject()
        {
            JObject o = new JObject();
            o["FirstName"] = FirstName;
            o["LastName"] = LastName;
            o["FullName"] = FullName;
            o["DateOfBirth"] = DateOfBirth;
            o["ContactNumber"] = ContactNumber;
            o["Email"] = Email;
            o["HouseNumber"] = HouseNumber;
            o["AddressLine1"] = AddressLine1;
            o["AddressLine2"] = AddressLine2;
            o["AddressLine3"] = AddressLine3;
            o["City"] = City;
            o["ZipOrPostalCode"] = ZipOrPostalCode;
            o["StateOrCounty"] = StateOrCounty;
            o["Country"] = Country;
            o["CardType"] = cardType.ToString();
            o["CardNumber"] = CardNumber;
            o["CardName"] = CardName;
            o["CardExpiryMonth"] = CardExpiryMonth;
            o["CardExpiryYear"] = CardExpiryYear;
            o["CardCVV"] = CardCVV;
            return o;
        }
    }
}
