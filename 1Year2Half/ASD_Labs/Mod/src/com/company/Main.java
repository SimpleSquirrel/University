package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args)
    {
        Scanner in = new Scanner(System.in);
        int n;

        System.out.println("Введите колово");
        n = in.nextInt();

        Firma agenzia[] = new Firma[n];
    }

    public static void setter(Firma ag[])
    {
        for(int i = 0; i<ag.length;i++)
        {
            ag[i] = new Firma();
            ag[i].setInfo();
        }
    }

    public static void sort(Firma ag[])
    {
        Firma saver = new Firma();
        for(int i = 0; i<ag.length;i++)
        {
            for(int j =0 ;j<ag.length - 1;j++)
            {
                if(ag[i].plata < ag[i+1].plata)
                {
                    saver.plata  = ag[i].plata;
                    saver.gender = ag[i].gender;
                    saver.name   = ag[i].name;

                    ag[i].plata    =    ag[i+1].plata;
                    ag[i].gender   =    ag[i+1].gender;
                    ag[i].name     =    ag[i+1].name;

                    ag[i+1].plata   =   saver.plata ;
                    ag[i+1].gender  =   saver.gender;
                    ag[i+1].name    =   saver.name  ;
                }
            }
        }
    }

    public static void outmax(Firma ag[])
    {
        for(int i = 0;i<ag.length;i++)
        {
            ag[i].outInfo();
            if(ag[i+1]!=ag[i])break;
        }
    }
}
