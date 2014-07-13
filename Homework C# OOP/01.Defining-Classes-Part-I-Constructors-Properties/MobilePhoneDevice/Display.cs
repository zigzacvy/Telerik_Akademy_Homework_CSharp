using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    class Display
    {
        //Display Fields (Task 1.) //Encapsulation with syntactic sugar (Task 5.)
        public uint sizeHeight { get; set; }
        public uint sizeWidth { get; set; }
        public uint numberOfColors { get; set; }

        //Empty Constructor for all Fields (Task 2.)
        public Display(uint userSizeH = 0, uint userSizeW = 0, uint userNumOfCol = 0)
        {
            this.sizeHeight = userSizeH;
            this.sizeWidth = userSizeW;
            this.numberOfColors = userNumOfCol;
        }

        //Overriding method (task 4.) Not sure if needed!
        public override string ToString()
        {
            StringBuilder displayFields = new StringBuilder();
            displayFields.AppendLine(this.sizeHeight.ToString());
            displayFields.AppendLine(this.sizeWidth.ToString());
            displayFields.AppendLine(this.numberOfColors.ToString());

            return displayFields.ToString();
        }
    }
}
