using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_77_78 : MonoBehaviour
{
    //public Tiket T;

    public R_Wait_1_6_2 inside_77;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    public void Go_77_Line()
    {
        if (Tiket.Total < 5)
        {
            No_More_Ticket.SetActive(true);
        }
        else
        {
            Tiket.Total -= 5;
            PlayerPrefs.SetInt("Count", Tiket.Total);
            PlayerPrefs.Save();

            questObject.Go_77_Line();
            inside_77.m_Coroutine = inside_77.WaitSecond_0();
            StartCoroutine(inside_77.m_Coroutine);
            Debug.Log("77��° ��������");
        }
    }

    public void Go_78_Line()
    {
        if (Tiket.Total < 5)
        {
            No_More_Ticket.SetActive(true);
        }
        else
        {
            Tiket.Total -= 5;
            PlayerPrefs.SetInt("Count", Tiket.Total);
            PlayerPrefs.Save();

            questObject.Go_78_Line();
            inside_77.m_Coroutine = inside_77.WaitSecond_0();
            StartCoroutine(inside_77.m_Coroutine);
            Debug.Log("78��° ��������");
        }
    }
}
