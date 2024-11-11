using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_35_36 : MonoBehaviour
{
    //public Tiket T;
    public R_Wait1_4_9 inside_35;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    public void Go_ThirtyFive_Line()
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

            questObject.Go_ThirtyFive_Line();
            inside_35.m_Coroutine = inside_35.NewCoroutine();
            StartCoroutine(inside_35.m_Coroutine);
            Debug.Log("35번째 리셋하자");
        }
    }

    public void Go_ThirtySix_Line()
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

            questObject.Go_ThirtySix_Line();
            inside_35.m_Coroutine = inside_35.NewCoroutine();
            StartCoroutine(inside_35.m_Coroutine);
            Debug.Log("36번째 리셋하자");
        }
    }
}
