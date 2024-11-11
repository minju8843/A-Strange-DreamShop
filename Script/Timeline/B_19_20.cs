using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_19_20 : MonoBehaviour
{
    public Next_1_3_6 inside_19;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    //public Tiket T;
    public void Go_Nineteen_Line()
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

            questObject.Go_Nineteen_Line();
            inside_19.m_Coroutine = inside_19.NewCoroutine();
            StartCoroutine(inside_19.m_Coroutine);
            Debug.Log("19번째 리셋하자");
        }
    }

    public void Go_Twenty_Line()
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

            questObject.Go_Twenty_Line();
            inside_19.m_Coroutine = inside_19.NewCoroutine();
            StartCoroutine(inside_19.m_Coroutine);
            Debug.Log("20번째 리셋하자");
        }
    }
}
