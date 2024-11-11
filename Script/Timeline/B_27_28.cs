using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_27_28 : MonoBehaviour
{
    public R_Wait1_4_1 inside_27;
    public GameObject No_More_Ticket;
    public Only_Line questObject;
    //public Tiket T;
    public void Go_TwentySeven_Line()
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

            questObject.Go_TwentySeven_Line();
            inside_27.m_Coroutine = inside_27.NewCoroutine();
            StartCoroutine(inside_27.m_Coroutine);
            Debug.Log("27번째 리셋하자");
        }
    }

    public void Go_TwentyEight_Line()
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

            questObject.Go_TwentyEight_Line();
            inside_27.m_Coroutine = inside_27.NewCoroutine();
            StartCoroutine(inside_27.m_Coroutine);
            Debug.Log("28번째 리셋하자");
        }
    }
}
