using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_127_128 : MonoBehaviour
{
    public R_Wait_1_6_42 inside_125;
    public GameObject No_More_Ticket;
    public Only_Line questObject;
    //public Tiket T;
    public void Go_127_Line()
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

            questObject.Go_127_Line();
            inside_125.m_Coroutine = inside_125.WaitSecond_0();
            StartCoroutine(inside_125.m_Coroutine);
            Debug.Log("127��° ��������");
        }
    }

    public void Go_128_Line()
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

            questObject.Go_128_Line();
            inside_125.m_Coroutine = inside_125.WaitSecond_0();
            StartCoroutine(inside_125.m_Coroutine);
            Debug.Log("128��° ��������");
        }
    }
}
