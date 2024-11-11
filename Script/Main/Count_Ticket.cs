using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count_Ticket : MonoBehaviour
{
    //public Tiket T;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Ten()
    {
        Tiket.Total += 10;
    }

    public void Twenty()
    {
        Tiket.Total += 20;
    }

    public void Fourty()
    {
        Tiket.Total += 40;
    }

    public void Back_O_Ship()
    {
        Tiket.Total += 150;

        

    }

    public void Sam_Back_O_Ship()
    {
        Tiket.Total += 350;
    }

    public void Pall_Back()
    {
        Tiket.Total += 800;
    }

    public void Minus_Five()
    {
        Tiket.Total -=5 ;
    }

    public void Minus_Ten()
    {
        Tiket.Total -= 10;
    }
}
