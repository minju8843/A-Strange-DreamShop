using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Next_1_3_2 : MonoBehaviour
{
    public Save_Collection All_Save;
    public Fade_Collect FadeObject;//���̵� ��ũ��Ʈ �ҷ�������
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
    public GameObject Line_18;*/

    public GameObject[] inside_Line_21;
    public int Line_21_Index;

    public R_Wait1_4_3 inside_29;

    public R_Wait1_3_2 inside_13;
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
    }




    IEnumerator WaitSecond_1()//�Ӹ���
    {
        yield return new WaitForSeconds(0.0f);
        //Line_1.SetActive(true);

        /*QuestObject.BGM_Index = 0;

        QuestObject.Audio_Object[0].gameObject.SetActive(true);
        QuestObject.Audio_Object[1].gameObject.SetActive(false);
        QuestObject.Audio_Object[2].gameObject.SetActive(false);
        QuestObject.Audio_Object[3].gameObject.SetActive(false);
        QuestObject.Audio_Object[4].gameObject.SetActive(false);*/

        QuestObject.BGM_Index = 2;

        QuestObject.Audio_Object[0].gameObject.SetActive(false);
        QuestObject.Audio_Object[1].gameObject.SetActive(false);
        QuestObject.Audio_Object[2].gameObject.SetActive(true);
        QuestObject.Audio_Object[3].gameObject.SetActive(false);
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

        Line_21_Index = 0;
        inside_Line_21[0].gameObject.SetActive(true);
        //inside_Line_21[21].gameObject.SetActive(false);

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

        inside_13.Line_13_Index = 0;
        inside_13.inside_Line_13[0].gameObject.SetActive(false);
        inside_13.inside_Line_13[1].gameObject.SetActive(false);
        inside_13.inside_Line_13[2].gameObject.SetActive(false);
        inside_13.inside_Line_13[3].gameObject.SetActive(false);
        inside_13.inside_Line_13[4].gameObject.SetActive(false);
        inside_13.inside_Line_13[5].gameObject.SetActive(false);
        inside_13.inside_Line_13[6].gameObject.SetActive(false);
        inside_13.inside_Line_13[7].gameObject.SetActive(false);
        inside_13.inside_Line_13[8].gameObject.SetActive(false);
        inside_13.inside_Line_13[9].gameObject.SetActive(false);
        inside_13.inside_Line_13[10].gameObject.SetActive(false);
        inside_13.inside_Line_13[11].gameObject.SetActive(false);
        inside_13.inside_Line_13[12].gameObject.SetActive(false);
        inside_13.inside_Line_13[13].gameObject.SetActive(false);
        inside_13.inside_Line_13[14].gameObject.SetActive(false);
        inside_13.inside_Line_13[15].gameObject.SetActive(false);
        inside_13.inside_Line_13[16].gameObject.SetActive(false);
        inside_13.inside_Line_13[17].gameObject.SetActive(false);
        inside_13.inside_Line_13[18].gameObject.SetActive(false);
        inside_13.inside_Line_13[19].gameObject.SetActive(false);
        inside_13.inside_Line_13[20].gameObject.SetActive(false);
        inside_13.inside_Line_13[21].gameObject.SetActive(false);
        inside_13.inside_Line_13[22].gameObject.SetActive(false);

       /* QuestObject.Line_Index = 21;

        QuestObject.questObject[0].gameObject.SetActive(false);
        QuestObject.questObject[1].gameObject.SetActive(false);
        QuestObject.questObject[2].gameObject.SetActive(false);
        QuestObject.questObject[3].gameObject.SetActive(false);
        QuestObject.questObject[4].gameObject.SetActive(false);
        QuestObject.questObject[5].gameObject.SetActive(false);
        QuestObject.questObject[6].gameObject.SetActive(false);
        QuestObject.questObject[7].gameObject.SetActive(false);
        QuestObject.questObject[8].gameObject.SetActive(false);
        QuestObject.questObject[9].gameObject.SetActive(false);
        QuestObject.questObject[10].gameObject.SetActive(false);
        QuestObject.questObject[11].gameObject.SetActive(false);
        QuestObject.questObject[12].gameObject.SetActive(false);
        QuestObject.questObject[13].gameObject.SetActive(false);
        QuestObject.questObject[14].gameObject.SetActive(false);
        QuestObject.questObject[15].gameObject.SetActive(false);
        QuestObject.questObject[16].gameObject.SetActive(false);
        QuestObject.questObject[17].gameObject.SetActive(false);
        QuestObject.questObject[18].gameObject.SetActive(false);
        QuestObject.questObject[19].gameObject.SetActive(false);
        QuestObject.questObject[20].gameObject.SetActive(false);
       
        QuestObject.questObject[23].gameObject.SetActive(false);
        QuestObject.questObject[24].gameObject.SetActive(false);
        QuestObject.questObject[25].gameObject.SetActive(false);
        QuestObject.questObject[26].gameObject.SetActive(false);
        QuestObject.questObject[27].gameObject.SetActive(false);
        QuestObject.questObject[28].gameObject.SetActive(false);
        QuestObject.questObject[29].gameObject.SetActive(false);
        QuestObject.questObject[30].gameObject.SetActive(false);
        QuestObject.questObject[31].gameObject.SetActive(false);
        QuestObject.questObject[32].gameObject.SetActive(false);
        QuestObject.questObject[33].gameObject.SetActive(false);
        QuestObject.questObject[34].gameObject.SetActive(false);
        QuestObject.questObject[35].gameObject.SetActive(false);
        QuestObject.questObject[36].gameObject.SetActive(false);
        QuestObject.questObject[37].gameObject.SetActive(false);
        QuestObject.questObject[38].gameObject.SetActive(false);
        QuestObject.questObject[39].gameObject.SetActive(false);
        QuestObject.questObject[40].gameObject.SetActive(false);
        QuestObject.questObject[41].gameObject.SetActive(false);
        QuestObject.questObject[42].gameObject.SetActive(false);
        QuestObject.questObject[43].gameObject.SetActive(false);
        QuestObject.questObject[44].gameObject.SetActive(false);
        QuestObject.questObject[45].gameObject.SetActive(false);
        QuestObject.questObject[46].gameObject.SetActive(false);
        QuestObject.questObject[47].gameObject.SetActive(false);
        QuestObject.questObject[48].gameObject.SetActive(false);
        QuestObject.questObject[49].gameObject.SetActive(false);
        QuestObject.questObject[50].gameObject.SetActive(false);
        QuestObject.questObject[51].gameObject.SetActive(false);
        QuestObject.questObject[52].gameObject.SetActive(false);
        QuestObject.questObject[53].gameObject.SetActive(false);
        QuestObject.questObject[54].gameObject.SetActive(false);
        QuestObject.questObject[55].gameObject.SetActive(false);
        QuestObject.questObject[56].gameObject.SetActive(false);
        QuestObject.questObject[57].gameObject.SetActive(false);
        QuestObject.questObject[58].gameObject.SetActive(false);
        QuestObject.questObject[59].gameObject.SetActive(false);
        QuestObject.questObject[60].gameObject.SetActive(false);
        QuestObject.questObject[61].gameObject.SetActive(false);
        QuestObject.questObject[62].gameObject.SetActive(false);
        QuestObject.questObject[63].gameObject.SetActive(false);
        QuestObject.questObject[64].gameObject.SetActive(false);
        QuestObject.questObject[65].gameObject.SetActive(false);
        QuestObject.questObject[66].gameObject.SetActive(false);
        QuestObject.questObject[67].gameObject.SetActive(false);
        QuestObject.questObject[68].gameObject.SetActive(false);
        QuestObject.questObject[69].gameObject.SetActive(false);
        QuestObject.questObject[70].gameObject.SetActive(false);
        QuestObject.questObject[71].gameObject.SetActive(false);
        QuestObject.questObject[72].gameObject.SetActive(false);
        QuestObject.questObject[73].gameObject.SetActive(false);
        QuestObject.questObject[74].gameObject.SetActive(false);
        QuestObject.questObject[75].gameObject.SetActive(false);
        QuestObject.questObject[76].gameObject.SetActive(false);
        QuestObject.questObject[77].gameObject.SetActive(false);
        QuestObject.questObject[78].gameObject.SetActive(false);
        QuestObject.questObject[79].gameObject.SetActive(false);
        QuestObject.questObject[80].gameObject.SetActive(false);
        QuestObject.questObject[81].gameObject.SetActive(false);
        QuestObject.questObject[82].gameObject.SetActive(false);
        QuestObject.questObject[83].gameObject.SetActive(false);
        QuestObject.questObject[84].gameObject.SetActive(false);
        QuestObject.questObject[85].gameObject.SetActive(false);
        QuestObject.questObject[86].gameObject.SetActive(false);
        QuestObject.questObject[87].gameObject.SetActive(false);
        QuestObject.questObject[88].gameObject.SetActive(false);
        QuestObject.questObject[89].gameObject.SetActive(false);
        QuestObject.questObject[90].gameObject.SetActive(false);
        QuestObject.questObject[91].gameObject.SetActive(false);
        QuestObject.questObject[92].gameObject.SetActive(false);
        QuestObject.questObject[93].gameObject.SetActive(false);
        QuestObject.questObject[94].gameObject.SetActive(false);
        QuestObject.questObject[95].gameObject.SetActive(false);
        QuestObject.questObject[96].gameObject.SetActive(false);
        QuestObject.questObject[97].gameObject.SetActive(false);
        QuestObject.questObject[98].gameObject.SetActive(false);
        QuestObject.questObject[99].gameObject.SetActive(false);
        QuestObject.questObject[100].gameObject.SetActive(false);
        QuestObject.questObject[101].gameObject.SetActive(false);
        QuestObject.questObject[102].gameObject.SetActive(false);
        QuestObject.questObject[103].gameObject.SetActive(false);
        QuestObject.questObject[104].gameObject.SetActive(false);
        QuestObject.questObject[105].gameObject.SetActive(false);
        QuestObject.questObject[106].gameObject.SetActive(false);
        QuestObject.questObject[107].gameObject.SetActive(false);
        QuestObject.questObject[108].gameObject.SetActive(false);
        QuestObject.questObject[109].gameObject.SetActive(false);
        QuestObject.questObject[110].gameObject.SetActive(false);
        QuestObject.questObject[111].gameObject.SetActive(false);
        QuestObject.questObject[112].gameObject.SetActive(false);
        QuestObject.questObject[113].gameObject.SetActive(false);
        QuestObject.questObject[114].gameObject.SetActive(false);
        QuestObject.questObject[115].gameObject.SetActive(false);
        QuestObject.questObject[116].gameObject.SetActive(false);
        QuestObject.questObject[117].gameObject.SetActive(false);
        QuestObject.questObject[118].gameObject.SetActive(false);
        QuestObject.questObject[119].gameObject.SetActive(false);
        QuestObject.questObject[120].gameObject.SetActive(false);
        QuestObject.questObject[121].gameObject.SetActive(false);
        QuestObject.questObject[122].gameObject.SetActive(false);
        QuestObject.questObject[123].gameObject.SetActive(false);
        QuestObject.questObject[124].gameObject.SetActive(false);
        QuestObject.questObject[125].gameObject.SetActive(false);
        QuestObject.questObject[126].gameObject.SetActive(false);
        QuestObject.questObject[127].gameObject.SetActive(false);
        QuestObject.questObject[128].gameObject.SetActive(false);
        QuestObject.questObject[129].gameObject.SetActive(false);
        QuestObject.questObject[130].gameObject.SetActive(false);
        QuestObject.questObject[131].gameObject.SetActive(false);
        QuestObject.questObject[132].gameObject.SetActive(false);
        QuestObject.questObject[133].gameObject.SetActive(false);
        QuestObject.questObject[134].gameObject.SetActive(false);
        QuestObject.questObject[135].gameObject.SetActive(false);
        QuestObject.questObject[136].gameObject.SetActive(false);
        QuestObject.questObject[137].gameObject.SetActive(false);
        QuestObject.questObject[138].gameObject.SetActive(false);
        QuestObject.questObject[139].gameObject.SetActive(false);
        QuestObject.questObject[140].gameObject.SetActive(false);
        QuestObject.questObject[141].gameObject.SetActive(false);
        QuestObject.questObject[142].gameObject.SetActive(false);
        QuestObject.questObject[143].gameObject.SetActive(false);
        QuestObject.questObject[144].gameObject.SetActive(false);
        QuestObject.questObject[145].gameObject.SetActive(false);
        QuestObject.questObject[146].gameObject.SetActive(false);*/

        TextContainer1.offsetMin = new Vector2(0, -4876.409f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 20209.75f);


    }

    IEnumerator WaitSecond_2()//�ƹ��͵� ����
    {
        yield return new WaitForSeconds(2.5f);
        //Line_1.SetActive(false);
        Line_21_Index = 0;
        inside_Line_21[0].gameObject.SetActive(false);

        QuestObject.BGM_Index = 2;

        QuestObject.Audio_Object[0].gameObject.SetActive(false);
        QuestObject.Audio_Object[1].gameObject.SetActive(false);
        QuestObject.Audio_Object[2].gameObject.SetActive(true);
        QuestObject.Audio_Object[3].gameObject.SetActive(false);
        QuestObject.Audio_Object[4].gameObject.SetActive(false);

        //inside_Line_21[21].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -3419.696f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 21666.46f);    //(��, ��)
    }

    IEnumerator WaitSecond_3()//�׸� ��Ÿ��
    {
        yield return new WaitForSeconds(4.5f);
        //Line_2.SetActive(true);

        Line_21_Index = 1;
        inside_Line_21[1].gameObject.SetActive(true);

        FadeObject.Fade_Index = 8;
        FadeObject.fadeObject[8].gameObject.SetActive(false);
        //inside_Line_21[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3419.696f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 21666.46f);    //(��, ��)

    }

    IEnumerator WaitSecond_4()
    {
        yield return new WaitForSeconds(6.0f);
        //Line_3.SetActive(true);

        Line_21_Index = 2;
        inside_Line_21[2].gameObject.SetActive(true);
        //inside_Line_21[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3419.696f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 21666.46f);    //(��, ��)

    }

    IEnumerator WaitSecond_5()
    {
        yield return new WaitForSeconds(7.5f);
        //Line_4.SetActive(true);

        Line_21_Index = 3;
        inside_Line_21[3].gameObject.SetActive(true);
        //inside_Line_21[21].gameObject.SetActive(false);

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

        TextContainer1.offsetMin = new Vector2(0, -3419.696f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 21666.46f);    //(��, ��)

    }

    IEnumerator WaitSecond_6()
    {
        yield return new WaitForSeconds(9.0f);
        //Line_5.SetActive(true);

        Line_21_Index = 4;
        inside_Line_21[4].gameObject.SetActive(true);
        //inside_Line_21[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3291.474f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 21794.69f);    //(��, ��)

    }

    IEnumerator WaitSecond_7()
    {
        yield return new WaitForSeconds(10.5f);
        //Line_6.SetActive(true);

        Line_21_Index = 5;
        inside_Line_21[5].gameObject.SetActive(true);
        //inside_Line_21[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3060.613f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 22025.55f);    //(��, ��)

    }

    IEnumerator WaitSecond_8()
    {
        yield return new WaitForSeconds(12.0f);
        //Line_7.SetActive(true);

        Line_21_Index = 6;
        inside_Line_21[6].gameObject.SetActive(true);
        //inside_Line_21[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2865.491f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 22220.67f);    //(��, ��)

    }

    IEnumerator WaitSecond_9()
    {
        yield return new WaitForSeconds(13.5f);
        //Line_8.SetActive(true);

        Line_21_Index = 7;
        inside_Line_21[7].gameObject.SetActive(true);
        //inside_Line_21[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2556.084f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 22530.08f);    //(��, ��)

    }

    IEnumerator WaitSecond_10()
    {
        yield return new WaitForSeconds(15.0f);
        //Line_9.SetActive(true);

        Line_21_Index = 8;
        inside_Line_21[8].gameObject.SetActive(true);
        //inside_Line_21[21].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2263.401f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 22822.76f);    //(��, ��)

    }

    IEnumerator WaitSecond_11()//�Ӹ���
    {
        yield return new WaitForSeconds(17.0f);
        //Line_10.SetActive(true);

        Line_21_Index = 9;
        inside_Line_21[9].gameObject.SetActive(true);
        //inside_Line_21[21].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_12()//�Ӹ���
    {
        yield return new WaitForSeconds(19.0f);
        //Line_10.SetActive(false);
        //Line_11.SetActive(true);

        Line_21_Index = 10;
        inside_Line_21[10].gameObject.SetActive(true);
        inside_Line_21[9].gameObject.SetActive(false);



    }

    IEnumerator WaitSecond_13()
    {
        yield return new WaitForSeconds(22.0f);
        // Line_12.SetActive(true);
        //Line_11.SetActive(false);

        Line_21_Index = 11;
        inside_Line_21[11].gameObject.SetActive(true);
        inside_Line_21[10].gameObject.SetActive(false);

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

        TextContainer1.offsetMin = new Vector2(0, -1543.893f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 23542.27f);    //(��, ��)
    }

    IEnumerator WaitSecond_14()
    {
        yield return new WaitForSeconds(23.5f);
        //Line_13.SetActive(true);

        Line_21_Index = 12;
        inside_Line_21[12].gameObject.SetActive(true);
        //inside_Line_21[9].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -1255.641f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 23830.52f);    //(��, ��)
    }

    IEnumerator WaitSecond_15()
    {
        yield return new WaitForSeconds(25.0f);
        //Line_14.SetActive(true);

        Line_21_Index = 13;
        inside_Line_21[13].gameObject.SetActive(true);
        //inside_Line_21[9].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -959.6533f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 24126.51f);    //(��, ��)

    }

    IEnumerator WaitSecond_16()
    {
        yield return new WaitForSeconds(26.5f);
        //Line_15.SetActive(true);

        Line_21_Index = 14;
        inside_Line_21[14].gameObject.SetActive(true);
        //inside_Line_21[9].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -811.4561f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 24274.7f);    //(��, ��)

    }

    IEnumerator WaitSecond_17()
    {
        yield return new WaitForSeconds(28.0f);
        //Line_16.SetActive(true);

        Line_21_Index = 15;
        inside_Line_21[15].gameObject.SetActive(true);
        //inside_Line_21[9].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -648.5254f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 24437.63f);    //(��, ��)


    }

    IEnumerator WaitSecond_18()
    {
        yield return new WaitForSeconds(29.5f);
        //Line_17.SetActive(true);

        Line_21_Index = 16;
        inside_Line_21[16].gameObject.SetActive(true);
        //inside_Line_21[9].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -423.8154f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 24662.34f);    //(��, ��)


    }

    IEnumerator WaitSecond_19()
    {
        yield return new WaitForSeconds(31.0f);
        //Line_18.SetActive(true);

        Line_21_Index = 17;
        inside_Line_21[17].gameObject.SetActive(true);
        //inside_Line_21[9].gameObject.SetActive(false);

        inside_29.Line_29_Index = 0;
        inside_29.inside_Line_29[0].gameObject.SetActive(false);
        inside_29.inside_Line_29[1].gameObject.SetActive(false);
        inside_29.inside_Line_29[2].gameObject.SetActive(false);
        inside_29.inside_Line_29[3].gameObject.SetActive(false);
        inside_29.inside_Line_29[4].gameObject.SetActive(false);
        inside_29.inside_Line_29[5].gameObject.SetActive(false);
        inside_29.inside_Line_29[6].gameObject.SetActive(false);
        inside_29.inside_Line_29[7].gameObject.SetActive(false);
        inside_29.inside_Line_29[8].gameObject.SetActive(false);
        inside_29.inside_Line_29[9].gameObject.SetActive(false);
        inside_29.inside_Line_29[10].gameObject.SetActive(false);
        inside_29.inside_Line_29[11].gameObject.SetActive(false);
        inside_29.inside_Line_29[12].gameObject.SetActive(false);
        inside_29.inside_Line_29[13].gameObject.SetActive(false);
        inside_29.inside_Line_29[14].gameObject.SetActive(false);
        inside_29.inside_Line_29[15].gameObject.SetActive(false);
        inside_29.inside_Line_29[16].gameObject.SetActive(false);
        inside_29.inside_Line_29[17].gameObject.SetActive(false);
        inside_29.inside_Line_29[18].gameObject.SetActive(false);
        inside_29.inside_Line_29[19].gameObject.SetActive(false);
        inside_29.inside_Line_29[20].gameObject.SetActive(false);
        inside_29.inside_Line_29[21].gameObject.SetActive(false);
        inside_29.inside_Line_29[22].gameObject.SetActive(false);
        inside_29.inside_Line_29[23].gameObject.SetActive(false);
        inside_29.inside_Line_29[24].gameObject.SetActive(false);
        inside_29.inside_Line_29[25].gameObject.SetActive(false);
        inside_29.inside_Line_29[26].gameObject.SetActive(false);
        inside_29.inside_Line_29[27].gameObject.SetActive(false);
        inside_29.inside_Line_29[28].gameObject.SetActive(false);
        inside_29.inside_Line_29[29].gameObject.SetActive(false);
        inside_29.inside_Line_29[30].gameObject.SetActive(false);
        inside_29.inside_Line_29[31].gameObject.SetActive(false);
        inside_29.inside_Line_29[32].gameObject.SetActive(false);
        inside_29.inside_Line_29[33].gameObject.SetActive(false);
        inside_29.inside_Line_29[34].gameObject.SetActive(false);
        inside_29.inside_Line_29[35].gameObject.SetActive(false);
        inside_29.inside_Line_29[36].gameObject.SetActive(false);
        inside_29.inside_Line_29[37].gameObject.SetActive(false);
        inside_29.inside_Line_29[38].gameObject.SetActive(false);
        inside_29.inside_Line_29[39].gameObject.SetActive(false);
        inside_29.inside_Line_29[40].gameObject.SetActive(false);
        inside_29.inside_Line_29[41].gameObject.SetActive(false);
        inside_29.inside_Line_29[42].gameObject.SetActive(false);
        inside_29.inside_Line_29[43].gameObject.SetActive(false);
        inside_29.inside_Line_29[44].gameObject.SetActive(false);
        inside_29.inside_Line_29[45].gameObject.SetActive(false);
        inside_29.inside_Line_29[46].gameObject.SetActive(false);
        inside_29.inside_Line_29[47].gameObject.SetActive(false);
        inside_29.inside_Line_29[48].gameObject.SetActive(false);
        inside_29.inside_Line_29[49].gameObject.SetActive(false);
        inside_29.inside_Line_29[50].gameObject.SetActive(false);
        inside_29.inside_Line_29[51].gameObject.SetActive(false);
        inside_29.inside_Line_29[52].gameObject.SetActive(false);
        inside_29.inside_Line_29[53].gameObject.SetActive(false);
        inside_29.inside_Line_29[54].gameObject.SetActive(false);
        inside_29.inside_Line_29[55].gameObject.SetActive(false);
        inside_29.inside_Line_29[56].gameObject.SetActive(false);
        inside_29.inside_Line_29[57].gameObject.SetActive(false);
        inside_29.inside_Line_29[58].gameObject.SetActive(false);
        inside_29.inside_Line_29[59].gameObject.SetActive(false);
        inside_29.inside_Line_29[60].gameObject.SetActive(false);
        inside_29.inside_Line_29[61].gameObject.SetActive(false);
        inside_29.inside_Line_29[62].gameObject.SetActive(false);
        inside_29.inside_Line_29[63].gameObject.SetActive(false);
        inside_29.inside_Line_29[64].gameObject.SetActive(false);
        inside_29.inside_Line_29[65].gameObject.SetActive(false);
        inside_29.inside_Line_29[66].gameObject.SetActive(false);
        inside_29.inside_Line_29[67].gameObject.SetActive(false);
        inside_29.inside_Line_29[68].gameObject.SetActive(false);
        inside_29.inside_Line_29[69].gameObject.SetActive(false);
        inside_29.inside_Line_29[70].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, 0.07617188f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 25086.24f);    //(��, ��)

    }



}
