using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class R_Wait1_5_5 : MonoBehaviour
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
    public GameObject Line_49;*/

    public GameObject[] inside_Line_45;
    public int Line_45_Index;

    public R_Wait1_4_3 inside_29;

    public R_Wait1_6_9 inside_89;
    public R_Wait1_6_30 inside_93;

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

        Line_45_Index = 0;
        inside_Line_45[0].gameObject.SetActive(true);
        //inside_Line_45[1].gameObject.SetActive(false);

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

        // *** 자동저장 라인 ***
        PlayerPrefs.SetInt("Auto_Index", QuestObject.Line_Index);

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


        /*QuestObject.Line_Index = 45;

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

        TextContainer1.offsetMin = new Vector2(0, -9390.02f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 40526.37f);    //(오, 위)


    }

    IEnumerator WaitSecond_2()//134-속마음
    {
        yield return new WaitForSeconds(2.5f);
        //Line_2.SetActive(true);
        //Line_1.SetActive(false);
        

        Line_45_Index = 1;
        inside_Line_45[1].gameObject.SetActive(true);
        inside_Line_45[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_3()//135-1
    {

        yield return new WaitForSeconds(5.0f);
        //Line_3.SetActive(true);
        //Line_2.SetActive(false);
        FadeObject.Fade_Index = 8;
        FadeObject.fadeObject[8].gameObject.SetActive(false);

        Line_45_Index = 2;
        inside_Line_45[2].gameObject.SetActive(true);
        inside_Line_45[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -9107.037f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 40809.35f);    //(오, 위)


    }

    IEnumerator WaitSecond_4()//135-2
    {
        yield return new WaitForSeconds(6.5f);
        //Line_4.SetActive(true);

        Line_45_Index = 3;
        inside_Line_45[3].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8950.496f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 40985.89f);    //(오, 위)

    }

    IEnumerator WaitSecond_5()//136-1
    {
        yield return new WaitForSeconds(8.0f);
        //Line_5.SetActive(true);

        Line_45_Index = 4;
        inside_Line_45[4].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8667.514f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 41248.88f);    //(오, 위)

    }

    IEnumerator WaitSecond_6()//136-2
    {
        yield return new WaitForSeconds(9.5f);
        //Line_6.SetActive(true);

        Line_45_Index = 5;
        inside_Line_45[5].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8507.061f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 41409.33f);    //(오, 위)

    }

    IEnumerator WaitSecond_7()//137
    {
        yield return new WaitForSeconds(11.0f);
        //Line_7.SetActive(true);

        Line_45_Index = 6;
        inside_Line_45[6].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8218.584f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 41697.8f);    //(오, 위)

    }

    IEnumerator WaitSecond_8()//138
    {
        yield return new WaitForSeconds(12.5f);
        //Line_8.SetActive(true);

        Line_45_Index = 7;
        inside_Line_45[7].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8020.205f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 41896.19f);    //(오, 위)

    }

    IEnumerator WaitSecond_9()//139
    {
        yield return new WaitForSeconds(14.0f);
        //Line_9.SetActive(true);

        Line_45_Index = 8;
        inside_Line_45[8].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7708.049f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 42208.34f);    //(오, 위)

    }

    IEnumerator WaitSecond_10()//140-속마음
    {
        yield return new WaitForSeconds(16.0f);
        //Line_10.SetActive(true);

        Line_45_Index = 9;
        inside_Line_45[9].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_11()//141-속마음
    {
        yield return new WaitForSeconds(18.5f);
        //Line_11.SetActive(true);
        //Line_10.SetActive(false);

        Line_45_Index = 10;
        inside_Line_45[10].gameObject.SetActive(true);
        inside_Line_45[9].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_12()//142
    {
        yield return new WaitForSeconds(22.0f);
        //Line_12.SetActive(true);
        //Line_11.SetActive(false);

        Line_45_Index = 11;
        inside_Line_45[11].gameObject.SetActive(true);
        inside_Line_45[10].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7366.908f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 42549.48f);    //(오, 위)

    }

    IEnumerator WaitSecond_13()//143
    {
        yield return new WaitForSeconds(23.5f);
        //Line_13.SetActive(true);

        Line_45_Index = 12;
        inside_Line_45[12].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7072.256f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 42844.13f);    //(오, -위)

    }

    IEnumerator WaitSecond_14()//144-속마음
    {
        yield return new WaitForSeconds(25.5f);
        //Line_14.SetActive(true);

        Line_45_Index = 13;
        inside_Line_45[13].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_15()//145-속마음
    {
        yield return new WaitForSeconds(29.5f);
        // Line_15.SetActive(true);
        //Line_14.SetActive(false);

        Line_45_Index = 14;
        inside_Line_45[14].gameObject.SetActive(true);
        inside_Line_45[13].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_16()//146하기 전 맨 위로 배치
    {
        yield return new WaitForSeconds(32.0f);
        //Line_15.SetActive(false);

        Line_45_Index = 14;
        inside_Line_45[14].gameObject.SetActive(false);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5605.695f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 44310.7f);    //(오, -위)
    }

    IEnumerator WaitSecond_17()//146
    {
        yield return new WaitForSeconds(34.0f);
        //Line_16.SetActive(true);

        Line_45_Index = 15;
        inside_Line_45[15].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5605.695f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 44310.7f);    //(오, -위)
    }

    IEnumerator WaitSecond_18()//147
    {
        yield return new WaitForSeconds(35.5f);

        //Line_17.SetActive(true);

        Line_45_Index = 16;
        inside_Line_45[16].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5605.695f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 44310.7f);    //(오, -위)

    }

    IEnumerator WaitSecond_19()//148
    {
        yield return new WaitForSeconds(37.0f);
        //Line_18.SetActive(true);

        Line_45_Index = 17;
        inside_Line_45[17].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5605.695f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 44310.7f);    //(오, -위)

    }

    IEnumerator WaitSecond_20()//149
    {
        yield return new WaitForSeconds(38.5f);
        //Line_19.SetActive(true);
        sfx5.Play();
        Line_45_Index = 18;
        inside_Line_45[18].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5605.695f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 44310.7f);    //(오, -위)
    }

    IEnumerator WaitSecond_21()//150
    {
        yield return new WaitForSeconds(40.0f);

        //Line_20.SetActive(true);

        Line_45_Index = 19;
        inside_Line_45[19].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5271.156f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 44645.23f);    //(오, -위)

    }

    IEnumerator WaitSecond_22()//151-속마음
    {
        yield return new WaitForSeconds(42.0f);
        //Line_21.SetActive(true);

        Line_45_Index = 20;
        inside_Line_45[20].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_23()//152-속마음
    {
        yield return new WaitForSeconds(45.0f);

        //Line_22.SetActive(true);
        //Line_21.SetActive(false);

        Line_45_Index = 21;
        inside_Line_45[21].gameObject.SetActive(true);
        inside_Line_45[20].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_24()//153
    {
        yield return new WaitForSeconds(47.0f);
        //Line_23.SetActive(true);
        //Line_22.SetActive(false);

        Line_45_Index = 22;
        inside_Line_45[22].gameObject.SetActive(true);
        inside_Line_45[21].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -4981.193f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 44935.2f);    //(오, -위)

    }

    IEnumerator WaitSecond_25()//154
    {
        yield return new WaitForSeconds(48.5f);
        //Line_24.SetActive(true);

        Line_45_Index = 23;
        inside_Line_45[23].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4698.211f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 45218.18f);    //(오, -위)

    }

    IEnumerator WaitSecond_26()//155
    {
        yield return new WaitForSeconds(50.0f);
        //Line_25.SetActive(true);

        Line_45_Index = 24;
        inside_Line_45[24].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4409.395f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 45507f);    //(오, -위)
    }

    IEnumerator WaitSecond_27()//156되기 전에 맨 위로 올리기
    {
        yield return new WaitForSeconds(51.5f);

        TextContainer1.offsetMin = new Vector2(0, -2946.229f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46970.16f);    //(오, -위)

    }

    IEnumerator WaitSecond_28()//156
    {
        yield return new WaitForSeconds(53.5f);
        //Line_26.SetActive(true);

        Line_45_Index = 25;
        inside_Line_45[25].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2946.229f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46970.16f);    //(오, -위)

    }

    IEnumerator WaitSecond_29()//157
    {
        yield return new WaitForSeconds(55.0f);
        //Line_27.SetActive(true);

        Line_45_Index = 26;
        inside_Line_45[26].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2946.229f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46970.16f);    //(오, -위)

    }

    IEnumerator WaitSecond_30()//158-속마음
    {
        yield return new WaitForSeconds(57.0f);
        //Line_28.SetActive(true);

        Line_45_Index = 27;
        inside_Line_45[27].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);



    }

    IEnumerator WaitSecond_31()//159-속마음
    {
        yield return new WaitForSeconds(60.0f);
        //Line_29.SetActive(true);
        //Line_28.SetActive(false);

        Line_45_Index = 28;
        inside_Line_45[28].gameObject.SetActive(true);
        inside_Line_45[27].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_32()//160-속마음
    {

        yield return new WaitForSeconds(63.5f);
        //Line_30.SetActive(true);
        //Line_29.SetActive(false);

        Line_45_Index = 29;
        inside_Line_45[29].gameObject.SetActive(true);
        inside_Line_45[28].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_33()//161
    {

        yield return new WaitForSeconds(68.0f);
        //Line_31.SetActive(true);
        //Line_30.SetActive(false);


        Line_45_Index = 30;
        inside_Line_45[30].gameObject.SetActive(true);
        inside_Line_45[29].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2946.229f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46970.16f);    //(오, -위)


    }

    IEnumerator WaitSecond_34()//162

    {
        yield return new WaitForSeconds(69.5f);
        //Line_32.SetActive(true);

        Line_45_Index = 31;
        inside_Line_45[31].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2946.229f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46970.16f);    //(오, -위)



    }

    IEnumerator WaitSecond_35()//163
    {
        yield return new WaitForSeconds(71.0f);
        //Line_33.SetActive(true);

        Line_45_Index = 32;
        inside_Line_45[32].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2946.229f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46970.16f);    //(오, -위)


    }

    IEnumerator WaitSecond_36()//164
    {
        yield return new WaitForSeconds(72.5f);

        //Line_34.SetActive(true);

        Line_45_Index = 33;
        inside_Line_45[33].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2685.836f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 47230.55f);    //(오, -위)


    }

    IEnumerator WaitSecond_37()//165
    {
        yield return new WaitForSeconds(74.0f);
        //Line_35.SetActive(true);

        Line_45_Index = 34;
        inside_Line_45[34].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2502.945f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 47413.45f);    //(오, -위)

    }


    IEnumerator WaitSecond_38()//166-1
    {
        yield return new WaitForSeconds(75.5f);
        //Line_36.SetActive(true);

        Line_45_Index = 35;
        inside_Line_45[35].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2183.066f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 47733.32f);    //(오, -위)

    }

    IEnumerator WaitSecond_39()//166-2
    {
        yield return new WaitForSeconds(77.0f);
        //Line_37.SetActive(true);

        Line_45_Index = 36;
        inside_Line_45[36].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2025.529f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 47890.86f);    //(오, -위)

    }

    IEnumerator WaitSecond_40()//167-1
    {
        yield return new WaitForSeconds(78.5f);
        //Line_38.SetActive(true);

        Line_45_Index = 37;
        inside_Line_45[37].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1736.713f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 48179.68f);    //(오, -위)

    }

    IEnumerator WaitSecond_41()//167-2
    {
        yield return new WaitForSeconds(80.0f);
        //Line_39.SetActive(true);

        Line_45_Index = 38;
        inside_Line_45[38].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1588.707f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 48327.68f);    //(오, -위)

    }

    IEnumerator WaitSecond_42()//168-속마음
    {
        yield return new WaitForSeconds(82.0f);
        //Line_40.SetActive(true);

        Line_45_Index = 39;
        inside_Line_45[39].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_43()//169-1
    {
        yield return new WaitForSeconds(84.0f);
        //Line_41.SetActive(true);
        //Line_40.SetActive(false);

        Line_45_Index = 40;
        inside_Line_45[40].gameObject.SetActive(true);
        inside_Line_45[39].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -1302.807f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 48613.59f);    //(오, -위)



    }

    IEnumerator WaitSecond_44()//169-2
    {
        yield return new WaitForSeconds(85.5f);
        //Line_42.SetActive(true);

        Line_45_Index = 41;
        inside_Line_45[41].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1145.27f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 48771.12f);    //(오, -위)

    }

    IEnumerator WaitSecond_45()//170-1
    {
        yield return new WaitForSeconds(87.0f);
        //Line_43.SetActive(true);

        Line_45_Index = 42;
        inside_Line_45[42].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -858.5176f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49057.88f);    //(오, -위)

    }

    IEnumerator WaitSecond_46()//170-2
    {
        yield return new WaitForSeconds(88.5f);
        //Line_44.SetActive(true);

        Line_45_Index = 43;
        inside_Line_45[43].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -706.8064f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49209.57f);    //(오, -위)

    }

    IEnumerator WaitSecond_47()//171
    {
        yield return new WaitForSeconds(90.0f);
        //Line_45.SetActive(true);

        Line_45_Index = 44;
        inside_Line_45[44].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -418f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49498.39f);    //(오, -위)

    }

    IEnumerator WaitSecond_48()//172-속마음
    {
        yield return new WaitForSeconds(92.0f);
        //Line_46.SetActive(true);

        Line_45_Index = 45;
        inside_Line_45[45].gameObject.SetActive(true);
        //inside_Line_45[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_49()//173-속마음
    {
        yield return new WaitForSeconds(94.0f);
        //Line_47.SetActive(true);
        //Line_46.SetActive(false);

        Line_45_Index = 46;
        inside_Line_45[46].gameObject.SetActive(true);
        inside_Line_45[45].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_50()//174-속마음
    {
        yield return new WaitForSeconds(98.0f);
        //Line_48.SetActive(true);
        //Line_47.SetActive(false);

        Line_45_Index = 47;
        inside_Line_45[47].gameObject.SetActive(true);
        inside_Line_45[46].gameObject.SetActive(false);
    }

    IEnumerator WaitSecond_51()//175-선택지
    {
        yield return new WaitForSeconds(102.5f);
        //Line_49.SetActive(true);
        //Line_48.SetActive(false);

        inside_89.Line_1_6_9_Index = 0;

        inside_89.inside_1_6_9[0].gameObject.SetActive(false);
        inside_89.inside_1_6_9[1].gameObject.SetActive(false);
        inside_89.inside_1_6_9[2].gameObject.SetActive(false);
        inside_89.inside_1_6_9[3].gameObject.SetActive(false);
        inside_89.inside_1_6_9[4].gameObject.SetActive(false);
        inside_89.inside_1_6_9[5].gameObject.SetActive(false);
        inside_89.inside_1_6_9[6].gameObject.SetActive(false);
        inside_89.inside_1_6_9[7].gameObject.SetActive(false);
        inside_89.inside_1_6_9[8].gameObject.SetActive(false);
        inside_89.inside_1_6_9[9].gameObject.SetActive(false);
        inside_89.inside_1_6_9[10].gameObject.SetActive(false);
        inside_89.inside_1_6_9[11].gameObject.SetActive(false);
        inside_89.inside_1_6_9[12].gameObject.SetActive(false);
        inside_89.inside_1_6_9[13].gameObject.SetActive(false);
        inside_89.inside_1_6_9[14].gameObject.SetActive(false);
        inside_89.inside_1_6_9[15].gameObject.SetActive(false);
        inside_89.inside_1_6_9[16].gameObject.SetActive(false);
        inside_89.inside_1_6_9[17].gameObject.SetActive(false);
        inside_89.inside_1_6_9[18].gameObject.SetActive(false);
        inside_89.inside_1_6_9[19].gameObject.SetActive(false);
        inside_89.inside_1_6_9[20].gameObject.SetActive(false);
        inside_89.inside_1_6_9[21].gameObject.SetActive(false);
        inside_89.inside_1_6_9[22].gameObject.SetActive(false);
        inside_89.inside_1_6_9[23].gameObject.SetActive(false);
        inside_89.inside_1_6_9[24].gameObject.SetActive(false);
        inside_89.inside_1_6_9[25].gameObject.SetActive(false);
        inside_89.inside_1_6_9[26].gameObject.SetActive(false);
        inside_89.inside_1_6_9[27].gameObject.SetActive(false);
        inside_89.inside_1_6_9[28].gameObject.SetActive(false);
        inside_89.inside_1_6_9[29].gameObject.SetActive(false);
        inside_89.inside_1_6_9[30].gameObject.SetActive(false);
        inside_89.inside_1_6_9[31].gameObject.SetActive(false);
        inside_89.inside_1_6_9[32].gameObject.SetActive(false);
        inside_89.inside_1_6_9[33].gameObject.SetActive(false);
        inside_89.inside_1_6_9[34].gameObject.SetActive(false);
        inside_89.inside_1_6_9[35].gameObject.SetActive(false);
        inside_89.inside_1_6_9[36].gameObject.SetActive(false);
        inside_89.inside_1_6_9[37].gameObject.SetActive(false);
        inside_89.inside_1_6_9[38].gameObject.SetActive(false);
        inside_89.inside_1_6_9[39].gameObject.SetActive(false);
        inside_89.inside_1_6_9[40].gameObject.SetActive(false);
        inside_89.inside_1_6_9[41].gameObject.SetActive(false);
        inside_89.inside_1_6_9[42].gameObject.SetActive(false);
        inside_89.inside_1_6_9[43].gameObject.SetActive(false);
        inside_89.inside_1_6_9[44].gameObject.SetActive(false);
        inside_89.inside_1_6_9[45].gameObject.SetActive(false);
        inside_89.inside_1_6_9[46].gameObject.SetActive(false);
        inside_89.inside_1_6_9[47].gameObject.SetActive(false);
        inside_89.inside_1_6_9[48].gameObject.SetActive(false);
        inside_89.inside_1_6_9[49].gameObject.SetActive(false);
        inside_89.inside_1_6_9[50].gameObject.SetActive(false);
        inside_89.inside_1_6_9[51].gameObject.SetActive(false);
        inside_89.inside_1_6_9[52].gameObject.SetActive(false);
        inside_89.inside_1_6_9[53].gameObject.SetActive(false);
        inside_89.inside_1_6_9[54].gameObject.SetActive(false);
        inside_89.inside_1_6_9[55].gameObject.SetActive(false);
        inside_89.inside_1_6_9[56].gameObject.SetActive(false);
        inside_89.inside_1_6_9[57].gameObject.SetActive(false);
        inside_89.inside_1_6_9[58].gameObject.SetActive(false);
        inside_89.inside_1_6_9[59].gameObject.SetActive(false);
        inside_89.inside_1_6_9[60].gameObject.SetActive(false);
        inside_89.inside_1_6_9[61].gameObject.SetActive(false);
        inside_89.inside_1_6_9[62].gameObject.SetActive(false);
        inside_89.inside_1_6_9[63].gameObject.SetActive(false);
        inside_89.inside_1_6_9[64].gameObject.SetActive(false);
        inside_89.inside_1_6_9[65].gameObject.SetActive(false);
        inside_89.inside_1_6_9[66].gameObject.SetActive(false);
        inside_89.inside_1_6_9[67].gameObject.SetActive(false);

        Line_45_Index = 48;
        inside_Line_45[48].gameObject.SetActive(true);
        inside_Line_45[47].gameObject.SetActive(false);

        inside_93.Line_1_6_30_Index = 0;

        inside_93.inside_1_6_30[0].gameObject.SetActive(false);
        inside_93.inside_1_6_30[1].gameObject.SetActive(false);
        inside_93.inside_1_6_30[2].gameObject.SetActive(false);
        inside_93.inside_1_6_30[3].gameObject.SetActive(false);
        inside_93.inside_1_6_30[4].gameObject.SetActive(false);
        inside_93.inside_1_6_30[5].gameObject.SetActive(false);
        inside_93.inside_1_6_30[6].gameObject.SetActive(false);
        inside_93.inside_1_6_30[7].gameObject.SetActive(false);
        inside_93.inside_1_6_30[8].gameObject.SetActive(false);
        inside_93.inside_1_6_30[9].gameObject.SetActive(false);
        inside_93.inside_1_6_30[10].gameObject.SetActive(false);
        inside_93.inside_1_6_30[11].gameObject.SetActive(false);
        inside_93.inside_1_6_30[12].gameObject.SetActive(false);
        inside_93.inside_1_6_30[13].gameObject.SetActive(false);
        inside_93.inside_1_6_30[14].gameObject.SetActive(false);
        inside_93.inside_1_6_30[15].gameObject.SetActive(false);
        inside_93.inside_1_6_30[16].gameObject.SetActive(false);
        inside_93.inside_1_6_30[17].gameObject.SetActive(false);
        inside_93.inside_1_6_30[18].gameObject.SetActive(false);
        inside_93.inside_1_6_30[19].gameObject.SetActive(false);
        inside_93.inside_1_6_30[20].gameObject.SetActive(false);
        inside_93.inside_1_6_30[21].gameObject.SetActive(false);
        inside_93.inside_1_6_30[22].gameObject.SetActive(false);
        inside_93.inside_1_6_30[23].gameObject.SetActive(false);
        inside_93.inside_1_6_30[24].gameObject.SetActive(false);
        inside_93.inside_1_6_30[25].gameObject.SetActive(false);
        inside_93.inside_1_6_30[26].gameObject.SetActive(false);
        inside_93.inside_1_6_30[27].gameObject.SetActive(false);
        inside_93.inside_1_6_30[28].gameObject.SetActive(false);
        inside_93.inside_1_6_30[29].gameObject.SetActive(false);
        inside_93.inside_1_6_30[30].gameObject.SetActive(false);
        inside_93.inside_1_6_30[31].gameObject.SetActive(false);
        inside_93.inside_1_6_30[32].gameObject.SetActive(false);
        inside_93.inside_1_6_30[33].gameObject.SetActive(false);
        inside_93.inside_1_6_30[34].gameObject.SetActive(false);
        inside_93.inside_1_6_30[35].gameObject.SetActive(false);
        inside_93.inside_1_6_30[36].gameObject.SetActive(false);
        inside_93.inside_1_6_30[37].gameObject.SetActive(false);
        inside_93.inside_1_6_30[38].gameObject.SetActive(false);
        inside_93.inside_1_6_30[39].gameObject.SetActive(false);
        inside_93.inside_1_6_30[40].gameObject.SetActive(false);
        inside_93.inside_1_6_30[41].gameObject.SetActive(false);
        inside_93.inside_1_6_30[42].gameObject.SetActive(false);
        inside_93.inside_1_6_30[43].gameObject.SetActive(false);
        inside_93.inside_1_6_30[44].gameObject.SetActive(false);
        inside_93.inside_1_6_30[45].gameObject.SetActive(false);
        inside_93.inside_1_6_30[46].gameObject.SetActive(false);
        inside_93.inside_1_6_30[47].gameObject.SetActive(false);
        inside_93.inside_1_6_30[48].gameObject.SetActive(false);
        inside_93.inside_1_6_30[49].gameObject.SetActive(false);
        inside_93.inside_1_6_30[50].gameObject.SetActive(false);
        inside_93.inside_1_6_30[51].gameObject.SetActive(false);
        inside_93.inside_1_6_30[52].gameObject.SetActive(false);
        inside_93.inside_1_6_30[53].gameObject.SetActive(false);
        inside_93.inside_1_6_30[54].gameObject.SetActive(false);
        inside_93.inside_1_6_30[55].gameObject.SetActive(false);
        inside_93.inside_1_6_30[56].gameObject.SetActive(false);
        inside_93.inside_1_6_30[57].gameObject.SetActive(false);
        inside_93.inside_1_6_30[58].gameObject.SetActive(false);
        inside_93.inside_1_6_30[59].gameObject.SetActive(false);
        inside_93.inside_1_6_30[60].gameObject.SetActive(false);
        inside_93.inside_1_6_30[61].gameObject.SetActive(false);
        inside_93.inside_1_6_30[62].gameObject.SetActive(false);
        inside_93.inside_1_6_30[63].gameObject.SetActive(false);
        inside_93.inside_1_6_30[64].gameObject.SetActive(false);
        inside_93.inside_1_6_30[65].gameObject.SetActive(false);
        inside_93.inside_1_6_30[66].gameObject.SetActive(false);
        inside_93.inside_1_6_30[67].gameObject.SetActive(false);
        inside_93.inside_1_6_30[68].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, 0.07617188f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49916.47f);    //(오, -위)

    }



}
