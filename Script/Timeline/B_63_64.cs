using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_63_64 : MonoBehaviour
{
    public R_Wait1_5_6 inside_61;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    //public Tiket T;
    public void Go_63_Line()
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

            questObject.Go_63_Line();
            inside_61.m_Coroutine = inside_61.NewCoroutine();
            StartCoroutine(inside_61.m_Coroutine);
            Debug.Log("63번째 리셋하자");
        }
    }

    public void Go_64_Line()
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

            questObject.Go_64_Line();
            inside_61.m_Coroutine = inside_61.NewCoroutine();
            StartCoroutine(inside_61.m_Coroutine);
            Debug.Log("64번째 리셋하자");
        }
    }
}
