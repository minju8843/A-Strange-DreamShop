using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class R_Wait1_3_5 : MonoBehaviour
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
    public GameObject Line_23;*/
    public Fade_Collect FadeObject;//페이드 스크립트 불러오려고

    public GameObject[] inside_Line_15;
    public int Line_15_Index;
    public R_Wait1_2_1 inside_5;
    public R_Wait1_2_4 inside_8;

    public Next_1_3_5 inside_23;

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

        // *** 자동저장 라인 ***
        PlayerPrefs.SetInt("Auto_Index", QuestObject.Line_Index);

        Line_15_Index = 0;
        inside_Line_15[0].gameObject.SetActive(true);

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

        /*QuestObject.Line_Index = 15;

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
        QuestObject.questObject[142].gameObject.SetActive(false);
        QuestObject.questObject[143].gameObject.SetActive(false);
        QuestObject.questObject[144].gameObject.SetActive(false);
        QuestObject.questObject[145].gameObject.SetActive(false);
        QuestObject.questObject[146].gameObject.SetActive(false);*/

        TextContainer1.offsetMin = new Vector2(0, -3988.186f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 15614.75f);    //(오, 위)


    }

    IEnumerator WaitSecond_2()
    {
        yield return new WaitForSeconds(1.5f);
        //Line_2.SetActive(true);

        Line_15_Index = 1;
        inside_Line_15[1].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -3832.088f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 15770.85f);    //(오, 위)
    }

    IEnumerator WaitSecond_3()
    {
        yield return new WaitForSeconds(3.0f);
        //Line_3.SetActive(true);

        Line_15_Index = 2;
        inside_Line_15[2].gameObject.SetActive(true);

        FadeObject.Fade_Index = 8;
        FadeObject.fadeObject[8].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -3480.869f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 16122.07f);    //(오, 위)

    }

    IEnumerator WaitSecond_4()
    {
        yield return new WaitForSeconds(4.5f);
        //Line_4.SetActive(true);

        Line_15_Index = 3;
        inside_Line_15[3].gameObject.SetActive(true);

        TextContainer1.offsetMin = new Vector2(0, -3321.984f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 16280.96f);    //(오, 위)

    }

    IEnumerator WaitSecond_5()
    {
        yield return new WaitForSeconds(6.0f);
        //Line_5.SetActive(true);

        Line_15_Index = 4;
        inside_Line_15[4].gameObject.SetActive(true);

        // % 여기부턴 앨범 관련 %

        //4번 앨범 오픈 관련
        if (All_Save.Album_4[2].gameObject.activeSelf == true)
        {//이미 4번 앨범이 오픈되어 있을 경우
            //오픈한 그대로 둔다

            All_Save.Album4_Index = 2;
            All_Save.Album_4[0].gameObject.SetActive(false);
            All_Save.Album_4[1].gameObject.SetActive(false);
            All_Save.Album_4[2].gameObject.SetActive(true);

        }

        //4번 앨범이 오픈되어 있지 않으면
        else if (All_Save.Album_4[2].gameObject.activeSelf == false)
        {
            //4번 앨범이 오픈되지 못했다면 오픈한다
            All_Save.Album4_Index = 2;
            All_Save.Album_4[0].gameObject.SetActive(false);
            All_Save.Album_4[1].gameObject.SetActive(false);
            All_Save.Album_4[2].gameObject.SetActive(true);

        }

        //4 번째 앨범 관련하여 자동 저장
        PlayerPrefs.SetInt("Album_4", All_Save.Album4_Index);

        // % 여기부턴 다음 앨범에 대한 힌트 제공 %

        //3번 앨범 오픈 관련
        if (All_Save.Album_3[2].gameObject.activeSelf == true)
        {//이미 3번 앨범이 오픈되어 있을 경우
            //오픈한 그대로 둔다

            All_Save.Album3_Index = 2;
            All_Save.Album_3[0].gameObject.SetActive(false);
            All_Save.Album_3[1].gameObject.SetActive(false);
            All_Save.Album_3[2].gameObject.SetActive(true);

        }

        //3번 앨범이 오픈되어 있지 않으면
        else if (All_Save.Album_3[2].gameObject.activeSelf == false)
        {
            //3번 앨범에 대한 힌트를 준다
            All_Save.Album3_Index = 1;
            All_Save.Album_3[0].gameObject.SetActive(false);
            All_Save.Album_3[1].gameObject.SetActive(true);
            All_Save.Album_3[2].gameObject.SetActive(false);

        }

        //3 번째 앨범 관련하여 자동 저장
        PlayerPrefs.SetInt("Album_3", All_Save.Album3_Index);

        //5번 앨범 오픈 관련
        if (All_Save.Album_5[2].gameObject.activeSelf == true)
        {//이미 5번 앨범이 오픈되어 있을 경우
            //오픈한 그대로 둔다

            All_Save.Album5_Index = 2;
            All_Save.Album_5[0].gameObject.SetActive(false);
            All_Save.Album_5[1].gameObject.SetActive(false);
            All_Save.Album_5[2].gameObject.SetActive(true);

        }

        //5번 앨범이 오픈되어 있지 않으면
        else if (All_Save.Album_5[2].gameObject.activeSelf == false)
        {
            //5번 앨범에 대한 힌트를 준다
            All_Save.Album5_Index = 1;
            All_Save.Album_5[0].gameObject.SetActive(false);
            All_Save.Album_5[1].gameObject.SetActive(true);
            All_Save.Album_5[2].gameObject.SetActive(false);

        }

        //5 번째 앨범 관련하여 자동 저장
        PlayerPrefs.SetInt("Album_5", All_Save.Album5_Index);

        TextContainer1.offsetMin = new Vector2(0, -2612.175f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 16990.76f);    //(오, 위)

    }

    IEnumerator WaitSecond_6()//속마음
    {
        yield return new WaitForSeconds(8.0f);
        //Line_6.SetActive(true);

        Line_15_Index = 5;
        inside_Line_15[5].gameObject.SetActive(true);

    }

    IEnumerator WaitSecond_7()//속마음
    {
        yield return new WaitForSeconds(12.0f);
        //Line_7.SetActive(true);
        //Line_6.SetActive(false);

        Line_15_Index = 6;
        inside_Line_15[6].gameObject.SetActive(true);
        inside_Line_15[5].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_8()
    {
        yield return new WaitForSeconds(14.0f);
        //Line_8.SetActive(true);
        //Line_7.SetActive(false);

        QuestObject.BGM_Index = 0;

        QuestObject.Audio_Object[0].gameObject.SetActive(true);
        QuestObject.Audio_Object[1].gameObject.SetActive(false);
        QuestObject.Audio_Object[2].gameObject.SetActive(false);
        QuestObject.Audio_Object[3].gameObject.SetActive(false);
        QuestObject.Audio_Object[4].gameObject.SetActive(false);

        Line_15_Index = 7;
        inside_Line_15[7].gameObject.SetActive(true);
        inside_Line_15[6].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1927.44f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 17675.5f);    //(오, 위)

    }

    IEnumerator WaitSecond_9()
    {
        yield return new WaitForSeconds(15.5f);
        //Line_9.SetActive(true);

        Line_15_Index = 8;
        inside_Line_15[8].gameObject.SetActive(true);
        //inside_Line_15[5].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1611.163f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 17991.78f);    //(오, 위)

    }

    IEnumerator WaitSecond_10()//속마음
    {
        yield return new WaitForSeconds(17.5f);
        //Line_10.SetActive(true);

        Line_15_Index = 9;
        inside_Line_15[9].gameObject.SetActive(true);
        //inside_Line_15[5].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_11()//속마음
    {
        yield return new WaitForSeconds(19.5f);
        // Line_10.SetActive(false);
        //Line_11.SetActive(true);


        Line_15_Index = 10;
        inside_Line_15[10].gameObject.SetActive(true);
        inside_Line_15[9].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_12()
    {
        yield return new WaitForSeconds(22.5f);
        //Line_12.SetActive(true);
        //Line_11.SetActive(false);

        Line_15_Index = 11;
        inside_Line_15[11].gameObject.SetActive(true);
        inside_Line_15[10].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1326.842f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 18276.1f);    //(오, 위)

    }

    IEnumerator WaitSecond_13()
    {
        yield return new WaitForSeconds(24.0f);
        //Line_13.SetActive(true);

        Line_15_Index = 12;
        inside_Line_15[12].gameObject.SetActive(true);
        //inside_Line_15[5].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -1040.393f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 18562.55f);    //(오, 위)
    }

    IEnumerator WaitSecond_14()//속마음
    {
        yield return new WaitForSeconds(26.0f);
        //Line_14.SetActive(true);

        Line_15_Index = 13;
        inside_Line_15[13].gameObject.SetActive(true);
        //inside_Line_15[5].gameObject.SetActive(false);


    }

    IEnumerator WaitSecond_15()
    {
        yield return new WaitForSeconds(28.0f);
        //Line_15.SetActive(true);
        //Line_14.SetActive(false);
        Line_15_Index = 14;
        inside_Line_15[14].gameObject.SetActive(true);
        inside_Line_15[13].gameObject.SetActive(false);


        TextContainer1.offsetMin = new Vector2(0, -688.1641f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 18914.78f);    //(오, 위)

    }

    IEnumerator WaitSecond_16()
    {
        yield return new WaitForSeconds(29.5f);
        //Line_16.SetActive(true);

        Line_15_Index = 15;
        inside_Line_15[15].gameObject.SetActive(true);
        //inside_Line_15[5].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -534.8535f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 19068.09f);    //(오, 위)


    }

    IEnumerator WaitSecond_17()
    {
        yield return new WaitForSeconds(31.0f);
        //Line_17.SetActive(true);

        Line_15_Index = 16;
        inside_Line_15[16].gameObject.SetActive(true);
        //inside_Line_15[5].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, -237.5049f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 19365.43f);    //(오, 위)


    }

    IEnumerator WaitSecond_18()//속마음
    {
        yield return new WaitForSeconds(33.0f);
        //Line_18.SetActive(true);

        Line_15_Index = 17;
        inside_Line_15[17].gameObject.SetActive(true);
        //inside_Line_15[16].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_19()//속마음
    {
        yield return new WaitForSeconds(35.0f);
        //Line_19.SetActive(true);
        //Line_18.SetActive(false);

        Line_15_Index = 18;
        inside_Line_15[18].gameObject.SetActive(true);
        inside_Line_15[17].gameObject.SetActive(false);
    }

    IEnumerator WaitSecond_20()//속마음
    {
        yield return new WaitForSeconds(38.0f);
        //Line_20.SetActive(true);
        //Line_19.SetActive(false);

        Line_15_Index = 19;
        inside_Line_15[19].gameObject.SetActive(true);
        inside_Line_15[18].gameObject.SetActive(false);
    }

    IEnumerator WaitSecond_21()//속마음
    {
        yield return new WaitForSeconds(40.5f);
        //Line_20.SetActive(false);
        //Line_21.SetActive(true);


        Line_15_Index = 20;
        inside_Line_15[20].gameObject.SetActive(true);
        inside_Line_15[19].gameObject.SetActive(false);
    }

    IEnumerator WaitSecond_22()//속마음
    {
        yield return new WaitForSeconds(43.0f);
        //Line_22.SetActive(true);
        //Line_21.SetActive(false);

        Line_15_Index = 21;
        inside_Line_15[21].gameObject.SetActive(true);
        inside_Line_15[20].gameObject.SetActive(false);

    }

    IEnumerator WaitSecond_23()
    {
        yield return new WaitForSeconds(45.0f);
        //Line_22.SetActive(false);
        //Line_23.SetActive(true);

        Line_15_Index = 22;
        inside_Line_15[22].gameObject.SetActive(true);
        inside_Line_15[21].gameObject.SetActive(false);

        inside_23.Line_23_Index = 0;
        inside_23.inside_Line_23[0].gameObject.SetActive(false);
        inside_23.inside_Line_23[1].gameObject.SetActive(false);
        inside_23.inside_Line_23[2].gameObject.SetActive(false);
        inside_23.inside_Line_23[3].gameObject.SetActive(false);
        inside_23.inside_Line_23[4].gameObject.SetActive(false);
        inside_23.inside_Line_23[5].gameObject.SetActive(false);
        inside_23.inside_Line_23[6].gameObject.SetActive(false);
        inside_23.inside_Line_23[7].gameObject.SetActive(false);
        inside_23.inside_Line_23[8].gameObject.SetActive(false);
        inside_23.inside_Line_23[9].gameObject.SetActive(false);
        inside_23.inside_Line_23[10].gameObject.SetActive(false);
        inside_23.inside_Line_23[11].gameObject.SetActive(false);
        inside_23.inside_Line_23[12].gameObject.SetActive(false);
        inside_23.inside_Line_23[13].gameObject.SetActive(false);
        inside_23.inside_Line_23[14].gameObject.SetActive(false);
        inside_23.inside_Line_23[15].gameObject.SetActive(false);
        inside_23.inside_Line_23[16].gameObject.SetActive(false);
        inside_23.inside_Line_23[17].gameObject.SetActive(false);

        TextContainer1.offsetMin = new Vector2(0, 0.06152344f);//(왼, 아래)
        TextContainer1.offsetMax = new Vector2(0, 19602.99f);    //(오, 위)

    }

}
