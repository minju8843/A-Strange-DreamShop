using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_13_14 : MonoBehaviour
{
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    //public Tiket T;

    public R_Wait1_3_2 inside_13;

    public void Go_Thirteen_Line()
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

            questObject.Go_Thirteen_Line();
            inside_13.m_Coroutine = inside_13.NewCoroutine();
            StartCoroutine(inside_13.m_Coroutine);
            Debug.Log("13번째 리셋하자");
        }
    }

    public void Go_Fourteen_Line()
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

            questObject.Go_Fourteen_Line();
            inside_13.m_Coroutine = inside_13.NewCoroutine();
            StartCoroutine(inside_13.m_Coroutine);
            Debug.Log("14번째 리셋하자");
        }
    }

}
