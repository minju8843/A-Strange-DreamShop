using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Next_1_3_1 : MonoBehaviour
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
    public GameObject Line_20;*/
    public Fade_Collect FadeObject;//���̵� ��ũ��Ʈ �ҷ�������
    public GameObject[] inside_Line_17;
    public int Line_17_Index;

    public R_Wait1_3_1 inside_9;
    public Only_Line QuestObject;
    public IEnumerator m_Coroutine;

    public R_Wait1_4_1 inside_25;

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
    }



    IEnumerator WaitSecond_1()
    {
        yield return new WaitForSeconds(0.0f);
        //Line_1.SetActive(true);

        QuestObject.BGM_Index = 2;

        QuestObject.Audio_Object[0].gameObject.SetActive(false);
        QuestObject.Audio_Object[1].gameObject.SetActive(false);
        QuestObject.Audio_Object[2].gameObject.SetActive(true);
        QuestObject.Audio_Object[3].gameObject.SetActive(false);
        QuestObject.Audio_Object[4].gameObject.SetActive(false);

        /*QuestObject.BGM_Index = 0;

        QuestObject.Audio_Object[0].gameObject.SetActive(true);
        QuestObject.Audio_Object[1].gameObject.SetActive(false);
        QuestObject.Audio_Object[2].gameObject.SetActive(false);
        QuestObject.Audio_Object[3].gameObject.SetActive(false);
        QuestObject.Audio_Object[4].gameObject.SetActive(false);*/

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

        Line_17_Index = 0;
        inside_Line_17[0].gameObject.SetActive(true);

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

        inside_9.Line_9_Index = 0;
        inside_9.inside_Line_9[0].gameObject.SetActive(false);
        inside_9.inside_Line_9[1].gameObject.SetActive(false);
        inside_9.inside_Line_9[2].gameObject.SetActive(false);
        inside_9.inside_Line_9[3].gameObject.SetActive(false);
        inside_9.inside_Line_9[4].gameObject.SetActive(false);
        inside_9.inside_Line_9[5].gameObject.SetActive(false);
        inside_9.inside_Line_9[6].gameObject.SetActive(false);
        inside_9.inside_Line_9[7].gameObject.SetActive(false);
        inside_9.inside_Line_9[8].gameObject.SetActive(false);
        inside_9.inside_Line_9[9].gameObject.SetActive(false);
        inside_9.inside_Line_9[10].gameObject.SetActive(false);
        inside_9.inside_Line_9[11].gameObject.SetActive(false);
        inside_9.inside_Line_9[12].gameObject.SetActive(false);
        inside_9.inside_Line_9[13].gameObject.SetActive(false);
        inside_9.inside_Line_9[14].gameObject.SetActive(false);
        inside_9.inside_Line_9[15].gameObject.SetActive(false);
        inside_9.inside_Line_9[16].gameObject.SetActive(false);
        inside_9.inside_Line_9[17].gameObject.SetActive(false);
        inside_9.inside_Line_9[18].gameObject.SetActive(false);
        inside_9.inside_Line_9[19].gameObject.SetActive(false);
        inside_9.inside_Line_9[20].gameObject.SetActive(false);
        inside_9.inside_Line_9[21].gameObject.SetActive(false);
        inside_9.inside_Line_9[22].gameObject.SetActive(false);
        inside_9.inside_Line_9[23].gameObject.SetActive(false);
        inside_9.inside_Line_9[24].gameObject.SetActive(false);
        inside_9.inside_Line_9[25].gameObject.SetActive(false);
        inside_9.inside_Line_9[26].gameObject.SetActive(false);
        inside_9.inside_Line_9[27].gameObject.SetActive(false);
        inside_9.inside_Line_9[28].gameObject.SetActive(false);

        

        TextContainer1.offsetMin = new Vector2(0, -5029.503f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 21348.17f);    //(��, ��)

        
    }

    IEnumerator WaitSecond_2()
    {
        yield return new WaitForSeconds(1.5f);
        //Line_2.SetActive(true);

        Line_17_Index = 1;
        inside_Line_17[1].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -4882.698f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 21494.97f);    //(��, ��)
    }

    IEnumerator WaitSecond_3()//�Ӹ���
    {
        yield return new WaitForSeconds(3.5f);
        //Line_3.SetActive(true);

        Line_17_Index = 2;
        inside_Line_17[2].gameObject.SetActive(true);

        FadeObject.Fade_Index = 8;
        FadeObject.fadeObject[8].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_4()//�ƹ��͵� ����
    {
        yield return new WaitForSeconds(6.0f);
        //Line_3.SetActive(false);

        QuestObject.BGM_Index = 2;

        QuestObject.Audio_Object[0].gameObject.SetActive(false);
        QuestObject.Audio_Object[1].gameObject.SetActive(false);
        QuestObject.Audio_Object[2].gameObject.SetActive(true);
        QuestObject.Audio_Object[3].gameObject.SetActive(false);
        QuestObject.Audio_Object[4].gameObject.SetActive(false);

        Line_17_Index = 2;
        inside_Line_17[2].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3427.561f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 22950.11f);    //(��, ��)

    }

    IEnumerator WaitSecond_5()//�׸� ��Ÿ��
    {
        yield return new WaitForSeconds(8.0f);
        //Line_4.SetActive(true);

        Line_17_Index = 3;
        inside_Line_17[3].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -3427.561f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 22950.11f);    //(��, ��)

    }

    IEnumerator WaitSecond_6()
    {
        yield return new WaitForSeconds(9.5f);
        //Line_5.SetActive(true);

        Line_17_Index = 4;
        inside_Line_17[4].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -3427.561f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 22950.11f);    //(��, ��)

    }

    IEnumerator WaitSecond_7()
    {
        yield return new WaitForSeconds(11.0f);
        //Line_6.SetActive(true);

        Line_17_Index = 5;
        inside_Line_17[5].gameObject.SetActive(true);

        // % ������� �ٹ� ���� %

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
            //1�� �ٹ��� ���µ��� ���ߴٸ� �����Ѵ�
            All_Save.Album5_Index = 2;
            All_Save.Album_5[0].gameObject.SetActive(false);
            All_Save.Album_5[1].gameObject.SetActive(false);
            All_Save.Album_5[2].gameObject.SetActive(true);

        }

        //5 ��° �ٹ� �����Ͽ� �ڵ� ����
        PlayerPrefs.SetInt("Album_5", All_Save.Album5_Index);

        // % ������� ���� �ٹ��� ���� ��Ʈ ���� %

        //6�� �ٹ� ���� ����
        if (All_Save.Album_6[2].gameObject.activeSelf == true)
        {//�̹� 6�� �ٹ��� ���µǾ� ���� ���
            //������ �״�� �д�

            All_Save.Album6_Index = 2;
            All_Save.Album_6[0].gameObject.SetActive(false);
            All_Save.Album_6[1].gameObject.SetActive(false);
            All_Save.Album_6[2].gameObject.SetActive(true);

        }

        //6�� �ٹ��� ���µǾ� ���� ������
        else if (All_Save.Album_6[2].gameObject.activeSelf == false)
        {
            //6�� �ٹ��� ���� ��Ʈ�� �ش�
            All_Save.Album6_Index = 1;
            All_Save.Album_6[0].gameObject.SetActive(false);
            All_Save.Album_6[1].gameObject.SetActive(true);
            All_Save.Album_6[2].gameObject.SetActive(false);

        }

        //6 ��° �ٹ� �����Ͽ� �ڵ� ����
        PlayerPrefs.SetInt("Album_6", All_Save.Album6_Index);

        TextContainer1.offsetMin = new Vector2(0, -3427.561f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 22950.11f);    //(��, ��)

    }

    IEnumerator WaitSecond_8()
    {
        yield return new WaitForSeconds(12.5f);
        //Line_7.SetActive(true);

        Line_17_Index = 6;
        inside_Line_17[6].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -3288.82f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 23088.97f);    //(��, ��)

    }

    IEnumerator WaitSecond_9()
    {
        yield return new WaitForSeconds(14.0f);
        //Line_8.SetActive(true);

        Line_17_Index = 7;
        inside_Line_17[7].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -3068.139f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 23309.65f);    //(��, ��)

    }

    IEnumerator WaitSecond_10()
    {
        yield return new WaitForSeconds(15.5f);
        //Line_9.SetActive(true);

        Line_17_Index = 8;
        inside_Line_17[8].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -2850.801f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 23526.99f);    //(��, ��)

    }

    IEnumerator WaitSecond_11()
    {
        yield return new WaitForSeconds(17.0f);
        //Line_10.SetActive(true);

        Line_17_Index = 9;
        inside_Line_17[9].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -2562.066f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 23815.72f);    //(��, ��)


    }

    IEnumerator WaitSecond_12()
    {
        yield return new WaitForSeconds(18.5f);
        //Line_11.SetActive(true);

        Line_17_Index = 10;
        inside_Line_17[10].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -2252.062f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 24125.73f);    //(��, ��)



    }

    IEnumerator WaitSecond_13()//�Ӹ���
    {
        yield return new WaitForSeconds(20.5f);
        //Line_12.SetActive(true);


        Line_17_Index = 11;
        inside_Line_17[11].gameObject.SetActive(true);

    }

    IEnumerator WaitSecond_14()//�Ӹ���
    {
        yield return new WaitForSeconds(22.5f);
        //Line_13.SetActive(true);
        //Line_12.SetActive(false);

        Line_17_Index = 12;
        inside_Line_17[12].gameObject.SetActive(true);
        inside_Line_17[11].gameObject.SetActive(false);
    }

    IEnumerator WaitSecond_15()
    {
        yield return new WaitForSeconds(25.5f);
        //Line_14.SetActive(true);
        //Line_13.SetActive(false);

        Line_17_Index = 13;
        inside_Line_17[13].gameObject.SetActive(true);
        inside_Line_17[12].gameObject.SetActive(false);

        // % ������� �ٹ� ���� %

        //6�� �ٹ� ���� ����
        if (All_Save.Album_6[2].gameObject.activeSelf == true)
        {//�̹� 6�� �ٹ��� ���µǾ� ���� ���
            //������ �״�� �д�

            All_Save.Album6_Index = 2;
            All_Save.Album_6[0].gameObject.SetActive(false);
            All_Save.Album_6[1].gameObject.SetActive(false);
            All_Save.Album_6[2].gameObject.SetActive(true);

        }

        //6�� �ٹ��� ���µǾ� ���� ������
        else if (All_Save.Album_6[2].gameObject.activeSelf == false)
        {
            //6�� �ٹ��� ���µ��� ���ߴٸ� �����Ѵ�
            All_Save.Album6_Index = 2;
            All_Save.Album_6[0].gameObject.SetActive(false);
            All_Save.Album_6[1].gameObject.SetActive(false);
            All_Save.Album_6[2].gameObject.SetActive(true);

        }

        //6 ��° �ٹ� �����Ͽ� �ڵ� ����
        PlayerPrefs.SetInt("Album_6", All_Save.Album6_Index);

        // % ������� ���� �ٹ��� ���� ��Ʈ ���� %

        //7�� �ٹ� ���� ����
        if (All_Save.Album_7[2].gameObject.activeSelf == true)
        {//�̹� 7�� �ٹ��� ���µǾ� ���� ���
            //������ �״�� �д�

            All_Save.Album7_Index = 2;
            All_Save.Album_7[0].gameObject.SetActive(false);
            All_Save.Album_7[1].gameObject.SetActive(false);
            All_Save.Album_7[2].gameObject.SetActive(true);

        }

        //7�� �ٹ��� ���µǾ� ���� ������
        else if (All_Save.Album_7[2].gameObject.activeSelf == false)
        {
            //7�� �ٹ��� ���� ��Ʈ�� �ش�
            All_Save.Album7_Index = 1;
            All_Save.Album_7[0].gameObject.SetActive(false);
            All_Save.Album_7[1].gameObject.SetActive(true);
            All_Save.Album_7[2].gameObject.SetActive(false);

        }

        //7 ��° �ٹ� �����Ͽ� �ڵ� ����
        PlayerPrefs.SetInt("Album_7", All_Save.Album7_Index);

        TextContainer1.offsetMin = new Vector2(0, -1588.133f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 24819.66f);    //(��, ��)

    }

    IEnumerator WaitSecond_16()
    {
        yield return new WaitForSeconds(27.0f);
        //Line_15.SetActive(true);


        Line_17_Index = 14;
        inside_Line_17[14].gameObject.SetActive(true);
        //inside_Line_17[11].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1253.86f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 25123.93f);    //(��, ��)

    }

    IEnumerator WaitSecond_17()
    {
        yield return new WaitForSeconds(28.5f);
        //Line_16.SetActive(true);

        Line_17_Index = 15;
        inside_Line_17[15].gameObject.SetActive(true);
        //inside_Line_17[11].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -964.8379f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 25412.95f);    //(��, ��)


    }

    IEnumerator WaitSecond_18()
    {
        yield return new WaitForSeconds(30.0f);
        //Line_17.SetActive(true);

        Line_17_Index = 16;
        inside_Line_17[16].gameObject.SetActive(true);
        //inside_Line_17[11].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -814.374f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 25563.41f);    //(��, ��)


    }

    IEnumerator WaitSecond_19()
    {
        yield return new WaitForSeconds(31.5f);
        //Line_18.SetActive(true);

        Line_17_Index = 17;
        inside_Line_17[17].gameObject.SetActive(true);
        //inside_Line_17[16].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -660.5664f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 25717.22f);    //(��, ��)

    }

    IEnumerator WaitSecond_20()
    {
        yield return new WaitForSeconds(33.0f);
        //Line_19.SetActive(true);

        Line_17_Index = 18;
        inside_Line_17[18].gameObject.SetActive(true);
        //inside_Line_17[11].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -436.542f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 25941.25f);    //(��, ��)
    }

    IEnumerator WaitSecond_21()//������
    {
        yield return new WaitForSeconds(34.5f);
        //Line_20.SetActive(true);

        Line_17_Index = 19;
        inside_Line_17[19].gameObject.SetActive(true);
        //inside_Line_17[11].gameObject.SetActive(false);

        inside_25.Line_25_Index = 0;
        inside_25.inside_Line_25[0].gameObject.SetActive(false);
        inside_25.inside_Line_25[1].gameObject.SetActive(false);
        inside_25.inside_Line_25[2].gameObject.SetActive(false);
        inside_25.inside_Line_25[3].gameObject.SetActive(false);
        inside_25.inside_Line_25[4].gameObject.SetActive(false);
        inside_25.inside_Line_25[5].gameObject.SetActive(false);
        inside_25.inside_Line_25[6].gameObject.SetActive(false);
        inside_25.inside_Line_25[7].gameObject.SetActive(false);
        inside_25.inside_Line_25[8].gameObject.SetActive(false);
        inside_25.inside_Line_25[9].gameObject.SetActive(false);
        inside_25.inside_Line_25[10].gameObject.SetActive(false);
        inside_25.inside_Line_25[11].gameObject.SetActive(false);
        inside_25.inside_Line_25[12].gameObject.SetActive(false);
        inside_25.inside_Line_25[13].gameObject.SetActive(false);
        inside_25.inside_Line_25[14].gameObject.SetActive(false);
        inside_25.inside_Line_25[15].gameObject.SetActive(false);
        inside_25.inside_Line_25[16].gameObject.SetActive(false);
        inside_25.inside_Line_25[17].gameObject.SetActive(false);
        inside_25.inside_Line_25[18].gameObject.SetActive(false);
        inside_25.inside_Line_25[19].gameObject.SetActive(false);
        inside_25.inside_Line_25[20].gameObject.SetActive(false);
        inside_25.inside_Line_25[21].gameObject.SetActive(false);
        inside_25.inside_Line_25[22].gameObject.SetActive(false);
        inside_25.inside_Line_25[23].gameObject.SetActive(false);
        inside_25.inside_Line_25[24].gameObject.SetActive(false);
        inside_25.inside_Line_25[25].gameObject.SetActive(false);
        inside_25.inside_Line_25[26].gameObject.SetActive(false);
        inside_25.inside_Line_25[27].gameObject.SetActive(false);
        inside_25.inside_Line_25[28].gameObject.SetActive(false);
        inside_25.inside_Line_25[29].gameObject.SetActive(false);
        inside_25.inside_Line_25[30].gameObject.SetActive(false);
        inside_25.inside_Line_25[31].gameObject.SetActive(false);
        inside_25.inside_Line_25[32].gameObject.SetActive(false);
        inside_25.inside_Line_25[33].gameObject.SetActive(false);
        inside_25.inside_Line_25[34].gameObject.SetActive(false);
        inside_25.inside_Line_25[35].gameObject.SetActive(false);
        inside_25.inside_Line_25[36].gameObject.SetActive(false);
        inside_25.inside_Line_25[37].gameObject.SetActive(false);
        inside_25.inside_Line_25[38].gameObject.SetActive(false);
        inside_25.inside_Line_25[39].gameObject.SetActive(false);
        inside_25.inside_Line_25[40].gameObject.SetActive(false);
        inside_25.inside_Line_25[41].gameObject.SetActive(false);
        inside_25.inside_Line_25[42].gameObject.SetActive(false);
        inside_25.inside_Line_25[43].gameObject.SetActive(false);
        inside_25.inside_Line_25[44].gameObject.SetActive(false);
        inside_25.inside_Line_25[45].gameObject.SetActive(false);
        inside_25.inside_Line_25[46].gameObject.SetActive(false);
        inside_25.inside_Line_25[47].gameObject.SetActive(false);
        inside_25.inside_Line_25[48].gameObject.SetActive(false);
        inside_25.inside_Line_25[49].gameObject.SetActive(false);
        inside_25.inside_Line_25[50].gameObject.SetActive(false);
        inside_25.inside_Line_25[51].gameObject.SetActive(false);
        inside_25.inside_Line_25[52].gameObject.SetActive(false);
        inside_25.inside_Line_25[53].gameObject.SetActive(false);
        inside_25.inside_Line_25[54].gameObject.SetActive(false);
        inside_25.inside_Line_25[55].gameObject.SetActive(false);
        inside_25.inside_Line_25[56].gameObject.SetActive(false);
        inside_25.inside_Line_25[57].gameObject.SetActive(false);
        inside_25.inside_Line_25[58].gameObject.SetActive(false);
        inside_25.inside_Line_25[59].gameObject.SetActive(false);
        inside_25.inside_Line_25[60].gameObject.SetActive(false);
        inside_25.inside_Line_25[61].gameObject.SetActive(false);
        inside_25.inside_Line_25[62].gameObject.SetActive(false);
        inside_25.inside_Line_25[63].gameObject.SetActive(false);
        inside_25.inside_Line_25[64].gameObject.SetActive(false);
        inside_25.inside_Line_25[65].gameObject.SetActive(false);
        inside_25.inside_Line_25[66].gameObject.SetActive(false);
        inside_25.inside_Line_25[67].gameObject.SetActive(false);
        inside_25.inside_Line_25[68].gameObject.SetActive(false);
        inside_25.inside_Line_25[69].gameObject.SetActive(false);
        inside_25.inside_Line_25[70].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, 0.09375f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 26377.88f);    //(��, ��)


    }


}
