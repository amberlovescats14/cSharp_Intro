using System;
namespace first
{

    public class ClassLecture
    {
        private String name;
        public ClassLecture()
        {
        }

        public void sayHello(String name)
        {
            this.name = name;
            Console.WriteLine("hello " + name.ToUpper());
            var secondClass = new SecondClass();
        }

    }
}
