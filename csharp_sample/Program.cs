using System;

namespace csharp_sample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // 各クラスのコンストラクタを呼ぶだけ
            Console.WriteLine("Start");
            personTest();
            Console.WriteLine("End");

        }

        public static void personTest()
        {
            Person person = new Person();
            Console.WriteLine("hello, " + person.name);
        }
    }
}
