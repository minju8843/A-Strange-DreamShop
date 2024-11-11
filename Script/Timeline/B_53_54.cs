using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_53_54 : MonoBehaviour
{
    public R_Wait1_5_21 inside_53;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    //public Tiket T;
    public void Go_53_Line()
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

            questObject.Go_53_Line();
            inside_53.m_Coroutine = inside_53.NewCoroutine();
            StartCoroutine(inside_53.m_Coroutine);
            Debug.Log("53번째 리셋하자");
        }
    }

    public void Go_54_Line()
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

            questObject.Go_54_Line();
            inside_53.m_Coroutine = inside_53.NewCoroutine();
            StartCoroutine(inside_53.m_Coroutine);
            Debug.Log("54번째 리셋하자");
        }
    }
}
