using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class R_Wait1_5_22 : MonoBehaviour
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

    public GameObject[] inside_Line_69;
    public int Line_69_Index;

    public R_Wait1_4_11 inside_37;

    public R_Wait1_6_43 inside_129;
    public R_Wait1_6_44 inside_133;

    public Only_Line QuestObject;
    public IEnumerator m_Coroutine;
    public RectTransform TextContainer1;//텍스트 컨테이너

    //public GameObject Go_Black;//페이드 인 & 아웃


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

    IEnumerator WaitSecond_1()//133-속마음
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

        // *** 자동저장 라인 ***
        PlayerPrefs.SetInt("Auto_Index", QuestObject.Line_Index);

        Line_69_Index = 0;
        inside_Line_69[0].gameObject.SetActive(true);

        //오류때문에 만듦. 오류 아니었으면 진작에 지움
        // *** 첫 번째 업적과 앨범 힌트 보여주기 ***

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

        // *** 업적과 앨범 보여준 거 자동저장 ***
        PlayerPrefs.SetInt("Achieve_1", All_Save.Achieve1_Index);

        inside_37.Line_37_Index = 0;
        inside_37.inside_Line_37[0].gameObject.SetActive(false);
        inside_37.inside_Line_37[1].gameObject.SetActive(false);
        inside_37.inside_Line_37[2].gameObject.SetActive(false);
        inside_37.inside_Line_37[3].gameObject.SetActive(false);
        inside_37.inside_Line_37[4].gameObject.SetActive(false);
        inside_37.inside_Line_37[5].gameObject.SetActive(false);
        inside_37.inside_Line_37[6].gameObject.SetActive(false);
        inside_37.inside_Line_37[7].gameObject.SetActive(false);
        inside_37.inside_Line_37[8].gameObject.SetActive(false);
        inside_37.inside_Line_37[9].gameObject.SetActive(false);
        inside_37.inside_Line_37[10].gameObject.SetActive(false);
        inside_37.inside_Line_37[11].gameObject.SetActive(false);
        inside_37.inside_Line_37[12].gameObject.SetActive(false);
        inside_37.inside_Line_37[13].gameObject.SetActive(false);
        inside_37.inside_Line_37[14].gameObject.SetActive(false);
        inside_37.inside_Line_37[15].gameObject.SetActive(false);
        inside_37.inside_Line_37[16].gameObject.SetActive(false);
        inside_37.inside_Line_37[17].gameObject.SetActive(false);
        inside_37.inside_Line_37[18].gameObject.SetActive(false);
        inside_37.inside_Line_37[19].gameObject.SetActive(false);
        inside_37.inside_Line_37[20].gameObject.SetActive(false);
        inside_37.inside_Line_37[21].gameObject.SetActive(false);
        inside_37.inside_Line_37[22].gameObject.SetActive(false);
        inside_37.inside_Line_37[23].gameObject.SetActive(false);
        inside_37.inside_Line_37[24].gameObject.SetActive(false);
        inside_37.inside_Line_37[25].gameObject.SetActive(false);
        inside_37.inside_Line_37[26].gameObject.SetActive(false);
        inside_37.inside_Line_37[27].gameObject.SetActive(false);
        inside_37.inside_Line_37[28].gameObject.SetActive(false);
        inside_37.inside_Line_37[29].gameObject.SetActive(false);
        inside_37.inside_Line_37[30].gameObject.SetActive(false);
        inside_37.inside_Line_37[31].gameObject.SetActive(false);
        inside_37.inside_Line_37[32].gameObject.SetActive(false);
        inside_37.inside_Line_37[33].gameObject.SetActive(false);
        inside_37.inside_Line_37[34].gameObject.SetActive(false);
        inside_37.inside_Line_37[35].gameObject.SetActive(false);
        inside_37.inside_Line_37[36].gameObject.SetActive(false);
        inside_37.inside_Line_37[37].gameObject.SetActive(false);
        inside_37.inside_Line_37[38].gameObject.SetActive(false);
        inside_37.inside_Line_37[39].gameObject.SetActive(false);
        inside_37.inside_Line_37[40].gameObject.SetActive(false);
        inside_37.inside_Line_37[41].gameObject.SetActive(false);
        inside_37.inside_Line_37[42].gameObject.SetActive(false);
        inside_37.inside_Line_37[43].gameObject.SetActive(false);
        inside_37.inside_Line_37[44].gameObject.SetActive(false);
        inside_37.inside_Line_37[45].gameObject.SetActive(false);
        inside_37.inside_Line_37[46].gameObject.SetActive(false);
        inside_37.inside_Line_37[47].gameObject.SetActive(false);
        inside_37.inside_Line_37[48].gameObject.SetActive(false);
        inside_37.inside_Line_37[49].gameObject.SetActive(false);
        inside_37.inside_Line_37[50].gameObject.SetActive(false);
        inside_37.inside_Line_37[51].gameObject.SetActive(false);
        inside_37.inside_Line_37[52].gameObject.SetActive(false);
        inside_37.inside_Line_37[53].gameObject.SetActive(false);
        inside_37.inside_Line_37[54].gameObject.SetActive(false);
        inside_37.inside_Line_37[55].gameObject.SetActive(false);
        inside_37.inside_Line_37[56].gameObject.SetActive(false);
        inside_37.inside_Line_37[57].gameObject.SetActive(false);
        inside_37.inside_Line_37[58].gameObject.SetActive(false);
        inside_37.inside_Line_37[59].gameObject.SetActive(false);
        inside_37.inside_Line_37[60].gameObject.SetActive(false);
        inside_37.inside_Line_37[61].gameObject.SetActive(false);
        inside_37.inside_Line_37[62].gameObject.SetActive(false);
        inside_37.inside_Line_37[63].gameObject.SetActive(false);
        inside_37.inside_Line_37[64].gameObject.SetActive(false);
        inside_37.inside_Line_37[65].gameObject.SetActive(false);
        inside_37.inside_Line_37[66].gameObject.SetActive(false);
        inside_37.inside_Line_37[67].gameObject.SetActive(false);
        inside_37.inside_Line_37[68].gameObject.SetActive(false);
        inside_37.inside_Line_37[69].gameObject.SetActive(false);
        inside_37.inside_Line_37[70].gameObject.SetActive(false);

        /*QuestObject.Line_Index = 69;

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

        TextContainer1.offsetMin = new Vector2(0, -9659.324f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 42679.04f);    //(오, 위)


    }

    IEnumerator WaitSecond_2()//134-속마음
    {
        yield return new WaitForSeconds(3.0f);
        //Line_2.SetActive(true);
        //Line_1.SetActive(false);

        FadeObject.Fade_Index = 8;
        FadeObject.fadeObject[8].gameObject.SetActive(false);

        Line_69_Index = 1;
        inside_Line_69[1].gameObject.SetActive(true);
        inside_Line_69[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_3()//135-속마음
    {

        yield return new WaitForSeconds(5.5f);
        //Line_3.SetActive(true);
        //Line_2.SetActive(false);

        Line_69_Index = 2;
        inside_Line_69[2].gameObject.SetActive(true);
        inside_Line_69[1].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_4()//136-1
    {
        yield return new WaitForSeconds(8.5f);
        //Line_4.SetActive(true);
        //Line_3.SetActive(false);

        Line_69_Index = 3;
        inside_Line_69[3].gameObject.SetActive(true);
        inside_Line_69[2].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -9369.443f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 42968.91f);    //(오, 위)


    }

    IEnumerator WaitSecond_5()//136-2
    {
        yield return new WaitForSeconds(10.0f);
        //Line_5.SetActive(true);

        Line_69_Index = 4;
        inside_Line_69[4].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -9157.738f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 43180.62f);    //(오, 위)

    }

    IEnumerator WaitSecond_6()//137-속마음
    {

        yield return new WaitForSeconds(12.0f);
        //Line_6.SetActive(true);

        Line_69_Index = 5;
        inside_Line_69[5].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_7()//138-속마음
    {
        yield return new WaitForSeconds(14.5f);
        //Line_7.SetActive(true);
        //Line_6.SetActive(false);

        Line_69_Index = 6;
        inside_Line_69[6].gameObject.SetActive(true);
        inside_Line_69[5].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_8()//139-1
    {
        yield return new WaitForSeconds(16.5f);
        //Line_8.SetActive(true);
        //Line_7.SetActive(false);

        Line_69_Index = 7;
        inside_Line_69[7].gameObject.SetActive(true);
        inside_Line_69[6].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8870.631f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 43467.73f);    //(오, 위)

    }

    IEnumerator WaitSecond_9()//139-2
    {
        yield return new WaitForSeconds(18.0f);
        //Line_9.SetActive(true);

        Line_69_Index = 8;
        inside_Line_69[8].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8708.959f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 43629.4f);    //(오, 위)

    }

    IEnumerator WaitSecond_10()//140
    {
        yield return new WaitForSeconds(19.5f);
        //Line_10.SetActive(true);

        Line_69_Index = 9;
        inside_Line_69[9].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8502.668f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 43835.67f);    //(오, 위)

    }

    IEnumerator WaitSecond_11()//141-1
    {
        yield return new WaitForSeconds(21.0f);
        //Line_11.SetActive(true);

        Line_69_Index = 10;
        inside_Line_69[10].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8189.557f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 44148.8f);    //(오, 위)

    }

    IEnumerator WaitSecond_12()//141-2
    {
        yield return new WaitForSeconds(22.5f);
        //Line_12.SetActive(true);

        Line_69_Index = 11;
        inside_Line_69[11].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8036.246f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 44302.11f);    //(오, 위)

    }

    IEnumerator WaitSecond_13()//142-속마음
    {
        yield return new WaitForSeconds(24.5f);
        //Line_13.SetActive(true);
        Line_69_Index = 12;
        inside_Line_69[12].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_14()//143-속마음
    {
        yield return new WaitForSeconds(26.5f);
        //Line_14.SetActive(true);
        //Line_13.SetActive(false);

        Line_69_Index = 13;
        inside_Line_69[13].gameObject.SetActive(true);
        inside_Line_69[12].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_15()//144
    {
        yield return new WaitForSeconds(29.5f);
        //Line_15.SetActive(true);
        //Line_14.SetActive(false);

        Line_69_Index = 14;
        inside_Line_69[14].gameObject.SetActive(true);
        inside_Line_69[13].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7765.633f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 44572.73f);    //(오, 위)

    }

    IEnumerator WaitSecond_16()//145-1
    {
        yield return new WaitForSeconds(31.0f);
        //Line_16.SetActive(true);

        Line_69_Index = 15;
        inside_Line_69[15].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7470.691f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 44867.67f);    //(오, -위)

    }

    IEnumerator WaitSecond_17()//145-2
    {
        yield return new WaitForSeconds(32.5f);
        //Line_17.SetActive(true);

        Line_69_Index = 16;
        inside_Line_69[16].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7304.229f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 45034.13f);    //(오, 위)


    }

    IEnumerator WaitSecond_18()//145-3
    {
        yield return new WaitForSeconds(34.0f);
        //Line_18.SetActive(true);
        Line_69_Index = 17;
        inside_Line_69[17].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7092.383f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 45245.98f);    //(오, 위)

    }

    IEnumerator WaitSecond_19()//146하기 전 맨 위로 배치
    {
        yield return new WaitForSeconds(35.5f);


        TextContainer1.offsetMin = new Vector2(0, -5636.365f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46701.99f);    //(오, -위)
    }

    IEnumerator WaitSecond_20()//146
    {
        yield return new WaitForSeconds(37.5f);
        //Line_19.SetActive(true);

        Line_69_Index = 18;
        inside_Line_69[18].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5636.365f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46701.99f);    //(오, -위)
    }

    IEnumerator WaitSecond_21()//147
    {
        yield return new WaitForSeconds(39.0f);

        //Line_20.SetActive(true);

        Line_69_Index = 19;
        inside_Line_69[19].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5636.365f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46701.99f);    //(오, -위)

    }

    IEnumerator WaitSecond_22()//148
    {
        yield return new WaitForSeconds(40.5f);
        //Line_21.SetActive(true);

        Line_69_Index = 20;
        inside_Line_69[20].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5636.365f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46701.99f);    //(오, -위)

    }

    IEnumerator WaitSecond_23()//149
    {
        yield return new WaitForSeconds(42.0f);
        //Line_22.SetActive(true);
        sfx5.Play();
        Line_69_Index = 21;
        inside_Line_69[21].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5636.365f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46701.99f);    //(오, -위)
    }

    IEnumerator WaitSecond_24()//150
    {
        yield return new WaitForSeconds(43.5f);

        //Line_23.SetActive(true);

        Line_69_Index = 22;
        inside_Line_69[22].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5289.26f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 47049.1f);    //(오, -위)

    }

    IEnumerator WaitSecond_25()//151-속마음
    {
        yield return new WaitForSeconds(45.5f);
        //Line_24.SetActive(true);

        Line_69_Index = 23;
        inside_Line_69[23].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_26()//152-속마음
    {
        yield return new WaitForSeconds(48.5f);

        //Line_25.SetActive(true);
        //Line_24.SetActive(false);

        Line_69_Index = 24;
        inside_Line_69[24].gameObject.SetActive(true);
        inside_Line_69[23].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_27()//153
    {
        yield return new WaitForSeconds(50.5f);
        //Line_26.SetActive(true);
        //Line_25.SetActive(false);

        Line_69_Index = 25;
        inside_Line_69[25].gameObject.SetActive(true);
        inside_Line_69[24].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -5002.152f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 47336.21f);    //(오, -위)

    }

    IEnumerator WaitSecond_28()//154
    {
        yield return new WaitForSeconds(52.0f);
        //Line_27.SetActive(true);

        Line_69_Index = 26;
        inside_Line_69[26].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4711.975f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 47626.38f);    //(오, -위)

    }

    IEnumerator WaitSecond_29()//155
    {
        yield return new WaitForSeconds(53.5f);
        //Line_28.SetActive(true);

        Line_69_Index = 27;
        inside_Line_69[27].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4433.402f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 47904.96f);    //(오, -위)
    }

    IEnumerator WaitSecond_30()//156되기 전에 맨 위로 올리기
    {
        yield return new WaitForSeconds(55.0f);

        TextContainer1.offsetMin = new Vector2(0, -2971.672f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49366.69f);    //(오, -위)

    }

    IEnumerator WaitSecond_31()//156
    {
        yield return new WaitForSeconds(57.0f);
        //Line_29.SetActive(true);

        Line_69_Index = 28;
        inside_Line_69[28].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2971.672f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49366.69f);    //(오, -위)

    }

    IEnumerator WaitSecond_32()//157
    {
        yield return new WaitForSeconds(58.5f);
        //Line_30.SetActive(true);

        Line_69_Index = 29;
        inside_Line_69[29].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2971.672f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49366.69f);    //(오, -위)

    }

    IEnumerator WaitSecond_33()//158-속마음
    {
        yield return new WaitForSeconds(60.5f);
        //Line_31.SetActive(true);

        Line_69_Index = 30;
        inside_Line_69[30].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);



    }

    IEnumerator WaitSecond_34()//159-속마음
    {
        yield return new WaitForSeconds(63.0f);
        // Line_32.SetActive(true);
        // Line_31.SetActive(false);

        Line_69_Index = 31;
        inside_Line_69[31].gameObject.SetActive(true);
        inside_Line_69[30].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_35()//160-속마음
    {

        yield return new WaitForSeconds(66.0f);
        //Line_33.SetActive(true);
        //Line_32.SetActive(false);

        Line_69_Index = 32;
        inside_Line_69[32].gameObject.SetActive(true);
        inside_Line_69[31].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_36()//161
    {

        yield return new WaitForSeconds(69.5f);
        //Line_34.SetActive(true);
        //Line_33.SetActive(false);

        Line_69_Index = 33;
        inside_Line_69[33].gameObject.SetActive(true);
        inside_Line_69[32].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2971.672f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49366.69f);    //(오, -위)


    }

    IEnumerator WaitSecond_37()//162

    {
        yield return new WaitForSeconds(71.0f);
        //Line_35.SetActive(true);

        Line_69_Index = 34;
        inside_Line_69[34].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2971.672f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49366.69f);    //(오, -위)


    }

    IEnumerator WaitSecond_38()//163
    {
        yield return new WaitForSeconds(72.5f);
        //Line_36.SetActive(true);

        Line_69_Index = 35;
        inside_Line_69[35].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2971.672f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49366.69f);    //(오, -위)


    }

    IEnumerator WaitSecond_39()//164
    {
        yield return new WaitForSeconds(74.0f);

        //Line_37.SetActive(true);

        Line_69_Index = 36;
        inside_Line_69[36].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2709.65f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49628.71f);    //(오, -위)


    }

    IEnumerator WaitSecond_40()//165
    {
        yield return new WaitForSeconds(75.5f);
        //Line_38.SetActive(true);

        Line_69_Index = 37;
        inside_Line_69[37].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2506.756f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49831.6f);    //(오, -위)

    }


    IEnumerator WaitSecond_41()//166-1
    {
        yield return new WaitForSeconds(77.0f);
        //Line_39.SetActive(true);

        Line_69_Index = 38;
        inside_Line_69[38].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2200.736f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 50137.63f);    //(오, -위)

    }

    IEnumerator WaitSecond_42()//166-2
    {
        yield return new WaitForSeconds(78.5f);
        //Line_40.SetActive(true);

        Line_69_Index = 39;
        inside_Line_69[39].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2044.639f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 50293.72f);    //(오, -위)

    }

    IEnumerator WaitSecond_43()//167-1//여기부터 해야 함
    {
        yield return new WaitForSeconds(80.0f);
        //Line_41.SetActive(true);

        Line_69_Index = 40;
        inside_Line_69[40].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1763.055f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 50575.3f);    //(오, -위)

    }

    IEnumerator WaitSecond_44()//167-2
    {
        yield return new WaitForSeconds(81.5f);
        //Line_42.SetActive(true);

        Line_69_Index = 41;
        inside_Line_69[41].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1604.818f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 50733.54f);    //(오, -위)

    }

    IEnumerator WaitSecond_45()//168-속마음
    {
        yield return new WaitForSeconds(83.5f);
        //Line_43.SetActive(true);

        Line_69_Index = 42;
        inside_Line_69[42].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_46()//169-1
    {
        yield return new WaitForSeconds(85.5f);
        //Line_44.SetActive(true);
        //Line_43.SetActive(false);

        Line_69_Index = 43;
        inside_Line_69[43].gameObject.SetActive(true);
        inside_Line_69[42].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1312.332f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 51026.03f);    //(오, -위)



    }

    IEnumerator WaitSecond_47()//169-2
    {
        yield return new WaitForSeconds(87.0f);
        //Line_45.SetActive(true);

        Line_69_Index = 44;
        inside_Line_69[44].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1164.598f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 51173.76f);    //(오, -위)

    }

    IEnumerator WaitSecond_48()//170-1
    {
        yield return new WaitForSeconds(88.5f);
        //Line_46.SetActive(true);

        Line_69_Index = 45;
        inside_Line_69[45].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -880.2773f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 51458.08f);    //(오, -위)

    }

    IEnumerator WaitSecond_49()//170-2
    {
        yield return new WaitForSeconds(90.0f);
        //Line_47.SetActive(true);

        Line_69_Index = 46;
        inside_Line_69[46].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -725.3027f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 51613.05f);    //(오, -위)

    }

    IEnumerator WaitSecond_50()//171
    {
        yield return new WaitForSeconds(91.5f);
        //Line_48.SetActive(true);

        Line_69_Index = 47;
        inside_Line_69[47].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -435.4082f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 51902.95f);    //(오, -위)

    }

    IEnumerator WaitSecond_51()//172-속마음
    {
        yield return new WaitForSeconds(93.5f);
        //Line_49.SetActive(true);

        Line_69_Index = 48;
        inside_Line_69[48].gameObject.SetActive(true);
        //inside_Line_69[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_52()//173-속마음
    {
        yield return new WaitForSeconds(95.5f);
        //Line_50.SetActive(true);
        //Line_49.SetActive(false);

        Line_69_Index = 49;
        inside_Line_69[49].gameObject.SetActive(true);
        inside_Line_69[48].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_53()//174-속마음
    {
        yield return new WaitForSeconds(98.5f);
        //Line_51.SetActive(true);
        //Line_50.SetActive(false);

        Line_69_Index = 50;
        inside_Line_69[50].gameObject.SetActive(true);
        inside_Line_69[49].gameObject.SetActive(false);
    }

    IEnumerator WaitSecond_54()//175-선택지
    {
        yield return new WaitForSeconds(102.5f);
        //Line_52.SetActive(true);
        //Line_51.SetActive(false);

        inside_129.Line_1_6_43_Index = 0;

        inside_129.inside_1_6_43[0].gameObject.SetActive(false);
        inside_129.inside_1_6_43[1].gameObject.SetActive(false);
        inside_129.inside_1_6_43[2].gameObject.SetActive(false);
        inside_129.inside_1_6_43[3].gameObject.SetActive(false);
        inside_129.inside_1_6_43[4].gameObject.SetActive(false);
        inside_129.inside_1_6_43[5].gameObject.SetActive(false);
        inside_129.inside_1_6_43[6].gameObject.SetActive(false);
        inside_129.inside_1_6_43[7].gameObject.SetActive(false);
        inside_129.inside_1_6_43[8].gameObject.SetActive(false);
        inside_129.inside_1_6_43[9].gameObject.SetActive(false);
        inside_129.inside_1_6_43[10].gameObject.SetActive(false);
        inside_129.inside_1_6_43[11].gameObject.SetActive(false);
        inside_129.inside_1_6_43[12].gameObject.SetActive(false);
        inside_129.inside_1_6_43[13].gameObject.SetActive(false);
        inside_129.inside_1_6_43[14].gameObject.SetActive(false);
        inside_129.inside_1_6_43[15].gameObject.SetActive(false);
        inside_129.inside_1_6_43[16].gameObject.SetActive(false);
        inside_129.inside_1_6_43[17].gameObject.SetActive(false);
        inside_129.inside_1_6_43[18].gameObject.SetActive(false);
        inside_129.inside_1_6_43[19].gameObject.SetActive(false);
        inside_129.inside_1_6_43[20].gameObject.SetActive(false);
        inside_129.inside_1_6_43[21].gameObject.SetActive(false);
        inside_129.inside_1_6_43[22].gameObject.SetActive(false);
        inside_129.inside_1_6_43[23].gameObject.SetActive(false);
        inside_129.inside_1_6_43[24].gameObject.SetActive(false);
        inside_129.inside_1_6_43[25].gameObject.SetActive(false);
        inside_129.inside_1_6_43[26].gameObject.SetActive(false);
        inside_129.inside_1_6_43[27].gameObject.SetActive(false);
        inside_129.inside_1_6_43[28].gameObject.SetActive(false);
        inside_129.inside_1_6_43[29].gameObject.SetActive(false);
        inside_129.inside_1_6_43[30].gameObject.SetActive(false);
        inside_129.inside_1_6_43[31].gameObject.SetActive(false);
        inside_129.inside_1_6_43[32].gameObject.SetActive(false);
        inside_129.inside_1_6_43[33].gameObject.SetActive(false);
        inside_129.inside_1_6_43[34].gameObject.SetActive(false);
        inside_129.inside_1_6_43[35].gameObject.SetActive(false);
        inside_129.inside_1_6_43[36].gameObject.SetActive(false);
        inside_129.inside_1_6_43[37].gameObject.SetActive(false);
        inside_129.inside_1_6_43[38].gameObject.SetActive(false);
        inside_129.inside_1_6_43[39].gameObject.SetActive(false);
        inside_129.inside_1_6_43[40].gameObject.SetActive(false);
        inside_129.inside_1_6_43[41].gameObject.SetActive(false);
        inside_129.inside_1_6_43[42].gameObject.SetActive(false);
        inside_129.inside_1_6_43[43].gameObject.SetActive(false);
        inside_129.inside_1_6_43[44].gameObject.SetActive(false);
        inside_129.inside_1_6_43[45].gameObject.SetActive(false);
        inside_129.inside_1_6_43[46].gameObject.SetActive(false);
        inside_129.inside_1_6_43[47].gameObject.SetActive(false);
        inside_129.inside_1_6_43[48].gameObject.SetActive(false);
        inside_129.inside_1_6_43[49].gameObject.SetActive(false);
        inside_129.inside_1_6_43[50].gameObject.SetActive(false);
        inside_129.inside_1_6_43[51].gameObject.SetActive(false);
        inside_129.inside_1_6_43[52].gameObject.SetActive(false);
        inside_129.inside_1_6_43[53].gameObject.SetActive(false);
        inside_129.inside_1_6_43[54].gameObject.SetActive(false);
        inside_129.inside_1_6_43[55].gameObject.SetActive(false);
        inside_129.inside_1_6_43[56].gameObject.SetActive(false);
        inside_129.inside_1_6_43[57].gameObject.SetActive(false);
        inside_129.inside_1_6_43[58].gameObject.SetActive(false);
        inside_129.inside_1_6_43[59].gameObject.SetActive(false);
        inside_129.inside_1_6_43[60].gameObject.SetActive(false);
        inside_129.inside_1_6_43[61].gameObject.SetActive(false);
        inside_129.inside_1_6_43[62].gameObject.SetActive(false);
        inside_129.inside_1_6_43[63].gameObject.SetActive(false);
        inside_129.inside_1_6_43[64].gameObject.SetActive(false);
        inside_129.inside_1_6_43[65].gameObject.SetActive(false);
        inside_129.inside_1_6_43[66].gameObject.SetActive(false);
        inside_129.inside_1_6_43[67].gameObject.SetActive(false);

        Line_69_Index = 51;
        inside_Line_69[51].gameObject.SetActive(true);
        inside_Line_69[50].gameObject.SetActive(false);

        inside_133.Line_1_6_44_Index = 0;

        inside_133.inside_1_6_44[0].gameObject.SetActive(false);
        inside_133.inside_1_6_44[1].gameObject.SetActive(false);
        inside_133.inside_1_6_44[2].gameObject.SetActive(false);
        inside_133.inside_1_6_44[3].gameObject.SetActive(false);
        inside_133.inside_1_6_44[4].gameObject.SetActive(false);
        inside_133.inside_1_6_44[5].gameObject.SetActive(false);
        inside_133.inside_1_6_44[6].gameObject.SetActive(false);
        inside_133.inside_1_6_44[7].gameObject.SetActive(false);
        inside_133.inside_1_6_44[8].gameObject.SetActive(false);
        inside_133.inside_1_6_44[9].gameObject.SetActive(false);
        inside_133.inside_1_6_44[10].gameObject.SetActive(false);
        inside_133.inside_1_6_44[11].gameObject.SetActive(false);
        inside_133.inside_1_6_44[12].gameObject.SetActive(false);
        inside_133.inside_1_6_44[13].gameObject.SetActive(false);
        inside_133.inside_1_6_44[14].gameObject.SetActive(false);
        inside_133.inside_1_6_44[15].gameObject.SetActive(false);
        inside_133.inside_1_6_44[16].gameObject.SetActive(false);
        inside_133.inside_1_6_44[17].gameObject.SetActive(false);
        inside_133.inside_1_6_44[18].gameObject.SetActive(false);
        inside_133.inside_1_6_44[19].gameObject.SetActive(false);
        inside_133.inside_1_6_44[20].gameObject.SetActive(false);
        inside_133.inside_1_6_44[21].gameObject.SetActive(false);
        inside_133.inside_1_6_44[22].gameObject.SetActive(false);
        inside_133.inside_1_6_44[23].gameObject.SetActive(false);
        inside_133.inside_1_6_44[24].gameObject.SetActive(false);
        inside_133.inside_1_6_44[25].gameObject.SetActive(false);
        inside_133.inside_1_6_44[26].gameObject.SetActive(false);
        inside_133.inside_1_6_44[27].gameObject.SetActive(false);
        inside_133.inside_1_6_44[28].gameObject.SetActive(false);
        inside_133.inside_1_6_44[29].gameObject.SetActive(false);
        inside_133.inside_1_6_44[30].gameObject.SetActive(false);
        inside_133.inside_1_6_44[31].gameObject.SetActive(false);
        inside_133.inside_1_6_44[32].gameObject.SetActive(false);
        inside_133.inside_1_6_44[33].gameObject.SetActive(false);
        inside_133.inside_1_6_44[34].gameObject.SetActive(false);
        inside_133.inside_1_6_44[35].gameObject.SetActive(false);
        inside_133.inside_1_6_44[36].gameObject.SetActive(false);
        inside_133.inside_1_6_44[37].gameObject.SetActive(false);
        inside_133.inside_1_6_44[38].gameObject.SetActive(false);
        inside_133.inside_1_6_44[39].gameObject.SetActive(false);
        inside_133.inside_1_6_44[40].gameObject.SetActive(false);
        inside_133.inside_1_6_44[41].gameObject.SetActive(false);
        inside_133.inside_1_6_44[42].gameObject.SetActive(false);
        inside_133.inside_1_6_44[43].gameObject.SetActive(false);
        inside_133.inside_1_6_44[44].gameObject.SetActive(false);
        inside_133.inside_1_6_44[45].gameObject.SetActive(false);
        inside_133.inside_1_6_44[46].gameObject.SetActive(false);
        inside_133.inside_1_6_44[47].gameObject.SetActive(false);
        inside_133.inside_1_6_44[48].gameObject.SetActive(false);
        inside_133.inside_1_6_44[49].gameObject.SetActive(false);
        inside_133.inside_1_6_44[50].gameObject.SetActive(false);
        inside_133.inside_1_6_44[51].gameObject.SetActive(false);
        inside_133.inside_1_6_44[52].gameObject.SetActive(false);
        inside_133.inside_1_6_44[53].gameObject.SetActive(false);
        inside_133.inside_1_6_44[54].gameObject.SetActive(false);
        inside_133.inside_1_6_44[55].gameObject.SetActive(false);
        inside_133.inside_1_6_44[56].gameObject.SetActive(false);
        inside_133.inside_1_6_44[57].gameObject.SetActive(false);
        inside_133.inside_1_6_44[58].gameObject.SetActive(false);
        inside_133.inside_1_6_44[59].gameObject.SetActive(false);
        inside_133.inside_1_6_44[60].gameObject.SetActive(false);
        inside_133.inside_1_6_44[61].gameObject.SetActive(false);
        inside_133.inside_1_6_44[62].gameObject.SetActive(false);
        inside_133.inside_1_6_44[63].gameObject.SetActive(false);
        inside_133.inside_1_6_44[64].gameObject.SetActive(false);
        inside_133.inside_1_6_44[65].gameObject.SetActive(false);
        inside_133.inside_1_6_44[66].gameObject.SetActive(false);
        inside_133.inside_1_6_44[67].gameObject.SetActive(false);
        inside_133.inside_1_6_44[68].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, 0.05859375f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 52338.42f);    //(오, -위)

    }



}
