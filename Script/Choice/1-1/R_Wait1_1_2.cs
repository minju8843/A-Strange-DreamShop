using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_Wait1_1_2 : MonoBehaviour
{
    public GameObject[] inside_Line_2;
    public int Line_2_Index;
    public R_Wait1 Wait1;

    public From_R_Wait1_1_2 inside_1_1_2;
    public Only_Line QuestObject;
    public IEnumerator m_Coroutine;

    /*public GameObject Line_1;
    public GameObject Line_2;
    public GameObject Line_3;
    public GameObject Line_4;
    public GameObject Line_5;
    public GameObject Go_Fourth_Line;
    public GameObject Remove_Second_Line;

    public GameObject Remove_Black_Empty;*/

    public RectTransform TextContainer1;//�ؽ�Ʈ �����̳�

    public Fade_Collect FadeObject;//���̵� ��ũ��Ʈ �ҷ�������

    //public GameObject Go_White;//���̵� �� & �ƿ�
    //public GameObject Go_Empty;//���̵� �� & �ƿ�


    void Start()
    {
        m_Coroutine = NewCoroutine();
    }


    void Update()
    {
        StartCoroutine(m_Coroutine);
    }


    public IEnumerator NewCoroutine()
    {
        //yield return StartCoroutine(WaitSecond_0());
        yield return StartCoroutine(WaitSecond_1());
        yield return StartCoroutine(WaitSecond_2());
        yield return StartCoroutine(WaitSecond_3());
        yield return StartCoroutine(WaitSecond_4());
        yield return StartCoroutine(WaitSecond_5());
        yield return StartCoroutine(WaitSecond_6());
        yield return StartCoroutine(WaitSecond_7());
        /*yield return StartCoroutine(WaitSecond_8());
        yield return StartCoroutine(WaitSecond_9());
        yield return StartCoroutine(WaitSecond_10());
        yield return StartCoroutine(WaitSecond_11());
        yield return StartCoroutine(WaitSecond_12());
        yield return StartCoroutine(WaitSecond_13());*/

    }



    IEnumerator WaitSecond_1()
    {
        yield return new WaitForSeconds(0.0f);

        Debug.Log("�ڵ� ���� �����̴�");
        PlayerPrefs.SetInt("Auto_BGM_Index", QuestObject.BGM_Index);
        PlayerPrefs.SetInt("Auto_Index", QuestObject.Line_Index);
        Debug.Log(QuestObject.Line_Index + "��° �� �ڵ� ����");
        PlayerPrefs.Save();

        //Line_1.SetActive(true);
        Line_2_Index = 0;
        inside_Line_2[0].gameObject.SetActive(true);

        //Remove_Black_Empty.SetActive(false);//���̵� �����

        FadeObject.Fade_Index = 8;

        FadeObject.fadeObject[1].gameObject.SetActive(false);
        FadeObject.fadeObject[2].gameObject.SetActive(false);
        FadeObject.fadeObject[3].gameObject.SetActive(false);
        FadeObject.fadeObject[4].gameObject.SetActive(false);
        FadeObject.fadeObject[5].gameObject.SetActive(false);
        FadeObject.fadeObject[6].gameObject.SetActive(false);
        FadeObject.fadeObject[7].gameObject.SetActive(false);
        FadeObject.fadeObject[8].gameObject.SetActive(false);
        FadeObject.fadeObject[9].gameObject.SetActive(false);
        FadeObject.fadeObject[10].gameObject.SetActive(false);
        FadeObject.fadeObject[11].gameObject.SetActive(false);
        FadeObject.fadeObject[12].gameObject.SetActive(false);
        FadeObject.fadeObject[13].gameObject.SetActive(false);
        FadeObject.fadeObject[14].gameObject.SetActive(false);

        Wait1.Line_0_Index = 0;
        Wait1.inside_Line_0[0].gameObject.SetActive(false);
        Wait1.inside_Line_0[1].gameObject.SetActive(false);
        Wait1.inside_Line_0[2].gameObject.SetActive(false);
        Wait1.inside_Line_0[3].gameObject.SetActive(false);
        Wait1.inside_Line_0[4].gameObject.SetActive(false);
        Wait1.inside_Line_0[5].gameObject.SetActive(false);
        Wait1.inside_Line_0[6].gameObject.SetActive(false);
        Wait1.inside_Line_0[7].gameObject.SetActive(false);
        Wait1.inside_Line_0[8].gameObject.SetActive(false);
        Wait1.inside_Line_0[9].gameObject.SetActive(false);
        Wait1.inside_Line_0[10].gameObject.SetActive(false);
        Wait1.inside_Line_0[11].gameObject.SetActive(false);
        Wait1.inside_Line_0[12].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -936.0183f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 2222.892f);    //(��, ��)


    }

    IEnumerator WaitSecond_2()
    {
        yield return new WaitForSeconds(1.5f);
        //Line_2.SetActive(true);
        Line_2_Index = 1;
        inside_Line_2[1].gameObject.SetActive(true);

        //Go_White.SetActive(false);//���̵� �����

        TextContainer1.offsetMin = new Vector2(0, -788.2966f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 2370.613f);    //(��, ��)
    }

    IEnumerator WaitSecond_3()
    {
        yield return new WaitForSeconds(3.0f);
        //Line_3.SetActive(true);
        Line_2_Index = 2;
        inside_Line_2[2].gameObject.SetActive(true);

        //Go_White.SetActive(false);//���̵� �����
        TextContainer1.offsetMin = new Vector2(0, -632.6558f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 2526.254f);    //(��, ��)

    }

    IEnumerator WaitSecond_4()
    {
        yield return new WaitForSeconds(4.5f);
        //Line_4.SetActive(true);

        Line_2_Index = 3;
        inside_Line_2[3].gameObject.SetActive(true);

        //Go_White.SetActive(false);//���̵� �����
        TextContainer1.offsetMin = new Vector2(0, -348.3352f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 2810.575f);    //(��, ��)

    }

    IEnumerator WaitSecond_5()
    {
        yield return new WaitForSeconds(6.0f);
        //Line_5.SetActive(true);

        Line_2_Index = 4;
        inside_Line_2[4].gameObject.SetActive(true);

        //Go_White.SetActive(false);//���̵� �����
        TextContainer1.offsetMin = new Vector2(0, 0.03540039f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 3158.949f);    //(��, ��)

    }

    IEnumerator WaitSecond_6()//���̵� ��&�ƿ� �׸��� �̵�����
    {



        yield return new WaitForSeconds(7.5f);

        //Go_White.SetActive(true);
        FadeObject.Fade_Index = 7;

        FadeObject.fadeObject[1].gameObject.SetActive(false);
        FadeObject.fadeObject[2].gameObject.SetActive(false);
        FadeObject.fadeObject[3].gameObject.SetActive(false);
        FadeObject.fadeObject[4].gameObject.SetActive(false);
        FadeObject.fadeObject[5].gameObject.SetActive(false);
        FadeObject.fadeObject[6].gameObject.SetActive(false);
        FadeObject.fadeObject[7].gameObject.SetActive(true);
        FadeObject.fadeObject[8].gameObject.SetActive(false);
        FadeObject.fadeObject[9].gameObject.SetActive(false);
        FadeObject.fadeObject[10].gameObject.SetActive(false);
        FadeObject.fadeObject[11].gameObject.SetActive(false);
        FadeObject.fadeObject[12].gameObject.SetActive(false);
        FadeObject.fadeObject[13].gameObject.SetActive(false);
        FadeObject.fadeObject[14].gameObject.SetActive(false);

    }

    //7�� ������ ������ ����
    IEnumerator WaitSecond_7()//���̵� ��&�ƿ� �׸��� �̵�����
    {



        yield return new WaitForSeconds(9.0f);

        // TextContainer1.offsetMin = new Vector2(0, -412.4721f);//(��, �Ʒ�)
        //TextContainer1.offsetMax = new Vector2(0, 1929.618f);    //(��, ��)
        //Remove_Second_Line.SetActive(false);

        QuestObject.Line_Index = 4;
        QuestObject.questObject[4].gameObject.SetActive(true);
        QuestObject.questObject[2].gameObject.SetActive(false);

        inside_1_1_2.Line_4_Index = 0;
        inside_1_1_2.inside_Line_4[0].gameObject.SetActive(false);
        inside_1_1_2.inside_Line_4[1].gameObject.SetActive(false);
        inside_1_1_2.inside_Line_4[2].gameObject.SetActive(false);
        inside_1_1_2.inside_Line_4[3].gameObject.SetActive(false);
        inside_1_1_2.inside_Line_4[4].gameObject.SetActive(false);
        inside_1_1_2.inside_Line_4[5].gameObject.SetActive(false);
        inside_1_1_2.inside_Line_4[6].gameObject.SetActive(false);

        inside_1_1_2.m_Coroutine = inside_1_1_2.NewCoroutine();
        StartCoroutine(inside_1_1_2.m_Coroutine);
        Debug.Log("From_Wait_1_1_2_��������");

        //Go_Fourth_Line.SetActive(true);


    }

    /*IEnumerator WaitSecond_8()
    {
        yield return new WaitForSeconds(12.0f);

        //TextContainer1.offsetMin = new Vector2(0, -412.4721f);//(��, �Ʒ�)
        //TextContainer1.offsetMax = new Vector2(0, 1929.618f);    //(��, ��)




        Remove_Six_Line.SetActive(false);
        Go_White.SetActive(false);
        Go_Seven_Line.SetActive(true);

    }

    /*IEnumerator WaitSecond_9()
    {
        yield return new WaitForSeconds(10.0f);
        Line_9.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0,-1732.037f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 905.7594f);    //(��, ��)

    }

    IEnumerator WaitSecond_10()
    {
        yield return new WaitForSeconds(11.0f);
        Line_10.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -1478.963f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 1158.827f);    //(��, ��)

    }

    IEnumerator WaitSecond_11()
    {
        yield return new WaitForSeconds(12.0f);
        Line_11.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -1194.642f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 1443.148f);    //(��, ��)

    }

    IEnumerator WaitSecond_12()
    {
        yield return new WaitForSeconds(13.0f);
        Line_12.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -811.6662f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 1826.124f);    //(��, -��)

    }*/

}
