using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication59
{
    public class Vehicle
    {
        public string Name;
        class MotorVehicle : Vehicle
        {
            public string modelalName;
        }
        class Car : MotorVehicle
        { }//فارغ
        class truck : MotorVehicle
        { }//فارغ
        class Program
        {//رئيسي
            static void Main(string[] args)
            {
                Car MyCar = new Car();
                MyCar.Name = "MERCEDES";
                MyCar.modelalName = "1996";
                truck MyTruck = new truck();
                MyTruck.Name = "BMW";
                MyTruck.modelalName = "1998";
                Console.WriteLine("My Car name and model is: " +
                MyCar.Name + " and " + MyCar.modelalName);
                Console.WriteLine("My Truck name and model is : " +
                MyTruck.Name + " and " + MyTruck.modelalName);
                Console.ReadKey();
            }
        }
    }
}