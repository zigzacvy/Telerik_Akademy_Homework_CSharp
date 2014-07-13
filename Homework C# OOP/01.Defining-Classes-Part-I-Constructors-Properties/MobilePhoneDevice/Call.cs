using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    class Call
    {
        //Call information (Task 8.)
        public string callDate { get; set; }
        public TimeSpan callTime { get; set; }
        private string callDailedNum;
        public float callDuration { get; set; }
        public DateTime callDateTime { get; set; }

        public Call(string userDateTime, string userCallNum, float userCallDur)
        {
            this.callDateTime = DateTime.ParseExact(userDateTime, "dd-MM-yyyy HH:mm:ss", new CultureInfo("bg-BG"));
            this.callDate = callDateTime.Date.ToString().Substring(0, callDateTime.Date.ToString().IndexOf(' '));
            this.callTime = callDateTime.TimeOfDay;
            this.CallDailedNum = userCallNum;
            this.callDuration = userCallDur;
        }

        public string CallDailedNum
        {
            get { return this.callDailedNum; }
            set
            {
                if (value.Length == 10) this.callDailedNum = value;
                else throw new ArgumentOutOfRangeException();
            }
        }

        public override string ToString()
        {
            StringBuilder callHistFields = new StringBuilder();
            callHistFields.AppendLine(this.callDate.ToString());
            callHistFields.AppendLine(this.callTime.ToString());
            callHistFields.AppendLine(this.callDailedNum);
            callHistFields.AppendLine(this.callDuration.ToString());

            return callHistFields.ToString();
        }
    }
}
