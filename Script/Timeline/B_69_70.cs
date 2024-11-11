using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_69_70 : MonoBehaviour
{
    //public Tiket T;

    public R_Wait1_5_22 inside_69;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    public void Go_69_Line()
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

            questObject.Go_69_Line();
            inside_69.m_Coroutine = inside_69.NewCoroutine();
            StartCoroutine(inside_69.m_Coroutine);
            Debug.Log("69번째 리셋하자");
        }
    }

    public void Go_70_Line()
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

            questObject.Go_70_Line();
            inside_69.m_Coroutine = inside_69.NewCoroutine();
            StartCoroutine(inside_69.m_Coroutine);
            Debug.Log("70번째 리셋하자");
        }
    }
}
