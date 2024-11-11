using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_93_94 : MonoBehaviour
{
    public R_Wait1_6_30 inside_93;
    public GameObject No_More_Ticket;
    public Only_Line questObject;
    //public Tiket T;
    public void Go_93_Line()
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

            questObject.Go_93_Line();
            inside_93.m_Coroutine = inside_93.WaitSecond_0();
            StartCoroutine(inside_93.m_Coroutine);
            Debug.Log("93번째 리셋하자");
        }
    }

    public void Go_94_Line()
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

            questObject.Go_94_Line();
            inside_93.m_Coroutine = inside_93.WaitSecond_0();
            StartCoroutine(inside_93.m_Coroutine);
            Debug.Log("94번째 리셋하자");
        }
    }
}
