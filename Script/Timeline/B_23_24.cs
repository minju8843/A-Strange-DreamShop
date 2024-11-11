using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_23_24 : MonoBehaviour
{
    //public Tiket T;

    public Next_1_3_5 inside_23;
    public GameObject No_More_Ticket;
    public Only_Line questObject;

    public void Go_TwentyThree_Line()
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

            questObject.Go_TwentyThree_Line();
            inside_23.m_Coroutine = inside_23.NewCoroutine();
            StartCoroutine(inside_23.m_Coroutine);
            Debug.Log("23번째 리셋하자");

        }
    }

    public void Go_TwentyFour_Line()
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

            questObject.Go_TwentyFour_Line();
            inside_23.m_Coroutine = inside_23.NewCoroutine();
            StartCoroutine(inside_23.m_Coroutine);
            Debug.Log("24번째 리셋하자");
        }
    }
}
