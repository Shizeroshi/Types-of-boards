using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Cs_homework
{
    class Interiactive : Doska
    {
        public Message Info;
        public Message Error;

        bool marker = false;
        bool Sponge = false;
        bool turnon = false;

        public void TurnonDoska()
        {
            if (turnon == false)
            {
                turnon = true;
                Info?.Invoke(message: "Вы включили доску");
            }
            else Error?.Invoke(message: "Доска уже включена");
        }

        public void TurnofDoska()
        {
            if (turnon == true)
            {
                turnon = false;
                Info?.Invoke(message: "Вы выключили доску");
            }
            else Error?.Invoke(message: "Доска уже выключена");
        }

        public void takeSponge()
        {
            if (Sponge == false)
            {
                Sponge = true;
                Info?.Invoke(message: "Вы взяли губку");
            }
            else Error?.Invoke(message: "У вас уже есть губка");
        }

        public void takemarker()
        {
            if (marker == false)
            {
                marker = true;
                Info?.Invoke(message: "Вы взяли маркер");
            }
            else Error?.Invoke(message: "У вас уже есть маркер");
        }

        public void draw()
        {
            if (marker == true)
            {
                Info?.Invoke(message: "Вы начертили что-то на доске");
            }
            else Error?.Invoke(message: "У вас нет маркера :(");
        }

        public void Click()
        {
            if (turnon == true)
            {
                Info?.Invoke("Вы кликнули куда-то");
            }
            else Error?.Invoke(message: "Нужно включить доску");
        }

        public void Clean()
        {
            if (Sponge == true)
            {
                for (int i = 0; i < 101; ++i)
                {
                    Console.Write("\rЧистим доску:" + "" + i);
                    Thread.Sleep(50);

                    if (i == 100)
                    {
                        Info?.Invoke(message: "\nДоска вычищена");
                    }
                }
            }
            else Error?.Invoke(message: "Надо взять губку");
        }
    }
}
