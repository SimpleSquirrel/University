package com.company;

public class Stack {
    public String[] s;
    private int n = 0;

    public Stack() {
        s = new String[1];
    }

    private void reSize(int capacity) {
        String[] copy = new String[capacity];
        for (int i = 0; i < n; i++) {
            copy[i] = s[i];
        }
        s = copy;
    }

    public boolean isEmpty() {
        return n == 0;
    }

    public int stackSize() {
        return n;
    }

    public void push(String info) {
        if (info != null) {
            if (n == s.length) {
                reSize(s.length * 2);
            }
        }
        s[n++] = info;
    }

    public String pop() {
        String item = null;
        if (!isEmpty()) {
            item = s[--n];
            s[n] = null;
        }
        if (n == (s.length / 4)) {
            reSize(s.length / 4);
        }
        return item;
    }
}