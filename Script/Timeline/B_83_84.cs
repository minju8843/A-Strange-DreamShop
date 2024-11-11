using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_83_84 : MonoBehaviour
{
    public R_Wait1_6_3 inside_81;
    public GameObject No_More_Ticket;
    public Only_Line questObject;
    //public Tiket T;
    public void Go_83_Line()
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

            questObject.Go_83_Line();
            inside_81.m_Coroutine = inside_81.WaitSecond_0();
            StartCoroutine(inside_81.m_Coroutine);
            Debug.Log("83번째 리셋하자");
        }
    }

    public void Go_84_Line()
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

            questObject.Go_84_Line();
            inside_81.m_Coroutine = inside_81.WaitSecond_0();
            StartCoroutine(inside_81.m_Coroutine);
            Debug.Log("84번째 리셋하자");
        }
    }
}
