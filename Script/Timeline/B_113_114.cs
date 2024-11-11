using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_113_114 : MonoBehaviour
{
    public R_Wait1_6_35 inside_113;
    public GameObject No_More_Ticket;
    public Only_Line questObject;
    //public Tiket T;
    public void Go_113_Line()
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

            questObject.Go_113_Line();
            inside_113.m_Coroutine = inside_113.WaitSecond_0();
            StartCoroutine(inside_113.m_Coroutine);
            Debug.Log("113번째 리셋하자");
        }
    }

    public void Go_114_Line()
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

            questObject.Go_114_Line();
            inside_113.m_Coroutine = inside_113.WaitSecond_0();
            StartCoroutine(inside_113.m_Coroutine);
            Debug.Log("114번째 리셋하자");
        }
    }
}
