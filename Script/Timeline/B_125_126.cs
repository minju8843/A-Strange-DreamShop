using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_125_126 : MonoBehaviour
{
    //public Tiket T;
    public R_Wait_1_6_42 inside_125;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    public void Go_125_Line()
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

            questObject.Go_125_Line();
            inside_125.m_Coroutine = inside_125.WaitSecond_0();
            StartCoroutine(inside_125.m_Coroutine);
            Debug.Log("125번째 리셋하자");
        }
    }

    public void Go_126_Line()
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

            questObject.Go_126_Line();
            inside_125.m_Coroutine = inside_125.WaitSecond_0();
            StartCoroutine(inside_125.m_Coroutine);
            Debug.Log("126번째 리셋하자");
        }
    }
}
