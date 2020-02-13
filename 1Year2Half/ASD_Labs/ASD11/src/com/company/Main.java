package com.company;

import java.util.Scanner;

public class Main
{
    public static void main(String[] args)
    {
        Scanner in = new Scanner(System.in);
        boolean check = true;
        int n;
        int k;
        while (check)
        {
            System.out.println("1 - спуск\n2 - возвращение\n3 - выход");
            k = in.nextInt();
            switch (k)
            {
                case 1:
                {
                    n = set();
                    double sum = 0;
                    sum = S(n,sum);
                    System.out.println(sum);
                    break;
                }
                case 2:
                {
                    n = set();
                    double sum = 0;
                    sum = V(n, sum);
                    System.out.println(sum);
                    break;
                }
                case 3:
                {
                    check = false;
                    break;
                }
            }

        }
    }

    private static double S(int n, double sum)
    {
        if(n<1)
            return 0;
        double k = Math.sin((n-1) + Math.cos(n));
        return sum += k + S(n-1, sum);
    }

    private static double V(int n, double sum)
    {
        if(n<1)
            return 0;
        double k = Math.sin((n-1) + Math.cos(n));
        n--;
        return sum += k + S(n, sum);
    }

    private static int set()
    {
        int n;
        Scanner in = new Scanner(System.in);
        System.out.println("Введите колово элементов в последовательности");
        n = in.nextInt();

        return n;
    }
}
