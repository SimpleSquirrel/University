package com.company;

public class Main
{
    public static void main(String[] args)
    {
	    Stack stack = new Stack();
	    stack.push("Students");
	    stack.push("of");
	    stack.push("the");
	    stack.push("group");
	    stack.push("TE");
	    stack.push("3");

	    for(int i =0; i<stack.stackSize(); i++)
        {
        	if(stack.s[i].length() == 2)
            System.out.println(stack.s[i]);

        }

	    int b;
	    b=0;
	    b = b++ + ++b;
		System.out.println(b);
    }
}
