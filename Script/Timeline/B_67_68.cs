using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_67_68 : MonoBehaviour
{
    public R_Wait1_5_18 inside_65;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    //public Tiket T;
    public void Go_67_Line()
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

            questObject.Go_67_Line();
            inside_65.m_Coroutine = inside_65.NewCoroutine();
            StartCoroutine(inside_65.m_Coroutine);
            Debug.Log("67번째 리셋하자");
        }
    }

    public void Go_68_Line()
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

            questObject.Go_68_Line();
            inside_65.m_Coroutine = inside_65.NewCoroutine();
            StartCoroutine(inside_65.m_Coroutine);
            Debug.Log("68번째 리셋하자");
        }
    }
}
