using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal(); //Создать экземпляр абстрактного класса не возможно
            Wolf wolf = new Wolf();
            wolf.Sound();

            Chihuahua nedosobaka = new Chihuahua();
            nedosobaka.Sound();
        }
    }
}
