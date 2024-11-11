using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_11_12 : MonoBehaviour
{
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    //public Tiket T;

    public R_Wait1_3_6 inside_11;

    public void Go_Eleven_Line()
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

            questObject.Go_Eleven_Line();
            inside_11.m_Coroutine = inside_11.NewCoroutine();
            StartCoroutine(inside_11.m_Coroutine);
            Debug.Log("11번째 리셋하자");
        }
    }

    public void Go_Twelve_Line()
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

            questObject.Go_Twelve_Line();
            inside_11.m_Coroutine = inside_11.NewCoroutine();
            StartCoroutine(inside_11.m_Coroutine);
            Debug.Log("12번째 리셋하자");
        }
    }
}
