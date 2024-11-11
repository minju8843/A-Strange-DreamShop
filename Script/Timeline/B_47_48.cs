using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_47_48 : MonoBehaviour
{
    //public Tiket T;

    public R_Wait1_5_5 inside_45;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    public void Go_47_Line()
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

            questObject.Go_47_Line();
            inside_45.m_Coroutine = inside_45.NewCoroutine();
            StartCoroutine(inside_45.m_Coroutine);
            Debug.Log("47번째 리셋하자");
        }
    }

    public void Go_48_Line()
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

            questObject.Go_48_Line();
            inside_45.m_Coroutine = inside_45.NewCoroutine();
            StartCoroutine(inside_45.m_Coroutine);
            Debug.Log("48번째 리셋하자");
        }
    }
}
