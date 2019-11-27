using System;

namespace les6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            object o = null;
            try{
                int i = (int)o;  // error 
                
            }catch (NullReferenceException e){
                Console.WriteLine("E: " + e.Message);
            }
            catch(InvalidCastException e){

            }
        }
    }
}
