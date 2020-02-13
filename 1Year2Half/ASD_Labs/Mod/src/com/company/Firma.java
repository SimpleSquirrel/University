package com.company;

import java.util.Scanner;

public class Firma
{
    public String name;
    public String gender;
    public int plata;


    Firma()
    {
        name = " ";
        plata = 0;
        gender = " ";
    }

    public void setInfo()
    {
        Scanner in = new Scanner(System.in);
        System.out.println("Введите фамилию");
        name = in.nextLine();

        System.out.println("Введите возраст");
        plata = Integer.parseInt(in.nextLine());

        System.out.println("Введите стать");
        gender = in.nextLine();
    }

    public void outInfo()
    {
        System.out.println("\nФамилия: " + name +
                "\nВозраст: " + plata +
                "\nСтать: " + gender);
    }
}
