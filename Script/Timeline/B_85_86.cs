using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_85_86 : MonoBehaviour
{
    public R_Wait1_6_4 inside_85;
    public GameObject No_More_Ticket;
    public Only_Line questObject;
    //public Tiket T;
    public void Go_85_Line()
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

            questObject.Go_85_Line();
            inside_85.m_Coroutine = inside_85.WaitSecond_0();
            StartCoroutine(inside_85.m_Coroutine);
            Debug.Log("85번째 리셋하자");
        }
    }

    public void Go_86_Line()
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

            questObject.Go_86_Line();
            inside_85.m_Coroutine = inside_85.WaitSecond_0();
            StartCoroutine(inside_85.m_Coroutine);
            Debug.Log("86번째 리셋하자");
        }
    }
}
