using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class R_Wait1_5_2 : MonoBehaviour
{
    public Save_Collection All_Save;
    public AudioSource sfx5;
    public Fade_Collect FadeObject;
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
    public GameObject Line_29;
    public GameObject Line_30;
    public GameObject Line_31;
    public GameObject Line_32;
    public GameObject Line_33;
    public GameObject Line_34;
    public GameObject Line_35;
    public GameObject Line_36;
    public GameObject Line_37;
    public GameObject Line_38;
    public GameObject Line_39;
    public GameObject Line_40;
    public GameObject Line_41;
    public GameObject Line_42;
    public GameObject Line_43;
    public GameObject Line_44;
    public GameObject Line_45;
    public GameObject Line_46;
    public GameObject Line_47;
    public GameObject Line_48;
    public GameObject Line_49;
    public GameObject Line_50;
    public GameObject Line_51;
    public GameObject Line_52;*/

    public GameObject[] inside_Line_57;
    public int Line_57_Index;

    public R_Wait1_4_1 inside_25;

    public R_Wait1_6_3 inside_81;
    public R_Wait1_6_4 inside_85;


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
        yield return StartCoroutine(WaitSecond_30());
        yield return StartCoroutine(WaitSecond_31());
        yield return StartCoroutine(WaitSecond_32());
        yield return StartCoroutine(WaitSecond_33());
        yield return StartCoroutine(WaitSecond_34());
        yield return StartCoroutine(WaitSecond_35());
        yield return StartCoroutine(WaitSecond_36());
        yield return StartCoroutine(WaitSecond_37());
        yield return StartCoroutine(WaitSecond_38());
        yield return StartCoroutine(WaitSecond_39());
        yield return StartCoroutine(WaitSecond_40());
        yield return StartCoroutine(WaitSecond_41());
        yield return StartCoroutine(WaitSecond_42());
        yield return StartCoroutine(WaitSecond_43());
        yield return StartCoroutine(WaitSecond_44());
        yield return StartCoroutine(WaitSecond_45());
        yield return StartCoroutine(WaitSecond_46());
        yield return StartCoroutine(WaitSecond_47());
        yield return StartCoroutine(WaitSecond_48());
        yield return StartCoroutine(WaitSecond_49());
        yield return StartCoroutine(WaitSecond_50());
        yield return StartCoroutine(WaitSecond_51());
        yield return StartCoroutine(WaitSecond_52());
        yield return StartCoroutine(WaitSecond_53());
        yield return StartCoroutine(WaitSecond_54());





    }

    IEnumerator WaitSecond_1()//133-�Ӹ���
    {
        yield return new WaitForSeconds(0.0f);
        //Line_1.SetActive(true);

        QuestObject.BGM_Index = 1;

        QuestObject.Audio_Object[0].gameObject.SetActive(false);
        QuestObject.Audio_Object[1].gameObject.SetActive(true);
        QuestObject.Audio_Object[2].gameObject.SetActive(false);
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

        Line_57_Index = 0;
        inside_Line_57[0].gameObject.SetActive(true);
        //inside_Line_57[1].gameObject.SetActive(false);

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

        /*QuestObject.Line_Index = 57;

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
        QuestObject.questObject[21].gameObject.SetActive(false);
        QuestObject.questObject[22].gameObject.SetActive(false);
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

        TextContainer1.offsetMin = new Vector2(0, -9651.881f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 41790.12f);    //(��, ��)


    }

    IEnumerator WaitSecond_2()//134-�Ӹ���
    {
        yield return new WaitForSeconds(3.0f);
        //Line_2.SetActive(true);
        //Line_1.SetActive(false);
        FadeObject.Fade_Index = 8;
        FadeObject.fadeObject[8].gameObject.SetActive(false);

        Line_57_Index = 1;
        inside_Line_57[1].gameObject.SetActive(true);
        inside_Line_57[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_3()//135-�Ӹ���
    {

        yield return new WaitForSeconds(5.5f);
        //Line_3.SetActive(true);
        //Line_2.SetActive(false);

        Line_57_Index = 2;
        inside_Line_57[2].gameObject.SetActive(true);
        inside_Line_57[1].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_4()//136-1
    {
        yield return new WaitForSeconds(8.5f);
        //Line_4.SetActive(true);
        //Line_3.SetActive(false);

        Line_57_Index = 3;
        inside_Line_57[3].gameObject.SetActive(true);
        inside_Line_57[2].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -9361.837f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 42080.16f);    //(��, ��)


    }

    IEnumerator WaitSecond_5()//136-2
    {
        yield return new WaitForSeconds(10.0f);
        //Line_5.SetActive(true);

        Line_57_Index = 4;
        inside_Line_57[4].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -9147.217f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 42294.78f);    //(��, ��)

    }

    IEnumerator WaitSecond_6()//137-�Ӹ���
    {

        yield return new WaitForSeconds(12.0f);
        //Line_6.SetActive(true);

        Line_57_Index = 5;
        inside_Line_57[5].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_7()//138-�Ӹ���
    {
        yield return new WaitForSeconds(14.5f);
        //Line_7.SetActive(true);
        //Line_6.SetActive(false);

        Line_57_Index = 6;
        inside_Line_57[6].gameObject.SetActive(true);
        inside_Line_57[5].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_8()//139-1
    {
        yield return new WaitForSeconds(16.5f);
        //Line_8.SetActive(true);
        //Line_7.SetActive(false);

        Line_57_Index = 7;
        inside_Line_57[7].gameObject.SetActive(true);
        inside_Line_57[6].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8851.746f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 42590.25f);    //(��, ��)

    }

    IEnumerator WaitSecond_9()//139-2
    {
        yield return new WaitForSeconds(18.0f);
        //Line_9.SetActive(true);

        Line_57_Index = 8;
        inside_Line_57[8].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8695.648f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 42746.35f);    //(��, ��)

    }

    IEnumerator WaitSecond_10()//140
    {
        yield return new WaitForSeconds(19.5f);
        //Line_10.SetActive(true);

        Line_57_Index = 9;
        inside_Line_57[9].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8494.951f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 42947.05f);    //(��, ��)

    }

    IEnumerator WaitSecond_11()//141-1
    {
        yield return new WaitForSeconds(21.0f);
        //Line_11.SetActive(true);

        Line_57_Index = 10;
        inside_Line_57[10].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8182.756f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 43259.24f);    //(��, ��)

    }

    IEnumerator WaitSecond_12()//141-2
    {
        yield return new WaitForSeconds(22.5f);
        //Line_12.SetActive(true);

        Line_57_Index = 11;
        inside_Line_57[11].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8026.658f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 43415.34f);    //(��, ��)

    }

    IEnumerator WaitSecond_13()//142-�Ӹ���
    {
        yield return new WaitForSeconds(24.5f);
        //Line_13.SetActive(true);

        Line_57_Index = 12;
        inside_Line_57[12].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_14()//143-�Ӹ���
    {
        yield return new WaitForSeconds(26.5f);
        //Line_14.SetActive(true);
        //Line_13.SetActive(false);

        Line_57_Index = 3;
        inside_Line_57[13].gameObject.SetActive(true);
        inside_Line_57[12].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_15()//144
    {
        yield return new WaitForSeconds(29.5f);
        //Line_15.SetActive(true);
        //Line_14.SetActive(false);

        Line_57_Index = 14;
        inside_Line_57[14].gameObject.SetActive(true);
        inside_Line_57[13].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7739.551f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 43702.45f);    //(��, ��)

    }

    IEnumerator WaitSecond_16()//145-1
    {
        yield return new WaitForSeconds(31.0f);
        //Line_16.SetActive(true);

        Line_57_Index = 15;
        inside_Line_57[15].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7453.08f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 43988.92f);    //(��, -��)

    }

    IEnumerator WaitSecond_17()//145-2
    {
        yield return new WaitForSeconds(32.5f);
        //Line_17.SetActive(true);

        Line_57_Index = 16;
        inside_Line_57[16].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7300.924f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 44141.08f);    //(��, ��)


    }

    IEnumerator WaitSecond_18()//145-3
    {
        yield return new WaitForSeconds(34.0f);
        //Line_18.SetActive(true);

        Line_57_Index = 17;
        inside_Line_57[17].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7080.715f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 44361.29f);    //(��, ��)

    }

    IEnumerator WaitSecond_19()//146�ϱ� �� �� ���� ��ġ
    {
        yield return new WaitForSeconds(35.5f);
   

        TextContainer1.offsetMin = new Vector2(0, -5626.596f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 45815.41f);    //(��, -��)
    }

    IEnumerator WaitSecond_20()//146
    {
        yield return new WaitForSeconds(37.5f);
        //Line_19.SetActive(true);

        Line_57_Index = 18;
        inside_Line_57[18].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5626.596f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 45815.41f);    //(��, -��)
    }

    IEnumerator WaitSecond_21()//147
    {
        yield return new WaitForSeconds(39.0f);

        //Line_20.SetActive(true);

        Line_57_Index = 19;
        inside_Line_57[19].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5626.596f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 45815.41f);    //(��, -��)

    }

    IEnumerator WaitSecond_22()//148
    {
        yield return new WaitForSeconds(40.5f);
        //Line_21.SetActive(true);

        Line_57_Index = 20;
        inside_Line_57[20].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5626.596f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 45815.41f);    //(��, -��)

    }

    IEnumerator WaitSecond_23()//149
    {
        yield return new WaitForSeconds(42.0f);
        //Line_22.SetActive(true);

        sfx5.Play();

        Line_57_Index = 21;
        inside_Line_57[21].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5626.596f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 45815.41f);    //(��, -��)
    }

    IEnumerator WaitSecond_24()//150
    {
        yield return new WaitForSeconds(43.5f);

        //Line_23.SetActive(true);

        Line_57_Index = 22;
        inside_Line_57[22].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5285.961f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 46156.04f);    //(��, -��)

    }

    IEnumerator WaitSecond_25()//151-�Ӹ���
    {
        yield return new WaitForSeconds(45.5f);
        //Line_24.SetActive(true);

        Line_57_Index = 23;
        inside_Line_57[23].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);
    }

    IEnumerator WaitSecond_26()//152-�Ӹ���
    {
        yield return new WaitForSeconds(48.5f);

        //Line_25.SetActive(true);
        //Line_24.SetActive(false);

        Line_57_Index = 24;
        inside_Line_57[24].gameObject.SetActive(true);
        inside_Line_57[23].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_27()//153
    {
        yield return new WaitForSeconds(50.5f);
        //Line_26.SetActive(true);
        //Line_25.SetActive(false);

        Line_57_Index = 25;
        inside_Line_57[25].gameObject.SetActive(true);
        inside_Line_57[24].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4990.49f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 46451.51f);    //(��, -��)

    }

    IEnumerator WaitSecond_28()//154
    {
        yield return new WaitForSeconds(52.0f);
        //Line_27.SetActive(true);

        Line_57_Index = 26;
        inside_Line_57[26].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4697.807f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 46744.2f);    //(��, -��)

    }

    IEnumerator WaitSecond_29()//155
    {
        yield return new WaitForSeconds(53.5f);
        // Line_28.SetActive(true);

        Line_57_Index = 27;
        inside_Line_57[27].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4430.203f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 47011.8f);    //(��, -��)
    }

    IEnumerator WaitSecond_30()//156�Ǳ� ���� �� ���� �ø���
    {
        yield return new WaitForSeconds(55.0f);

        TextContainer1.offsetMin = new Vector2(0, -2957.818f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 48484.18f);    //(��, -��)

    }

    IEnumerator WaitSecond_31()//156
    {
        yield return new WaitForSeconds(57.0f);
        //Line_29.SetActive(true);

        Line_57_Index = 28;
        inside_Line_57[28].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2957.818f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 48484.18f);    //(��, -��)

    }

    IEnumerator WaitSecond_32()//157
    {
        yield return new WaitForSeconds(58.5f);
        //Line_30.SetActive(true);

        Line_57_Index = 29;
        inside_Line_57[29].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2957.818f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 48484.18f);    //(��, -��)

    }

    IEnumerator WaitSecond_33()//158-�Ӹ���
    {
        yield return new WaitForSeconds(60.5f);
        //Line_31.SetActive(true);

        Line_57_Index = 30;
        inside_Line_57[30].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);



    }

    IEnumerator WaitSecond_34()//159-�Ӹ���
    {
        yield return new WaitForSeconds(63.0f);
        //Line_32.SetActive(true);
        //Line_31.SetActive(false);

        Line_57_Index = 31;
        inside_Line_57[31].gameObject.SetActive(true);
        inside_Line_57[30].gameObject.SetActive(false);



    }

    IEnumerator WaitSecond_35()//160-�Ӹ���
    {

        yield return new WaitForSeconds(66.0f);
        //Line_33.SetActive(true);
        //Line_32.SetActive(false);

        Line_57_Index = 32;
        inside_Line_57[32].gameObject.SetActive(true);
        inside_Line_57[31].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_36()//161
    {

        yield return new WaitForSeconds(69.5f);
        //Line_34.SetActive(true);
        //Line_33.SetActive(false);

        Line_57_Index = 33;
        inside_Line_57[33].gameObject.SetActive(true);
        inside_Line_57[32].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2957.818f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 48484.18f);    //(��, -��)


    }

    IEnumerator WaitSecond_37()//162

    {
        yield return new WaitForSeconds(71.0f);
        //Line_35.SetActive(true);

        Line_57_Index = 34;
        inside_Line_57[34].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2957.818f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 48484.18f);    //(��, -��)



    }

    IEnumerator WaitSecond_38()//163
    {
        yield return new WaitForSeconds(72.5f);
        //Line_36.SetActive(true);

        Line_57_Index = 35;
        inside_Line_57[35].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2957.818f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 48484.18f);    //(��, -��)


    }

    IEnumerator WaitSecond_39()//164
    {
        yield return new WaitForSeconds(74.0f);

        //Line_37.SetActive(true);

        Line_57_Index = 36;
        inside_Line_57[36].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2693.01f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 48748.99f);    //(��, -��)


    }

    IEnumerator WaitSecond_40()//165
    {
        yield return new WaitForSeconds(75.5f);
        //Line_38.SetActive(true);

        Line_57_Index = 37;
        inside_Line_57[37].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2489.525f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 48952.48f);    //(��, -��)

    }


    IEnumerator WaitSecond_41()//166-1
    {
        yield return new WaitForSeconds(77.0f);
        //Line_39.SetActive(true);

        Line_57_Index = 38;
        inside_Line_57[38].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2188.77f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 49253.23f);    //(��, -��)

    }

    IEnumerator WaitSecond_42()//166-2
    {
        yield return new WaitForSeconds(78.5f);
        //Line_40.SetActive(true);

        Line_57_Index = 39;
        inside_Line_57[39].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2029.885f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 49412.12f);    //(��, -��)

    }

    IEnumerator WaitSecond_43()//167-1
    {
        yield return new WaitForSeconds(80.0f);
        //Line_41.SetActive(true);

        Line_57_Index = 40;
        inside_Line_57[40].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1748.352f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 49693.65f);    //(��, -��)

    }

    IEnumerator WaitSecond_44()//167-2
    {
        yield return new WaitForSeconds(81.5f);
        //Line_42.SetActive(true);

        Line_57_Index = 41;
        inside_Line_57[41].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1596.555f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 49845.45f);    //(��, -��)

    }

    IEnumerator WaitSecond_45()//168-�Ӹ���
    {
        yield return new WaitForSeconds(83.5f);
        //Line_43.SetActive(true);

        Line_57_Index = 42;
        inside_Line_57[42].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_46()//169-1
    {
        yield return new WaitForSeconds(85.5f);
        //Line_44.SetActive(true);
        //Line_43.SetActive(false);

        Line_57_Index = 43;
        inside_Line_57[43].gameObject.SetActive(true);
        inside_Line_57[42].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1309.496f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 50132.5f);    //(��, -��)



    }

    IEnumerator WaitSecond_47()//169-2
    {
        yield return new WaitForSeconds(87.0f);
        //Line_45.SetActive(true);

        Line_57_Index = 44;
        inside_Line_57[44].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -1153.398f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 50286.6f);    //(��, -��)

    }

    IEnumerator WaitSecond_48()//170-1
    {
        yield return new WaitForSeconds(88.5f);
        //Line_46.SetActive(true);

        Line_57_Index = 45;
        inside_Line_57[45].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -871.8652f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 50570.13f);    //(��, -��)

    }

    IEnumerator WaitSecond_49()//170-2
    {
        yield return new WaitForSeconds(90.0f);
        //Line_47.SetActive(true);

        Line_57_Index = 46;
        inside_Line_57[46].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -712.9805f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 50729.02f);    //(��, -��)

    }

    IEnumerator WaitSecond_50()//171
    {
        yield return new WaitForSeconds(91.5f);
        //Line_48.SetActive(true);

        Line_57_Index = 47;
        inside_Line_57[47].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -417.5098f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 51024.49f);    //(��, -��)

    }

    IEnumerator WaitSecond_51()//172-�Ӹ���
    {
        yield return new WaitForSeconds(93.5f);
        //Line_49.SetActive(true);

        Line_57_Index = 48;
        inside_Line_57[48].gameObject.SetActive(true);
        //inside_Line_57[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_52()//173-�Ӹ���
    {
        yield return new WaitForSeconds(95.5f);
        //Line_50.SetActive(true);
        //Line_49.SetActive(false);


        Line_57_Index = 49;
        inside_Line_57[49].gameObject.SetActive(true);
        inside_Line_57[48].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_53()//174-�Ӹ���
    {
        yield return new WaitForSeconds(98.5f);
        //Line_51.SetActive(true);
        //Line_50.SetActive(false);

        Line_57_Index = 50;
        inside_Line_57[50].gameObject.SetActive(true);
        inside_Line_57[49].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_54()//175-������
    {
        yield return new WaitForSeconds(102.5f);
        //Line_52.SetActive(true);
        //Line_51.SetActive(false);

        inside_81.Line_1_6_3_Index = 0;

        inside_81.inside_1_6_3[0].gameObject.SetActive(false);
        inside_81.inside_1_6_3[1].gameObject.SetActive(false);
        inside_81.inside_1_6_3[2].gameObject.SetActive(false);
        inside_81.inside_1_6_3[3].gameObject.SetActive(false);
        inside_81.inside_1_6_3[4].gameObject.SetActive(false);
        inside_81.inside_1_6_3[5].gameObject.SetActive(false);
        inside_81.inside_1_6_3[6].gameObject.SetActive(false);
        inside_81.inside_1_6_3[7].gameObject.SetActive(false);
        inside_81.inside_1_6_3[8].gameObject.SetActive(false);
        inside_81.inside_1_6_3[9].gameObject.SetActive(false);
        inside_81.inside_1_6_3[10].gameObject.SetActive(false);
        inside_81.inside_1_6_3[11].gameObject.SetActive(false);
        inside_81.inside_1_6_3[12].gameObject.SetActive(false);
        inside_81.inside_1_6_3[13].gameObject.SetActive(false);
        inside_81.inside_1_6_3[14].gameObject.SetActive(false);
        inside_81.inside_1_6_3[15].gameObject.SetActive(false);
        inside_81.inside_1_6_3[16].gameObject.SetActive(false);
        inside_81.inside_1_6_3[17].gameObject.SetActive(false);
        inside_81.inside_1_6_3[18].gameObject.SetActive(false);
        inside_81.inside_1_6_3[19].gameObject.SetActive(false);
        inside_81.inside_1_6_3[20].gameObject.SetActive(false);
        inside_81.inside_1_6_3[21].gameObject.SetActive(false);
        inside_81.inside_1_6_3[22].gameObject.SetActive(false);
        inside_81.inside_1_6_3[23].gameObject.SetActive(false);
        inside_81.inside_1_6_3[24].gameObject.SetActive(false);
        inside_81.inside_1_6_3[25].gameObject.SetActive(false);
        inside_81.inside_1_6_3[26].gameObject.SetActive(false);
        inside_81.inside_1_6_3[27].gameObject.SetActive(false);
        inside_81.inside_1_6_3[28].gameObject.SetActive(false);
        inside_81.inside_1_6_3[29].gameObject.SetActive(false);
        inside_81.inside_1_6_3[30].gameObject.SetActive(false);
        inside_81.inside_1_6_3[31].gameObject.SetActive(false);
        inside_81.inside_1_6_3[32].gameObject.SetActive(false);
        inside_81.inside_1_6_3[33].gameObject.SetActive(false);
        inside_81.inside_1_6_3[34].gameObject.SetActive(false);
        inside_81.inside_1_6_3[35].gameObject.SetActive(false);
        inside_81.inside_1_6_3[36].gameObject.SetActive(false);
        inside_81.inside_1_6_3[37].gameObject.SetActive(false);
        inside_81.inside_1_6_3[38].gameObject.SetActive(false);
        inside_81.inside_1_6_3[39].gameObject.SetActive(false);
        inside_81.inside_1_6_3[40].gameObject.SetActive(false);
        inside_81.inside_1_6_3[41].gameObject.SetActive(false);
        inside_81.inside_1_6_3[42].gameObject.SetActive(false);
        inside_81.inside_1_6_3[43].gameObject.SetActive(false);
        inside_81.inside_1_6_3[44].gameObject.SetActive(false);
        inside_81.inside_1_6_3[45].gameObject.SetActive(false);
        inside_81.inside_1_6_3[46].gameObject.SetActive(false);
        inside_81.inside_1_6_3[47].gameObject.SetActive(false);
        inside_81.inside_1_6_3[48].gameObject.SetActive(false);
        inside_81.inside_1_6_3[49].gameObject.SetActive(false);
        inside_81.inside_1_6_3[50].gameObject.SetActive(false);
        inside_81.inside_1_6_3[51].gameObject.SetActive(false);
        inside_81.inside_1_6_3[52].gameObject.SetActive(false);
        inside_81.inside_1_6_3[53].gameObject.SetActive(false);
        inside_81.inside_1_6_3[54].gameObject.SetActive(false);
        inside_81.inside_1_6_3[55].gameObject.SetActive(false);
        inside_81.inside_1_6_3[56].gameObject.SetActive(false);
        inside_81.inside_1_6_3[57].gameObject.SetActive(false);
        inside_81.inside_1_6_3[58].gameObject.SetActive(false);
        inside_81.inside_1_6_3[59].gameObject.SetActive(false);
        inside_81.inside_1_6_3[60].gameObject.SetActive(false);
        inside_81.inside_1_6_3[61].gameObject.SetActive(false);
        inside_81.inside_1_6_3[62].gameObject.SetActive(false);
        inside_81.inside_1_6_3[63].gameObject.SetActive(false);
        inside_81.inside_1_6_3[64].gameObject.SetActive(false);
        inside_81.inside_1_6_3[65].gameObject.SetActive(false);
        inside_81.inside_1_6_3[66].gameObject.SetActive(false);
        inside_81.inside_1_6_3[67].gameObject.SetActive(false);

        Line_57_Index = 51;
        inside_Line_57[51].gameObject.SetActive(true);
        inside_Line_57[50].gameObject.SetActive(false);

        inside_85.Line_1_6_4_Index = 0;

        inside_85.inside_1_6_4[0].gameObject.SetActive(false);
        inside_85.inside_1_6_4[1].gameObject.SetActive(false);
        inside_85.inside_1_6_4[2].gameObject.SetActive(false);
        inside_85.inside_1_6_4[3].gameObject.SetActive(false);
        inside_85.inside_1_6_4[4].gameObject.SetActive(false);
        inside_85.inside_1_6_4[5].gameObject.SetActive(false);
        inside_85.inside_1_6_4[6].gameObject.SetActive(false);
        inside_85.inside_1_6_4[7].gameObject.SetActive(false);
        inside_85.inside_1_6_4[8].gameObject.SetActive(false);
        inside_85.inside_1_6_4[9].gameObject.SetActive(false);
        inside_85.inside_1_6_4[10].gameObject.SetActive(false);
        inside_85.inside_1_6_4[11].gameObject.SetActive(false);
        inside_85.inside_1_6_4[12].gameObject.SetActive(false);
        inside_85.inside_1_6_4[13].gameObject.SetActive(false);
        inside_85.inside_1_6_4[14].gameObject.SetActive(false);
        inside_85.inside_1_6_4[15].gameObject.SetActive(false);
        inside_85.inside_1_6_4[16].gameObject.SetActive(false);
        inside_85.inside_1_6_4[17].gameObject.SetActive(false);
        inside_85.inside_1_6_4[18].gameObject.SetActive(false);
        inside_85.inside_1_6_4[19].gameObject.SetActive(false);
        inside_85.inside_1_6_4[20].gameObject.SetActive(false);
        inside_85.inside_1_6_4[21].gameObject.SetActive(false);
        inside_85.inside_1_6_4[22].gameObject.SetActive(false);
        inside_85.inside_1_6_4[23].gameObject.SetActive(false);
        inside_85.inside_1_6_4[24].gameObject.SetActive(false);
        inside_85.inside_1_6_4[25].gameObject.SetActive(false);
        inside_85.inside_1_6_4[26].gameObject.SetActive(false);
        inside_85.inside_1_6_4[27].gameObject.SetActive(false);
        inside_85.inside_1_6_4[28].gameObject.SetActive(false);
        inside_85.inside_1_6_4[29].gameObject.SetActive(false);
        inside_85.inside_1_6_4[30].gameObject.SetActive(false);
        inside_85.inside_1_6_4[31].gameObject.SetActive(false);
        inside_85.inside_1_6_4[32].gameObject.SetActive(false);
        inside_85.inside_1_6_4[33].gameObject.SetActive(false);
        inside_85.inside_1_6_4[34].gameObject.SetActive(false);
        inside_85.inside_1_6_4[35].gameObject.SetActive(false);
        inside_85.inside_1_6_4[36].gameObject.SetActive(false);
        inside_85.inside_1_6_4[37].gameObject.SetActive(false);
        inside_85.inside_1_6_4[38].gameObject.SetActive(false);
        inside_85.inside_1_6_4[39].gameObject.SetActive(false);
        inside_85.inside_1_6_4[40].gameObject.SetActive(false);
        inside_85.inside_1_6_4[41].gameObject.SetActive(false);
        inside_85.inside_1_6_4[42].gameObject.SetActive(false);
        inside_85.inside_1_6_4[43].gameObject.SetActive(false);
        inside_85.inside_1_6_4[44].gameObject.SetActive(false);
        inside_85.inside_1_6_4[45].gameObject.SetActive(false);
        inside_85.inside_1_6_4[46].gameObject.SetActive(false);
        inside_85.inside_1_6_4[47].gameObject.SetActive(false);
        inside_85.inside_1_6_4[48].gameObject.SetActive(false);
        inside_85.inside_1_6_4[49].gameObject.SetActive(false);
        inside_85.inside_1_6_4[50].gameObject.SetActive(false);
        inside_85.inside_1_6_4[51].gameObject.SetActive(false);
        inside_85.inside_1_6_4[52].gameObject.SetActive(false);
        inside_85.inside_1_6_4[53].gameObject.SetActive(false);
        inside_85.inside_1_6_4[54].gameObject.SetActive(false);
        inside_85.inside_1_6_4[55].gameObject.SetActive(false);
        inside_85.inside_1_6_4[56].gameObject.SetActive(false);
        inside_85.inside_1_6_4[57].gameObject.SetActive(false);
        inside_85.inside_1_6_4[58].gameObject.SetActive(false);
        inside_85.inside_1_6_4[59].gameObject.SetActive(false);
        inside_85.inside_1_6_4[60].gameObject.SetActive(false);
        inside_85.inside_1_6_4[61].gameObject.SetActive(false);
        inside_85.inside_1_6_4[62].gameObject.SetActive(false);
        inside_85.inside_1_6_4[63].gameObject.SetActive(false);
        inside_85.inside_1_6_4[64].gameObject.SetActive(false);
        inside_85.inside_1_6_4[65].gameObject.SetActive(false);
        inside_85.inside_1_6_4[66].gameObject.SetActive(false);
        inside_85.inside_1_6_4[67].gameObject.SetActive(false);
        inside_85.inside_1_6_4[68].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, 0.02539063f);//(��, �Ʒ�)
        TextContainer1.offsetMax = new Vector2(0, 51442.02f);    //(��, -��)

    }



}
