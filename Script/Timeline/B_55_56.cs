using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_55_56 : MonoBehaviour
{
    public R_Wait1_5_21 inside_53;
    public GameObject No_More_Ticket;
    public Only_Line questObject;
    //public Tiket T;
    public void Go_55_Line()
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

            questObject.Go_55_Line();
            inside_53.m_Coroutine = inside_53.NewCoroutine();
            StartCoroutine(inside_53.m_Coroutine);
            Debug.Log("55번째 리셋하자");
        }
    }

    public void Go_56_Line()
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

            questObject.Go_56_Line();
            inside_53.m_Coroutine = inside_53.NewCoroutine();
            StartCoroutine(inside_53.m_Coroutine);
            Debug.Log("56번째 리셋하자");
        }
    }
}
