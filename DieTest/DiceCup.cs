using DieTest;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

public class DiceCup
{
    public int die1;
    public int die2;
    public int die3;
    public int die4;
    public int die5;
    Die d1 = new Die();
    Die d2 = new Die();
    Die d3 = new Die();
    Die d4 = new Die();
    Die d5 = new Die();



    public void Shake()

        {
       

        d1.roll();
        d2.roll();
        d3.roll();
        d4.roll();
        d5.roll();

        this.die1 = d1.getValue();
        this.die2 = d2.getValue();
        this.die3 = d3.getValue();
        this.die4 = d4.getValue();
        this.die5 = d5.getValue();

    }
    

    




    
}
