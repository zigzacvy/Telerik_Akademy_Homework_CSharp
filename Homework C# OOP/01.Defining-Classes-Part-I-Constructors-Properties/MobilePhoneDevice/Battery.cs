using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    //Model enumeration (Task 3.)
    public enum battModel
    {
        Lilon,
        NiMH,
        NiCd
    }

    class Battery
    {
        //Model enumeration (Task 3.)
        private battModel model;

        //Battery Fields (Task 1.)
        // private string model = "Model not assigned!";
        private uint hoursIdle;
        private uint hoursTalk;

        //Properties (task 5.)
        public battModel Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public uint HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value > 0) this.hoursIdle = value;
                else throw new ArgumentOutOfRangeException();
            }
        }
        public uint HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value > 0) this.hoursTalk = value;
                else throw new ArgumentOutOfRangeException();
            }
        }

        //Empty Constructor for all Fields (Task 2.)
        public Battery(battModel userModel, uint userHoursIdle = 0, uint userHoursTalk = 0)
        {
            this.Model = userModel;
            this.HoursIdle = userHoursIdle;
            this.HoursTalk = userHoursTalk;
        }

        //Overriding method (task 4.) Not sure if needed!
        public override string ToString()
        {
            StringBuilder batteryFields = new StringBuilder();
            batteryFields.AppendLine(this.model.ToString());
            batteryFields.AppendLine(this.hoursIdle.ToString());
            batteryFields.AppendLine(this.hoursTalk.ToString());

            return batteryFields.ToString();
        }
    }
}
