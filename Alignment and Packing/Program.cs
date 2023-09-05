using System;

//ref link:https://www.youtube.com/watch?v=oOf29ewSins&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=35
// alignment and Packing -- memory management -- target: no waste

class MeUglyClass
{
    public char meChar1;
    public int meInt;
    public char meChar2;
}

class MainClass
{
    static void Main()
    {
        MeUglyClass mug = new MeUglyClass();
        mug.meChar1 = 'j';
        mug.meInt = 25;
        mug.meChar2 = 'k';
    }
}