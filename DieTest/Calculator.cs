using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace DieTest
{
    internal class Calculator
    {
        public int Enere(DieCup dC)
        {
            int i = 0;
            foreach (Die d in dC.DieA)
            {
                if (d.Eyes == 1)
                {
                    i++;
                }
            }
            return i;
        }

        public int Toere(DieCup dC)
        {
            int i = 0;
            foreach (Die d in dC.DieA)
            {
                if (d.Eyes == 2)
                {
                    i++;
                }
            }
            return i * 2;
        }

        public int Treere(DieCup dC)
        {
            int i = 0;
            foreach (Die d in dC.DieA)
            {
                if (d.Eyes == 3)
                {
                    i++;
                }
            }
            return i * 3;
        }

        public int Firere(DieCup dC)
        {
            int i = 0;
            foreach (Die d in dC.DieA)
            {
                if (d.Eyes == 4)
                {
                    i++;
                }
            }
            return i * 4;
        }

        public int Femmere(DieCup dC)
        {
            int i = 0;
            foreach (Die d in dC.DieA)
            {
                if (d.Eyes == 5)
                {
                    i++;
                }
            }
            return i * 5;
        }

        public int Seksere(DieCup dC)
        {
            int i = 0;
            foreach (Die d in dC.DieA)
            {
                if (d.Eyes == 6)
                {
                    i++;
                }
            }
            return i * 6;
        }

        public int EtPar(DieCup dC)
        {
            int enere = 0;
            int toere = 0;
            int treere = 0;
            int firere = 0;
            int femmere = 0;
            int seksere = 0;
            int score1 = 0;
            int score2 = 0;
            int score3 = 0;
            int score4 = 0;
            int score5 = 0;
            foreach (Die d in dC.DieA)
            {
                if (d.Eyes == 1)
                {
                    enere++;
                    if (enere > 1)
                    {
                        score1 = 2;
                    }
                }
                if (d.Eyes == 2)
                {
                    toere++;
                    if (toere > 1)
                    {
                        score2 = 4;
                    }
                }
                if (d.Eyes == 3)
                {
                    treere++;
                    if (treere > 1)
                    {
                        score3 = 6;
                    }
                }
                if (d.Eyes == 4)
                {
                    firere++;
                    if (firere > 1)
                    {
                        score4 = 8;
                    }
                }
                if (d.Eyes == 5)
                {
                    femmere++;
                    if (femmere > 1)
                    {
                        score5 = 10;
                    }
                }
                if (d.Eyes == 6)
                {
                    seksere++;
                    if (seksere > 1)
                    {
                        return 12;
                    }
                }
            }
            if (score5 != 0) { return score5; }
            else if (score4 != 0) { return score4; }
            else if (score3 != 0) { return score3; }
            else if (score2 != 0) { return score2; }
            else if (score1 != 0) { return score1; }
            else { return 0; }
        }

        public int ToPar(DieCup dC)
        {
            int enere = 0;
            int toere = 0;
            int treere = 0;
            int firere = 0;
            int femmere = 0;
            int seksere = 0;
            int score1 = 0;
            int score2 = 0;
            int score3 = 0;
            int score4 = 0;
            int score5 = 0;
            int score6 = 0;
            int score = 0;
            foreach (Die d in dC.DieA)
            {
                if (d.Eyes == 1)
                {
                    enere++;
                    if (enere > 1)
                    {
                        score1 = 2;
                    }
                }
                if (d.Eyes == 2)
                {
                    toere++;
                    if (toere > 1)
                    {
                        score2 = 4;
                    }
                }
                if (d.Eyes == 3)
                {
                    treere++;
                    if (treere > 1)
                    {
                        score3 = 6;
                    }
                }
                if (d.Eyes == 4)
                {
                    firere++;
                    if (firere > 1)
                    {
                        score4 = 8;
                    }
                }
                if (d.Eyes == 5)
                {
                    femmere++;
                    if (femmere > 1)
                    {
                        score5 = 10;
                    }
                }
                if (d.Eyes == 6)
                {
                    seksere++;
                    if (seksere > 1)
                    {
                        score6 = 12;
                    }
                }
            }
            if (score6 != 0)
            {
                score = score6;
            }
            if (score5 != 0)
            {
                if (score != 0)
                {
                    return score + score5;
                }
                else
                {
                    score = score5;
                }
            }
            if (score4 != 0)
            {
                if (score != 0)
                {
                    return score + score4;
                }
                else
                {
                    score = score4;
                }
            }
            if (score3 != 0)
            {
                if (score != 0)
                {
                    return score + score3;
                }
                else
                {
                    score = score3;
                }
            }
            if (score2 != 0)
            {
                if (score != 0)
                {
                    return score + score2;
                }
                else
                {
                    score = score2;
                }
            }
            if (score1 != 0)
            {
                if (score != 0)
                {
                    return score + score1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        public int TreEns(DieCup dC)
        {
            int enere = 0;
            int toere = 0;
            int treere = 0;
            int firere = 0;
            int femmere = 0;
            int seksere = 0;
            foreach (Die d in dC.DieA)
            {
                if (d.Eyes == 1)
                {
                    enere++;
                    if (enere > 2)
                    {
                        return enere;
                    }
                }
                if (d.Eyes == 2)
                {
                    toere++;
                    if (toere > 2)
                    {
                        return toere * 2;
                    }
                }
                if (d.Eyes == 3)
                {
                    treere++;
                    if (treere > 2)
                    {
                        return treere * 3;
                    }
                }
                if (d.Eyes == 4)
                {
                    firere++;
                    if (firere > 2)
                    {
                        return firere * 4;
                    }
                }
                if (d.Eyes == 5)
                {
                    femmere++;
                    if (femmere > 2)
                    {
                        return femmere * 5;
                    }
                }
                if (d.Eyes == 6)
                {
                    seksere++;
                    if (seksere > 2)
                    {
                        return seksere * 6;
                    }
                }
            }
            return 0;
        }

        public int FireEns(DieCup dC)
        {
            int enere = 0;
            int toere = 0;
            int treere = 0;
            int firere = 0;
            int femmere = 0;
            int seksere = 0;
            foreach (Die d in dC.DieA)
            {
                if (d.Eyes == 1)
                {
                    enere++;
                    if (enere > 3)
                    {
                        return enere;
                    }
                }
                if (d.Eyes == 2)
                {
                    toere++;
                    if (toere > 3)
                    {
                        return toere * 2;
                    }
                }
                if (d.Eyes == 3)
                {
                    treere++;
                    if (treere > 3)
                    {
                        return treere * 3;
                    }
                }
                if (d.Eyes == 4)
                {
                    firere++;
                    if (firere > 3)
                    {
                        return firere * 4;
                    }
                }
                if (d.Eyes == 5)
                {
                    femmere++;
                    if (femmere > 3)
                    {
                        return femmere * 5;
                    }
                }
                if (d.Eyes == 6)
                {
                    seksere++;
                    if (seksere > 3)
                    {
                        return seksere * 6;
                    }
                }
            }
            return 0;
        }

        public int LilleStraight(DieCup dC)
        {
            int enere = 0;
            int toere = 0;
            int treere = 0;
            int firere = 0;
            int femmere = 0;
            int seksere = 0;
            int score = 0;
            foreach (Die d in dC.DieA)
            {
                if (d.Eyes == 1)
                {
                    enere++;
                }
                if (d.Eyes == 2)
                {
                    toere++;
                }
                if (d.Eyes == 3)
                {
                    treere++;
                }
                if (d.Eyes == 4)
                {
                    firere++;
                }
                if (d.Eyes == 5)
                {
                    femmere++;
                }
            }
            if (enere != 0 && toere != 0 && treere != 0 && firere != 0 && femmere != 0)
            {
                return 15;
            }
            return 0;
        }

        public int StorStraight(DieCup dC)
        {
            int enere = 0;
            int toere = 0;
            int treere = 0;
            int firere = 0;
            int femmere = 0;
            int seksere = 0;
            int score = 0;
            foreach (Die d in dC.DieA)
            {
                if (d.Eyes == 1)
                {
                    enere++;
                }
                if (d.Eyes == 2)
                {
                    toere++;
                }
                if (d.Eyes == 3)
                {
                    treere++;
                }
                if (d.Eyes == 4)
                {
                    firere++;
                }
                if (d.Eyes == 5)
                {
                    femmere++;
                }
                if (d.Eyes == 6)
                {
                    seksere++;
                }
            }
            if (toere != 0 && treere != 0 && firere != 0 && femmere != 0 && seksere != 0)
            {
                return 20;
            }
            return 0;
        }

        public int Chancen(DieCup dC)
        {
            int i = 0;
            foreach (Die d in dC.DieA)
            {
                i = i + d.Eyes;
            }
            return i;
        }

        public int Yatzy(DieCup dC)
        {
            int i = dC.DieA[0].Eyes;
            foreach (Die d in dC.DieA)
            {
                if (d.Eyes != i)
                {
                    return 0;
                }
            }
            return 50;
        }
    }
}
