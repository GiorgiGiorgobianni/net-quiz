using net_quiz_2;
using System;

class Program
{
    static void Main(string[] args)
    {
        #region Task 1
        DataHandler<int> intHandler = new DataHandler<int>();

        intHandler.AddData(2);
        intHandler.AddData(3);
        intHandler.AddData(4);
        intHandler.AddData(5);
            
        intHandler.AddData(6);
        intHandler.AddData(7);

        Console.WriteLine($"Retrieved data at index 3: { intHandler.RetrieveData(3)}");
        #endregion

        #region Task 2
        DeviceController TVController = new DeviceController("TV");

        TVController.Activate();
        #endregion

        #region Task 3
        Vehicle myCar = new Car();
        myCar.StartEngine();
        myCar.Accelerate();

        Vehicle myBike = new Bike();
        myBike.StartEngine();
        myBike.Accelerate();
        #endregion
    }
}
