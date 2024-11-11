using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_71_72 : MonoBehaviour
{
    public R_Wait1_5_22 inside_69;
    public GameObject No_More_Ticket;
    public Only_Line questObject;
    //public Tiket T;
    public void Go_71_Line()
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

            questObject.Go_71_Line();
            inside_69.m_Coroutine = inside_69.NewCoroutine();
            StartCoroutine(inside_69.m_Coroutine);
            Debug.Log("71번째 리셋하자");
        }
    }

    public void Go_72_Line()
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

            questObject.Go_72_Line();
            inside_69.m_Coroutine = inside_69.NewCoroutine();
            StartCoroutine(inside_69.m_Coroutine);
            Debug.Log("72번째 리셋하자");
        }
    }
}
