using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_45_46 : MonoBehaviour
{
    public R_Wait1_5_5 inside_45;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    //public Tiket T;

    public void Go_45_Line()
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

            questObject.Go_45_Line();
            inside_45.m_Coroutine = inside_45.NewCoroutine();
            StartCoroutine(inside_45.m_Coroutine);
            Debug.Log("45번째 리셋하자");
        }
    }

    public void Go_46_Line()
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

            questObject.Go_46_Line();
            inside_45.m_Coroutine = inside_45.NewCoroutine();
            StartCoroutine(inside_45.m_Coroutine);
            Debug.Log("46번째 리셋하자");
        }
    }
}
