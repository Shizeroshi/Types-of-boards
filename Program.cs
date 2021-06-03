using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Cs_homework
{
    class Program
    {
        static void Main()
        {
            //var meldoska = new Mel();
            //var markdoska = new Marker();
            //var interdoska = new Interiactive();

            Console.WriteLine("На какой доске будем рисовать?");
            Console.WriteLine("1. Меловая");
            Console.WriteLine("2. Маркерная");
            Console.WriteLine("3. Интерактивная");
            int answerDoska = Convert.ToInt32(Console.ReadLine());
            if (answerDoska == 1) Melovaya();
            if (answerDoska == 2) Markernaya();
            if (answerDoska == 3) Interaktivnaya();

        }

        static void Melovaya()
        {
            Mel meldoska = new Mel();
            meldoska.Info = ShowConsoleMel;
            meldoska.Error = ShowConsoleMel;
            meldoska.Height = 1920;
            meldoska.Width = 1080;
            Console.WriteLine("Размер доски " + meldoska.Height + "x" + meldoska.Width);
            Console.WriteLine("Что будем делать?");
            Console.WriteLine("1. Чертить");
            Console.WriteLine("2. Вымыть доску");
            Console.WriteLine("3. Взять мел");
            Console.WriteLine("4. Взять тряпку");
            Console.WriteLine("5. Намочить тряпку");
            Console.WriteLine("6. Выбор доски");
            for (; ; )
            {
                int answerMelovaya = Convert.ToInt32(Console.ReadLine());
                if (answerMelovaya == 1) meldoska.draw();
                if (answerMelovaya == 2) meldoska.Clean();
                if (answerMelovaya == 3) meldoska.takemel();
                if (answerMelovaya == 4) meldoska.takeRag();
                if (answerMelovaya == 5) meldoska.wetaRag();
                if (answerMelovaya == 6) Main();
            }
        }

        static void Markernaya()
        {
            Marker markdoska = new Marker();
            markdoska.Info = ShowConsoleMarker;
            markdoska.Error = ShowConsoleMarker;
            markdoska.Height = 1920;
            markdoska.Width = 1080;
            Console.WriteLine("Размер доски " + markdoska.Height + "x" + markdoska.Width);
            Console.WriteLine("Что будем делать?");
            Console.WriteLine("1. Чертить");
            Console.WriteLine("2. Почистить доску");
            Console.WriteLine("3. Взять маркер");
            Console.WriteLine("4. Взять губку");
            Console.WriteLine("5. Выбор доски");
            for (; ; )
            {
                int answerMelovaya = Convert.ToInt32(Console.ReadLine());
                if (answerMelovaya == 1) markdoska.draw();
                if (answerMelovaya == 2) markdoska.Clean();
                if (answerMelovaya == 3) markdoska.takemarker();
                if (answerMelovaya == 4) markdoska.takeSponge();
                if (answerMelovaya == 5) Main();
            }
        }

        static void Interaktivnaya()
        {
            Interiactive interdoska = new Interiactive();
            interdoska.Info = ShowConsoleInter;
            interdoska.Error = ShowConsoleInter;
            interdoska.Height = 1920;
            interdoska.Width = 1080;
            Console.WriteLine("Размер доски " + interdoska.Height + "x" + interdoska.Width);
            Console.WriteLine("Что будем делать?");
            Console.WriteLine("1. Чертить");
            Console.WriteLine("2. Почистить доску");
            Console.WriteLine("3. Взять маркер");
            Console.WriteLine("4. Взять губку");
            Console.WriteLine("5. Нажать куда-нибудь");
            Console.WriteLine("6. Включить доску");
            Console.WriteLine("7. Выключить доску");
            Console.WriteLine("8. Выбор доски");
            for (; ; )
            {
                int answerMelovaya = Convert.ToInt32(Console.ReadLine());
                if (answerMelovaya == 1) interdoska.draw();
                if (answerMelovaya == 2) interdoska.Clean();
                if (answerMelovaya == 3) interdoska.takemarker();
                if (answerMelovaya == 4) interdoska.takeSponge();
                if (answerMelovaya == 5) interdoska.Click();
                if (answerMelovaya == 6) interdoska.TurnonDoska();
                if (answerMelovaya == 7) interdoska.TurnofDoska();
                if (answerMelovaya == 8) Main();
            }
        }

        static void ShowConsoleMel(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        static void ShowConsoleMarker(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        static void ShowConsoleInter(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}
