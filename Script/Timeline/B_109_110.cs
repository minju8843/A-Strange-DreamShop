using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_109_110 : MonoBehaviour
{
    //public Tiket T;
    public R_Wait1_6_34 inside_109;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    public void Go_109_Line()
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

            questObject.Go_109_Line();
            inside_109.m_Coroutine = inside_109.WaitSecond_0();
            StartCoroutine(inside_109.m_Coroutine);
            Debug.Log("109��° ��������");
        }
    }

    public void Go_110_Line()
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

            questObject.Go_110_Line();
            inside_109.m_Coroutine = inside_109.WaitSecond_0();
            StartCoroutine(inside_109.m_Coroutine);
            Debug.Log("110��° ��������");
        }
    }
}
