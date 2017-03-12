using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessClass
{
    public class ChessBoard
    {
        private int line = 0;
        private int column = 0;

        public ChessBoard(int line, int column)
        {
            if (line > 3 && column > 3)
            {
                this.line = line;
                this.column = column;
            }
            else
            {
                Console.WriteLine("Некорректный размер шахматного поля!!");
            }
        }

        public bool isCorrect()
        {
            if (line > 3 && column > 3)
                return true;
            else
                return false;
        }

        public int countOfBlack()
        {
            if (line % 2 == 0)
                return line * column / 2;
            else
                return (line * column / 2) + 1;
        }

        public string Color(int line, int column)
        {
            if ((line + column) % 2 == 0)
                return "чёрный";
            else
                return "белый";
        }

        public bool isSimilar(int l1, int c1, int l2, int c2)
        {
            if ((l1 + c1) % 2 == 0 && (l2 + c2) % 2 == 0)
                return true;
            else if ((l1 + c1) % 2 != 0 && (l2 + c2) % 2 != 0)
                return true;
            return false;
        }

        public bool isUnderAttack(int l1, int c1, int l2, int c2, char figure)
        {//p - пешка    e - слон    l - ладья   f - ферзь   h - конь
            bool f = false;
            int lt = l2;
            int ct = c2;
            switch (figure)
            {
                case 'p':
                    if ((l1 == l2 - 1 && c1 == c2 - 1) || (l1 == l2 - 1 && c1 == c2 + 1))
                        return true;
                    else
                        return false;

                case 'e':
                    if (l1 == l2 || c1 == c2)
                        return true;
                    else
                        return false;

                case 'l':
                    while (f == false && lt >= 1 && ct <= 1)
                    {
                        lt--;
                        ct--;
                        if (l1 == lt && c1 == ct)
                            return true;
                    }
                    lt = l2;
                    ct = c2;
                    while (f == false && lt <= line && ct <= column)
                    {
                        lt++;
                        ct++;
                        if (l1 == lt && c1 == ct)
                            return true;
                    }
                    lt = l2;
                    ct = c2;
                    while (f == false && lt <= line && ct >= 1)
                    {
                        lt++;
                        ct--;
                        if (l1 == lt && c1 == ct)
                            return true;
                    }
                    lt = l2;
                    ct = c2;
                    while (f == false && lt >= 1 && ct <= column)
                    {
                        lt--;
                        ct++;
                        if (l1 == lt && c1 == ct)
                            return true;
                    }
                    return false;

                case 'f':
                    while (f == false && lt >= 1 && ct <= 1)
                    {
                        lt--;
                        ct--;
                        if (l1 == lt && c1 == ct)
                            f = true;
                    }
                    lt = l2;
                    ct = c2;
                    while (f == false && lt <= line && ct <= column)
                    {
                        lt++;
                        ct++;
                        if (l1 == lt && c1 == ct)
                            f = true;
                    }
                    lt = l2;
                    ct = c2;
                    while (f == false && lt <= line && ct >= 1)
                    {
                        lt++;
                        ct--;
                        if (l1 == lt && c1 == ct)
                            f = true;
                    }
                    lt = l2;
                    ct = c2;
                    while (f == false && lt >= 1 && ct <= column)
                    {
                        lt--;
                        ct++;
                        if (l1 == lt && c1 == ct)
                            f = true;
                    }
                    if (f == true || (l1 == l2 || c1 == c2))
                        return true;

                    else
                        return false;

                case 'h':
                    if ((l1 == l2 - 1 && c1 == c2 + 2) || (l1 == l2 - 2 && c1 == c2 + 1) || (l1 == l2 - 2 && c1 == c2 - 1) || (l1 == l2 - 1 && c1 == c2 - 2) || (l1 == l2 + 1 && c1 == c2 + 2) || (l1 == l2 + 2 && c1 == c2 + 1) || (l1 == l2 + 2 && c1 == c2 - 1) || (l1 == l2 + 2 && c1 == c2 - 2))
                        return true;
                    else
                        return false;

                default:
                    Console.WriteLine("Ошибка выбора фигуры");
                    return false;
            }

        }
    }
}
