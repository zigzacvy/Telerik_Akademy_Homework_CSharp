using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    class GSM
    {
        //GSM Fields (Task 1.) //Encapsulation with syntactic sugar (Task 5.)
        public string model { get; set; }
        public string manufacturer { get; set; }
        private float price = 0;
        public string owner { get; set; }

        //Instances of the secondary classes: Display, Battery (Task 1.)
        public Battery instBattery { get; set; }
        public Display instDisplay { get; set; }

        //Property that holds list of performed calls (Task 9.)
        private List<Call> callHistory;

        //That helps me initialise the iPhone object with his preset info (Task 7.) 
        public GSM() { }

        //Mandatory Fields Constructor (Task 2.)
        public GSM(string userModel, string userManufacturer, float userPrice = 0, string userOwner = null
            , Battery userBattery = null, Display userDisplay = null)
        {
            this.model = userModel;
            this.manufacturer = userManufacturer;
            this.Price = userPrice; //Calls for the property of the field "price"
            this.owner = userOwner;
            this.instBattery = userBattery;
            this.instDisplay = userDisplay;
            this.callHistory = new List<Call>();
        }

        //Properties (Task 5.)       
        public float Price
        {
            get { return this.price; }
            set
            {
                if (value > 0) this.price = value;
                else throw new ArgumentOutOfRangeException();
            }
        }

        //Static object: iPhtone (Task 6.)
        static private GSM iPhone = new GSM("iPhone4S", "Apple", 1000);  //Throws TypeInitializationException with only the first two initializations!

        public GSM IPhone
        {
            get { return iPhone; }
        }

        //Printing method (Task 4.)
        public override string ToString()
        {
            StringBuilder gsmFields = new StringBuilder();
            gsmFields.AppendLine(this.model);
            gsmFields.AppendLine(this.manufacturer);
            gsmFields.AppendLine(this.price.ToString());
            gsmFields.AppendLine(this.owner);
            gsmFields.AppendLine(this.instBattery.ToString());
            gsmFields.AppendLine(this.instDisplay.ToString());

            return gsmFields.ToString();
        }

        //Method that displays the information about the static class (Task 7.)
        public string PrintIPhoneInfo()
        {
            StringBuilder iPhoneFields = new StringBuilder();
            iPhoneFields.AppendLine(this.model);
            iPhoneFields.AppendLine(this.manufacturer);
            iPhoneFields.AppendLine(this.price.ToString());

            return iPhoneFields.ToString();
        }

        //Adding, deleting and clearing CallHistory (Task 10.)
        public void InsertCallInHist(Call callInfo)
        {
            this.callHistory.Add(callInfo);
        }

        public void DeleteCallFromHist(int numOfEl)
        {
            this.callHistory.Remove(callHistory[numOfEl]);
        }

        public void ClearAllCallHist()
        {
            this.callHistory.Clear();
        }

        //Method that calculated total price of calls in the CallHistory (Task 11.)
        public float PriceCalculator(float pricePerMin)
        {
            float price = pricePerMin;
            float priceSum = 0;
            for (int i = 0; i < callHistory.Count; i++)
            {
                priceSum += callHistory[i].callDuration * price;
            }

            return priceSum;
        }

        //Method that prints the CallHistori information
        public string CallHistToStr()
        {
            StringBuilder callsInHist = new StringBuilder();
            for (int i = 0; i < callHistory.Count; i++)
            {
                callsInHist.AppendLine(callHistory[i].ToString());
            }
            return callsInHist.ToString();
        }
    }
}
