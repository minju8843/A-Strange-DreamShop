using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_25_26 : MonoBehaviour
{
    public R_Wait1_4_1 inside_25;
    public GameObject No_More_Ticket;
    public Only_Line questObject;
    //public Tiket T;
    public void Go_TwentyFive_Line()
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

            questObject.Go_TwentyFive_Line();
            inside_25.m_Coroutine = inside_25.NewCoroutine();
            StartCoroutine(inside_25.m_Coroutine);
            Debug.Log("25��° ��������");
        }
    }

    public void Go_TwentySix_Line()
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

            questObject.Go_TwentySix_Line();
            inside_25.m_Coroutine = inside_25.NewCoroutine();
            StartCoroutine(inside_25.m_Coroutine);
            Debug.Log("26��° ��������");
        }
    }
}
