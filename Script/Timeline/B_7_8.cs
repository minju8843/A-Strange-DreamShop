using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_7_8 : MonoBehaviour
{
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    //public Tiket T;


    public R_Wait1_2_1 inside_5;
    public R_Wait1_2_4 inside_8;

    public void Go_Seven_Line()
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

            questObject.Go_Seven_Line();
            inside_5.m_Coroutine = inside_5.NewCoroutine();
            StartCoroutine(inside_5.m_Coroutine);
            Debug.Log("7번째 리셋하자");
        }
    }

    public void Go_Eight_Line()
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

            questObject.Go_Eight_Line();
            inside_8.m_Coroutine = inside_8.NewCoroutine();
            StartCoroutine(inside_8.m_Coroutine);
            Debug.Log("8번째 리셋하자");
        }
    }
}
