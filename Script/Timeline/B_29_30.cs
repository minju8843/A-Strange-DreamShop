using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_29_30 : MonoBehaviour
{
    public R_Wait1_4_3 inside_29;
    public GameObject No_More_Ticket;
    public Only_Line questObject;
    //public Tiket T;
    public void Go_TwentyNine_Line()
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

            questObject.Go_TwentyNine_Line();
            inside_29.m_Coroutine = inside_29.NewCoroutine();
            StartCoroutine(inside_29.m_Coroutine);
            Debug.Log("29번째 리셋하자");
        }
    }

    public void Go_Thirty_Line()
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

            questObject.Go_Thirty_Line();
            inside_29.m_Coroutine = inside_29.NewCoroutine();
            StartCoroutine(inside_29.m_Coroutine);
            Debug.Log("30번째 리셋하자");
        }
    }
}
