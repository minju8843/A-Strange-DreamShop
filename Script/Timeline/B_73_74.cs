using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_73_74 : MonoBehaviour
{
    public R_Wait1_6_1 inside_73;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    //public Tiket T;

    public void Go_73_Line()
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

            questObject.Go_73_Line();
            inside_73.m_Coroutine = inside_73.WaitSecond_0();
            StartCoroutine(inside_73.m_Coroutine);
            Debug.Log("73번째 리셋하자");
        }
    }

    public void Go_74_Line()
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

            questObject.Go_74_Line();
            inside_73.m_Coroutine = inside_73.WaitSecond_0();
            StartCoroutine(inside_73.m_Coroutine);
            Debug.Log("74번째 리셋하자");
        }
    }
}
