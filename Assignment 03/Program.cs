namespace Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            #region Part 01 

            #region Q1
            //a)Composition
            //b)Association
            //c)Inheritance
            //d)Aggregation
            //e)Dependency
            #endregion

            #region Q2
            //a)protected field Can be accessable in a child class in a different assembly but outside the class will be accessable as privete
            //b)protected internal:member accessible with the same assembly(accessible in its class and this class assembly)
            //  private protected:member accessible wthin the same class(accessible in its class only)
            //c)sealed when applied to a class:prevent inhertence from this class(this class can not be a parent class for any class else)
            //  sealed when applied to a method: prevent futher overriding on this method
            //d)yes you can create an object from a sealed class using new() ,but you cant inheret from it 
            #endregion

            #endregion

            #region Part 02 
            Cinema c1 = new Cinema("stars cinema");
            c1.OpenCinema();
            StandardTicket t1 = new StandardTicket("mission imposible", 450, new seat_location('A', 8));
            IMAXTicket t2 = new IMAXTicket("hoom alone", 89, new seat_location('B', 9), true);
            VIPTicket t3 =new VIPTicket("avengers",800, new seat_location('C', 5), false);
            c1.AddTicket(t1);
            c1.AddTicket(t2);   
            c1.AddTicket(t3);
            c1.PrintAllTickets();
            c1.CloseCinema();
            #endregion
        }
    }
}
