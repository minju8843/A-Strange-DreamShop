using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class R_Wait1_4_11 : MonoBehaviour
{
    public Save_Collection All_Save;
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
    public GameObject Line_52;
    public GameObject Line_53;
    public GameObject Line_54;
    public GameObject Line_55;
    public GameObject Line_56;
    public GameObject Line_57;
    public GameObject Line_58;
    public GameObject Line_59;
    public GameObject Line_60;
    public GameObject Line_61;
    public GameObject Line_62;
    public GameObject Line_63;
    public GameObject Line_64;
    public GameObject Line_65;
    public GameObject Line_66;
    public GameObject Line_67;
    public GameObject Line_68;
    public GameObject Line_69;
    public GameObject Line_70;*/


    //public GameObject Go_Black;
    //public GameObject Go_Empty;

    //public GameObject BackGround_BLACK;
    //public GameObject BackGround_Gray;

    public GameObject[] inside_Line_37;
    public int Line_37_Index;

    public Next_1_3_6 inside_19;

    public R_Wait1_5_22 inside_69;
    public R_Wait1_5_21 inside_53;

    public AudioSource sfx2;
    public AudioSource sfx3;
    public AudioSource sfx4;
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
        yield return StartCoroutine(WaitSecond_55());
        yield return StartCoroutine(WaitSecond_56());
        yield return StartCoroutine(WaitSecond_57());
        yield return StartCoroutine(WaitSecond_58());
        yield return StartCoroutine(WaitSecond_59());
        yield return StartCoroutine(WaitSecond_60());
        yield return StartCoroutine(WaitSecond_61());
        yield return StartCoroutine(WaitSecond_62());
        yield return StartCoroutine(WaitSecond_63());
        yield return StartCoroutine(WaitSecond_64());
        yield return StartCoroutine(WaitSecond_65());
        yield return StartCoroutine(WaitSecond_66());
        yield return StartCoroutine(WaitSecond_67());
        yield return StartCoroutine(WaitSecond_68());
        yield return StartCoroutine(WaitSecond_69());
        yield return StartCoroutine(WaitSecond_70());
        yield return StartCoroutine(WaitSecond_71());
        yield return StartCoroutine(WaitSecond_72());
        yield return StartCoroutine(WaitSecond_73());
        yield return StartCoroutine(WaitSecond_74());
        yield return StartCoroutine(WaitSecond_75());




    }



    IEnumerator WaitSecond_1()//79-1
    {
        yield return new WaitForSeconds(0.0f);
        //Line_1.SetActive(true);

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

        // *** 자동저장 라인 ***
        PlayerPrefs.SetInt("Auto_Index", QuestObject.Line_Index);

        Line_37_Index = 0;
        inside_Line_37[0].gameObject.SetActive(true);

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

        TextContainer1.offsetMin = new Vector2(0, -16023.27f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 27105.44f);    //(오, 위)

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

        /*QuestObject.Line_Index = 37;

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

    }

    IEnumerator WaitSecond_2()//79-2
    {
        yield return new WaitForSeconds(1.5f);
        //Line_2.SetActive(true);

        Line_37_Index = 1;
        inside_Line_37[1].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -15872.75f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 27255.96f);    //(오, 위)
    }

    IEnumerator WaitSecond_3()//맨 위로 올림
    {
        yield return new WaitForSeconds(3.0f);

        FadeObject.Fade_Index = 8;
        FadeObject.fadeObject[8].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -14417.44f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 28711.27f);    //(오, 위)

    }

    IEnumerator WaitSecond_4()//맨 위로 올린 뒤 다음 거 나타내기
                              //80
    {
        yield return new WaitForSeconds(5.0f);
        //Line_3.SetActive(true);

        Line_37_Index = 2;
        inside_Line_37[2].gameObject.SetActive(true);

        //타임라인 중간부터 시작 네모 보여주고

        if (All_Save.Time_Run[1].gameObject.activeSelf == true)
        {
            All_Save.Time_Run_Index = 1;
            All_Save.Time_Run[0].gameObject.SetActive(false);
            All_Save.Time_Run[1].gameObject.SetActive(true);
        }

        else
        {
            All_Save.Time_Run_Index = 1;
            All_Save.Time_Run[0].gameObject.SetActive(false);
            All_Save.Time_Run[1].gameObject.SetActive(true);
        }


        //만약 이미 열려 있다면 열려 있는 채로 두자.

        //자동 저장하기
        PlayerPrefs.SetInt("TimeLine_Run", All_Save.Time_Run_Index);

        //2 번째 동그라미도 오픈
        if (All_Save.Time_Circle_2[1].gameObject.activeSelf == false)
        {
            All_Save.Time_Circle_2_Index = 1;
            All_Save.Time_Circle_2[0].gameObject.SetActive(false);
            All_Save.Time_Circle_2[1].gameObject.SetActive(true);
            PlayerPrefs.SetInt("Time_Circle_2", All_Save.Time_Circle_2_Index);
        }

        else if (All_Save.Time_Circle_2[1].gameObject.activeSelf == true)
        {
            All_Save.Time_Circle_2_Index = 1;
            All_Save.Time_Circle_2[0].gameObject.SetActive(false);
            All_Save.Time_Circle_2[1].gameObject.SetActive(true);
            PlayerPrefs.SetInt("Time_Circle_2", All_Save.Time_Circle_2_Index);
        }

        TextContainer1.offsetMin = new Vector2(0, -14417.44f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 28711.27f);    //(오, 위)

    }

    IEnumerator WaitSecond_5()//81-1
    {
        yield return new WaitForSeconds(6.5f);
        //Line_4.SetActive(true);

        Line_37_Index = 3;
        inside_Line_37[3].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -14417.44f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 28711.27f);    //(오, 위)

    }

    IEnumerator WaitSecond_6()//81-2
    {
        yield return new WaitForSeconds(8.0f);
        //Line_5.SetActive(true);

        Line_37_Index = 4;
        inside_Line_37[4].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -14417.44f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 28711.27f);    //(오, 위)

    }

    IEnumerator WaitSecond_7()//81-3
    {
        yield return new WaitForSeconds(9.5f);
        //Line_6.SetActive(true);

        Line_37_Index = 5;
        inside_Line_37[5].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -14417.44f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 28711.27f);    //(오, 위)

    }

    IEnumerator WaitSecond_8()//82
    {
        yield return new WaitForSeconds(11.0f);
        //Line_7.SetActive(true);

        Line_37_Index = 6;
        inside_Line_37[6].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -14417.44f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 28711.27f);    //(오, 위)

    }

    IEnumerator WaitSecond_9()//83
    {
        yield return new WaitForSeconds(12.5f);
        //Line_8.SetActive(true);

        Line_37_Index = 7;
        inside_Line_37[7].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -13855.71f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 29273f);    //(오, 위)

    }

    IEnumerator WaitSecond_10()//84
    {
        yield return new WaitForSeconds(14.0f);
        //Line_9.SetActive(true);

        Line_37_Index = 8;
        inside_Line_37[8].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -13557.45f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 29571.26f);    //(오, -위)

    }

    IEnumerator WaitSecond_11()//85
    {
        yield return new WaitForSeconds(15.5f);
        //Line_10.SetActive(true);

        Line_37_Index = 9;
        inside_Line_37[9].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -13289.86f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 29838.86f);    //(오, 위)

    }

    IEnumerator WaitSecond_12()//86
    {
        yield return new WaitForSeconds(17.0f);
        //Line_11.SetActive(true);

        Line_37_Index = 10;
        inside_Line_37[10].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -13013.9f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 30114.81f);    //(오, 위)

    }

    IEnumerator WaitSecond_13()//87
    {
        yield return new WaitForSeconds(18.5f);
        //Line_12.SetActive(true);

        Line_37_Index = 11;
        inside_Line_37[11].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -12718.43f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 30410.29f);    //(오, -위)

    }

    IEnumerator WaitSecond_14()//88
    {
        yield return new WaitForSeconds(20.0f);
        //Line_13.SetActive(true);

        Line_37_Index = 12;
        inside_Line_37[12].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -12515f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 30613.71f);    //(오, 위)

    }

    IEnumerator WaitSecond_15()//89
    {
        yield return new WaitForSeconds(21.5f);
        //Line_14.SetActive(true);

        Line_37_Index = 13;
        inside_Line_37[13].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -12194.45f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 30934.26f);    //(오, 위)

    }

    IEnumerator WaitSecond_16()//90-1
    {
        yield return new WaitForSeconds(23.0f);
        //Line_15.SetActive(true);

        Line_37_Index = 14;
        inside_Line_37[14].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -11915.7f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 31213.01f);    //(오, -위)
    }

    IEnumerator WaitSecond_17()//90-2
    {
        yield return new WaitForSeconds(24.5f);
        //Line_16.SetActive(true);

        Line_37_Index = 15;
        inside_Line_37[15].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -11751.24f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 31377.47f);    //(오, -위)
    }

    IEnumerator WaitSecond_18()//91-1
    {
        yield return new WaitForSeconds(26.0f);

        //Line_17.SetActive(true);

        Line_37_Index = 16;
        inside_Line_37[16].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -11475.08f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 31653.63f);    //(오, -위)

    }

    IEnumerator WaitSecond_19()//91-2
    {
        yield return new WaitForSeconds(27.5f);
        //Line_18.SetActive(true);

        Line_37_Index = 17;
        inside_Line_37[17].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -11313.41f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 31815.3f);    //(오, -위)

    }

    IEnumerator WaitSecond_20()//92
    {
        yield return new WaitForSeconds(29.0f);
        //Line_19.SetActive(true);

        Line_37_Index = 18;
        inside_Line_37[18].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -11031.88f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 32096.84f);    //(오, -위)
    }

    IEnumerator WaitSecond_21()//93
    {
        yield return new WaitForSeconds(30.5f);

        //Line_20.SetActive(true);

        Line_37_Index = 19;
        inside_Line_37[19].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -10736.41f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 32392.3f);    //(오, -위)

    }

    IEnumerator WaitSecond_22()//94
    {
        yield return new WaitForSeconds(31.5f);
        //Line_21.SetActive(true);
        Line_37_Index = 20;
        inside_Line_37[20].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -10538.5f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 32590.21f);    //(오, -위)
    }

    IEnumerator WaitSecond_23()//95
    {
        yield return new WaitForSeconds(33.0f);

        //Line_22.SetActive(true);

        Line_37_Index = 21;
        inside_Line_37[21].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -10226.3f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 32902.41f);    //(오, -위)
    }

    IEnumerator WaitSecond_24()//96
    {
        yield return new WaitForSeconds(34.5f);
        //Line_23.SetActive(true);
        sfx2.Play();
        Line_37_Index = 22;
        inside_Line_37[22].gameObject.SetActive(true);


        TextContainer1.offsetMin = new Vector2(0, -10022.82f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 33105.89f);    //(오, -위)

    }

    IEnumerator WaitSecond_25()//97
    {
        yield return new WaitForSeconds(36.0f);
        //Line_24.SetActive(true);

        Line_37_Index = 23;
        inside_Line_37[23].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -9705.047f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 33423.66f);    //(오, -위)

    }

    IEnumerator WaitSecond_26()//98
    {
        yield return new WaitForSeconds(37.5f);
        //Line_25.SetActive(true);
        sfx2.Play();
        Line_37_Index = 24;
        inside_Line_37[24].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -9507.138f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 33621.57f);    //(오, -위)
    }

    IEnumerator WaitSecond_27()//99
    {
        yield return new WaitForSeconds(39.0f);
        //Line_26.SetActive(true);

        Line_37_Index = 25;
        inside_Line_37[25].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -9320.378f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 33808.33f);    //(오, -위)

    }

    IEnumerator WaitSecond_28()//100
    {
        yield return new WaitForSeconds(40.5f);
        //Line_27.SetActive(true);

        Line_37_Index = 26;
        inside_Line_37[26].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -8944.071f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 34184.64f);    //(오, -위)

    }

    IEnumerator WaitSecond_29()//101
    {
        yield return new WaitForSeconds(42.0f);
        //Line_28.SetActive(true);

        Line_37_Index = 27;
        inside_Line_37[27].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -8742.619f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 34386.09f);    //(오, -위)

    }

    IEnumerator WaitSecond_30()//102
    {
        yield return new WaitForSeconds(43.5f);
        //Line_29.SetActive(true);

        Line_37_Index = 28;
        inside_Line_37[28].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -8421.19f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 34707.52f);    //(오, -위)

    }

    IEnumerator WaitSecond_31()//103-속마음
    {
        yield return new WaitForSeconds(45.5f);
        //Line_30.SetActive(true);

        QuestObject.BGM_Index = 0;

        QuestObject.Audio_Object[0].gameObject.SetActive(true);
        QuestObject.Audio_Object[1].gameObject.SetActive(false);
        QuestObject.Audio_Object[2].gameObject.SetActive(false);
        QuestObject.Audio_Object[3].gameObject.SetActive(false);
        QuestObject.Audio_Object[4].gameObject.SetActive(false);

        Line_37_Index = 29;
        inside_Line_37[29].gameObject.SetActive(true);

    }

    IEnumerator WaitSecond_32()//베경 검게 만들기
    {
        //대사 맨 위로
        //위치 좌표는 적기
        yield return new WaitForSeconds(48.0f);
        //BackGround_BLACK.SetActive(true);
        //[70]으로 대체
        
        
        //Line_30.SetActive(false);

        Line_37_Index = 70;
        inside_Line_37[29].gameObject.SetActive(false);
        inside_Line_37[70].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -6966.148f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 36162.56f);    //(오, -위)


    }

    IEnumerator WaitSecond_33()//배경 검은데다가 대사 나타내기
                               //104
    {
        //위치 좌표는 적기
        yield return new WaitForSeconds(50.0f);
        //Line_31.SetActive(true);

        Line_37_Index = 30;
        inside_Line_37[30].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -6966.148f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 36162.56f);    //(오, -위)


    }

    IEnumerator WaitSecond_34()//105-속마음

    {
        yield return new WaitForSeconds(52.0f);
        //Line_32.SetActive(true);
        Line_37_Index = 31;
        inside_Line_37[31].gameObject.SetActive(true);


    }

    IEnumerator WaitSecond_35()//106-속마음
    {
        yield return new WaitForSeconds(54.5f);
        //Line_33.SetActive(true);
        //Line_32.SetActive(false);

        Line_37_Index = 32;
        inside_Line_37[32].gameObject.SetActive(true);
        inside_Line_37[31].gameObject.SetActive(false);
    }

    IEnumerator WaitSecond_36()//35로부터 1.5초 뒤에 실행(그냥 평범한 대사가 앞에 있을 경우)
    {//1.5초 뒤에 점점 검게
        yield return new WaitForSeconds(57.0f);
        //Go_Black.SetActive(true);

        FadeObject.Fade_Index = 5;

        FadeObject.fadeObject[1].gameObject.SetActive(false);
        FadeObject.fadeObject[2].gameObject.SetActive(false);
        FadeObject.fadeObject[3].gameObject.SetActive(false);
        FadeObject.fadeObject[4].gameObject.SetActive(false);
        FadeObject.fadeObject[5].gameObject.SetActive(true);
        FadeObject.fadeObject[6].gameObject.SetActive(false);
        FadeObject.fadeObject[7].gameObject.SetActive(false);
        FadeObject.fadeObject[8].gameObject.SetActive(false);
        FadeObject.fadeObject[9].gameObject.SetActive(false);
        FadeObject.fadeObject[10].gameObject.SetActive(false);
        FadeObject.fadeObject[11].gameObject.SetActive(false);
        FadeObject.fadeObject[12].gameObject.SetActive(false);
        FadeObject.fadeObject[13].gameObject.SetActive(false);
        FadeObject.fadeObject[14].gameObject.SetActive(false);

        //Line_33.SetActive(false);

        Line_37_Index = 32;
        inside_Line_37[32].gameObject.SetActive(false);
        //inside_Line_37[31].gameObject.SetActive(false);


        //TextContainer1.offsetMin = new Vector2(0, -6677.5f);//(왼, 아래)
        //TextContainer1.offsetMax = new Vector2(0, 35561.27f);    //(오, -위)


    }

    IEnumerator WaitSecond_37()//페이드 아웃 실행, 페이드 인 지우기
    {//36로부터 1.5초 뒤에 점점 연하게 실행, 검은거 삭제
     //배경 색 회색으로 바꾸기
        yield return new WaitForSeconds(58.5f);

        //Go_Black.SetActive(false);
        //Go_Empty.SetActive(true);

        FadeObject.Fade_Index = 6;

        FadeObject.fadeObject[1].gameObject.SetActive(false);
        FadeObject.fadeObject[2].gameObject.SetActive(false);
        FadeObject.fadeObject[3].gameObject.SetActive(false);
        FadeObject.fadeObject[4].gameObject.SetActive(false);
        FadeObject.fadeObject[5].gameObject.SetActive(false);
        FadeObject.fadeObject[6].gameObject.SetActive(true);
        FadeObject.fadeObject[7].gameObject.SetActive(false);
        FadeObject.fadeObject[8].gameObject.SetActive(false);
        FadeObject.fadeObject[9].gameObject.SetActive(false);
        FadeObject.fadeObject[10].gameObject.SetActive(false);
        FadeObject.fadeObject[11].gameObject.SetActive(false);
        FadeObject.fadeObject[12].gameObject.SetActive(false);
        FadeObject.fadeObject[13].gameObject.SetActive(false);
        FadeObject.fadeObject[14].gameObject.SetActive(false);

        //BackGround_BLACK.SetActive(false);
        //[70]으로 대체

        Line_37_Index = 70;
        inside_Line_37[70].gameObject.SetActive(false);
        //inside_Line_37[31].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -6679.04f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 36449.67f);    //(오, -위)

    }


    IEnumerator WaitSecond_38()//37로부터 4초후에 대사 나타내기
    {//아무것도 없는거 지우기
        //107
        yield return new WaitForSeconds(62.5f);
        //Line_34.SetActive(true);

        Line_37_Index = 33;
        inside_Line_37[33].gameObject.SetActive(true);
        //inside_Line_37[31].gameObject.SetActive(false);


        //Go_Empty.SetActive(false);

        FadeObject.Fade_Index = 6;

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

        TextContainer1.offsetMin = new Vector2(0, -6679.04f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 36449.67f);    //(오, -위)

    }

    IEnumerator WaitSecond_39()//108
    {
        yield return new WaitForSeconds(64.0f);
        //Line_35.SetActive(true);

        Line_37_Index = 34;
        inside_Line_37[34].gameObject.SetActive(true);
        //inside_Line_37[31].gameObject.SetActive(false);

        // % 여기부턴 앨범 관련 %

        //7번 앨범 오픈 관련
        if (All_Save.Album_7[2].gameObject.activeSelf == true)
        {//이미 7번 앨범이 오픈되어 있을 경우
            //오픈한 그대로 둔다

            All_Save.Album7_Index = 2;
            All_Save.Album_7[0].gameObject.SetActive(false);
            All_Save.Album_7[1].gameObject.SetActive(false);
            All_Save.Album_7[2].gameObject.SetActive(true);

        }

        //7번 앨범이 오픈되어 있지 않으면
        else if (All_Save.Album_7[2].gameObject.activeSelf == false)
        {
            //7번 앨범이 오픈되지 못했다면 오픈한다
            All_Save.Album7_Index = 2;
            All_Save.Album_7[0].gameObject.SetActive(false);
            All_Save.Album_7[1].gameObject.SetActive(false);
            All_Save.Album_7[2].gameObject.SetActive(true);

        }

        //7 번째 앨범 관련하여 자동 저장
        PlayerPrefs.SetInt("Album_7", All_Save.Album7_Index);

        // % 여기부턴 다음 앨범에 대한 힌트 제공 %

        //8번 앨범 오픈 관련
        if (All_Save.Album_8[2].gameObject.activeSelf == true)
        {//이미 8번 앨범이 오픈되어 있을 경우
            //오픈한 그대로 둔다

            All_Save.Album8_Index = 2;
            All_Save.Album_8[0].gameObject.SetActive(false);
            All_Save.Album_8[1].gameObject.SetActive(false);
            All_Save.Album_8[2].gameObject.SetActive(true);

        }

        //8번 앨범이 오픈되어 있지 않으면
        else if (All_Save.Album_8[2].gameObject.activeSelf == false)
        {
            //8번 앨범에 대한 힌트를 준다
            All_Save.Album8_Index = 1;
            All_Save.Album_8[0].gameObject.SetActive(false);
            All_Save.Album_8[1].gameObject.SetActive(true);
            All_Save.Album_8[2].gameObject.SetActive(false);

        }

        //8 번째 앨범 관련하여 자동 저장
        PlayerPrefs.SetInt("Album_8", All_Save.Album8_Index);

        TextContainer1.offsetMin = new Vector2(0, -6679.04f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 36449.67f);    //(오, -위)

    }

    IEnumerator WaitSecond_40()//109-1
    {
        yield return new WaitForSeconds(65.5f);
        //Line_36.SetActive(true);

        Line_37_Index = 35;
        inside_Line_37[35].gameObject.SetActive(true);
        //inside_Line_37[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -6679.04f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 36449.67f);    //(오, -위)

    }

    IEnumerator WaitSecond_41()//109-2
    {
        yield return new WaitForSeconds(67.0f);
        //Line_37.SetActive(true);

        Line_37_Index = 36;
        inside_Line_37[36].gameObject.SetActive(true);
        //inside_Line_37[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -6614.929f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 36513.78f);    //(오, -위)

    }

    IEnumerator WaitSecond_42()//110-속마음
    {
        yield return new WaitForSeconds(69.0f);
        //Line_38.SetActive(true);

        Line_37_Index = 37;
        inside_Line_37[37].gameObject.SetActive(true);
        //inside_Line_37[31].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_43()//111-속마음
    {
        yield return new WaitForSeconds(72.0f);
        //Line_39.SetActive(true);
        //Line_38.SetActive(false);

        Line_37_Index = 38;
        inside_Line_37[38].gameObject.SetActive(true);
        inside_Line_37[37].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_44()//112
    {
        yield return new WaitForSeconds(74.5f);
        //Line_40.SetActive(true);
        //Line_39.SetActive(false);

        Line_37_Index = 39;
        inside_Line_37[39].gameObject.SetActive(true);
        inside_Line_37[38].gameObject.SetActive(false);

        // % 여기부턴 앨범 관련 %

        //8번 앨범 오픈 관련
        if (All_Save.Album_8[2].gameObject.activeSelf == true)
        {//이미 8번 앨범이 오픈되어 있을 경우
            //오픈한 그대로 둔다

            All_Save.Album8_Index = 2;
            All_Save.Album_8[0].gameObject.SetActive(false);
            All_Save.Album_8[1].gameObject.SetActive(false);
            All_Save.Album_8[2].gameObject.SetActive(true);

        }

        //8번 앨범이 오픈되어 있지 않으면
        else if (All_Save.Album_8[2].gameObject.activeSelf == false)
        {
            //8번 앨범이 오픈되지 못했다면 오픈한다
            All_Save.Album8_Index = 2;
            All_Save.Album_8[0].gameObject.SetActive(false);
            All_Save.Album_8[1].gameObject.SetActive(false);
            All_Save.Album_8[2].gameObject.SetActive(true);

        }

        //8 번째 앨범 관련하여 자동 저장
        PlayerPrefs.SetInt("Album_8", All_Save.Album8_Index);

        TextContainer1.offsetMin = new Vector2(0, -5904.514f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 37224.2f);    //(오, -위)

    }

    IEnumerator WaitSecond_45()//113-1
    {
        yield return new WaitForSeconds(76.0f);
        //Line_41.SetActive(true);

        Line_37_Index = 40;
        inside_Line_37[40].gameObject.SetActive(true);
        //inside_Line_37[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5595.336f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 37533.38f);    //(오, -위)

    }

    IEnumerator WaitSecond_46()//113-2
    {
        yield return new WaitForSeconds(77.5f);
        //Line_42.SetActive(true);

        Line_37_Index = 41;
        inside_Line_37[41].gameObject.SetActive(true);
        //inside_Line_37[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5444.813f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 37683.9f);    //(오, -위)

    }

    IEnumerator WaitSecond_47()//113-3
    {
        yield return new WaitForSeconds(79.0f);
        // Line_43.SetActive(true);

        Line_37_Index = 42;
        inside_Line_37[42].gameObject.SetActive(true);
        //inside_Line_37[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5288.716f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 37840f);    //(오, -위)

    }

    IEnumerator WaitSecond_48()//114전
                               //맨 위로 보내기
    {
        yield return new WaitForSeconds(80.5f);

        QuestObject.BGM_Index = 1;

        QuestObject.Audio_Object[0].gameObject.SetActive(false);
        QuestObject.Audio_Object[1].gameObject.SetActive(true);
        QuestObject.Audio_Object[2].gameObject.SetActive(false);
        QuestObject.Audio_Object[3].gameObject.SetActive(false);
        QuestObject.Audio_Object[4].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3830.277f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 39298.43f);    //(오, -위)

    }

    IEnumerator WaitSecond_49()//114-1
    {//48로부터 2초 후 다음 거 나타내기
        yield return new WaitForSeconds(82.5f);
        //Line_44.SetActive(true);

        sfx3.Play();

        Line_37_Index = 43;
        inside_Line_37[43].gameObject.SetActive(true);
        //inside_Line_37[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3830.277f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 39298.43f);    //(오, -위)

    }

    IEnumerator WaitSecond_50()//14-2
    {
        yield return new WaitForSeconds(84.0f);
        //Line_45.SetActive(true);

        Line_37_Index = 44;
        inside_Line_37[44].gameObject.SetActive(true);
        //inside_Line_37[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3830.277f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 39298.43f);    //(오, -위)

    }

    IEnumerator WaitSecond_51()//115-속마음
    {
        yield return new WaitForSeconds(86.0f);
        //Line_46.SetActive(true);

        Line_37_Index = 45;
        inside_Line_37[45].gameObject.SetActive(true);
        //inside_Line_37[31].gameObject.SetActive(false);
    }

    IEnumerator WaitSecond_52()//116속마음
    {
        yield return new WaitForSeconds(88.5f);
        //Line_47.SetActive(true);
        //Line_46.SetActive(false);

        Line_37_Index = 46;
        inside_Line_37[46].gameObject.SetActive(true);
        inside_Line_37[45].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_53()//117
    {
        yield return new WaitForSeconds(92.5f);
        //Line_48.SetActive(true);
        //Line_47.SetActive(false);

        sfx4.Play();

        Line_37_Index = 47;
        inside_Line_37[47].gameObject.SetActive(true);
        inside_Line_37[46].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3830.277f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 39298.43f);    //(오, -위)

    }

    IEnumerator WaitSecond_54()//118
    {
        yield return new WaitForSeconds(94.0f);
        //Line_49.SetActive(true);

        Line_37_Index = 48;
        inside_Line_37[48].gameObject.SetActive(true);
        //inside_Line_37[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3830.277f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 39298.43f);    //(오, -위)

    }

    IEnumerator WaitSecond_55()//119
    {
        yield return new WaitForSeconds(95.5f);
        //Line_50.SetActive(true);

        Line_37_Index = 49;
        inside_Line_37[49].gameObject.SetActive(true);
        //inside_Line_37[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3830.277f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 39298.43f);    //(오, -위)

    }

    IEnumerator WaitSecond_56()//120
    {
        yield return new WaitForSeconds(97.0f);
        //Line_51.SetActive(true);

        Line_37_Index = 50;
        inside_Line_37[50].gameObject.SetActive(true);
        //inside_Line_37[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3337.906f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 39790.8f);    //(오, -위)

    }

    IEnumerator WaitSecond_57()//121-1
    {
        yield return new WaitForSeconds(98.5f);
        //Line_52.SetActive(true);

        Line_37_Index = 51;
        inside_Line_37[51].gameObject.SetActive(true);
        //inside_Line_37[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3039.648f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 40089.06f);    //(오, -위)

    }

    IEnumerator WaitSecond_58()//121-2
    {
        yield return new WaitForSeconds(100.0f);
        //Line_53.SetActive(true);

        Line_37_Index = 52;
        inside_Line_37[52].gameObject.SetActive(true);
        //inside_Line_37[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2889.125f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 40239.59f);    //(오, -위)

    }

    IEnumerator WaitSecond_59()//122-1
    {
        yield return new WaitForSeconds(101.5f);
        //Line_54.SetActive(true);

        Line_37_Index = 53;
        inside_Line_37[53].gameObject.SetActive(true);
        //inside_Line_37[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2602.018f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 40526.7f);    //(오, -위)

    }

    IEnumerator WaitSecond_60()//122-2
    {
        yield return new WaitForSeconds(103.0f);
        //Line_55.SetActive(true);

        Line_37_Index = 54;
        inside_Line_37[54].gameObject.SetActive(true);
        //inside_Line_37[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2457.07f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 40671.64f);    //(오, -위)

    }

    IEnumerator WaitSecond_61()//123
    {
        yield return new WaitForSeconds(104.5f);
        //Line_56.SetActive(true);

        Line_37_Index = 55;
        inside_Line_37[55].gameObject.SetActive(true);
        //inside_Line_37[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2161.6f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 40967.11f);    //(오, -위)

    }

    IEnumerator WaitSecond_62()//124
    {
        yield return new WaitForSeconds(106.0f);
        //Line_57.SetActive(true);

        Line_37_Index = 56;
        inside_Line_37[56].gameObject.SetActive(true);
        //inside_Line_37[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1880.066f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 41248.64f);    //(오, -위)

    }

    IEnumerator WaitSecond_63()//125-속마음
    {
        yield return new WaitForSeconds(108.0f);
        //Line_58.SetActive(true);
        Line_37_Index = 57;
        inside_Line_37[57].gameObject.SetActive(true);
        //inside_Line_37[31].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_64()//126-속마음
    {
        yield return new WaitForSeconds(110.0f);
        //Line_59.SetActive(true);
        //Line_58.SetActive(false);

        Line_37_Index = 58;
        inside_Line_37[58].gameObject.SetActive(true);
        inside_Line_37[57].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_65()//127-속마음
    {
        yield return new WaitForSeconds(113.0f);
        //Line_60.SetActive(true);
        //Line_59.SetActive(false);

        Line_37_Index = 59;
        inside_Line_37[59].gameObject.SetActive(true);
        inside_Line_37[58].gameObject.SetActive(false);


    }
    IEnumerator WaitSecond_66()//128
    {
        yield return new WaitForSeconds(116.0f);
        //Line_61.SetActive(true);
        //Line_60.SetActive(false);

        Line_37_Index = 60;
        inside_Line_37[60].gameObject.SetActive(true);
        inside_Line_37[59].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1587.383f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 41541.33f);    //(오, -위)

    }

    IEnumerator WaitSecond_67()//129
    {
        yield return new WaitForSeconds(117.5f);
        //Line_62.SetActive(true);

        Line_37_Index = 61;
        inside_Line_37[61].gameObject.SetActive(true);
        //inside_Line_37[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1308.637f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 41820.07f);    //(오, -위)

    }

    IEnumerator WaitSecond_68()//130
    {
        yield return new WaitForSeconds(119.0f);
        // Line_63.SetActive(true);

        Line_37_Index = 62;
        inside_Line_37[62].gameObject.SetActive(true);
        //inside_Line_37[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1024.316f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 42104.39f);    //(오, -위)

    }

    IEnumerator WaitSecond_69()//131
    {
        yield return new WaitForSeconds(120.5f);
        //Line_64.SetActive(true);

        Line_37_Index = 63;
        inside_Line_37[63].gameObject.SetActive(true);
        //inside_Line_37[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -728.8457f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 42399.87f);    //(오, -위)

    }

    IEnumerator WaitSecond_70()//132
    {
        yield return new WaitForSeconds(122.0f);
        //Line_65.SetActive(true);

        Line_37_Index = 64;
        inside_Line_37[64].gameObject.SetActive(true);
        //inside_Line_37[31].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -438.9512f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 42689.76f);    //(오, -위)

    }

    IEnumerator WaitSecond_71()//133-속마음
    {
        yield return new WaitForSeconds(124.0f);
        //Line_66.SetActive(true);

        Line_37_Index = 65;
        inside_Line_37[65].gameObject.SetActive(true);
        //inside_Line_37[31].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_72()//134-속마음
    {
        yield return new WaitForSeconds(126.0f);
        //Line_67.SetActive(true);
        //Line_66.SetActive(false);

        Line_37_Index = 66;
        inside_Line_37[66].gameObject.SetActive(true);
        inside_Line_37[65].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_73()//135-속마음
    {
        yield return new WaitForSeconds(130.0f);
        //Line_68.SetActive(true);
        //Line_67.SetActive(false);

        Line_37_Index = 67;
        inside_Line_37[67].gameObject.SetActive(true);
        inside_Line_37[66].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_74()//136-속마음
    {
        yield return new WaitForSeconds(133.0f);
        //Line_69.SetActive(true);
        //Line_68.SetActive(false);

        Line_37_Index = 68;
        inside_Line_37[68].gameObject.SetActive(true);
        inside_Line_37[67].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_75()//137-선택지
    {
        yield return new WaitForSeconds(135.5f);
        //Line_70.SetActive(true);
        //Line_69.SetActive(false);

        Line_37_Index = 69;
        inside_Line_37[69].gameObject.SetActive(true);
        inside_Line_37[68].gameObject.SetActive(false);

        inside_69.Line_69_Index = 0;
        inside_69.inside_Line_69[0].gameObject.SetActive(false);
        inside_69.inside_Line_69[1].gameObject.SetActive(false);
        inside_69.inside_Line_69[2].gameObject.SetActive(false);
        inside_69.inside_Line_69[3].gameObject.SetActive(false);
        inside_69.inside_Line_69[4].gameObject.SetActive(false);
        inside_69.inside_Line_69[5].gameObject.SetActive(false);
        inside_69.inside_Line_69[6].gameObject.SetActive(false);
        inside_69.inside_Line_69[7].gameObject.SetActive(false);
        inside_69.inside_Line_69[8].gameObject.SetActive(false);
        inside_69.inside_Line_69[9].gameObject.SetActive(false);
        inside_69.inside_Line_69[10].gameObject.SetActive(false);
        inside_69.inside_Line_69[11].gameObject.SetActive(false);
        inside_69.inside_Line_69[12].gameObject.SetActive(false);
        inside_69.inside_Line_69[13].gameObject.SetActive(false);
        inside_69.inside_Line_69[14].gameObject.SetActive(false);
        inside_69.inside_Line_69[15].gameObject.SetActive(false);
        inside_69.inside_Line_69[16].gameObject.SetActive(false);
        inside_69.inside_Line_69[17].gameObject.SetActive(false);
        inside_69.inside_Line_69[18].gameObject.SetActive(false);
        inside_69.inside_Line_69[19].gameObject.SetActive(false);
        inside_69.inside_Line_69[20].gameObject.SetActive(false);
        inside_69.inside_Line_69[21].gameObject.SetActive(false);
        inside_69.inside_Line_69[22].gameObject.SetActive(false);
        inside_69.inside_Line_69[23].gameObject.SetActive(false);
        inside_69.inside_Line_69[24].gameObject.SetActive(false);
        inside_69.inside_Line_69[25].gameObject.SetActive(false);
        inside_69.inside_Line_69[26].gameObject.SetActive(false);
        inside_69.inside_Line_69[27].gameObject.SetActive(false);
        inside_69.inside_Line_69[28].gameObject.SetActive(false);
        inside_69.inside_Line_69[29].gameObject.SetActive(false);
        inside_69.inside_Line_69[30].gameObject.SetActive(false);
        inside_69.inside_Line_69[31].gameObject.SetActive(false);
        inside_69.inside_Line_69[32].gameObject.SetActive(false);
        inside_69.inside_Line_69[33].gameObject.SetActive(false);
        inside_69.inside_Line_69[34].gameObject.SetActive(false);
        inside_69.inside_Line_69[35].gameObject.SetActive(false);
        inside_69.inside_Line_69[36].gameObject.SetActive(false);
        inside_69.inside_Line_69[37].gameObject.SetActive(false);
        inside_69.inside_Line_69[38].gameObject.SetActive(false);
        inside_69.inside_Line_69[39].gameObject.SetActive(false);
        inside_69.inside_Line_69[40].gameObject.SetActive(false);
        inside_69.inside_Line_69[41].gameObject.SetActive(false);
        inside_69.inside_Line_69[42].gameObject.SetActive(false);
        inside_69.inside_Line_69[43].gameObject.SetActive(false);
        inside_69.inside_Line_69[44].gameObject.SetActive(false);
        inside_69.inside_Line_69[45].gameObject.SetActive(false);
        inside_69.inside_Line_69[46].gameObject.SetActive(false);
        inside_69.inside_Line_69[47].gameObject.SetActive(false);
        inside_69.inside_Line_69[48].gameObject.SetActive(false);
        inside_69.inside_Line_69[49].gameObject.SetActive(false);
        inside_69.inside_Line_69[50].gameObject.SetActive(false);
        inside_69.inside_Line_69[51].gameObject.SetActive(false);

        inside_53.Line_53_Index = 0;
        inside_53.inside_Line_53[0].gameObject.SetActive(false);
        inside_53.inside_Line_53[1].gameObject.SetActive(false);
        inside_53.inside_Line_53[2].gameObject.SetActive(false);
        inside_53.inside_Line_53[3].gameObject.SetActive(false);
        inside_53.inside_Line_53[4].gameObject.SetActive(false);
        inside_53.inside_Line_53[5].gameObject.SetActive(false);
        inside_53.inside_Line_53[6].gameObject.SetActive(false);
        inside_53.inside_Line_53[7].gameObject.SetActive(false);
        inside_53.inside_Line_53[8].gameObject.SetActive(false);
        inside_53.inside_Line_53[9].gameObject.SetActive(false);
        inside_53.inside_Line_53[10].gameObject.SetActive(false);
        inside_53.inside_Line_53[11].gameObject.SetActive(false);
        inside_53.inside_Line_53[12].gameObject.SetActive(false);
        inside_53.inside_Line_53[13].gameObject.SetActive(false);
        inside_53.inside_Line_53[14].gameObject.SetActive(false);
        inside_53.inside_Line_53[15].gameObject.SetActive(false);
        inside_53.inside_Line_53[16].gameObject.SetActive(false);
        inside_53.inside_Line_53[17].gameObject.SetActive(false);
        inside_53.inside_Line_53[18].gameObject.SetActive(false);
        inside_53.inside_Line_53[19].gameObject.SetActive(false);
        inside_53.inside_Line_53[20].gameObject.SetActive(false);
        inside_53.inside_Line_53[21].gameObject.SetActive(false);
        inside_53.inside_Line_53[22].gameObject.SetActive(false);
        inside_53.inside_Line_53[23].gameObject.SetActive(false);
        inside_53.inside_Line_53[24].gameObject.SetActive(false);
        inside_53.inside_Line_53[25].gameObject.SetActive(false);
        inside_53.inside_Line_53[26].gameObject.SetActive(false);
        inside_53.inside_Line_53[27].gameObject.SetActive(false);
        inside_53.inside_Line_53[28].gameObject.SetActive(false);
        inside_53.inside_Line_53[29].gameObject.SetActive(false);
        inside_53.inside_Line_53[30].gameObject.SetActive(false);
        inside_53.inside_Line_53[31].gameObject.SetActive(false);
        inside_53.inside_Line_53[32].gameObject.SetActive(false);
        inside_53.inside_Line_53[33].gameObject.SetActive(false);
        inside_53.inside_Line_53[34].gameObject.SetActive(false);
        inside_53.inside_Line_53[35].gameObject.SetActive(false);
        inside_53.inside_Line_53[36].gameObject.SetActive(false);
        inside_53.inside_Line_53[37].gameObject.SetActive(false);
        inside_53.inside_Line_53[38].gameObject.SetActive(false);
        inside_53.inside_Line_53[39].gameObject.SetActive(false);
        inside_53.inside_Line_53[40].gameObject.SetActive(false);
        inside_53.inside_Line_53[41].gameObject.SetActive(false);
        inside_53.inside_Line_53[42].gameObject.SetActive(false);
        inside_53.inside_Line_53[43].gameObject.SetActive(false);
        inside_53.inside_Line_53[44].gameObject.SetActive(false);
        inside_53.inside_Line_53[45].gameObject.SetActive(false);
        inside_53.inside_Line_53[46].gameObject.SetActive(false);
        inside_53.inside_Line_53[47].gameObject.SetActive(false);
        inside_53.inside_Line_53[48].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, 0.1015625f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 43128.81f);    //(오, -위)

    }


}
