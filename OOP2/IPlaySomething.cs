using System;

namespace OOP2
{
    //Task2
    internal partial class Program
    {
        interface IPlaySomething
        {
            void Play();
        }
        class Mp3 : IPlaySomething
        {
            public void Play()
            {
                Console.WriteLine("Play Mp3");
            }
        }
        class WAV : IPlaySomething
        {
            public void Play()
            {
                Console.WriteLine("Play WAV");
            }
        }
        class OGG : IPlaySomething
        {
            public void Play()
            {
                Console.WriteLine("PLay OGG");
            }
        }

    }
}
