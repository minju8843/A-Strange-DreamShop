using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_75_76 : MonoBehaviour
{
    //public Tiket T;

    public R_Wait1_6_1 inside_73;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    public void Go_75_Line()
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

            questObject.Go_75_Line();
            inside_73.m_Coroutine = inside_73.WaitSecond_0();
            StartCoroutine(inside_73.m_Coroutine);
            Debug.Log("75번째 리셋하자");
        }
    }

    public void Go_76_Line()
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

            questObject.Go_76_Line();
            inside_73.m_Coroutine = inside_73.WaitSecond_0();
            StartCoroutine(inside_73.m_Coroutine);
            Debug.Log("76번째 리셋하자");
        }
    }
}
