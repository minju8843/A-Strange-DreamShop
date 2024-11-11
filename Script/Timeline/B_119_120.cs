using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_119_120 : MonoBehaviour
{
    public R_Wait1_6_36 inside_117;
    public GameObject No_More_Ticket;
    public Only_Line questObject;
    //public Tiket T;
    public void Go_119_Line()
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

            questObject.Go_119_Line();
            inside_117.m_Coroutine = inside_117.WaitSecond_0();
            StartCoroutine(inside_117.m_Coroutine);
            Debug.Log("119번째 리셋하자");
        }
    }

    public void Go_120_Line()
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

            questObject.Go_120_Line();
            inside_117.m_Coroutine = inside_117.WaitSecond_0();
            StartCoroutine(inside_117.m_Coroutine);
            Debug.Log("120번째 리셋하자");
        }
    }
}
