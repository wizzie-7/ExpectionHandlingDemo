using System;

namespace ExpectionHandlingDemo
{
    class DemoExceptionHandling
    {
        static void Main(string[] args)
        {
            CreatExcpnProg CEP = new CreatExcpnProg();
            CEP.NullArrayException();
        }
    }
    public class CreatExcpnProg
    {
        //int result, num1; num2;
        public void NullArrayException()
        {
            try
            {
                int[] NullArray = null;
                //int[] NullArray = new int[3] {}
                for(int i=0;i<= NullArray.Length; i++)
                {

                }
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine("Exception Caught: {0}", e);
                Console.WriteLine(e.Message);
            }
            catch(DivideByZeroException d)
            {
                Console.WriteLine("Exception Caught: {0}", d);
            }
            //finally
            //{
            //    Console.WriteLine("Final Block will definetly wil execute even catch block is not there");
            //}
        }
    }
}
