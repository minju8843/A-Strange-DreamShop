using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class R_Wait1_3_6 : MonoBehaviour
{
    public Save_Collection All_Save;
    /*public GameObject Line_1;
    public GameObject Line_2;
    public GameObject Line_3;
    public GameObject Line_4;
    public GameObject Line_5;
    public GameObject Line_6;
    public GameObject Line_7;
    public GameObject Line_8;
    public GameObject Line_9;
    public GameObject Line_10;
    public GameObject Line_11;
    public GameObject Line_12;
    public GameObject Line_13;
    public GameObject Line_14;
    public GameObject Line_15;
    public GameObject Line_16;
    public GameObject Line_17;
    public GameObject Line_18;
    public GameObject Line_19;
    public GameObject Line_20;
    public GameObject Line_21;
    public GameObject Line_22;
    public GameObject Line_23;
    public GameObject Line_24;
    public GameObject Line_25;
    public GameObject Line_26;
    public GameObject Line_27;
    public GameObject Line_28;
    public GameObject Line_29;*/
    public Fade_Collect FadeObject;//���̵� ��ũ��Ʈ �ҷ�������
    public GameObject[] inside_Line_11;
    public int Line_11_Index;
    public R_Wait1_2_1 inside_5;
    public R_Wait1_2_4 inside_8;

    public Next_1_3_6 inside_19;

    public Only_Line QuestObject;
    public IEnumerator m_Coroutine;

    public RectTransform TextContainer1;//�ؽ�Ʈ �����̳�

    //public GameObject Go_Black;//���̵� �� & �ƿ�


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

        yield return StartCoroutine(WaitSecond_1());
        yield return StartCoroutine(WaitSecond_2());
        yield return StartCoroutine(WaitSecond_3());
        yield return StartCoroutine(WaitSecond_4());
        yield return StartCoroutine(WaitSecond_5());
        yield return StartCoroutine(WaitSecond_6());
        yield return StartCoroutine(WaitSecond_7());
        yield return StartCoroutine(WaitSecond_8());
        yield return StartCoroutine(WaitSecond_9());
        yield return StartCoroutine(WaitSecond_10());
        yield return StartCoroutine(WaitSecond_11());
        yield return StartCoroutine(WaitSecond_12());
        yield return StartCoroutine(WaitSecond_13());
        yield return StartCoroutine(WaitSecond_14());
        yield return StartCoroutine(WaitSecond_15());
        yield return StartCoroutine(WaitSecond_16());
        yield return StartCoroutine(WaitSecond_17());
        yield return StartCoroutine(WaitSecond_18());
        yield return StartCoroutine(WaitSecond_19());
        yield return StartCoroutine(WaitSecond_20());
        yield return StartCoroutine(WaitSecond_21());
        yield return StartCoroutine(WaitSecond_22());
        yield return StartCoroutine(WaitSecond_23());
        yield return StartCoroutine(WaitSecond_24());
        yield return StartCoroutine(WaitSecond_25());
        yield return StartCoroutine(WaitSecond_26());
        yield return StartCoroutine(WaitSecond_27());
        yield return StartCoroutine(WaitSecond_28());
        yield return StartCoroutine(WaitSecond_29());



    }



    IEnumerator WaitSecond_1()
    {
        yield return new WaitForSeconds(0.0f);
        //Line_1.SetActive(true);

        QuestObject.BGM_Index = 3;

        QuestObject.Audio_Object[0].gameObject.SetActive(false);
        QuestObject.Audio_Object[1].gameObject.SetActive(false);
        QuestObject.Audio_Object[2].gameObject.SetActive(false);
        QuestObject.Audio_Object[3].gameObject.SetActive(true);
        QuestObject.Audio_Object[4].gameObject.SetActive(false);

        FadeObject.Fade_Index = 8;

        FadeObject.fadeObject[1].gameObject.SetActive(false);
        FadeObject.fadeObject[2].gameObject.SetActive(false);
        FadeObject.fadeObject[3].gameObject.SetActive(false);
        FadeObject.fadeObject[4].gameObject.SetActive(false);
        FadeObject.fadeObject[5].gameObject.SetActive(false);
        FadeObject.fadeObject[6].gameObject.SetActive(false);
        FadeObject.fadeObject[7].gameObject.SetActive(false);

        FadeObject.fadeObject[9].gameObject.SetActive(false);
        FadeObject.fadeObject[10].gameObject.SetActive(false);
        FadeObject.fadeObject[11].gameObject.SetActive(false);
        FadeObject.fadeObject[12].gameObject.SetActive(false);
        FadeObject.fadeObject[13].gameObject.SetActive(false);
        FadeObject.fadeObject[14].gameObject.SetActive(false);

        // *** �ڵ����� ���� ***
        PlayerPrefs.SetInt("Auto_Index", QuestObject.Line_Index);

        Line_11_Index = 0;
        inside_Line_11[0].gameObject.SetActive(true);

        //���������� ����. ���� �ƴϾ����� ���ۿ� ����
        // *** ù ��° ������ �ٹ� ��Ʈ �����ֱ� ***

        if (All_Save.Achieve_1[2].gameObject.activeSelf == true)
        {
            All_Save.Achieve1_Index = 2;
            All_Save.Achieve_1[0].gameObject.SetActive(false);
            All_Save.Achieve_1[1].gameObject.SetActive(false);
            All_Save.Achieve_1[2].gameObject.SetActive(true);
        }
        else
        {
            All_Save.Achieve1_Index = 1;
            All_Save.Achieve_1[0].gameObject.SetActive(false);
            All_Save.Achieve_1[1].gameObject.SetActive(true);
            All_Save.Achieve_1[2].gameObject.SetActive(false);
        }

        // *** ������ �ٹ� ������ �� �ڵ����� ***
        PlayerPrefs.SetInt("Achieve_1", All_Save.Achieve1_Index);

        //Go_Black.SetActive(false);//���̵� �����

        TextContainer1.offsetMin = new Vector2(0, -5639.79f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 16543.36f);    //(��, ��)

        inside_5.Line_5_Index = 0;
        inside_5.inside_Line_5[0].gameObject.SetActive(false);
        inside_5.inside_Line_5[1].gameObject.SetActive(false);
        inside_5.inside_Line_5[2].gameObject.SetActive(false);
        inside_5.inside_Line_5[3].gameObject.SetActive(false);
        inside_5.inside_Line_5[4].gameObject.SetActive(false);
        inside_5.inside_Line_5[5].gameObject.SetActive(false);
        inside_5.inside_Line_5[6].gameObject.SetActive(false);
        inside_5.inside_Line_5[7].gameObject.SetActive(false);
        inside_5.inside_Line_5[8].gameObject.SetActive(false);
        inside_5.inside_Line_5[9].gameObject.SetActive(false);
        inside_5.inside_Line_5[10].gameObject.SetActive(false);
        inside_5.inside_Line_5[11].gameObject.SetActive(false);
        inside_5.inside_Line_5[12].gameObject.SetActive(false);
        inside_5.inside_Line_5[13].gameObject.SetActive(false);
        inside_5.inside_Line_5[14].gameObject.SetActive(false);
        inside_5.inside_Line_5[15].gameObject.SetActive(false);
        inside_5.inside_Line_5[16].gameObject.SetActive(false);
        inside_5.inside_Line_5[17].gameObject.SetActive(false);
        inside_5.inside_Line_5[18].gameObject.SetActive(false);
        inside_5.inside_Line_5[19].gameObject.SetActive(false);
        inside_5.inside_Line_5[20].gameObject.SetActive(false);
        inside_5.inside_Line_5[21].gameObject.SetActive(false);
        inside_5.inside_Line_5[22].gameObject.SetActive(false);
        inside_5.inside_Line_5[23].gameObject.SetActive(false);
        inside_5.inside_Line_5[24].gameObject.SetActive(false);
        inside_5.inside_Line_5[25].gameObject.SetActive(false);
        inside_5.inside_Line_5[26].gameObject.SetActive(false);
        inside_5.inside_Line_5[27].gameObject.SetActive(false);
        inside_5.inside_Line_5[28].gameObject.SetActive(false);
        inside_5.inside_Line_5[29].gameObject.SetActive(false);
        inside_5.inside_Line_5[30].gameObject.SetActive(false);
        inside_5.inside_Line_5[31].gameObject.SetActive(false);
        inside_5.inside_Line_5[32].gameObject.SetActive(false);
        inside_5.inside_Line_5[33].gameObject.SetActive(false);
        inside_5.inside_Line_5[34].gameObject.SetActive(false);
        inside_5.inside_Line_5[35].gameObject.SetActive(false);
        inside_5.inside_Line_5[36].gameObject.SetActive(false);
        inside_5.inside_Line_5[37].gameObject.SetActive(false);
        inside_5.inside_Line_5[38].gameObject.SetActive(false);
        inside_5.inside_Line_5[39].gameObject.SetActive(false);
        inside_5.inside_Line_5[40].gameObject.SetActive(false);
        inside_5.inside_Line_5[41].gameObject.SetActive(false);

        inside_8.Line_8_Index = 0;
        inside_8.inside_Line_8[0].gameObject.SetActive(false);
        inside_8.inside_Line_8[1].gameObject.SetActive(false);
        inside_8.inside_Line_8[2].gameObject.SetActive(false);
        inside_8.inside_Line_8[3].gameObject.SetActive(false);
        inside_8.inside_Line_8[4].gameObject.SetActive(false);
        inside_8.inside_Line_8[5].gameObject.SetActive(false);
        inside_8.inside_Line_8[6].gameObject.SetActive(false);
        inside_8.inside_Line_8[7].gameObject.SetActive(false);
        inside_8.inside_Line_8[8].gameObject.SetActive(false);
        inside_8.inside_Line_8[9].gameObject.SetActive(false);
        inside_8.inside_Line_8[10].gameObject.SetActive(false);
        inside_8.inside_Line_8[11].gameObject.SetActive(false);
        inside_8.inside_Line_8[12].gameObject.SetActive(false);
        inside_8.inside_Line_8[13].gameObject.SetActive(false);
        inside_8.inside_Line_8[14].gameObject.SetActive(false);
        inside_8.inside_Line_8[15].gameObject.SetActive(false);
        inside_8.inside_Line_8[16].gameObject.SetActive(false);
        inside_8.inside_Line_8[17].gameObject.SetActive(false);
        inside_8.inside_Line_8[18].gameObject.SetActive(false);
        inside_8.inside_Line_8[19].gameObject.SetActive(false);
        inside_8.inside_Line_8[20].gameObject.SetActive(false);
        inside_8.inside_Line_8[21].gameObject.SetActive(false);
        inside_8.inside_Line_8[22].gameObject.SetActive(false);
        inside_8.inside_Line_8[23].gameObject.SetActive(false);
        inside_8.inside_Line_8[24].gameObject.SetActive(false);
        inside_8.inside_Line_8[25].gameObject.SetActive(false);
        inside_8.inside_Line_8[26].gameObject.SetActive(false);
        inside_8.inside_Line_8[27].gameObject.SetActive(false);
        inside_8.inside_Line_8[28].gameObject.SetActive(false);
        inside_8.inside_Line_8[29].gameObject.SetActive(false);
        inside_8.inside_Line_8[30].gameObject.SetActive(false);
        inside_8.inside_Line_8[31].gameObject.SetActive(false);
        inside_8.inside_Line_8[32].gameObject.SetActive(false);
        inside_8.inside_Line_8[33].gameObject.SetActive(false);
        inside_8.inside_Line_8[34].gameObject.SetActive(false);
        inside_8.inside_Line_8[35].gameObject.SetActive(false);
        inside_8.inside_Line_8[36].gameObject.SetActive(false);
        inside_8.inside_Line_8[37].gameObject.SetActive(false);
        inside_8.inside_Line_8[38].gameObject.SetActive(false);
        inside_8.inside_Line_8[39].gameObject.SetActive(false);
        inside_8.inside_Line_8[40].gameObject.SetActive(false);
        inside_8.inside_Line_8[41].gameObject.SetActive(false);
        inside_8.inside_Line_8[42].gameObject.SetActive(false);
        inside_8.inside_Line_8[43].gameObject.SetActive(false);
        inside_8.inside_Line_8[44].gameObject.SetActive(false);

       
    }

    IEnumerator WaitSecond_2()
    {
        yield return new WaitForSeconds(1.5f);
        //Line_2.SetActive(true);


        Line_11_Index = 1;
        inside_Line_11[1].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -5486.48f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 16696.67f);    //(��, ��)
    }

    IEnumerator WaitSecond_3()
    {
        yield return new WaitForSeconds(3.0f);
        //Line_3.SetActive(true);

        Line_11_Index = 2;
        inside_Line_11[2].gameObject.SetActive(true);

        FadeObject.Fade_Index = 8;
        FadeObject.fadeObject[8].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5263.483f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 16919.67f);    //(��, ��)

    }

    IEnumerator WaitSecond_4()
    {
        yield return new WaitForSeconds(4.5f);
        //Line_4.SetActive(true);

        Line_11_Index = 3;
        inside_Line_11[3].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -4973.588f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 17209.56f);    //(��, ��)

    }

    IEnumerator WaitSecond_5()
    {
        yield return new WaitForSeconds(6.0f);
        //Line_5.SetActive(true);

        Line_11_Index = 4;
        inside_Line_11[4].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -4693.643f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 17489.51f);    //(��, ��)

    }

    IEnumerator WaitSecond_6()
    {
        yield return new WaitForSeconds(7.5f);
        //Line_6.SetActive(true);

        Line_11_Index = 5;
        inside_Line_11[5].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -4401.802f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 17781.35f);    //(��, ��)

    }

    IEnumerator WaitSecond_7()
    {
        yield return new WaitForSeconds(9.0f);
        //Line_7.SetActive(true);

        Line_11_Index = 6;
        inside_Line_11[6].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -4248.492f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 17934.66f);    //(��, ��)

    }

    IEnumerator WaitSecond_8()
    {
        yield return new WaitForSeconds(10.5f);
        //Line_8.SetActive(true);

        Line_11_Index = 7;
        inside_Line_11[7].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -3961.384f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 18221.77f);    //(��, ��)

    }

    IEnumerator WaitSecond_9()
    {
        yield return new WaitForSeconds(12.0f);
        //Line_9.SetActive(true);

        Line_11_Index = 8;
        inside_Line_11[8].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -3649.188f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 18533.96f);    //(��, ��)

    }

    IEnumerator WaitSecond_10()//�Ӹ���
    {
        yield return new WaitForSeconds(14.0f);
        //Line_10.SetActive(true);//�Ӹ���1


        Line_11_Index = 9;
        inside_Line_11[9].gameObject.SetActive(true);

    }

    IEnumerator WaitSecond_11()//�Ӹ���1 ���ֱ�
    {
        yield return new WaitForSeconds(18.0f);
        //Line_10.SetActive(false);//�Ӹ���1 ���ֱ�
        //Line_11.SetActive(true);

        QuestObject.BGM_Index = 0;

        QuestObject.Audio_Object[0].gameObject.SetActive(true);
        QuestObject.Audio_Object[1].gameObject.SetActive(false);
        QuestObject.Audio_Object[2].gameObject.SetActive(false);
        QuestObject.Audio_Object[3].gameObject.SetActive(false);
        QuestObject.Audio_Object[4].gameObject.SetActive(false);

        Line_11_Index = 10;
        inside_Line_11[10].gameObject.SetActive(true);
        inside_Line_11[9].gameObject.SetActive(false);




        TextContainer1.offsetMin = new Vector2(0, -2944.915f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 19238.23f);    //(��, ��)

    }

    IEnumerator WaitSecond_12()//11
    {
        yield return new WaitForSeconds(19.5f);
        //Line_12.SetActive(true);

        Line_11_Index = 11;
        inside_Line_11[11].gameObject.SetActive(true);
        //inside_Line_11[9].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2655.02f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 19528.13f);    //(��, ��)

    }

    IEnumerator WaitSecond_13()//�Ӹ���
    {
        yield return new WaitForSeconds(21.5f);
        //Line_13.SetActive(true);

        Line_11_Index = 12;
        inside_Line_11[12].gameObject.SetActive(true);
        //inside_Line_11[9].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_14()//13
    {
        yield return new WaitForSeconds(23.5f);
        //Line_14.SetActive(true);
        //Line_13.SetActive(false);

        Line_11_Index = 13;
        inside_Line_11[13].gameObject.SetActive(true);
        inside_Line_11[12].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2368.464f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 19814.69f);    //(��, ��)

    }

    IEnumerator WaitSecond_15()//14
    {
        yield return new WaitForSeconds(25.0f);
        //Line_15.SetActive(true);

        Line_11_Index = 14;
        inside_Line_11[14].gameObject.SetActive(true);
        //inside_Line_11[9].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2070.206f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 20112.95f);    //(��, ��)

    }

    IEnumerator WaitSecond_16()//�Ӹ���
    {
        yield return new WaitForSeconds(27.0f);
        //Line_16.SetActive(true);

        Line_11_Index = 15;
        inside_Line_11[15].gameObject.SetActive(true);
        //inside_Line_11[9].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_17()
    {
        yield return new WaitForSeconds(30.5f);//�Ӹ���
        //Line_17.SetActive(true);
        //Line_16.SetActive(false);


        Line_11_Index = 16;
        inside_Line_11[16].gameObject.SetActive(true);
        inside_Line_11[15].gameObject.SetActive(false);
    }

    IEnumerator WaitSecond_18()//15
    {
        yield return new WaitForSeconds(32.5f);
        //Line_17.SetActive(false);
        //Line_18.SetActive(true);

        Line_11_Index = 17;
        inside_Line_11[17].gameObject.SetActive(true);
        inside_Line_11[16].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1855.572f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 20327.58f);    //(��, -��)

    }

    IEnumerator WaitSecond_19()//15
    {
        yield return new WaitForSeconds(34.0f);
        //Line_19.SetActive(true);


        Line_11_Index = 18;
        inside_Line_11[18].gameObject.SetActive(true);
        //inside_Line_11[9].gameObject.SetActive(false);
        TextContainer1.offsetMin = new Vector2(0, -1532.4f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 20650.75f);    //(��, -��)

    }

    IEnumerator WaitSecond_20()//�Ӹ���
    {
        yield return new WaitForSeconds(36.0f);
        //Line_20.SetActive(true);


        Line_11_Index = 19;
        inside_Line_11[19].gameObject.SetActive(true);
        //inside_Line_11[9].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_21()//15
    {
        yield return new WaitForSeconds(39.5f);
        //Line_20.SetActive(false);
        //Line_21.SetActive(true);

        Line_11_Index = 20;
        inside_Line_11[20].gameObject.SetActive(true);
        inside_Line_11[19].gameObject.SetActive(false);

        // % ������� �ٹ� ���� %

        //3�� �ٹ� ���� ����
        if (All_Save.Album_3[2].gameObject.activeSelf == true)
        {//�̹� 3�� �ٹ��� ���µǾ� ���� ���
            //������ �״�� �д�

            All_Save.Album3_Index = 2;
            All_Save.Album_3[0].gameObject.SetActive(false);
            All_Save.Album_3[1].gameObject.SetActive(false);
            All_Save.Album_3[2].gameObject.SetActive(true);

        }

        //3�� �ٹ��� ���µǾ� ���� ������
        else if (All_Save.Album_3[2].gameObject.activeSelf == false)
        {
            //2�� �ٹ��� ���µ��� ���ߴٸ� �����Ѵ�
            All_Save.Album3_Index = 2;
            All_Save.Album_3[0].gameObject.SetActive(false);
            All_Save.Album_3[1].gameObject.SetActive(false);
            All_Save.Album_3[2].gameObject.SetActive(true);

        }

        //3 ��° �ٹ� �����Ͽ� �ڵ� ����
        PlayerPrefs.SetInt("Album_3", All_Save.Album3_Index);

        // % ������� ���� �ٹ��� ���� ��Ʈ ���� %

        //4�� �ٹ� ���� ����
        if (All_Save.Album_4[2].gameObject.activeSelf == true)
        {//�̹� 4�� �ٹ��� ���µǾ� ���� ���
            //������ �״�� �д�

            All_Save.Album4_Index = 2;
            All_Save.Album_4[0].gameObject.SetActive(false);
            All_Save.Album_4[1].gameObject.SetActive(false);
            All_Save.Album_4[2].gameObject.SetActive(true);

        }

        //4�� �ٹ��� ���µǾ� ���� ������
        else if (All_Save.Album_4[2].gameObject.activeSelf == false)
        {
            //4�� �ٹ��� ���� ��Ʈ�� �ش�
            All_Save.Album4_Index = 1;
            All_Save.Album_4[0].gameObject.SetActive(false);
            All_Save.Album_4[1].gameObject.SetActive(true);
            All_Save.Album_4[2].gameObject.SetActive(false);

        }

        //4 ��° �ٹ� �����Ͽ� �ڵ� ����
        PlayerPrefs.SetInt("Album_4", All_Save.Album4_Index);

        //5�� �ٹ� ���� ����
        if (All_Save.Album_5[2].gameObject.activeSelf == true)
        {//�̹� 5�� �ٹ��� ���µǾ� ���� ���
            //������ �״�� �д�

            All_Save.Album5_Index = 2;
            All_Save.Album_5[0].gameObject.SetActive(false);
            All_Save.Album_5[1].gameObject.SetActive(false);
            All_Save.Album_5[2].gameObject.SetActive(true);

        }

        //5�� �ٹ��� ���µǾ� ���� ������
        else if (All_Save.Album_5[2].gameObject.activeSelf == false)
        {
            //5�� �ٹ��� ���� ��Ʈ�� �ش�
            All_Save.Album5_Index = 1;
            All_Save.Album_5[0].gameObject.SetActive(false);
            All_Save.Album_5[1].gameObject.SetActive(true);
            All_Save.Album_5[2].gameObject.SetActive(false);

        }

        //5 ��° �ٹ� �����Ͽ� �ڵ� ����
        PlayerPrefs.SetInt("Album_5", All_Save.Album5_Index);

        TextContainer1.offsetMin = new Vector2(0, -839.8262f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 21343.32f);    //(��, -��)

    }

    IEnumerator WaitSecond_22()//�Ӹ���
    {
        yield return new WaitForSeconds(41.0f);
        //Line_22.SetActive(true);

        Line_11_Index = 21;
        inside_Line_11[21].gameObject.SetActive(true);
        //inside_Line_11[19].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_23()//�Ӹ���
    {
        yield return new WaitForSeconds(43.0f);
        //Line_22.SetActive(false);
        //Line_23.SetActive(true);

        Line_11_Index = 22;
        inside_Line_11[22].gameObject.SetActive(true);
        inside_Line_11[21].gameObject.SetActive(false);
    }

    IEnumerator WaitSecond_24()//15
    {
        yield return new WaitForSeconds(45.0f);
        //Line_24.SetActive(true);
        //Line_23.SetActive(false);

        Line_11_Index = 23;
        inside_Line_11[23].gameObject.SetActive(true);
        inside_Line_11[22].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -548.1436f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 21635.01f);    //(��, -��)

    }

    IEnumerator WaitSecond_25()//15
    {
        yield return new WaitForSeconds(46.5f);
        //Line_25.SetActive(true);

        Line_11_Index = 24;
        inside_Line_11[24].gameObject.SetActive(true);
        //inside_Line_11[19].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -243.5781f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 21939.57f);    //(��, -��)

    }

    IEnumerator WaitSecond_26()//�Ӹ���
    {
        yield return new WaitForSeconds(48.5f);
        //Line_26.SetActive(true);
        Line_11_Index = 25;
        inside_Line_11[25].gameObject.SetActive(true);
        //inside_Line_11[19].gameObject.SetActive(false);
    }

    IEnumerator WaitSecond_27()//�Ӹ���
    {
        yield return new WaitForSeconds(51.0f);
        // Line_27.SetActive(true);
        //Line_26.SetActive(false);

        Line_11_Index = 26;
        inside_Line_11[26].gameObject.SetActive(true);
        inside_Line_11[25].gameObject.SetActive(false);
    }

    IEnumerator WaitSecond_28()//�Ӹ���
    {
        yield return new WaitForSeconds(53.0f);
        //Line_28.SetActive(true);
        //Line_27.SetActive(false);

        Line_11_Index = 27;
        inside_Line_11[27].gameObject.SetActive(true);
        inside_Line_11[26].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_29()//15
    {
        yield return new WaitForSeconds(55.0f);
        //Line_29.SetActive(true);
        //Line_28.SetActive(false);

        Line_11_Index = 28;
        inside_Line_11[28].gameObject.SetActive(true);
        inside_Line_11[27].gameObject.SetActive(false);

        inside_19.Line_19_Index = 0;
        inside_19.inside_Line_19[0].gameObject.SetActive(false);
        inside_19.inside_Line_19[1].gameObject.SetActive(false);
        inside_19.inside_Line_19[2].gameObject.SetActive(false);
        inside_19.inside_Line_19[3].gameObject.SetActive(false);
        inside_19.inside_Line_19[4].gameObject.SetActive(false);
        inside_19.inside_Line_19[5].gameObject.SetActive(false);
        inside_19.inside_Line_19[6].gameObject.SetActive(false);
        inside_19.inside_Line_19[7].gameObject.SetActive(false);
        inside_19.inside_Line_19[8].gameObject.SetActive(false);
        inside_19.inside_Line_19[9].gameObject.SetActive(false);
        inside_19.inside_Line_19[10].gameObject.SetActive(false);
        inside_19.inside_Line_19[11].gameObject.SetActive(false);
        inside_19.inside_Line_19[12].gameObject.SetActive(false);
        inside_19.inside_Line_19[13].gameObject.SetActive(false);
        inside_19.inside_Line_19[14].gameObject.SetActive(false);
        inside_19.inside_Line_19[15].gameObject.SetActive(false);
        inside_19.inside_Line_19[16].gameObject.SetActive(false);
        inside_19.inside_Line_19[17].gameObject.SetActive(false);
        inside_19.inside_Line_19[18].gameObject.SetActive(false);
        inside_19.inside_Line_19[19].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, 0.04980469f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 22183.2f);    //(��, -��)

    }

}
