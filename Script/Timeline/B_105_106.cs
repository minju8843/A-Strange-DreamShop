using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_105_106 : MonoBehaviour
{
    public R_Wait1_6_33 inside_105;
    public GameObject No_More_Ticket;
    public Only_Line questObject;
    //public Tiket T;
    public void Go_105_Line()
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

            questObject.Go_105_Line();
            inside_105.m_Coroutine = inside_105.WaitSecond_0();
            StartCoroutine(inside_105.m_Coroutine);
            Debug.Log("105번째 리셋하자");
        }
    }

    public void Go_106_Line()
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

            questObject.Go_106_Line();
            inside_105.m_Coroutine = inside_105.WaitSecond_0();
            StartCoroutine(inside_105.m_Coroutine);
            Debug.Log("106번째 리셋하자");
        }
    }
}
