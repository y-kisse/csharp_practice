using System;

namespace csharp_sample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // 各クラスのコンストラクタを呼ぶだけ
            Person person = new Person();
            Console.WriteLine(person.name);
        }
    }
}
