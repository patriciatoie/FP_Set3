using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP_SETIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            P1();
            P2();
            P3();
            P4();
            P5();
            P6();
            P7();
            P8();
            P9();
            P10();
            P11();
            P12();
            P13();
            P14();
            P15();
            P16();
            P17();
            P18();
            P19();
            P20();
            P21();
            P22();
            P23();
            P24();
            P25();
        }
        private static void P1()
        {
            //Calculati suma elementelor unui vector de n numere
            //citite de la tastatura. Rezultatul se va afisa pe ecran.

            int n, i, s;
            s = 0;
            Console.WriteLine("Cate elemente are vectorul?");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (i = 0; i <= n - 1; i++)
            {
                Console.WriteLine($"Introduceti al {i}-lea element al vectorului", i);
                v[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i <= n - 1; i++)
                Console.WriteLine($"v[{i}] = {v[i]}");
            for (i = 0; i <= n - 1; i++)
                s = s + v[i];
            Console.WriteLine($"Suma elementelor vectorului cu n numere introduse de la tastatura este {s}");
        }

        private static void P2()
        {
            //2.Se da un vector cu n elemente si o valoare k. Se cere sa se determine
            //prima pozitie din vector pe care apare k. Daca k nu apare in vector
            //rezultatul va fi -1. 

            string[] t = Console.ReadLine().Split(' ');
            int n = int.Parse(t[0]);
            Console.WriteLine("Introduceti numarul k");
            int k = int.Parse(t[1]);
            t = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(t[i]);
            bool ok = false;
            for (int i = 0; i < n; i++)
            {
                if (v[i] == k)
                {
                    Console.WriteLine(i);
                    ok = true;
                    break;
                }
            }
            if (!ok)
                Console.WriteLine("-1");
        }

        private static void P3()
        {
            //Sa se determine pozitiile dintr-un vector pe care apar cel mai mic
            //si cel mai mare element al vectorului. Pentru extra-credit realizati
            //programul efectuand 3n/2 comparatii (in cel mai rau caz). 

            int n;
            Console.WriteLine("Cate elemente are vectorul?");
            n = int.Parse(Console.ReadLine());
            int min, max, i, j;
            int[] v = new int[100];
            min = max = v[0];

            for (i = 0; i <= n - 1; i++)
            {
                Console.WriteLine($"Introduceti al {i}-lea element al vectorului", i);
                v[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i <= n - 1; i++)
                Console.WriteLine($"v[{i}] = {v[i]}");
            for (i = 0; i <= n - 1; i++)
            {
                min = max = v[0];
                if (min > v[i])
                    min = v[i];

                if (max < v[i])
                    max = v[i];
            }
            Console.WriteLine($"Minimul este {min}");
            Console.WriteLine($"Maximul este {max}");
            if (min == v[i])
                Console.WriteLine($"Pozitia pe care se afla minimul este {i}");
            if (max == v[i])
                Console.WriteLine($"Pozitia pe care se afla maximul este {i}");
        }

        private static void P4()
        {
            //Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare
            //valoare dintr-un vector si de cate ori apar acestea. 

            int n;
            Console.WriteLine("Cate elemente are vectorul?");
            n = int.Parse(Console.ReadLine());
            int min, max, i, cmin, cmax;
            int[] v = new int[n];

            for (i = 0; i <= n - 1; i++)
            {
                Console.WriteLine($"Introduceti al {i}-lea element al vectorului", i);
                v[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i <= n - 1; i++)
                Console.WriteLine($"v[{i}] = {v[i]}");
            min = max = v[0];
            cmin = cmax = 0;
            for (i = 0; i <= n - 1; i++)
            {
                if (v[i] < min)
                    min = v[i];
                if (min == v[i])
                    cmin++;
                if (v[i] > max)
                    max = v[i];
                if (max == v[i])
                    cmax++;
            }
            Console.WriteLine($"Minimul este {min} si apare de {cmin} -ori");
            Console.WriteLine($"Maximul este {max} si apare de {cmax} -ori");
        }

        private static void P5()
        {
            //Se da un vector cu n elemente, o valoare e si o pozitie din vector k.
            //Se cere sa se insereze valoarea e in vector pe pozitia k. Primul
            //element al vectorului se considera pe pozitia zero. 

            Console.WriteLine("n,e,k,vector");
            int n = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] A = new int[n + 1];
            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
            for (int i = n - 1; i > k - 1; i--)
                A[i + 1] = A[i];
            n = n + 1;
            A[k] = e;
            for (int i = 0; i < n; i++)
                Console.WriteLine($"{A[i]} ");
        }

        private static void P6()
        {
            //Se da un vector cu n elemente si o pozitie din vector k.
            //Se cere sa se stearga din vector elementul de pe pozitia k.
            //Prin stergerea unui element, toate elementele din dreapta
            //lui se muta cu o pozitie spre stanga.

            Console.Write("Introduceti lungimea vectorului: ");
            int i;
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (i = 0; i <= n - 1; i++)
            {
                Console.WriteLine($"Introduceti al {i}-lea element al vectorului", i);
                v[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i <= n - 1; i++)
                Console.WriteLine($"v[{i}] = {v[i]}");
            Console.Write("Introduceti numarul k: ");
            int k = int.Parse(Console.ReadLine());
            if (k < 0 || k >= n)
            {
                Console.WriteLine("k trebuie se fie pozitiv si mai mic decat " + n);
                return;
            }
            for (i = k; i < n - 1; i++)
                v[i] = v[i + 1];
            n--;
            for (i = k; i < n - 1; i++)
                Console.WriteLine(v[i] + " ");
        }

        private static void P7()
        {
            //Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea
            //elementelor din vector. Prin inversare se intelege ca primul element
            //devine ultimul, al doilea devine penultimul etc.

            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(t[i]);
            int aux = 0;
            int a = 1;
            for (int i = 0; i < n / 2; i++)
            {
                aux = v[i];
                v[i] = v[n - a];
                v[n - a] = aux;
                a++;
            }
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
        }

        private static void P8()
        {
            // Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu
            // o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul,
            // al doilea devine primul etc. 

            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(t[i]);
            int aux = v[0];
            for (int i = 0; i < n - 1; i++)
                v[i] = v[i + 1];
            v[n - 1] = aux;
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
        }

        private static void P9()
        {
            //Rotire k. Se da un vector cu n elemente.
            //Rotiti elementele vectorului cu k pozitii spre stanga. 

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(t[i]);
            for (int j = 1; j <= k; j++)
            {
                int aux = v[0];
                for (int i = 0; i < n - 1; i++)
                    v[i] = v[i + 1];
                v[n - 1] = aux;
            }
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
        }

        private static void P10()
        {
            //Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare.
            //Se cere sa se determine pozitia unui element dat k. Daca elementul
            //nu se gaseste in vector rezultatul va fi -1.

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(t[i]);
            int left = 0;
            int right = n - 1;
            int sol = -1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (v[mid] == k)
                {
                    sol = mid;
                    break;
                }
                if (v[mid] > k)
                { right = mid - 1; }
                if (v[mid] < k)
                { left = mid + 1; }
            }
            Console.WriteLine(sol);
            Console.ReadKey();
        }

        private static void P11()
        {
            //Se da un numar natural n. Se cere sa se afiseze toate
            //numerele prime mai mici sau egale cu n (ciurul lui Eratostene). 

            int n = int.Parse(Console.ReadLine());
            bool[] v = new bool[n];
            int idx = 2;
            Console.Write(idx + " ");
            do
            {
                int k = 1;
                while (idx * k < n)
                {
                    v[idx * k] = true;
                    k++;
                }
                while (v[idx])
                    idx++;
                Console.Write(idx + " ");
            }
            while (idx < n - 1);
            Console.WriteLine(idx);
        }

        private static void P12()
        {
            // Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. 

            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(t[i]);
            int aux;
            for (int step = 0; step < n - 1; step++)
            {
                int minim = step;
                for (int i = step + 1; i < n; i++)
                {
                    if (v[i] < v[minim])
                        minim = i;
                }
                aux = v[minim];
                v[minim] = v[step];
                v[step] = aux;
            }
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
        }

        private static void P13()
        {
            //Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>. 

            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(t[i]);
            int j, key;
            for (int i = 1; i < n; i++)
            {
                key = v[i];
                j = i - 1;
                while (j >= 0 && v[j] > key)
                {
                    v[j + 1] = v[j];
                    j--;
                }
                v[j + 1] = key;
            }
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
        }

        private static void P14()
        {
            //Interschimbati elementele unui vector in asa fel incat la final
            //toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor
            //folosi vectori suplimentari - operatia se va realiza inplace
            //cu un algoritm eficient - se va face o singura parcugere a
            //vectorului). 

            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(t[i]);
            int left = 0;
            int right = n - 1;
            while (left <= right)
            {
                if (v[left] == 0)
                {
                    int aux = v[right];
                    v[right] = v[left];
                    v[left] = aux;
                    right--;
                }
                else
                    left++;
            }
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
        }

        private static void P15()
        {
            // Modificati un vector prin eliminarea elementelor care
            // se repeta, fara a folosi un alt vector. 

            int n = int.Parse(Console.ReadLine());

            int[] v = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(t[i]);
            int k = n - 1;
            for (int i = 1; i < k; i++)
            {
                bool ok = false;
                for (int j = 0; j < i; j++)
                    if (v[i] == v[j])
                    {
                        ok = true;
                        break;
                    }
                if (ok)
                {
                    int aux = v[i];
                    v[i] = v[k];
                    v[k] = aux;
                    k--;
                    i--;
                }
            }
            for (int i = 0; i < k; i++)
                Console.Write(v[i] + " ");
        }

        private static void P16()
        {
            //Se da un vector de n numere naturale. Determinati
            //cel mai mare divizor comun al elementelor vectorului.

            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(t[i]);
            int d = v[0];
            int r;
            for (int i = 1; i < n; i++)
            {
                r = d % v[i];
                while (r > 0)
                {
                    d = v[i];
                    v[i] = r;
                    r = d % v[i];
                }
                d = v[i];
            }
            Console.WriteLine(d);
        }

        private static void P17()
        {
            //Se da un numar n in baza 10 si un numar b. 1 < b < 17.
            //Sa se converteasca si sa se afiseze numarul n in baza b.   

            Console.Write("Introduceti numarul n in baza 10: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti baza de convertire: ");
            int baza = int.Parse(Console.ReadLine());
            List<int> LI = new List<int>();
            StringBuilder final = new StringBuilder();
            if (n == 0) LI.Add(0);
            while (n != 0)
            {
                LI.Add(n % baza);
                n /= baza;
            }
            for (int i = LI.Count - 1; i >= 0; i--)
            {
                switch (LI[i])
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        final.Append(LI[i]); break;
                    case 10: final.Append('A'); break;
                    case 11: final.Append('B'); break;
                    case 12: final.Append('C'); break;
                    case 13: final.Append('D'); break;
                    case 14: final.Append('E'); break;
                    case 15: final.Append('F'); break;
                }
            }
            Console.WriteLine(final.ToString());
        }
        private static void P18()
        {
            //Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector.
            //Cel mai putin semnificativ coeficient este pe pozitia zero in vector.
            //Se cere valoarea polinomului intr-un punct x. 

            Console.Write("Introduceti gradul polinomului: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti coeficientii polinomului: ");
            int[] v = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(t[i]);
            Console.Write("Introduceti valoarea punctului: ");
            int x = int.Parse(Console.ReadLine());
            int s = 0;
            StringBuilder str = new StringBuilder();
            for (int i = n - 1; i >= 0; i--)
            {
                str.Append($"{v[i]}*{x}^{i + 1}+ ");
                s += (int)(Math.Pow(x, i + 1)) * v[i];
            }
            str.Remove(str.Length - 2, 2);
            Console.WriteLine($"Valoarea polinomului {str} este {s}");
        }
        private static void P19()
        {

        }

        private static void P20()
        {

        }

        private static void P21()
        {
            //Se dau doi vectori. Se cere sa se determine ordinea
            //lor lexicografica (care ar trebui sa apara primul in dictionar). 

            Console.WriteLine("Introduceti primul vector ");
            string[] v1 = Console.ReadLine().Split(' ');
            Console.WriteLine("Introduceti al doilea vector ");
            string[] v2 = Console.ReadLine().Split(' ');
            string s1 = string.Join("", v1);
            string s2 = string.Join("", v2);
            if (s1 == s2) Console.WriteLine("Sunt egal lexicografic");
            else
                if (s1.CompareTo(s2) < 0) Console.WriteLine("Primul sir precede pe al doilea.");
            else
                Console.WriteLine("Al doilea sir il precede pe primul.");
        }

        private static void P22()
        {

        }

        private static void P23()
        {

        }
        private static void P24()
        {

        }
        private static void P25()
        {
            // (Interclasare)Se dau doi vector sortati crescator v1 si v2. Construiti
            // un al treilea vector ordonat crescator format din toate elementele din
            // v1 si v2.Sunt permise elemente duplicate.

            string[] t1 = Console.ReadLine().Split(' ');
            int[] v1 = new int[t1.Length];
            for (int i = 0; i < t1.Length; i++)
                v1[i] = int.Parse(t1[i]);
            string[] t2 = Console.ReadLine().Split(' ');
            int[] v2 = new int[t2.Length];
            for (int i = 0; i < t2.Length; i++)
                v2[i] = int.Parse(t2[i]);
            int[] F = new int[t1.Length + t2.Length];
            int f = 0;

            for (int i = 0; i < t1.Length; i++)
            {
                F[f++] = v1[i];
            }
            for (int i = 0; i < t2.Length; i++)
            {
                F[f++] = v2[i];
            }
            int key, j;
            for (int i = 1; i < t1.Length + t2.Length; i++)
            {
                key = F[i];
                j = i - 1;
                while (j >= 0 && F[j] > key)
                {
                    F[j + 1] = F[j];
                    j--;
                }
                F[j + 1] = key;
            }
            for (int i = 0; i < t1.Length + t2.Length; i++)
                Console.Write(F[i] + " ");
        }

        private static int[] QuickSort(int[] v, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = v[left];
            while (i <= j)
            {
                while (v[i] < pivot)
                {
                    i++;
                }

                while (v[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = v[i];
                    v[i] = v[j];
                    v[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                QuickSort(v, left, j);
            if (i < right)
                QuickSort(v, i, right);
            return v;
        }
    }
}

