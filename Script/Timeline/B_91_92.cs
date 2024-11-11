using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_91_92 : MonoBehaviour
{
    public R_Wait1_6_9 inside_89;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    //public Tiket T;
    public void Go_91_Line()
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

            questObject.Go_91_Line();
            inside_89.m_Coroutine = inside_89.WaitSecond_0();
            StartCoroutine(inside_89.m_Coroutine);
            Debug.Log("91번째 리셋하자");
        }
    }

    public void Go_92_Line()
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

            questObject.Go_92_Line();
            inside_89.m_Coroutine = inside_89.WaitSecond_0();
            StartCoroutine(inside_89.m_Coroutine);
            Debug.Log("92번째 리셋하자");
        }
    }
}
