using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_49_50 : MonoBehaviour
{
    public R_Wait1_5_17 inside_49;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    //public Tiket T;
    public void Go_49_Line()
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

            questObject.Go_49_Line();
            inside_49.m_Coroutine = inside_49.NewCoroutine();
            StartCoroutine(inside_49.m_Coroutine);
            Debug.Log("49번째 리셋하자");
        }
    }

    public void Go_50_Line()
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

            questObject.Go_50_Line();
            inside_49.m_Coroutine = inside_49.NewCoroutine();
            StartCoroutine(inside_49.m_Coroutine);
            Debug.Log("50번째 리셋하자");
        }
    }
}
