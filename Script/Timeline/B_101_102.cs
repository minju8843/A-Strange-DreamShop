using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_101_102 : MonoBehaviour
{
    //public Tiket T;
    public R_Wait1_6_12 inside_101;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    public void Go_101_Line()
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

            questObject.Go_101_Line();
            inside_101.m_Coroutine = inside_101.WaitSecond_0();
            StartCoroutine(inside_101.m_Coroutine);
            Debug.Log("101번째 리셋하자");
        }
    }

    public void Go_102_Line()
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

            questObject.Go_102_Line();
            inside_101.m_Coroutine = inside_101.WaitSecond_0();
            StartCoroutine(inside_101.m_Coroutine);
            Debug.Log("102번째 리셋하자");
        }
    }
}
