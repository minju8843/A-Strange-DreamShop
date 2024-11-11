using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_21_22 : MonoBehaviour
{
    public Next_1_3_2 inside_21;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    //public Tiket T;
    public void Go_TwentyOne_Line()
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

            questObject.Go_TwentyOne_Line();
            inside_21.m_Coroutine = inside_21.NewCoroutine();
            StartCoroutine(inside_21.m_Coroutine);
            Debug.Log("21번째 리셋하자");
        }
    }

    public void Go_TwentyTwo_Line()
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

            questObject.Go_TwentyTwo_Line();
            inside_21.m_Coroutine = inside_21.NewCoroutine();
            StartCoroutine(inside_21.m_Coroutine);
            Debug.Log("22번째 리셋하자");
        }
    }
}
