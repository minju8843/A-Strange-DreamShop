using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_17_18 : MonoBehaviour
{
    public Next_1_3_1 inside_17;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    //public Tiket T;
    public void Go_Seventeen_Line()
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

            questObject.Go_Seventeen_Line();
            inside_17.m_Coroutine = inside_17.NewCoroutine();
            StartCoroutine(inside_17.m_Coroutine);
            Debug.Log("17번째 리셋하자");
        }
    }

    public void Go_Eighteen_Line()
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

            questObject.Go_Eighteen_Line();
            inside_17.m_Coroutine = inside_17.NewCoroutine();
            StartCoroutine(inside_17.m_Coroutine);
            Debug.Log("18번째 리셋하자");
        }
    }
}
