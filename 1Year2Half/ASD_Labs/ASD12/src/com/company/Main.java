package com.company;

public class Main
{
    public static void main(String[] args)
    {
        int a=9, b=11, c=14;
        int[] mas = new int[0];

        create(a,mas);
        create(b,mas);
        create(c,mas);
    }

    private static void create(int n, int[]mas)
    {
        mas = new int[n];
        for(int i = 0;i<n;i++)
            mas[i] = (int)(-25+Math.random()*51);
        out(n,mas);
        sep();
        sumz(n,mas);
        sep();
    }

    private static void sumz(int n, int[] mas)
    {
        int sumDo = 0, sumPosle = 0;
        int flag=0;

        for(int i = 0;i <n;i++)
        {
            if (mas[i] < 0)
            {
                flag = i;
                break;
            }
        }

        for(int i = 0; i<flag;i++)
            sumDo+=mas[i];
        for(int i = flag+1; i<n;i++)
            sumPosle+=mas[i];

        System.out.println("Сумма до первого отрицательного элемента равна " + sumDo);
        System.out.println("Самма после первого отрицательного элемента равна " + sumPosle);
    }

    private static void out(int n, int[]mas)
    {
        for(int i = 0;i<n;i++)
            System.out.print(mas[i] + "\t");
    }
    private static void sep()
    {
        System.out.println();
    }
}
