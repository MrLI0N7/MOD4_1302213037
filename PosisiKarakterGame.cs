using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD4_1302213037
{
    internal class PosisiKarakterGame
    {
        enum State { Berdiri, Jongkok, Tengkurap, Terbang};

        public void Karakter()
        {
            State state = State.Berdiri;
            string[] screenName = { "Berdiri", "Jongkok", "Tengkurap", "Terbang" };
            
            while(true)
            {
                Console.WriteLine("Posisi Karakter sedang :" + screenName[(int)state]);
                Console.Write("Masukkan Command (S/W/X): ");

                string command = Console.ReadLine();
                switch (state) {
                    case State.Berdiri:
                        if (command == "S")
                        {
                            state = State.Jongkok;
                        }
                        else if (command == "W")
                        {
                            state = State.Terbang;
                        }
                        else
                        {
                            state = State.Berdiri;
                            Console.WriteLine("Posisi Standby");
                            break;
                        }
                        break;
                    case State.Jongkok:
                        if (command == "S")
                        {
                            state = State.Tengkurap;
                            Console.WriteLine("Posisi Istitrahat");
                        }
                        else if (command == "W")
                        {
                            state = State.Berdiri;
                            Console.WriteLine("Posisi Standby");
                        }
                        else
                        {
                            state = State.Jongkok;
                    
                            break;
                        }
                        break;
                    case State.Terbang:
                        if (command == "S")
                        {
                            state = State.Berdiri;
                            Console.WriteLine("Posisi Standby");

                        }
                        else if (command == "X")
                        {
                            state = State.Jongkok;
                        }
                        else
                        {
                            state = State.Terbang;

                            break;
                        }
                        break;
                    case State.Tengkurap:
                        if (command == "W")
                        {
                            state = State.Jongkok;
                            

                        } 
                        else
                        {
                            state = State.Tengkurap;
                            Console.WriteLine("Posisi Istitrahat");
                            break;
                        }
                        break;
                }
                }
            }
            
        }
    }
