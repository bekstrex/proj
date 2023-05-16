using System.Reflection;
using System.Runtime.CompilerServices;

public class WeighingMachine
{
    public WeighingMachine(double precision)
    {
        Precision = precision;
    }

    public double Precision { get; }


    private double weight;
    public double Weight
    {

        get { return weight; }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Your number cant be negative");
            }
            weight = value;
        }
    }

    public int adj;
    
    public int Tareadjustment
    {
        get { return adj; }
        
        set { adj = value+5;  }
    }

    public double Display
    {
        get { return weight - adj; }
        set { Console.WriteLine(value); }
    }
         
   



}
   



        

        //set value negative


    








