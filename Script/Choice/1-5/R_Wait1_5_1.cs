using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class R_Wait1_5_1 : MonoBehaviour
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

    public GameObject[] inside_Line_41;
    public int Line_41_Index;

    public R_Wait1_4_1 inside_25;

    public R_Wait1_6_1 inside_73;
    public R_Wait_1_6_2 inside_77;

    


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

        // *** 자동저장 라인 ***
        PlayerPrefs.SetInt("Auto_Index", QuestObject.Line_Index);

        Line_41_Index = 0;
        inside_Line_41[0].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

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

        /*QuestObject.Line_Index = 41;

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

        TextContainer1.offsetMin = new Vector2(0, -9375.523f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 41796.49f);    //(오, 위)


    }

    IEnumerator WaitSecond_2()//134-속마음
    {
        yield return new WaitForSeconds(2.5f);
        //Line_2.SetActive(true);
        //Line_1.SetActive(false);

        Line_41_Index = 1;
        inside_Line_41[1].gameObject.SetActive(true);
        inside_Line_41[0].gameObject.SetActive(false);

        

    }

    IEnumerator WaitSecond_3()//135-1
    {

        yield return new WaitForSeconds(5.0f);
        //Line_3.SetActive(true);
        //Line_2.SetActive(false);

        FadeObject.Fade_Index = 8;
        FadeObject.fadeObject[8].gameObject.SetActive(false);

        Line_41_Index = 2;
        inside_Line_41[2].gameObject.SetActive(true);
        inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -9085.428f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 42086.59f);    //(오, 위)


    }

    IEnumerator WaitSecond_4()//135-2
    {
        yield return new WaitForSeconds(6.5f);
        //Line_4.SetActive(true);

        Line_41_Index = 3;
        inside_Line_41[3].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8931.314f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 42240.7f);    //(오, 위)

    }

    IEnumerator WaitSecond_5()//136-1
    {
        yield return new WaitForSeconds(8.0f);
        //Line_5.SetActive(true);

        Line_41_Index = 4;
        inside_Line_41[4].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8650.314f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 42521.73f);    //(오, 위)

    }

    IEnumerator WaitSecond_6()//136-2
    {
        yield return new WaitForSeconds(9.5f);
        //Line_6.SetActive(true);

        Line_41_Index = 5;
        inside_Line_41[5].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8502.215f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 42669.8f);    //(오, 위)

    }

    IEnumerator WaitSecond_7()//137
    {
        yield return new WaitForSeconds(11.0f);
        //Line_7.SetActive(true);

        Line_41_Index = 6;
        inside_Line_41[6].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8209.098f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 42962.91f);    //(오, 위)

    }

    IEnumerator WaitSecond_8()//138
    {
        yield return new WaitForSeconds(12.5f);
        //Line_8.SetActive(true);

        Line_41_Index = 7;
        inside_Line_41[7].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8000.592f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 43171.42f);    //(오, 위)

    }

    IEnumerator WaitSecond_9()//139
    {
        yield return new WaitForSeconds(14.0f);
        //Line_9.SetActive(true);

        Line_41_Index = 8;
        inside_Line_41[8].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7691.684f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 43480.33f);    //(오, 위)

    }

    IEnumerator WaitSecond_10()//140-속마음
    {
        yield return new WaitForSeconds(16.0f);
        //Line_10.SetActive(true);

        Line_41_Index = 9;
        inside_Line_41[9].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_11()//141-속마음
    {
        yield return new WaitForSeconds(18.5f);
        //Line_11.SetActive(true);
        //Line_10.SetActive(false);

        Line_41_Index = 10;
        inside_Line_41[10].gameObject.SetActive(true);
        inside_Line_41[9].gameObject.SetActive(false);
    }

    IEnumerator WaitSecond_12()//142
    {
        yield return new WaitForSeconds(22.0f);
        //Line_12.SetActive(true);
        //Line_11.SetActive(false);

        Line_41_Index = 11;
        inside_Line_41[11].gameObject.SetActive(true);
        inside_Line_41[10].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7344.174f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 43827.84f);    //(오, 위)

    }

    IEnumerator WaitSecond_13()//143
    {
        yield return new WaitForSeconds(23.5f);
        //Line_13.SetActive(true);

        Line_41_Index = 12;
        inside_Line_41[12].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7063.145f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 44108.87f);    //(오, -위)

    }

    IEnumerator WaitSecond_14()//144-속마음
    {
        yield return new WaitForSeconds(25.5f);
        //Line_14.SetActive(true);
        Line_41_Index = 13;
        inside_Line_41[13].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_15()//145-속마음
    {
        yield return new WaitForSeconds(29.5f);
        //Line_15.SetActive(true);
        //Line_14.SetActive(false);
        Line_41_Index = 14;
        inside_Line_41[14].gameObject.SetActive(true);
        inside_Line_41[13].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_16()//146하기 전 맨 위로 배치
    {
        yield return new WaitForSeconds(32.0f);
        //Line_15.SetActive(false);

        Line_41_Index = 14;
        inside_Line_41[14].gameObject.SetActive(false);
        //inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5604.113f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 45567.9f);    //(오, -위)
    }

    IEnumerator WaitSecond_17()//146
    {
        yield return new WaitForSeconds(34.0f);
        //Line_16.SetActive(true);

        Line_41_Index = 15;
        inside_Line_41[15].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5604.113f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 45567.9f);    //(오, -위)
    }

    IEnumerator WaitSecond_18()//147
    {
        yield return new WaitForSeconds(35.5f);

        // Line_17.SetActive(true);

        Line_41_Index = 16;
        inside_Line_41[16].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5604.113f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 45567.9f);    //(오, -위)

    }

    IEnumerator WaitSecond_19()//148
    {
        yield return new WaitForSeconds(37.0f);
        //Line_18.SetActive(true);

        Line_41_Index = 17;
        inside_Line_41[17].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5604.113f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 45567.9f);    //(오, -위)

    }

    IEnumerator WaitSecond_20()//149
    {
        yield return new WaitForSeconds(38.5f);
        //Line_19.SetActive(true);

        sfx5.Play();

        Line_41_Index = 18;
        inside_Line_41[18].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5604.113f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 45567.9f);    //(오, -위)
    }

    IEnumerator WaitSecond_21()//150
    {
        yield return new WaitForSeconds(40.0f);

        //Line_20.SetActive(true);

        Line_41_Index = 19;
        inside_Line_41[19].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5258.867f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 45913.14f);    //(오, -위)

    }

    IEnumerator WaitSecond_22()//151-속마음
    {
        yield return new WaitForSeconds(42.0f);
        //Line_21.SetActive(true);

        Line_41_Index = 20;
        inside_Line_41[20].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_23()//152-속마음
    {
        yield return new WaitForSeconds(45.0f);

        //Line_22.SetActive(true);
        //Line_21.SetActive(false);

        Line_41_Index = 21;
        inside_Line_41[21].gameObject.SetActive(true);
        inside_Line_41[20].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_24()//153
    {
        yield return new WaitForSeconds(47.0f);
        //Line_23.SetActive(true);
        //Line_22.SetActive(false);

        Line_41_Index = 22;
        inside_Line_41[22].gameObject.SetActive(true);
        inside_Line_41[21].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -4968.771f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46203.24f);    //(오, -위)

    }

    IEnumerator WaitSecond_25()//154
    {
        yield return new WaitForSeconds(48.5f);
        //Line_24.SetActive(true);

        Line_41_Index = 23;
        inside_Line_41[23].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4684.721f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0,46487.29f);    //(오, -위)

    }

    IEnumerator WaitSecond_26()//155
    {
        yield return new WaitForSeconds(50.0f);
        //Line_25.SetActive(true);

        Line_41_Index = 24;
        inside_Line_41[24].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4400.67f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 46771.34f);    //(오, -위)
    }

    IEnumerator WaitSecond_27()//156되기 전에 맨 위로 올리기
    {
        yield return new WaitForSeconds(51.5f);

        TextContainer1.offsetMin = new Vector2(0, -2941.283f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 48230.73f);    //(오, -위)

    }

    IEnumerator WaitSecond_28()//156
    {
        yield return new WaitForSeconds(53.5f);
        // Line_26.SetActive(true);

        Line_41_Index = 25;
        inside_Line_41[25].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2941.283f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 48230.73f);    //(오, -위)

    }

    IEnumerator WaitSecond_29()//157
    {
        yield return new WaitForSeconds(55.0f);
        //Line_27.SetActive(true);

        Line_41_Index = 26;
        inside_Line_41[26].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -2941.283f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 48230.73f);    //(오, -위)

    }

    IEnumerator WaitSecond_30()//158-속마음
    {
        yield return new WaitForSeconds(57.0f);
        //Line_28.SetActive(true);

        Line_41_Index = 27;
        inside_Line_41[27].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);



    }

    IEnumerator WaitSecond_31()//159-속마음
    {
        yield return new WaitForSeconds(60.0f);
        //Line_29.SetActive(true);
        //Line_28.SetActive(false);

        Line_41_Index = 28;
        inside_Line_41[28].gameObject.SetActive(true);
        inside_Line_41[27].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_32()//160-속마음
    {
        
        yield return new WaitForSeconds(63.5f);
        //Line_30.SetActive(true);
        //Line_29.SetActive(false);

        Line_41_Index = 29;
        inside_Line_41[29].gameObject.SetActive(true);
        inside_Line_41[28].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_33()//161
    {
        
        yield return new WaitForSeconds(68.0f);
        //Line_31.SetActive(true);
        //Line_30.SetActive(false);

        Line_41_Index = 30;
        inside_Line_41[30].gameObject.SetActive(true);
        inside_Line_41[29].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2941.283f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 48230.73f);    //(오, -위)


    }

    IEnumerator WaitSecond_34()//162

    {
        yield return new WaitForSeconds(69.5f);
        //Line_32.SetActive(true);

        Line_41_Index = 31;
        inside_Line_41[31].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2941.283f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 48230.73f);    //(오, -위)



    }

    IEnumerator WaitSecond_35()//163
    {
        yield return new WaitForSeconds(71.0f);
        //Line_33.SetActive(true);

        Line_41_Index = 32;
        inside_Line_41[32].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2941.283f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 48230.73f);    //(오, -위)


    }

    IEnumerator WaitSecond_36()//164
    {
        yield return new WaitForSeconds(72.5f);

        //Line_34.SetActive(true);

        Line_41_Index = 33;
        inside_Line_41[33].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2683.068f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 48488.95f);    //(오, -위)


    }

    IEnumerator WaitSecond_37()//165
    { 
        yield return new WaitForSeconds(74.0f);
        //Line_35.SetActive(true);

        Line_41_Index = 34;
        inside_Line_41[34].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2480.605f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 48691.41f);    //(오, -위)

    }


    IEnumerator WaitSecond_38()//166-1
    {
        yield return new WaitForSeconds(75.5f);
        //Line_36.SetActive(true);

        Line_41_Index = 35;
        inside_Line_41[35].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2175.176f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 48996.84f);    //(오, -위)

    }

    IEnumerator WaitSecond_39()//166-2
    {
        yield return new WaitForSeconds(77.0f);
        //Line_37.SetActive(true);

        Line_41_Index = 36;
        inside_Line_41[36].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2015.193f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49156.82f);    //(오, -위)

    }

    IEnumerator WaitSecond_40()//167-1
    {
        yield return new WaitForSeconds(78.5f);
        //Line_38.SetActive(true);

        Line_41_Index = 37;
        inside_Line_41[37].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1731.471f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49440.54f);    //(오, -위)

    }

    IEnumerator WaitSecond_41()//167-2
    {
        yield return new WaitForSeconds(80.0f);
        //Line_39.SetActive(true);

        Line_41_Index = 38;
        inside_Line_41[38].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1571.314f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49600.7f);    //(오, -위)

    }

    IEnumerator WaitSecond_42()//168-속마음
    {
        yield return new WaitForSeconds(82.0f);
        //Line_40.SetActive(true);
        Line_41_Index = 39;
        inside_Line_41[39].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_43()//169-1
    {
        yield return new WaitForSeconds(84.0f);
        //Line_41.SetActive(true);
        //Line_40.SetActive(false);


        Line_41_Index = 40;
        inside_Line_41[40].gameObject.SetActive(true);
        inside_Line_41[39].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1294.398f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 49877.61f);    //(오, -위)



    }

    IEnumerator WaitSecond_44()//169-2
    {
        yield return new WaitForSeconds(85.5f);
        //Line_42.SetActive(true);

        Line_41_Index = 41;
        inside_Line_41[41].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1143.307f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 50028.7f);    //(오, -위)

    }

    IEnumerator WaitSecond_45()//170-1
    {
        yield return new WaitForSeconds(87.0f);
        //Line_43.SetActive(true);

        Line_41_Index = 42;
        inside_Line_41[42].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -850.1895f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 50321.82f);    //(오, -위)

    }

    IEnumerator WaitSecond_46()//170-2
    {
        yield return new WaitForSeconds(88.5f);
        //Line_44.SetActive(true);

        Line_41_Index = 43;
        inside_Line_41[43].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -693.0547f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 50478.96f);    //(오, -위)

    }

    IEnumerator WaitSecond_47()//171
    {
        yield return new WaitForSeconds(90.0f);
        //Line_45.SetActive(true);

        Line_41_Index = 44;
        inside_Line_41[44].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -412.0254f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 50759.98f);    //(오, -위)

    }

    IEnumerator WaitSecond_48()//172-속마음
    {
        yield return new WaitForSeconds(92.0f);
        //Line_46.SetActive(true);

        Line_41_Index = 45;
        inside_Line_41[45].gameObject.SetActive(true);
        //inside_Line_41[1].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_49()//173-속마음
    {
        yield return new WaitForSeconds(94.0f);
        //Line_47.SetActive(true);
        //Line_46.SetActive(false);

        Line_41_Index = 46;
        inside_Line_41[46].gameObject.SetActive(true);
        inside_Line_41[45].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_50()//174-속마음
    {
        yield return new WaitForSeconds(98.0f);
        //Line_48.SetActive(true);
        //Line_47.SetActive(false);

        Line_41_Index = 47;
        inside_Line_41[47].gameObject.SetActive(true);
        inside_Line_41[46].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_51()//175-선택지
    {
        yield return new WaitForSeconds(103.0f);
        //Line_49.SetActive(true);
        //Line_48.SetActive(false);

        inside_73.Line_1_6_1_Index = 0;

        inside_73.inside_1_6_1[0].gameObject.SetActive(false);
        inside_73.inside_1_6_1[1].gameObject.SetActive(false);
        inside_73.inside_1_6_1[2].gameObject.SetActive(false);
        inside_73.inside_1_6_1[3].gameObject.SetActive(false);
        inside_73.inside_1_6_1[4].gameObject.SetActive(false);
        inside_73.inside_1_6_1[5].gameObject.SetActive(false);
        inside_73.inside_1_6_1[6].gameObject.SetActive(false);
        inside_73.inside_1_6_1[7].gameObject.SetActive(false);
        inside_73.inside_1_6_1[8].gameObject.SetActive(false);
        inside_73.inside_1_6_1[9].gameObject.SetActive(false);
        inside_73.inside_1_6_1[10].gameObject.SetActive(false);
        inside_73.inside_1_6_1[11].gameObject.SetActive(false);
        inside_73.inside_1_6_1[12].gameObject.SetActive(false);
        inside_73.inside_1_6_1[13].gameObject.SetActive(false);
        inside_73.inside_1_6_1[14].gameObject.SetActive(false);
        inside_73.inside_1_6_1[15].gameObject.SetActive(false);
        inside_73.inside_1_6_1[16].gameObject.SetActive(false);
        inside_73.inside_1_6_1[17].gameObject.SetActive(false);
        inside_73.inside_1_6_1[18].gameObject.SetActive(false);
        inside_73.inside_1_6_1[19].gameObject.SetActive(false);
        inside_73.inside_1_6_1[20].gameObject.SetActive(false);
        inside_73.inside_1_6_1[21].gameObject.SetActive(false);
        inside_73.inside_1_6_1[22].gameObject.SetActive(false);
        inside_73.inside_1_6_1[23].gameObject.SetActive(false);
        inside_73.inside_1_6_1[24].gameObject.SetActive(false);
        inside_73.inside_1_6_1[25].gameObject.SetActive(false);
        inside_73.inside_1_6_1[26].gameObject.SetActive(false);
        inside_73.inside_1_6_1[27].gameObject.SetActive(false);
        inside_73.inside_1_6_1[28].gameObject.SetActive(false);
        inside_73.inside_1_6_1[29].gameObject.SetActive(false);
        inside_73.inside_1_6_1[30].gameObject.SetActive(false);
        inside_73.inside_1_6_1[31].gameObject.SetActive(false);
        inside_73.inside_1_6_1[32].gameObject.SetActive(false);
        inside_73.inside_1_6_1[33].gameObject.SetActive(false);
        inside_73.inside_1_6_1[34].gameObject.SetActive(false);
        inside_73.inside_1_6_1[35].gameObject.SetActive(false);
        inside_73.inside_1_6_1[36].gameObject.SetActive(false);
        inside_73.inside_1_6_1[37].gameObject.SetActive(false);
        inside_73.inside_1_6_1[38].gameObject.SetActive(false);
        inside_73.inside_1_6_1[39].gameObject.SetActive(false);
        inside_73.inside_1_6_1[40].gameObject.SetActive(false);
        inside_73.inside_1_6_1[41].gameObject.SetActive(false);
        inside_73.inside_1_6_1[42].gameObject.SetActive(false);
        inside_73.inside_1_6_1[43].gameObject.SetActive(false);
        inside_73.inside_1_6_1[44].gameObject.SetActive(false);
        inside_73.inside_1_6_1[45].gameObject.SetActive(false);
        inside_73.inside_1_6_1[46].gameObject.SetActive(false);
        inside_73.inside_1_6_1[47].gameObject.SetActive(false);
        inside_73.inside_1_6_1[48].gameObject.SetActive(false);
        inside_73.inside_1_6_1[49].gameObject.SetActive(false);
        inside_73.inside_1_6_1[50].gameObject.SetActive(false);
        inside_73.inside_1_6_1[51].gameObject.SetActive(false);
        inside_73.inside_1_6_1[52].gameObject.SetActive(false);
        inside_73.inside_1_6_1[53].gameObject.SetActive(false);
        inside_73.inside_1_6_1[54].gameObject.SetActive(false);
        inside_73.inside_1_6_1[55].gameObject.SetActive(false);
        inside_73.inside_1_6_1[56].gameObject.SetActive(false);
        inside_73.inside_1_6_1[57].gameObject.SetActive(false);
        inside_73.inside_1_6_1[58].gameObject.SetActive(false);
        inside_73.inside_1_6_1[59].gameObject.SetActive(false);
        inside_73.inside_1_6_1[60].gameObject.SetActive(false);
        inside_73.inside_1_6_1[61].gameObject.SetActive(false);
        inside_73.inside_1_6_1[62].gameObject.SetActive(false);
        inside_73.inside_1_6_1[63].gameObject.SetActive(false);
        inside_73.inside_1_6_1[64].gameObject.SetActive(false);
        inside_73.inside_1_6_1[65].gameObject.SetActive(false);
        inside_73.inside_1_6_1[66].gameObject.SetActive(false);
        inside_73.inside_1_6_1[67].gameObject.SetActive(false);

        inside_77.Line_1_6_2_Index = 0;

        inside_77.inside_1_6_2[0].gameObject.SetActive(false);
        inside_77.inside_1_6_2[1].gameObject.SetActive(false);
        inside_77.inside_1_6_2[2].gameObject.SetActive(false);
        inside_77.inside_1_6_2[3].gameObject.SetActive(false);
        inside_77.inside_1_6_2[4].gameObject.SetActive(false);
        inside_77.inside_1_6_2[5].gameObject.SetActive(false);
        inside_77.inside_1_6_2[6].gameObject.SetActive(false);
        inside_77.inside_1_6_2[7].gameObject.SetActive(false);
        inside_77.inside_1_6_2[8].gameObject.SetActive(false);
        inside_77.inside_1_6_2[9].gameObject.SetActive(false);
        inside_77.inside_1_6_2[10].gameObject.SetActive(false);
        inside_77.inside_1_6_2[11].gameObject.SetActive(false);
        inside_77.inside_1_6_2[12].gameObject.SetActive(false);
        inside_77.inside_1_6_2[13].gameObject.SetActive(false);
        inside_77.inside_1_6_2[14].gameObject.SetActive(false);
        inside_77.inside_1_6_2[15].gameObject.SetActive(false);
        inside_77.inside_1_6_2[16].gameObject.SetActive(false);
        inside_77.inside_1_6_2[17].gameObject.SetActive(false);
        inside_77.inside_1_6_2[18].gameObject.SetActive(false);
        inside_77.inside_1_6_2[19].gameObject.SetActive(false);
        inside_77.inside_1_6_2[20].gameObject.SetActive(false);
        inside_77.inside_1_6_2[21].gameObject.SetActive(false);
        inside_77.inside_1_6_2[22].gameObject.SetActive(false);
        inside_77.inside_1_6_2[23].gameObject.SetActive(false);
        inside_77.inside_1_6_2[24].gameObject.SetActive(false);
        inside_77.inside_1_6_2[25].gameObject.SetActive(false);
        inside_77.inside_1_6_2[26].gameObject.SetActive(false);
        inside_77.inside_1_6_2[27].gameObject.SetActive(false);
        inside_77.inside_1_6_2[28].gameObject.SetActive(false);
        inside_77.inside_1_6_2[29].gameObject.SetActive(false);
        inside_77.inside_1_6_2[30].gameObject.SetActive(false);
        inside_77.inside_1_6_2[31].gameObject.SetActive(false);
        inside_77.inside_1_6_2[32].gameObject.SetActive(false);
        inside_77.inside_1_6_2[33].gameObject.SetActive(false);
        inside_77.inside_1_6_2[34].gameObject.SetActive(false);
        inside_77.inside_1_6_2[35].gameObject.SetActive(false);
        inside_77.inside_1_6_2[36].gameObject.SetActive(false);
        inside_77.inside_1_6_2[37].gameObject.SetActive(false);
        inside_77.inside_1_6_2[38].gameObject.SetActive(false);
        inside_77.inside_1_6_2[39].gameObject.SetActive(false);
        inside_77.inside_1_6_2[40].gameObject.SetActive(false);
        inside_77.inside_1_6_2[41].gameObject.SetActive(false);
        inside_77.inside_1_6_2[42].gameObject.SetActive(false);
        inside_77.inside_1_6_2[43].gameObject.SetActive(false);
        inside_77.inside_1_6_2[44].gameObject.SetActive(false);
        inside_77.inside_1_6_2[45].gameObject.SetActive(false);
        inside_77.inside_1_6_2[46].gameObject.SetActive(false);
        inside_77.inside_1_6_2[47].gameObject.SetActive(false);
        inside_77.inside_1_6_2[48].gameObject.SetActive(false);
        inside_77.inside_1_6_2[49].gameObject.SetActive(false);
        inside_77.inside_1_6_2[50].gameObject.SetActive(false);
        inside_77.inside_1_6_2[51].gameObject.SetActive(false);
        inside_77.inside_1_6_2[52].gameObject.SetActive(false);
        inside_77.inside_1_6_2[53].gameObject.SetActive(false);
        inside_77.inside_1_6_2[54].gameObject.SetActive(false);
        inside_77.inside_1_6_2[55].gameObject.SetActive(false);
        inside_77.inside_1_6_2[56].gameObject.SetActive(false);
        inside_77.inside_1_6_2[57].gameObject.SetActive(false);
        inside_77.inside_1_6_2[58].gameObject.SetActive(false);
        inside_77.inside_1_6_2[59].gameObject.SetActive(false);
        inside_77.inside_1_6_2[60].gameObject.SetActive(false);
        inside_77.inside_1_6_2[61].gameObject.SetActive(false);
        inside_77.inside_1_6_2[62].gameObject.SetActive(false);
        inside_77.inside_1_6_2[63].gameObject.SetActive(false);
        inside_77.inside_1_6_2[64].gameObject.SetActive(false);
        inside_77.inside_1_6_2[65].gameObject.SetActive(false);
        inside_77.inside_1_6_2[66].gameObject.SetActive(false);
        inside_77.inside_1_6_2[67].gameObject.SetActive(false);
        inside_77.inside_1_6_2[68].gameObject.SetActive(false);

        Line_41_Index = 48;
        inside_Line_41[48].gameObject.SetActive(true);
        inside_Line_41[47].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, 0.0546875f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 51172.07f);    //(오, -위)

    }



}
