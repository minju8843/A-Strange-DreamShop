using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_99_100 : MonoBehaviour
{
    public R_Wait1_6_11 inside_97;
    public GameObject No_More_Ticket;
    public Only_Line questObject;
    //public Tiket T;
    public void Go_99_Line()
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

            questObject.Go_99_Line();
            inside_97.m_Coroutine = inside_97.WaitSecond_0();
            StartCoroutine(inside_97.m_Coroutine);
            Debug.Log("99��° ��������");
        }
    }

    public void Go_100_Line()
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

            questObject.Go_100_Line();
            inside_97.m_Coroutine = inside_97.WaitSecond_0();
            StartCoroutine(inside_97.m_Coroutine);
            Debug.Log("100��° ��������");
        }
    }
}
