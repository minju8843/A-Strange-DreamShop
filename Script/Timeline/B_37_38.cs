using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_37_38 : MonoBehaviour
{
    //public Tiket T;
    public R_Wait1_4_11 inside_37;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    public void Go_ThirtySeven_Line()
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

            questObject.Go_ThirtySeven_Line();
            inside_37.m_Coroutine = inside_37.NewCoroutine();
            StartCoroutine(inside_37.m_Coroutine);
            Debug.Log("37번째 리셋하자");
        }
    }

    public void Go_ThirtyEight_Line()
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

            questObject.Go_ThirtyEight_Line();
            inside_37.m_Coroutine = inside_37.NewCoroutine();
            StartCoroutine(inside_37.m_Coroutine);
            Debug.Log("38번째 리셋하자");
        }
    }
}
