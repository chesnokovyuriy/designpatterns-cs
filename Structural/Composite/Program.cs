﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
        class Program
        {
                static void Main(string[] args)
                {
                        IEquipment fpu = new Processor() { Name = "fpu", Price = 10 };
                        IEquipment cpu = new Processor() { Name = "cpu", Price = 5 };
                        IEquipment video = new Card() { Name = "video", Price = 150 };
                        IEquipment pci = new Card() { Name = "pci", Price = 7 };
                        IEquipment net = new Card() { Name = "net", Price = 20 };

                        IEquipment board = new CompositeEquipment() { Name = "mother board" };

                        board.Add(fpu);
                        board.Add(cpu);
                        board.Add(video);
                        board.Add(pci);
                        board.Add(net);

                        IEquipment cd = new Drive() { Name = "cd", Price = 11 };
                        IEquipment dvd = new Drive() { Name = "dvd", Price = 12 };
                        IEquipment hdd = new Drive() { Name = "hdd", Price = 30 };

                        IEquipment computer = new CompositeEquipment() { Name = "IBM PC computer" };

                        computer.Add(board);
                        computer.Add(cd);
                        computer.Add(dvd);
                        computer.Add(hdd);

                        Console.WriteLine("{0} price = {1}", board.Name, board.Price);
                        Console.WriteLine("{0} price = {1}", computer.Name, computer.Price);
                        Console.WriteLine();

                        computer.Run();
                }
        }
}
