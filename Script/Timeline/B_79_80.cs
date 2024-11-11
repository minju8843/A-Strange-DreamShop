using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_79_80 : MonoBehaviour
{
    public R_Wait_1_6_2 inside_77;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    //public Tiket T;
    public void Go_79_Line()
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

            questObject.Go_79_Line();
            inside_77.m_Coroutine = inside_77.WaitSecond_0();
            StartCoroutine(inside_77.m_Coroutine);
            Debug.Log("79번째 리셋하자");
        }
    }

    public void Go_80_Line()
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

            questObject.Go_80_Line();
            inside_77.m_Coroutine = inside_77.WaitSecond_0();
            StartCoroutine(inside_77.m_Coroutine);
            Debug.Log("80번째 리셋하자");
        }
    }
}
