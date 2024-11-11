using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_51_52 : MonoBehaviour
{
    public R_Wait1_5_17 inside_49;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    //public Tiket T;
    public void Go_51_Line()
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

            questObject.Go_51_Line();
            inside_49.m_Coroutine = inside_49.NewCoroutine();
            StartCoroutine(inside_49.m_Coroutine);
            Debug.Log("51번째 리셋하자");
        }
    }

    public void Go_52_Line()
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

            questObject.Go_52_Line();
            inside_49.m_Coroutine = inside_49.NewCoroutine();
            StartCoroutine(inside_49.m_Coroutine);
            Debug.Log("52번째 리셋하자");
        }
    }

}
