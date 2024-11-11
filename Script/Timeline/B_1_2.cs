using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class B_1_2 : MonoBehaviour
{

    public GameObject No_More_Ticket;
    public Only_Line questObject;

    //티켓때문에 만들어봄
    //public Tiket T;


    public Sum_1_1_1 inside_1;
    public Sum_1_1_2 inside_2;

    public void Go_Thrid_Line()
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

            questObject.Go_Thrid_Line();
            inside_1.m_Coroutine = inside_1.NewCoroutine();
            StartCoroutine(inside_1.m_Coroutine);
            Debug.Log("1같은 3 리셋하자");

            //Line.SetActive(false);
            //Line_1.SetActive(true);

        }
        /*if (Tiket.Total < 5)
        {

            No_More_Ticket.SetActive(true);

        }
        else
        {
            Tiket.Total -= 5;
            PlayerPrefs.SetInt("Count", Tiket.Total);
            PlayerPrefs.Save();

            questObject.Go_Thrid_Line();
            inside_1.m_Coroutine = inside_1.NewCoroutine();
            StartCoroutine(inside_1.m_Coroutine);
            Debug.Log("1같은 3 리셋하자");

            //Line.SetActive(false);
            //Line_1.SetActive(true);

        }*/
    }

    public void Go_Fourth_Line()
    {
        /*if (Tiket.Total < 5)
        {


            No_More_Ticket.SetActive(true);

        }
        else
        {
            Tiket.Total -= 5;
            PlayerPrefs.SetInt("Count", Tiket.Total);
            PlayerPrefs.Save();

            // PlayerPrefs.SetInt("Ticket", Tiket.Total);
            // PlayerPrefs.Save();

            questObject.Go_Fourth_Line();
            inside_2.m_Coroutine = inside_2.NewCoroutine();
            StartCoroutine(inside_2.m_Coroutine);
            Debug.Log("2같은 4 리셋하자");


            //Line.SetActive(false);
            //Line_2.SetActive(true);

        }*/

        if (Tiket.Total < 5)
        {


            No_More_Ticket.SetActive(true);

        }
        else
        {
            Tiket.Total -= 5;
            PlayerPrefs.SetInt("Count", Tiket.Total);
            PlayerPrefs.Save();

            // PlayerPrefs.SetInt("Ticket", Tiket.Total);
            // PlayerPrefs.Save();

            questObject.Go_Fourth_Line();
            inside_2.m_Coroutine = inside_2.NewCoroutine();
            StartCoroutine(inside_2.m_Coroutine);
            Debug.Log("2같은 4 리셋하자");


            //Line.SetActive(false);
            //Line_2.SetActive(true);

        }
    }
}
