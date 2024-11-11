using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
public class Line_142 : MonoBehaviour
{
    public Save_Collection All_Save;
    public AudioSource sfx5;
    public Like_1_4_11 Line_140;
    
    public Only_Line QuestObject;

    public RectTransform TextContainer1;//텍스트 컨테이너

    public GameObject[] inside_Line_142;
    public int Line_142_Index;
    public Fade_Collect FadeObject;
    public IEnumerator m_Coroutine;//원래 private였음

    void Start()
    {

        m_Coroutine = WaitSecond_0();

    }

    void Update()
    {
        StartCoroutine(m_Coroutine);
    }

    public IEnumerator WaitSecond_0()
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

        QuestObject.Line_Index = 142;

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
        QuestObject.questObject[142].gameObject.SetActive(true);
        QuestObject.questObject[143].gameObject.SetActive(false);
        QuestObject.questObject[144].gameObject.SetActive(false);
        QuestObject.questObject[145].gameObject.SetActive(false);
        QuestObject.questObject[146].gameObject.SetActive(false);
        QuestObject.questObject[147].gameObject.SetActive(false);
        QuestObject.questObject[148].gameObject.SetActive(false);
        QuestObject.questObject[149].gameObject.SetActive(false);




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

        Line_142_Index = 0;
        inside_Line_142[0].gameObject.SetActive(true);

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

