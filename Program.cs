/* Matěj Zedník P2B 12. 10. 2023
1. Počet prvků
2. Maximum (ne přes vestavěné funkce)
3. Minimum
4. Součet všech hodnot
5. Součin všech hodnot
6. Aritmetický průměr
7. Geometrický průměr - pozor na to, že je definován pouze pro kladná čísla
8. Medián (k seřazení hodnot použijte funkci Array.Sort())
9. Četnost výskytu všech hodnot (vrátí pole, ve kterém bude počet výskytů dané hodnoty - tedy pro {1,2,1,3,5,1} vrátí {0,3,1,1,0,1} ), zde je otázka, jak se postarat o záporná čísla
10. Pole odchylek všech prvků od dané hodnoty - tedy pro pole {4,3,2} a hodnotu 3 vrátí {1,0,-1}
11. Rozptyl
12. Směrodatnou odchylku*/


//1. Podprogram

using System.Runtime.InteropServices;

static int pocetPrvku(int pocet)
{
    int[] pole1 = new int[] { 1, 5, 6, 8, 9 };
    pocet = pole1.Count();
    return pocet;
}

//2. Podprogram

static int najdiMax(int[] arr)
{

    int max = arr[0];  

    foreach (int num in arr)
    {
        if (num > max)
        {
            max = num;  
        }
    }

    return max;
}


//3. Podprogram


static int najdiMin(int minimum)
{
    int[] pole3 = new int[] { 1, 2, 3, 5, 8, 9, 55 };
    int min = pole3.Min();
    return minimum;
}


//4. Podprogram

static int soucetHodnot(int vysledek)
{
    int[] pole4 = { 1, 3, 5, 8 };
    int soucet = pole4.Sum();
    return soucet;
}

//5. Podprogram


static int soucinHodnot(int vysledek2)
{
    int[] pole5 = { 1, 3, 8, 7, 4, 5, 6, 2, 1, 3 };
    int soucin = 0;
    foreach (int num in pole5)
    {
        soucin *= num;

    }
    return soucin;
}



//6. Podprogram

static int aritMetickyPrumer(int vysledek3)
{
    double[] pole6 = { 1, 3, 5, 6, 8, 6, 7, 9, 2, 3, 45 };
    double prumer = pole6.Average();
    return (int)prumer;
}


// 7. Podprogram
static int geometrickyPrume(int vysledek4)
{
    return null;
}