using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_15_16 : MonoBehaviour
{
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    //public Tiket T;

    public R_Wait1_3_5 inside_15;

    public void Go_Fifteen_Line()
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

            questObject.Go_Fifteen_Line();
            inside_15.m_Coroutine = inside_15.NewCoroutine();
            StartCoroutine(inside_15.m_Coroutine);
            Debug.Log("15번째 리셋하자");
        }
    }

    public void Go_Sixteen_Line()
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

            questObject.Go_Sixteen_Line();
            inside_15.m_Coroutine = inside_15.NewCoroutine();
            StartCoroutine(inside_15.m_Coroutine);
            Debug.Log("16번째 리셋하자");
        }
    }
}
