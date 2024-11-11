using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_107_108 : MonoBehaviour
{
    public R_Wait1_6_33 inside_105;
    public GameObject No_More_Ticket;
    public Only_Line questObject;
    //public Tiket T;
    public void Go_107_Line()
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

            questObject.Go_107_Line();
            inside_105.m_Coroutine = inside_105.WaitSecond_0();
            StartCoroutine(inside_105.m_Coroutine);
            Debug.Log("107번째 리셋하자");
        }
    }

    public void Go_108_Line()
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

            questObject.Go_108_Line();
            inside_105.m_Coroutine = inside_105.WaitSecond_0();
            StartCoroutine(inside_105.m_Coroutine);
            Debug.Log("108번째 리셋하자");
        }
    }
}
