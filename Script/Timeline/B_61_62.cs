using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_61_62 : MonoBehaviour
{
    public R_Wait1_5_6 inside_61;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    //public Tiket T;
    public void Go_61_Line()
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

            questObject.Go_61_Line();
            inside_61.m_Coroutine = inside_61.NewCoroutine();
            StartCoroutine(inside_61.m_Coroutine);
            Debug.Log("61번째 리셋하자");
        }
    }

    public void Go_62_Line()
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

            questObject.Go_62_Line();
            inside_61.m_Coroutine = inside_61.NewCoroutine();
            StartCoroutine(inside_61.m_Coroutine);
            Debug.Log("62번째 리셋하자");
        }
    }
}
