using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_41_42 : MonoBehaviour
{
    //public Tiket T;

    public R_Wait1_5_1 inside_41;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    public void Go_41_Line()
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

            questObject.Go_41_Line();
            inside_41.m_Coroutine = inside_41.NewCoroutine();
            StartCoroutine(inside_41.m_Coroutine);
            Debug.Log("41번째 리셋하자");
        }
    }

    public void Go_42_Line()
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

            questObject.Go_42_Line();
            inside_41.m_Coroutine = inside_41.NewCoroutine();
            StartCoroutine(inside_41.m_Coroutine);
            Debug.Log("42번째 리셋하자");
        }
    }
}
