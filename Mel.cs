using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Cs_homework
{
    class Mel : Doska
    {
        public Message Info;
        public Message Error;

        bool mel = false;
        bool wetRag = false;
        bool rag = false;

        public void takeRag()
        {
            if(rag == false)
            {
                rag = true;
                Info?.Invoke(message: "Вы взяли тряпку");
            }
            else Error?.Invoke(message: "У вас уже есть тряпка");
        }

        public void takemel()
        {
                if (mel == false)
                {
                    mel = true;
                    Info?.Invoke(message: "Вы взяли мел");
                }
                else Error?.Invoke(message: "У вас уже есть мел");
        }

        public void draw()
        {
            if (mel == true)
            {
                Info?.Invoke(message: "Вы начертили что-то на доске");
            }
            else Error?.Invoke(message: "У вас нет мела :(");
        }

        public void wetaRag()
        {
            if (rag == true)
            {
                if (wetRag == false)
                {
                    for (int i = 0; i < 101; ++i)
                    {
                        Console.Write("\rМочим тряпку:" + "" + i);
                        Thread.Sleep(50);

                        if (i == 100)
                        {
                            wetRag = true;
                            Info?.Invoke(message: "\nТряпка намочена");
                        }
                    }
                }
                else Error?.Invoke(message: "Тряпка уже намочена");
            }
            else Error?.Invoke(message: "У вас нет тряпки");
        }

        public void Clean()
        {
            if (rag == true)
            {
                if (wetRag == true)
                {
                    for (int i = 0; i < 101; ++i)
                    {
                        Console.Write("\rМоем доску:" + "" + i);
                        Thread.Sleep(50);

                        if (i == 100)
                        {
                            Info?.Invoke(message: "\nДоска вымыта");
                        }
                    }
                }
                else Error?.Invoke(message: "Надо намочить тряпку");
            }
            else Error?.Invoke(message: "Надо взять тряпку");
        }
    }
}
