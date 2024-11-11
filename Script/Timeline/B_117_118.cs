using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_117_118 : MonoBehaviour
{
    //public Tiket T;
    public R_Wait1_6_36 inside_117;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    public void Go_117_Line()
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

            questObject.Go_117_Line();
            inside_117.m_Coroutine = inside_117.WaitSecond_0();
            StartCoroutine(inside_117.m_Coroutine);
            Debug.Log("117번째 리셋하자");
        }
    }

    public void Go_118_Line()
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

            questObject.Go_118_Line();
            inside_117.m_Coroutine = inside_117.WaitSecond_0();
            StartCoroutine(inside_117.m_Coroutine);
            Debug.Log("118번째 리셋하자");
        }
    }
}
