using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            // Устанавливаем для сокета локальную конечную точку
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);

            // Создаем сокет Tcp/Ip
            Socket sListener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            // Назначаем сокет локальной конечной точке и слушаем входящие сокеты
            try
            {
                sListener.Bind(ipEndPoint);
                sListener.Listen(10);

                // Начинаем слушать соединения
                while (true)
                {
                    Console.WriteLine("Ожидаем соединение через порт ", ipEndPoint);
                    // Программа приостанавливается, ожидая входящее соединение
                    Socket handler = sListener.Accept();
                    string data = null;

                    // Мы дождались клиента, пытающегося с нами соединиться

                    byte[] bytes = new byte[1024];
                    int bytesRec = handler.Receive(bytes);

                    data += Encoding.UTF8.GetString(bytes, 0, bytesRec);

                    // Показываем данные на консоли
                    Console.Write("Полученный текст: " + data + "\n\n");

                    void Mon()
                    {
                        Console.WriteLine("Понедельник");
                        string reply = "Понедельник\n 8:00 Литературное чтение \n 8:50 Русский язык \n 9:45 Динамическая пауза \n10:50 Технология ";
                        byte[] msg = Encoding.UTF8.GetBytes(reply);
                        handler.Send(msg);
                    }
                    void Tue()
                    {
                        Console.WriteLine("Вторник ");
                        string reply = "Вторник\n 8:00 ИЗО \n 8:50 Русский язык \n 9:45 Динамическая пауза \n10:50 Математика ";
                        byte[] msg = Encoding.UTF8.GetBytes(reply);
                        handler.Send(msg);
                    }
                    void Wed()
                    {
                        Console.WriteLine("Среда ");
                        string reply = "Среда\n 8:00 Литературное чтение \n 8:50 Русский язык \n 9:45 Динамическая пауза \n10:50 Математика ";
                        byte[] msg = Encoding.UTF8.GetBytes(reply);
                        handler.Send(msg);
                    }
                    void Th()
                    {
                        Console.WriteLine("Четверг ");
                        string reply = " Четверг\n 8:00 Окружающий мир \n 8:50 Русский язык \n 9:45 Динамическая пауза \n10:50 Математика ";
                        byte[] msg = Encoding.UTF8.GetBytes(reply);
                        handler.Send(msg);
                    }
                    void Fr()
                    {
                        Console.WriteLine("Пятница ");
                        string reply = "Пятница\n 8:00 Музыка \n 8:50 Физ. культура \n 9:45 Динамическая пауза \n10:50 Технология ";
                        byte[] msg = Encoding.UTF8.GetBytes(reply);
                        handler.Send(msg);
                    }
                   

                    switch (data)
                    {
                        case "Понедельник":
                            Mon();
                            break;
                        case "Вторник":
                            Tue();
                            break;
                        case "Среда":
                            Wed();
                            break;
                        case "Четверг":
                            Th();
                            break;
                        case "Пятница":
                            Fr();
                            break;
                    }


                    // Отправляем ответ клиенту\
                    

                    if (data.IndexOf("<TheEnd>") > -1)
                    {
                        Console.WriteLine("Сервер завершил соединение с клиентом.");
                        break;
                    }

                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
