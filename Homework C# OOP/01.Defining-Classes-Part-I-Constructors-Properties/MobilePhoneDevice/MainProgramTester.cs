using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    class MainProgramTester
    {
        //This Main method is for testing purposes only! Taks other task 8. are tested in this method!
        static void Main(string[] args)
        {
            //Testing data:
            //GSM properties
            string inputModel = "K530i";
            string inputManuf = "SonyEricsson";
            float inputPrice = 200;
            string inputOwner = "Pesho";
            //Battery properties
            battModel inputBatModel = battModel.NiCd;
            uint inputHoursIdle = 100;
            uint inputHoursTalk = 10;
            //Display properties
            uint inputSizeW = 5;
            uint inputSizeH = 15;
            uint inputNumOfCol = 2000000;

            //Creating and initialising objects
            Battery inputBattery = new Battery(inputBatModel, inputHoursIdle, inputHoursTalk);
            Display inputDisplay = new Display(inputSizeH, inputSizeW, inputNumOfCol);
            GSM inputGSM = new GSM(inputModel, inputManuf, inputPrice, inputOwner, inputBattery, inputDisplay);

            //Method that displays the information about the static class (Task 7.)
            GSM staticPhone = new GSM();
            string iPhoneInfo = staticPhone.IPhone.PrintIPhoneInfo();

            //Test output without format
            string inputInfo = inputGSM.ToString();
            Console.WriteLine("Test output for GSM:\n{0}", inputInfo);
            Console.WriteLine("iPhone info:\n{0}", iPhoneInfo);

            //Call information test input (Task 8.)
            string inputCallDate = "03-09-2013";
            string inputCallTime = "17:00:00";
            string inputCallNum = "0888888888";
            float inputCallDur = 240;
            string inputDateTime = inputCallDate + " " + inputCallTime;

            Call inputCallInfo = new Call(inputDateTime, inputCallNum, inputCallDur);

            //Test for the CallHistory property (Task 9.) (Task 12.)
            GSM inputCallHistory = new GSM(inputModel, inputManuf, inputPrice, inputOwner, inputBattery, inputDisplay);
            inputCallHistory.InsertCallInHist(new Call(inputDateTime, inputCallNum, inputCallDur));
            inputCallHistory.InsertCallInHist(new Call("26-06-2013 23:30:00", "0877766677", 160));
            inputCallHistory.InsertCallInHist(new Call("14-11-2013 05:00:00", "0877777777", 60));

            //Test (Task 10.) (Task 12.
            inputCallHistory.DeleteCallFromHist(1); //Remove one call
            //inputCallHistory.ClearAllCallHist(); //Clear all calls from the history

            //Test (Task 11.) (Task 12.)
            float inputPricePM = 0.37f;
            float outputPriceSum = inputCallHistory.PriceCalculator(inputPricePM);
            Console.WriteLine("Total Price is {0}.", outputPriceSum);

            //Test (Task 12.)
            string histOutput = inputCallHistory.CallHistToStr();
            Console.WriteLine("Call history:\n{0}", histOutput);
            inputCallHistory.ClearAllCallHist();

            //Finish! :) :) 
        }

        //Tasks 8. runs in this method!
        static void COMMENTEDMain(string[] args)
        {
            //Input data in arrays (Task 7.)
            GSM[] inputDataArray = new GSM[3];
            Battery[] inputBattArray = new Battery[inputDataArray.Length];
            Display[] inputDispArray = new Display[inputDataArray.Length];
            //GSM properties
            string[] inputModelArr = { "K530i", "A60", "C200" };
            string[] inputManufArr = { "SonyEricsson", "Siemens", "NOKIA" };
            float[] inputPriceArr = { 200, 50, 150 };
            string[] inputOwnerArr = { "Pesho", "Gosho", "Tosho" };
            //Battery properties
            battModel[] inputBatModelArr = { battModel.NiCd, battModel.Lilon, battModel.NiMH };
            uint[] inputHoursIdleArr = { 200, 150, 300 };
            uint[] inputHoursTalkArr = { 10, 8, 12 };
            //Display properties
            uint[] inputSizeWArr = { 5, 3, 5 };
            uint[] inputSizeHArr = { 10, 7, 9 };
            uint[] inputNumOfColArr = { 2000000, 100, 2500000 };

            for (int i = 0; i < inputDataArray.Length; i++)
            {
                inputBattArray[i] = new Battery(inputBatModelArr[i], inputHoursIdleArr[i], inputHoursTalkArr[i]);
                inputDispArray[i] = new Display(inputSizeHArr[i], inputSizeWArr[i], inputNumOfColArr[i]);
                inputDataArray[i] = new GSM(inputModelArr[i], inputManufArr[i], inputPriceArr[i], inputOwnerArr[i], inputBattArray[i], inputDispArray[i]);
                Console.WriteLine(inputDataArray[i].ToString());
            }

            //Call information test input (Task 8.)
            string inputCallDate = "03-09-2013";
            string inputCallTime = "17:00:00";
            string inputCallNum = "0888888888";
            float inputCallDur = 240;
            string inputDateTime = inputCallDate + " " + inputCallTime;

            Call inputCallInfo = new Call(inputDateTime, inputCallNum, inputCallDur);
        }
    }
}
