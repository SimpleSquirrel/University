package com.company;

import java.util.Scanner;

public class Main
{
    public static void main(String[] args)
    {
        Scanner in = new Scanner(System.in);
        boolean check = true;
        int choose;
        while(check)
        {
            System.out.println("\n1 - Алгоритм Флойда" +
                    "\n2 - Алгоритм Дейкстри" +
                    "\n3 - Выход");
            choose = in.nextInt();
            switch (choose)
            {
                case 1:
                {
                    int i,j,k;
                    int[][] Veight = {
                            {0,  4,  2,  0,  0,  0},
                            {2,  0,  0,  4,  0,  0},
                            {6,  0,  0,  0,  0,  0},
                            {0,  1,  0,  0,  0,  0},
                            {0,  0,  3,  7,  0,  0},
                            {0,  0,  9,  8,  5,  0}};
                    int[][] History = {
                            {0,  2,  3,  0,  0,  0},
                            {1,  0,  0,  4,  0,  0},
                            {1,  0,  0,  0,  6,  7},
                            {0,  0,  0,  0,  6,  7},
                            {0,  0,  0,  0,  0,  7},
                            {0,  0,  0,  0,  0,  0}};
                    System.out.println("Это исходный вес:");
                    for(i = 0; i < 6; i++)
                    {
                        for(j = 0; j < 6; j++)
                        {
                            if(Veight[i][j] != 0)
                                System.out.print(Veight[i][j] + "\t");
                            else
                                System.out.print("-\t");
                        }
                        System.out.println();
                    }
                    System.out.println("Это исходный путь:");
                    for(i = 0;i<6;i++)
                    {
                        for(j = 0;j <6;j++)
                        {
                            if(History[i][j] != 0)
                                System.out.print(History[i][j] + "\t");
                            else
                                System.out.print("-\t");
                        }
                        System.out.println();
                    }
                    for (i = 0; i < 6; i++)
                    {
                        for(j = 0; j < 6; j++)
                        {
                            if(Veight[i][j] != 0)
                            {
                                for(k = 0; k < 6; k++)
                                {
                                    if(Veight[i][k] > (Veight[i][j] + Veight[j][k]))
                                    {
                                        Veight[i][k] = (Veight[i][j] + Veight[j][k]);
                                        History[i][k] = History[i][j];
                                    }
                                }
                            }
                        }
                    }
                    System.out.println("Это вес:");
                    for(i =0;i<6;i++)
                    {
                        for(j = 0;j <6;j++)
                        {
                            if(Veight[i][j] != 0)
                                System.out.print(Veight[i][j] + "\t");
                            else
                                System.out.print("-\t");
                        }
                        System.out.println();
                    }
                    System.out.println("Это путь:");
                    for(i =0;i<6;i++)
                    {
                        for(j = 0;j <6;j++)
                        {
                            if(History[i][j] != 0)
                                System.out.print(History[i][j] + "\t");
                            else
                                System.out.print("-\t");
                        }
                        System.out.println();
                    }
                    break;
                }

                case 2:
                {
                    System.out.println("Введите начальную вершину");
                    int num = in.nextInt() - 1;
                    System.out.println("Введите конечную вершину");
                    int finish = in.nextInt() - 1;
                    int[][] Veight = {
                            {0,  4,  2,  0,  0,  0},
                            {2,  0,  0,  4,  0,  0},
                            {6,  0,  0,  0,  0,  0},
                            {0,  1,  0,  0,  0,  0},
                            {0,  0,  3,  7,  0,  0},
                            {0,  0,  9,  8,  5,  0}};

                    int[][] Info = {
                            {500, 500, 500, 500, 500, 500},//minstraf
                            {0,  0,  0,  0,  0,  0},        //otkuda
                            {0,  0,  0,  0,  0,  0}};       //used?
                    for(int i = 0; i<6; i++)
                    {
                        for(int j = 0; j<6; j++)
                        {
                            System.out.print(Veight[i][j]+"\t");
                        }
                        System.out.println();
                    }
                    System.out.println();
                    Info[0][num] = 0;
                    for(int i=0;i<6;i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            if (Veight[j][num] != 0)
                            {
                                if (Info[0][j] > Info[0][num] + Veight[j][num])
                                {
                                    Info[0][j] = Info[0][num] + Veight[j][num];
                                    Info[1][j] = num;
                                }
                            }
                        }
                        Info[2][num] = 1;
                        clear(num, Veight);
                        num = newPoint(Info);
                    }
                    for(int i = 0;i<2;i++)
                    {
                        for(int j=0;j<6;j++)
                        {
                            System.out.print(Info[i][j] + "\t");
                        }
                        System.out.println();
                    }
                    System.out.println("Штраф будет равен " + Info[0][finish]);
                    System.out.print("Вот путь: ");
                    System.out.print(finish+1 + " ");
                    while(Info[1][finish] !=0)
                    {
                        System.out.print(Info[1][finish]+1 + " ");
                        finish = Info[1][finish];
                    }
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

    private static void clear(int num, int[][] Veight)
    {
        int i;
        for(i=0;i<6;i++)
        {
            Veight[i][num] = 0;
        }
    }
    private static int newPoint(int Info[][])
    {
        int num=0, min=500;
        for(int i = 0; i<6;i++)
        {
            if(Info[0][i] < min && Info[2][i] == 0)
            {
                min = Info[0][i];
                num = i;
            }
        }
        return num;
    }
}