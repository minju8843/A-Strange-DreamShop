using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_39_40 : MonoBehaviour
{
    public R_Wait1_4_11 inside_39;
    public GameObject No_More_Ticket;
    public Only_Line questObject;
    //public Tiket T;
    public void Go_ThirtyNine_Line()
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

            questObject.Go_ThirtyNine_Line();
            inside_39.m_Coroutine = inside_39.NewCoroutine();
            StartCoroutine(inside_39.m_Coroutine);
            Debug.Log("39번째 리셋하자");
        }
    }

    public void Go_Forty_Line()
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

            questObject.Go_Forty_Line();
            inside_39.m_Coroutine = inside_39.NewCoroutine();
            StartCoroutine(inside_39.m_Coroutine);
            Debug.Log("40번째 리셋하자");
        }
    }
}
