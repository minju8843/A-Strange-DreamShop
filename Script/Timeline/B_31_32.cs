using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_31_32 : MonoBehaviour
{
    //public Tiket T;
    public R_Wait1_4_3 inside_31;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    public void Go_ThirtyOne_Line()
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

            questObject.Go_ThirtyOne_Line();
            inside_31.m_Coroutine = inside_31.NewCoroutine();
            StartCoroutine(inside_31.m_Coroutine);
            Debug.Log("31번째 리셋하자");
        }
    }

    public void Go_ThirtyTwo_Line()
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

            questObject.Go_ThirtyTwo_Line();
            inside_31.m_Coroutine = inside_31.NewCoroutine();
            StartCoroutine(inside_31.m_Coroutine);
            Debug.Log("32번째 리셋하자");
        }
    }
}
