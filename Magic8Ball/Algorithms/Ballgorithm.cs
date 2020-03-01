using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magic8Ball.Algorithms
{
    public class Ballgorithm
    {
        public string Shake(string q)
        {
            Random rand = new Random();
            int luck = rand.Next(1, 16);
            switch (luck)
            {
                case 1:
                    return "Niet vandaag...";
                case 2:
                    return "Misschien ooit.";
                case 3:
                    return "In de nabije toekomst.";
                case 4:
                    return "De toekomst ziet er goed uit.";
                case 5:
                    return "Het zou zo maar eens kunnen.";
                case 6:
                    return "Je weet nooit wat op je pad komt!";
                case 7:
                    return "Wat denk je nu zelf?";
                case 8:
                    return "Ik denk het niet.";
                case 9:
                    return "Probeer eens opnieuw.";
                case 10:
                    return "Ik betwijfel het.";
                case 11:
                    return "Laat me niet lachen.";
                case 12:
                    return "Gegarandeerd!";
                case 13:
                    return "Misschien wel, als ik daar zin in heb.";
                case 14:
                    return "Pfff... Vraag 't me later nog eens.";
                case 15:
                    return "Heb je nu echt niets beters te doen?";
                default:
                    return "";
            }
        }
    }
}
