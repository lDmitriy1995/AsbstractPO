using AsbstractPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        PO[] soft = new PO[]{new Free ("word", "tba"),
                            new Shareware("excel", "microsoft", "12.03.1989", 50, 100),
                            new Shareware("notepad", "net", "05.05.1990", 30, 20),
                            new Commercial("NFS most wonted", "EArts", "27.09.2008", 50, 200, 3650),
                            new Free("paint", "microsoft")};

        Console.WriteLine("~~~~ Весь список ПО:");
        foreach (PO p in soft)
            p.Info();

        Console.WriteLine("~~~~ Список ПО, которое можно использовать на сегодняшний день: ");
        foreach (PO p in soft)
            if (p.ItIsAWorks()) Console.WriteLine(p.ProgramName);

        Console.ReadLine();
    }
}




