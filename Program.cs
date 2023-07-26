namespace Contuctor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            obj.detail();
            Class1 obj1  = new Class1(070,"Noman");
            obj1.detail();
            Class1 obj2 = new Class1(555,"Ali",'B');
            obj1.detail();

        }
    }
}