        Line_140.Like_1_4_11_Index = 0;
        Line_140.inside_Like_1_4_11[0].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[1].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[2].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[3].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[4].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[5].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[6].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[7].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[8].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[9].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[10].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[11].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[12].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[13].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[14].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[15].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[16].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[17].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[18].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[19].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[20].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[21].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[22].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[23].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[24].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[25].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[26].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[27].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[28].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[29].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[30].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[31].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[32].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[33].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[34].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[35].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[36].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[37].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[38].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[39].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[40].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[41].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[42].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[43].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[44].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[45].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[46].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[47].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[48].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[49].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[50].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[51].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[52].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[53].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[54].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[55].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[56].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[57].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[58].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[59].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[60].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[61].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[62].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[63].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[64].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[65].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[66].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[67].gameObject.SetActive(false);
        Line_140.inside_Like_1_4_11[68].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -9632.435f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 13974.23f);    //(오, 위)


    }

    IEnumerator WaitSecond_2()//134-속마음
    {
        yield return new WaitForSeconds(3.0f);
        //Line_2.SetActive(true);
        //Line_1.SetActive(false);

        FadeObject.Fade_Index = 8;
        FadeObject.fadeObject[8].gameObject.SetActive(false);

        Line_142_Index = 1;
        inside_Line_142[1].gameObject.SetActive(true);
        inside_Line_142[0].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_3()//135-속마음
    {

        yield return new WaitForSeconds(5.5f);
        //Line_3.SetActive(true);
        //Line_2.SetActive(false);

        Line_142_Index = 2;
        inside_Line_142[2].gameObject.SetActive(true);
        inside_Line_142[1].gameObject.SetActive(false);



    }

    IEnumerator WaitSecond_4()//136-1
    {
        yield return new WaitForSeconds(8.5f);
        //Line_4.SetActive(true);
        //Line_3.SetActive(false);

        Line_142_Index = 3;
        inside_Line_142[3].gameObject.SetActive(true);
        inside_Line_142[2].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -9339.895f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 14266.77f);    //(오, 위)


    }

    IEnumerator WaitSecond_5()//136-2
    {
        yield return new WaitForSeconds(10.0f);
        //Line_5.SetActive(true);

        Line_142_Index = 4;
        inside_Line_142[4].gameObject.SetActive(true);
        //inside_Line_142[3].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -9128.047f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 14478.61f);    //(오, 위)

    }

    IEnumerator WaitSecond_6()//137-속마음
    {

        yield return new WaitForSeconds(12.0f);
        // Line_6.SetActive(true);

        Line_142_Index = 5;
        inside_Line_142[5].gameObject.SetActive(true);
        //inside_Line_142[3].gameObject.SetActive(false);




    }

    IEnumerator WaitSecond_7()//138-속마음
    {
        yield return new WaitForSeconds(14.5f);
        //Line_7.SetActive(true);
        //Line_6.SetActive(false);
        Line_142_Index = 6;
        inside_Line_142[6].gameObject.SetActive(true);
        inside_Line_142[5].gameObject.SetActive(false);




    }

    IEnumerator WaitSecond_8()//139-1
    {
        yield return new WaitForSeconds(16.5f);
        //Line_8.SetActive(true);
        //Line_7.SetActive(false);

        Line_142_Index = 7;
        inside_Line_142[7].gameObject.SetActive(true);
        inside_Line_142[6].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8842.091f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 14764.57f);    //(오, 위)

    }

    IEnumerator WaitSecond_9()//139-2
    {
        yield return new WaitForSeconds(18.0f);
        //Line_9.SetActive(true);

        Line_142_Index = 8;
        inside_Line_142[8].gameObject.SetActive(true);
        //inside_Line_142[7].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8683.205f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 14923.46f);    //(오, 위)

    }

    IEnumerator WaitSecond_10()//140
    {
        yield return new WaitForSeconds(19.5f);
        // Line_10.SetActive(true);

        Line_142_Index = 9;
        inside_Line_142[9].gameObject.SetActive(true);
        //inside_Line_142[7].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8451.847f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 15154.81f);    //(오, 위)

    }

    IEnumerator WaitSecond_11()//141-1
    {
        yield return new WaitForSeconds(21.0f);
       // Line_11.SetActive(true);

        Line_142_Index = 10;
        inside_Line_142[10].gameObject.SetActive(true);
        //inside_Line_142[7].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8156.376f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 15450.28f);    //(오, 위)

    }

    IEnumerator WaitSecond_12()//141-2
    {
        yield return new WaitForSeconds(22.5f);
        //Line_12.SetActive(true);

        Line_142_Index = 11;
        inside_Line_142[11].gameObject.SetActive(true);
        //inside_Line_142[7].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -8011.429f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 15595.23f);    //(오, 위)

    }

    IEnumerator WaitSecond_13()//142-속마음
    {
        yield return new WaitForSeconds(24.5f);
        //Line_13.SetActive(true);

        Line_142_Index = 12;
        inside_Line_142[12].gameObject.SetActive(true);
        //inside_Line_142[7].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_14()//143-속마음
    {
        yield return new WaitForSeconds(26.5f);
        //Line_14.SetActive(true);
        //Line_13.SetActive(false);

        Line_142_Index = 13;
        inside_Line_142[13].gameObject.SetActive(true);
        inside_Line_142[12].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_15()//144
    {
        yield return new WaitForSeconds(29.5f);
        //Line_15.SetActive(true);
        //Line_14.SetActive(false);

        Line_142_Index = 14;
        inside_Line_142[14].gameObject.SetActive(true);
        inside_Line_142[13].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7727.108f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 15879.55f);    //(오, 위)

    }

    IEnumerator WaitSecond_16()//145-1
    {
        yield return new WaitForSeconds(31.0f);
        //Line_16.SetActive(true);

        Line_142_Index = 15;
        inside_Line_142[15].gameObject.SetActive(true);
        //inside_Line_142[14].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7437.212f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 16169.45f);    //(오, -위)

    }

    IEnumerator WaitSecond_17()//145-2
    {
        yield return new WaitForSeconds(32.5f);
        //Line_17.SetActive(true);

        Line_142_Index = 16;
        inside_Line_142[16].gameObject.SetActive(true);
        //inside_Line_142[15].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7281.115f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 16325.54f);    //(오, 위)


    }

    IEnumerator WaitSecond_18()//145-3
    {
        yield return new WaitForSeconds(34.0f);
        //Line_18.SetActive(true);

        Line_142_Index = 17;
        inside_Line_142[17].gameObject.SetActive(true);
        //inside_Line_142[14].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -7066.48f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 16540.18f);    //(오, 위)

    }

    IEnumerator WaitSecond_19()//146하기 전 맨 위로 배치
    {
        yield return new WaitForSeconds(35.5f);


        TextContainer1.offsetMin = new Vector2(0, -5613.01f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 17993.65f);    //(오, -위)
    }

    IEnumerator WaitSecond_20()//146
    {
        yield return new WaitForSeconds(37.5f);
        //Line_19.SetActive(true);

        Line_142_Index = 18;
        inside_Line_142[18].gameObject.SetActive(true);
        //inside_Line_142[14].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5613.01f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 17993.65f);    //(오, -위)
    }

    IEnumerator WaitSecond_21()//147
    {
        yield return new WaitForSeconds(39.0f);

        //Line_20.SetActive(true);

        Line_142_Index = 19;
        inside_Line_142[19].gameObject.SetActive(true);
        //inside_Line_142[14].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5613.01f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 17993.65f);    //(오, -위)

    }

    IEnumerator WaitSecond_22()//148
    {
        yield return new WaitForSeconds(40.5f);
        //Line_21.SetActive(true);

        Line_142_Index = 20;
        inside_Line_142[20].gameObject.SetActive(true);
        //inside_Line_142[14].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5613.01f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 17993.65f);    //(오, -위)

    }

    IEnumerator WaitSecond_23()//149
    {
        yield return new WaitForSeconds(42.0f);
        //Line_22.SetActive(true);

        sfx5.Play();
        Line_142_Index = 21;
        inside_Line_142[21].gameObject.SetActive(true);
        //inside_Line_142[14].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5613.01f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 17993.65f);    //(오, -위)
    }

    IEnumerator WaitSecond_24()//150
    {
        yield return new WaitForSeconds(43.5f);

        //Line_23.SetActive(true);

        Line_142_Index = 22;
        inside_Line_142[22].gameObject.SetActive(true);
        //inside_Line_142[14].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -5265.135f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 18341.53f);    //(오, -위)

    }

    IEnumerator WaitSecond_25()//151-속마음
    {
        yield return new WaitForSeconds(45.5f);
        //Line_24.SetActive(true);

        Line_142_Index = 23;
        inside_Line_142[23].gameObject.SetActive(true);
        //inside_Line_142[14].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_26()//152-속마음
    {
        yield return new WaitForSeconds(48.5f);

        //Line_25.SetActive(true);
        // Line_24.SetActive(false);

        Line_142_Index = 24;
        inside_Line_142[24].gameObject.SetActive(true);
        inside_Line_142[23].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_27()//153
    {
        yield return new WaitForSeconds(50.5f);
        //Line_26.SetActive(true);
        //Line_25.SetActive(false);

        Line_142_Index = 25;
        inside_Line_142[25].gameObject.SetActive(true);
        inside_Line_142[24].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -4975.86f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 18630.8f);    //(오, -위)

    }

    IEnumerator WaitSecond_28()//154
    {
        yield return new WaitForSeconds(52.0f);
        //Line_27.SetActive(true);

        Line_142_Index = 26;
        inside_Line_142[26].gameObject.SetActive(true);
        //inside_Line_142[25].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4685.965f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 18920.7f);    //(오, -위)

    }

    IEnumerator WaitSecond_29()//155
    {
        yield return new WaitForSeconds(53.5f);
        // Line_28.SetActive(true);

        Line_142_Index = 27;
        inside_Line_142[27].gameObject.SetActive(true);
        //inside_Line_142[26].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -4410.007f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 19196.65f);    //(오, -위)
    }

    IEnumerator WaitSecond_30()//156되기 전에 맨 위로 올리기
    {
        yield return new WaitForSeconds(55.0f);

        TextContainer1.offsetMin = new Vector2(0, -2947.868f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 20658.79f);    //(오, -위)

    }

    IEnumerator WaitSecond_31()//156
    {
        yield return new WaitForSeconds(57.0f);
        //Line_29.SetActive(true);

        Line_142_Index = 28;
        inside_Line_142[28].gameObject.SetActive(true);
        //inside_Line_142[23].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2947.868f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 20658.79f);    //(오, -위)

    }

    IEnumerator WaitSecond_32()//157
    {
        yield return new WaitForSeconds(58.5f);
        //Line_30.SetActive(true);

        Line_142_Index = 29;
        inside_Line_142[29].gameObject.SetActive(true);
        //inside_Line_142[23].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -2947.868f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 20658.79f);    //(오, -위)

    }

    IEnumerator WaitSecond_33()//158-속마음
    {
        yield return new WaitForSeconds(60.5f);
        //Line_31.SetActive(true);

        Line_142_Index = 30;
        inside_Line_142[30].gameObject.SetActive(true);
        //inside_Line_142[23].gameObject.SetActive(false);





    }

    IEnumerator WaitSecond_34()//159-속마음
    {
        yield return new WaitForSeconds(63.0f);
        //Line_32.SetActive(true);
        //Line_31.SetActive(false);

        Line_142_Index = 31;
        inside_Line_142[31].gameObject.SetActive(true);
        inside_Line_142[30].gameObject.SetActive(false);



    }

    IEnumerator WaitSecond_35()//160-속마음
    {

        yield return new WaitForSeconds(66.0f);
        //Line_33.SetActive(true);
        //Line_32.SetActive(false);

        Line_142_Index = 32;
        inside_Line_142[32].gameObject.SetActive(true);
        inside_Line_142[31].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_36()//161
    {

        yield return new WaitForSeconds(69.5f);
        //Line_34.SetActive(true);
        //Line_33.SetActive(false);

        Line_142_Index = 33;
        inside_Line_142[33].gameObject.SetActive(true);
        inside_Line_142[32].gameObject.SetActive(false);
        TextContainer1.offsetMin = new Vector2(0, -2947.868f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 20658.79f);    //(오, -위)


    }

    IEnumerator WaitSecond_37()//162

    {
        yield return new WaitForSeconds(71.0f);
        // Line_35.SetActive(true);

        Line_142_Index = 34;
        inside_Line_142[34].gameObject.SetActive(true);
        //inside_Line_142[30].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2947.868f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 20658.79f);    //(오, -위)



    }

    IEnumerator WaitSecond_38()//163
    {
        yield return new WaitForSeconds(72.5f);
        // Line_36.SetActive(true);

        Line_142_Index = 35;
        inside_Line_142[35].gameObject.SetActive(true);
        //inside_Line_142[30].gameObject.SetActive(false);
        TextContainer1.offsetMin = new Vector2(0, -2947.868f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 20658.79f);    //(오, -위)


    }

    IEnumerator WaitSecond_39()//164
    {
        yield return new WaitForSeconds(74.0f);

        //Line_37.SetActive(true);

        Line_142_Index = 36;
        inside_Line_142[36].gameObject.SetActive(true);
        //inside_Line_142[30].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2674.632f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 20932.03f);    //(오, -위)


    }

    IEnumerator WaitSecond_40()//165
    {
        yield return new WaitForSeconds(75.5f);
        //Line_38.SetActive(true);

        Line_142_Index = 37;
        inside_Line_142[37].gameObject.SetActive(true);
        //inside_Line_142[30].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2465.105f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 21141.55f);    //(오, -위)

    }


    IEnumerator WaitSecond_41()//166-1
    {
        yield return new WaitForSeconds(77.0f);
        //Line_39.SetActive(true);

        Line_142_Index = 38;
        inside_Line_142[38].gameObject.SetActive(true);
        //inside_Line_142[30].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2174.052f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 21432.61f);    //(오, -위)

    }

    IEnumerator WaitSecond_42()//166-2
    {
        yield return new WaitForSeconds(78.5f);
        //Line_40.SetActive(true);

        Line_142_Index = 39;
        inside_Line_142[39].gameObject.SetActive(true);
        //inside_Line_142[30].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -2017.229f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 21589.43f);    //(오, -위)

    }

    IEnumerator WaitSecond_43()//167-1
    {
        yield return new WaitForSeconds(80.0f);
        //Line_41.SetActive(true);

        Line_142_Index = 40;
        inside_Line_142[40].gameObject.SetActive(true);
        //inside_Line_142[30].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1729.773f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 21876.89f);    //(오, -위)

    }

    IEnumerator WaitSecond_44()//167-2
    {
        yield return new WaitForSeconds(81.5f);
        //Line_42.SetActive(true);

        Line_142_Index = 41;
        inside_Line_142[41].gameObject.SetActive(true);
        //inside_Line_142[30].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1573.676f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 22032.98f);    //(오, -위)

    }

    IEnumerator WaitSecond_45()//168-속마음
    {
        yield return new WaitForSeconds(83.5f);
        //Line_43.SetActive(true);

        Line_142_Index = 42;
        inside_Line_142[42].gameObject.SetActive(true);
        //inside_Line_142[30].gameObject.SetActive(false);



    }

    IEnumerator WaitSecond_46()//169-1
    {
        yield return new WaitForSeconds(85.5f);
        //Line_44.SetActive(true);
        //Line_43.SetActive(false);

        Line_142_Index = 43;
        inside_Line_142[43].gameObject.SetActive(true);
        inside_Line_142[42].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -1289.355f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 22317.3f);    //(오, -위)



    }

    IEnumerator WaitSecond_47()//169-2
    {
        yield return new WaitForSeconds(87.0f);
        // Line_45.SetActive(true);


        Line_142_Index = 44;
        inside_Line_142[44].gameObject.SetActive(true);
        //inside_Line_142[42].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1138.607f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 22468.05f);    //(오, -위)

    }

    IEnumerator WaitSecond_48()//170-1
    {
        yield return new WaitForSeconds(88.5f);
        // Line_46.SetActive(true);

        Line_142_Index = 45;
        inside_Line_142[45].gameObject.SetActive(true);
        //inside_Line_142[42].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -851.499f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 22755.16f);    //(오, -위)

    }

    IEnumerator WaitSecond_49()//170-2
    {
        yield return new WaitForSeconds(90.0f);
        // Line_47.SetActive(true);

        Line_142_Index = 46;
        inside_Line_142[46].gameObject.SetActive(true);
        //inside_Line_142[42].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -694.8271f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 22911.83f);    //(오, -위)

    }

    IEnumerator WaitSecond_50()//171
    {
        yield return new WaitForSeconds(91.5f);
        //Line_48.SetActive(true);

        Line_142_Index = 47;
        inside_Line_142[47].gameObject.SetActive(true);
        //inside_Line_142[42].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -405.7969f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 23200.86f);    //(오, -위)

    }

    IEnumerator WaitSecond_51()//172-속마음
    {
        yield return new WaitForSeconds(93.5f);
        // Line_49.SetActive(true);

        Line_142_Index = 48;
        inside_Line_142[48].gameObject.SetActive(true);
        //inside_Line_142[42].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_52()//173-속마음
    {
        yield return new WaitForSeconds(95.5f);
        //Line_50.SetActive(true);
        // Line_49.SetActive(false);

        Line_142_Index = 49;
        inside_Line_142[49].gameObject.SetActive(true);
        inside_Line_142[48].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_53()//174-속마음
    {
        yield return new WaitForSeconds(98.5f);
        // Line_51.SetActive(true);
        // Line_50.SetActive(false);

        Line_142_Index = 50;
        inside_Line_142[50].gameObject.SetActive(true);
        inside_Line_142[49].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_54()//175-선택지
    {
        yield return new WaitForSeconds(102.5f);
        //Line_52.SetActive(true);
        //Line_51.SetActive(false);

        Line_142_Index = 51;
        inside_Line_142[51].gameObject.SetActive(true);
        inside_Line_142[50].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, 0.01269531f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 23606.67f);    //(오, -위)

    }



}
