using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_9_10 : MonoBehaviour
{
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    //public Tiket T;

    public R_Wait1_3_1 inside_9;


    public void Go_Nine_Line()
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

            questObject.Go_Nine_Line();
            inside_9.m_Coroutine = inside_9.NewCoroutine();
            StartCoroutine(inside_9.m_Coroutine);
            Debug.Log("9번째 리셋하자");
        }
    }


    public void Go_Ten_Line()
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

            questObject.Go_Ten_Line();
            inside_9.m_Coroutine = inside_9.NewCoroutine();
            StartCoroutine(inside_9.m_Coroutine);
            Debug.Log("10번째 리셋하자");
        }
    }
}
