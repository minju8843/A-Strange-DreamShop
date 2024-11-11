using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_59_60 : MonoBehaviour
{
    public R_Wait1_5_2 inside_57;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    //public Tiket T;
    public void Go_59_Line()
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

            questObject.Go_59_Line();
            inside_57.m_Coroutine = inside_57.NewCoroutine();
            StartCoroutine(inside_57.m_Coroutine);
            Debug.Log("59번째 리셋하자");
        }
    }

    public void Go_60_Line()
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

            questObject.Go_60_Line();
            inside_57.m_Coroutine = inside_57.NewCoroutine();
            StartCoroutine(inside_57.m_Coroutine);
            Debug.Log("60번째 리셋하자");
        }
    }
}
