using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_111_112 : MonoBehaviour
{
    public R_Wait1_6_34 inside_109;
    public GameObject No_More_Ticket;
    public Only_Line questObject;
    //public Tiket T;
    public void Go_111_Line()
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

            questObject.Go_111_Line();
            inside_109.m_Coroutine = inside_109.WaitSecond_0();
            StartCoroutine(inside_109.m_Coroutine);
            Debug.Log("111번째 리셋하자");
        }
    }

    public void Go_112_Line()
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

            questObject.Go_112_Line();
            inside_109.m_Coroutine = inside_109.WaitSecond_0();
            StartCoroutine(inside_109.m_Coroutine);
            Debug.Log("112번째 리셋하자");
        }
    }
}
