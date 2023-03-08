using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        int cardclass = 0;
        int value = 0;
        int cardposition;
        
        

        SortedDictionary<int, int> pack = new SortedDictionary<int, int>(52);

        public Pack()
        {
            for (cardclass < 4; cardclass++)
            {
                for (value < 13; value++)
                {
                    pack.Add(cardclass, value);
                    return;
                }
            }
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            if (typeOfShuffle == 1)
            {
                for (cardposition = -1; cardposition > -53; cardposition--)
                {
                    var random = new Random();
                    int card = random.Next(-1, -53);
                    (pack[cardposition], pack[card]) = (pack[card], pack[cardposition]);
                    return;
                }
            }
            else if (typeOfShuffle == 2)
            {
                p1 = pack[0:25];
                p2 = pack[26:51];
                for (cardposition = 0; cardposition < 52; cardposition++)
                {
                    pack[(cardposition * 2)] = p1[cardposition];
                    pack[(cardposition * 2) + 1] = p2[cardposition];
                        return;
                }
            }
            else if (typeOfShuffle == 3)
            {
                return;
            }
            else
            {
                return false;
            }

        }

        public static Card deal()
        {
            Console.WriteLine(pack[0]);

        }
        public static List<Card> dealCard(int amount)
        {
            Console.WriteLine(pack[0:amount])
        }
    }
}
