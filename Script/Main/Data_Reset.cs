using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Data_Reset : MonoBehaviour
{
    public Save_Collection All_Save;
    public GameObject Game_ReSet;
    public GameObject Game_ReSet_Successful;


    public Only_Line questObject;//챕터1 대사들 모아놓은 거
    public Fade_Collect FadeObject;

    public IEnumerator m_Coroutine;
    public GameObject Setting;
    public R_Wait1 Wait1;

    //잠깐 타임 스케일 때문에 만듦
    public Fast_2023 speed;
    public Fast_2023_2 speed1;

    public SFX_2023 sfx;
    public Bgm_2023 bgm;



    public void Go_ReStart()
    {

       
        


        StartCoroutine(WaitSecond_3());
        StartCoroutine(WaitSecond_4());

        //StartCoroutine(WaitSecond_0());
        //코루틴을 이렇게 위로 옮긴 결과는?: 같음
        IEnumerator WaitSecond_3()
        {
            yield return new WaitForSeconds(0.0f);


            Game_ReSet.SetActive(false);
            Game_ReSet_Successful.SetActive(false);

            FadeObject.Fade_Index = 12;

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
            FadeObject.fadeObject[12].gameObject.SetActive(true);
            FadeObject.fadeObject[13].gameObject.SetActive(false);
            FadeObject.fadeObject[14].gameObject.SetActive(false);


            Wait1.Line_0_Index = 0;
            Wait1.inside_Line_0[0].gameObject.SetActive(false);
            Wait1.inside_Line_0[1].gameObject.SetActive(false);
            Wait1.inside_Line_0[2].gameObject.SetActive(false);
            Wait1.inside_Line_0[3].gameObject.SetActive(false);
            Wait1.inside_Line_0[4].gameObject.SetActive(false);
            Wait1.inside_Line_0[5].gameObject.SetActive(false);
            Wait1.inside_Line_0[6].gameObject.SetActive(false);
            Wait1.inside_Line_0[7].gameObject.SetActive(false);
            Wait1.inside_Line_0[8].gameObject.SetActive(false);
            Wait1.inside_Line_0[9].gameObject.SetActive(false);
            Wait1.inside_Line_0[10].gameObject.SetActive(false);
            Wait1.inside_Line_0[11].gameObject.SetActive(false);
            Wait1.inside_Line_0[12].gameObject.SetActive(false);


        }

        //Black_EningCradit.SetActive(true);//엔딩크레딧 가기 전에 검게





        //StartCoroutine(WaitSecond_0());

        IEnumerator WaitSecond_4()
        {

            //m_IsCoroutineing = true;

            yield return new WaitForSeconds(1.5f);
            //티켓 수 리셋
            Tiket.Total = 10;


            questObject.Line_Index = 0;

            questObject.questObject[0].gameObject.SetActive(true);
            questObject.questObject[1].gameObject.SetActive(false);
            questObject.questObject[2].gameObject.SetActive(false);

            questObject.questObject[3].gameObject.SetActive(false);
            questObject.questObject[4].gameObject.SetActive(false);
            questObject.questObject[5].gameObject.SetActive(false);
            questObject.questObject[6].gameObject.SetActive(false);
            questObject.questObject[7].gameObject.SetActive(false);
            questObject.questObject[8].gameObject.SetActive(false);
            questObject.questObject[9].gameObject.SetActive(false);

            questObject.questObject[10].gameObject.SetActive(false);
            questObject.questObject[11].gameObject.SetActive(false);
            questObject.questObject[12].gameObject.SetActive(false);
            questObject.questObject[13].gameObject.SetActive(false);
            questObject.questObject[14].gameObject.SetActive(false);
            questObject.questObject[15].gameObject.SetActive(false);
            questObject.questObject[16].gameObject.SetActive(false);
            questObject.questObject[17].gameObject.SetActive(false);
            questObject.questObject[18].gameObject.SetActive(false);
            questObject.questObject[19].gameObject.SetActive(false);
            questObject.questObject[20].gameObject.SetActive(false);
            questObject.questObject[21].gameObject.SetActive(false);
            questObject.questObject[22].gameObject.SetActive(false);
            questObject.questObject[23].gameObject.SetActive(false);
            questObject.questObject[24].gameObject.SetActive(false);
            questObject.questObject[25].gameObject.SetActive(false);
            questObject.questObject[26].gameObject.SetActive(false);
            questObject.questObject[27].gameObject.SetActive(false);
            questObject.questObject[28].gameObject.SetActive(false);
            questObject.questObject[29].gameObject.SetActive(false);
            questObject.questObject[30].gameObject.SetActive(false);
            questObject.questObject[31].gameObject.SetActive(false);
            questObject.questObject[32].gameObject.SetActive(false);
            questObject.questObject[33].gameObject.SetActive(false);
            questObject.questObject[34].gameObject.SetActive(false);
            questObject.questObject[35].gameObject.SetActive(false);
            questObject.questObject[36].gameObject.SetActive(false);
            questObject.questObject[37].gameObject.SetActive(false);
            questObject.questObject[38].gameObject.SetActive(false);
            questObject.questObject[39].gameObject.SetActive(false);
            questObject.questObject[40].gameObject.SetActive(false);
            questObject.questObject[41].gameObject.SetActive(false);
            questObject.questObject[42].gameObject.SetActive(false);
            questObject.questObject[43].gameObject.SetActive(false);
            questObject.questObject[44].gameObject.SetActive(false);
            questObject.questObject[45].gameObject.SetActive(false);
            questObject.questObject[46].gameObject.SetActive(false);
            questObject.questObject[47].gameObject.SetActive(false);
            questObject.questObject[48].gameObject.SetActive(false);
            questObject.questObject[49].gameObject.SetActive(false);
            questObject.questObject[50].gameObject.SetActive(false);
            questObject.questObject[51].gameObject.SetActive(false);
            questObject.questObject[52].gameObject.SetActive(false);
            questObject.questObject[53].gameObject.SetActive(false);
            questObject.questObject[54].gameObject.SetActive(false);
            questObject.questObject[55].gameObject.SetActive(false);
            questObject.questObject[56].gameObject.SetActive(false);
            questObject.questObject[57].gameObject.SetActive(false);
            questObject.questObject[58].gameObject.SetActive(false);
            questObject.questObject[59].gameObject.SetActive(false);
            questObject.questObject[60].gameObject.SetActive(false);
            questObject.questObject[61].gameObject.SetActive(false);
            questObject.questObject[62].gameObject.SetActive(false);
            questObject.questObject[63].gameObject.SetActive(false);
            questObject.questObject[64].gameObject.SetActive(false);
            questObject.questObject[65].gameObject.SetActive(false);
            questObject.questObject[66].gameObject.SetActive(false);
            questObject.questObject[67].gameObject.SetActive(false);
            questObject.questObject[68].gameObject.SetActive(false);
            questObject.questObject[69].gameObject.SetActive(false);
            questObject.questObject[70].gameObject.SetActive(false);
            questObject.questObject[71].gameObject.SetActive(false);
            questObject.questObject[72].gameObject.SetActive(false);
            questObject.questObject[73].gameObject.SetActive(false);
            questObject.questObject[74].gameObject.SetActive(false);
            questObject.questObject[75].gameObject.SetActive(false);
            questObject.questObject[76].gameObject.SetActive(false);
            questObject.questObject[77].gameObject.SetActive(false);
            questObject.questObject[78].gameObject.SetActive(false);
            questObject.questObject[79].gameObject.SetActive(false);
            questObject.questObject[80].gameObject.SetActive(false);
            questObject.questObject[81].gameObject.SetActive(false);
            questObject.questObject[82].gameObject.SetActive(false);
            questObject.questObject[83].gameObject.SetActive(false);
            questObject.questObject[84].gameObject.SetActive(false);
            questObject.questObject[85].gameObject.SetActive(false);
            questObject.questObject[86].gameObject.SetActive(false);
            questObject.questObject[87].gameObject.SetActive(false);
            questObject.questObject[88].gameObject.SetActive(false);
            questObject.questObject[89].gameObject.SetActive(false);
            questObject.questObject[90].gameObject.SetActive(false);
            questObject.questObject[91].gameObject.SetActive(false);
            questObject.questObject[92].gameObject.SetActive(false);
            questObject.questObject[93].gameObject.SetActive(false);
            questObject.questObject[94].gameObject.SetActive(false);
            questObject.questObject[95].gameObject.SetActive(false);
            questObject.questObject[96].gameObject.SetActive(false);
            questObject.questObject[97].gameObject.SetActive(false);
            questObject.questObject[98].gameObject.SetActive(false);
            questObject.questObject[99].gameObject.SetActive(false);


            questObject.questObject[100].gameObject.SetActive(false);
            questObject.questObject[101].gameObject.SetActive(false);
            questObject.questObject[102].gameObject.SetActive(false);
            questObject.questObject[103].gameObject.SetActive(false);
            questObject.questObject[104].gameObject.SetActive(false);
            questObject.questObject[105].gameObject.SetActive(false);
            questObject.questObject[106].gameObject.SetActive(false);
            questObject.questObject[107].gameObject.SetActive(false);
            questObject.questObject[108].gameObject.SetActive(false);
            questObject.questObject[109].gameObject.SetActive(false);
            questObject.questObject[110].gameObject.SetActive(false);
            questObject.questObject[111].gameObject.SetActive(false);
            questObject.questObject[112].gameObject.SetActive(false);
            questObject.questObject[113].gameObject.SetActive(false);
            questObject.questObject[114].gameObject.SetActive(false);
            questObject.questObject[115].gameObject.SetActive(false);
            questObject.questObject[116].gameObject.SetActive(false);
            questObject.questObject[117].gameObject.SetActive(false);
            questObject.questObject[118].gameObject.SetActive(false);
            questObject.questObject[119].gameObject.SetActive(false);
            questObject.questObject[120].gameObject.SetActive(false);
            questObject.questObject[121].gameObject.SetActive(false);
            questObject.questObject[122].gameObject.SetActive(false);
            questObject.questObject[123].gameObject.SetActive(false);
            questObject.questObject[124].gameObject.SetActive(false);
            questObject.questObject[125].gameObject.SetActive(false);
            questObject.questObject[126].gameObject.SetActive(false);
            questObject.questObject[127].gameObject.SetActive(false);
            questObject.questObject[128].gameObject.SetActive(false);
            questObject.questObject[129].gameObject.SetActive(false);
            questObject.questObject[130].gameObject.SetActive(false);
            questObject.questObject[131].gameObject.SetActive(false);
            questObject.questObject[132].gameObject.SetActive(false);
            questObject.questObject[133].gameObject.SetActive(false);
            questObject.questObject[134].gameObject.SetActive(false);
            questObject.questObject[135].gameObject.SetActive(false);
            questObject.questObject[136].gameObject.SetActive(false);
            questObject.questObject[137].gameObject.SetActive(false);
            questObject.questObject[138].gameObject.SetActive(false);
            questObject.questObject[139].gameObject.SetActive(false);
            questObject.questObject[140].gameObject.SetActive(false);
            questObject.questObject[141].gameObject.SetActive(false);
            questObject.questObject[142].gameObject.SetActive(false);
            questObject.questObject[143].gameObject.SetActive(false);
            questObject.questObject[144].gameObject.SetActive(false);
            questObject.questObject[145].gameObject.SetActive(false);
            questObject.questObject[146].gameObject.SetActive(false);

            questObject.questObject[147].gameObject.SetActive(false);
            questObject.questObject[148].gameObject.SetActive(false);
            questObject.questObject[149].gameObject.SetActive(false);

            questObject.BGM_Index = 0;
            questObject.Audio_Object[0].gameObject.SetActive(true);
            questObject.Audio_Object[1].gameObject.SetActive(false);
            questObject.Audio_Object[2].gameObject.SetActive(false);

            /*Wait1.m_Coroutine = Wait1.NewCoroutine();
            StartCoroutine(Wait1.m_Coroutine);
            Debug.Log("처음부터 시작하자");

            Debug.Log("게임 리셋");
            Debug.Log("게임 리셋하는데 타임 스케일은" + Time.timeScale + "이다.");*/

            //챕터 1 타임라인 닫기
            All_Save.Time_Line_Open_Index = 0;
            All_Save.Time_Line_Open[0].gameObject.SetActive(true);
            All_Save.Time_Line_Open[1].gameObject.SetActive(false);
            PlayerPrefs.SetInt("TimeLine", All_Save.Time_Line_Open_Index);

            //챕터 1 타임라인 중간부터 시작 닫기
            All_Save.Time_Run_Index = 0;
            All_Save.Time_Run[0].gameObject.SetActive(true);
            All_Save.Time_Run[1].gameObject.SetActive(false);
            PlayerPrefs.SetInt("TimeLine_Run", All_Save.Time_Run_Index);



            //타임라인 안에 동그라미1 닫기
            All_Save.Time_Circle_1_Index = 0;
            All_Save.Time_Circle_1[0].gameObject.SetActive(true);
            All_Save.Time_Circle_1[1].gameObject.SetActive(false);
            PlayerPrefs.SetInt("Time_Circle_1", All_Save.Time_Circle_1_Index);


            //타임라인 안에 동그라미 2 닫기
            All_Save.Time_Circle_2_Index = 0;
            All_Save.Time_Circle_2[0].gameObject.SetActive(true);
            All_Save.Time_Circle_2[1].gameObject.SetActive(false);
            PlayerPrefs.SetInt("Time_Circle_2", All_Save.Time_Circle_2_Index);



            //사장을 오픈한다.
            All_Save.Boss_Index = 0;
            All_Save.Boss[0].gameObject.SetActive(true);
            All_Save.Boss[1].gameObject.SetActive(false);
            PlayerPrefs.SetInt("Boss", All_Save.Boss_Index);

            //소리를 오픈한다.
            All_Save.Sori_Index = 0;
            All_Save.Sori[0].gameObject.SetActive(true);
            All_Save.Sori[1].gameObject.SetActive(false);
            PlayerPrefs.SetInt("Sori", All_Save.Sori_Index);

            //가짜 사장을 오픈한다.
            All_Save.Fake_Boss_Index = 0;
            All_Save.Fake_Boss[0].gameObject.SetActive(true);
            All_Save.Fake_Boss[1].gameObject.SetActive(false);
            PlayerPrefs.SetInt("Fake_Boss", All_Save.Fake_Boss_Index);

            //조율자를 오픈한다.
            All_Save.Black_Face_Man_Index = 0;
            All_Save.Black_Face_Man[0].gameObject.SetActive(true);
            All_Save.Black_Face_Man[1].gameObject.SetActive(false);
            PlayerPrefs.SetInt("Black_Face_Man", All_Save.Black_Face_Man_Index);

            //1번 엔딩 그림
            All_Save.Ending1_Index = 0;
            All_Save.Ending1[0].gameObject.SetActive(true);
            All_Save.Ending1[1].gameObject.SetActive(false);

            PlayerPrefs.SetInt("First_Ending", All_Save.Ending1_Index);

            //2번 엔딩 그림
            All_Save.Ending2_Index = 0;
            All_Save.Ending2[0].gameObject.SetActive(true);
            All_Save.Ending2[1].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Second_Ending", All_Save.Ending2_Index);

            //3번 엔딩 그림
            All_Save.Ending3_Index = 0;
            All_Save.Ending3[0].gameObject.SetActive(true);
            All_Save.Ending3[1].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Thrid_Ending", All_Save.Ending3_Index);

            //4번 엔딩 그림
            All_Save.Ending4_Index = 0;
            All_Save.Ending4[0].gameObject.SetActive(true);
            All_Save.Ending4[1].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Fourth_Ending", All_Save.Ending4_Index);

            //1번 업적을 오픈한다.
            All_Save.Achieve1_Index = 0;
            All_Save.Achieve_1[0].gameObject.SetActive(true);
            All_Save.Achieve_1[1].gameObject.SetActive(false);
            All_Save.Achieve_1[2].gameObject.SetActive(false);

            //2번 업적을 오픈한다.
            All_Save.Achieve2_Index = 0;
            All_Save.Achieve_2[0].gameObject.SetActive(true);
            All_Save.Achieve_2[1].gameObject.SetActive(false);
            All_Save.Achieve_2[2].gameObject.SetActive(false);

            //3번 업적을 오픈한다.
            All_Save.Achieve3_Index = 0;
            All_Save.Achieve_3[0].gameObject.SetActive(true);
            All_Save.Achieve_3[1].gameObject.SetActive(false);
            All_Save.Achieve_3[2].gameObject.SetActive(false);

            //4번 업적을 오픈한다.
            All_Save.Achieve4_Index = 0;
            All_Save.Achieve_4[0].gameObject.SetActive(true);
            All_Save.Achieve_4[1].gameObject.SetActive(false);
            All_Save.Achieve_4[2].gameObject.SetActive(false);

            //5번 업적을 오픈한다.
            All_Save.Achieve5_Index = 0;
            All_Save.Achieve_5[0].gameObject.SetActive(true);
            All_Save.Achieve_5[1].gameObject.SetActive(false);
            All_Save.Achieve_5[2].gameObject.SetActive(false);

            //6번 업적을 오픈한다.
            All_Save.Achieve6_Index = 0;
            All_Save.Achieve_6[0].gameObject.SetActive(true);
            All_Save.Achieve_6[1].gameObject.SetActive(false);
            All_Save.Achieve_6[2].gameObject.SetActive(false);

            //7번 업적을 오픈한다.
            All_Save.Achieve7_Index = 0;
            All_Save.Achieve_7[0].gameObject.SetActive(true);
            All_Save.Achieve_7[1].gameObject.SetActive(false);
            All_Save.Achieve_7[2].gameObject.SetActive(false);

            //1번째 없적이 오픈되었는가 / 아직 열리지 않았는가
            PlayerPrefs.SetInt("Achieve_1", All_Save.Achieve1_Index);

            //2번째 없적이 오픈되었는가 / 아직 열리지 않았는가
            PlayerPrefs.SetInt("Achieve_2", All_Save.Achieve2_Index);

            //3번째 없적이 오픈되었는가 / 아직 열리지 않았는가
            PlayerPrefs.SetInt("Achieve_3", All_Save.Achieve3_Index);

            //4번째 없적이 오픈되었는가 / 아직 열리지 않았는가
            PlayerPrefs.SetInt("Achieve_4", All_Save.Achieve4_Index);

            //5번째 없적이 오픈되었는가 / 아직 열리지 않았는가
            PlayerPrefs.SetInt("Achieve_5", All_Save.Achieve5_Index);

            //6번째 없적이 오픈되었는가 / 아직 열리지 않았는가
            PlayerPrefs.SetInt("Achieve_6", All_Save.Achieve6_Index);

            //7번째 없적이 오픈되었는가 / 아직 열리지 않았는가
            PlayerPrefs.SetInt("Achieve_7", All_Save.Achieve7_Index);

            //8 ( 1번 엔딩 )
            All_Save.Achieve8_Index = 0;
            All_Save.Achieve_8[0].gameObject.SetActive(true);
            All_Save.Achieve_8[1].gameObject.SetActive(false);
            All_Save.Achieve_8[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Achieve_8", All_Save.Achieve8_Index);

            //9 ( 2번 엔딩 )
            All_Save.Achieve9_Index = 0;
            All_Save.Achieve_9[0].gameObject.SetActive(true);
            All_Save.Achieve_9[1].gameObject.SetActive(false);
            All_Save.Achieve_9[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Achieve_9", All_Save.Achieve9_Index);

            //10 ( 3번 엔딩 )
            All_Save.Achieve10_Index = 0;
            All_Save.Achieve_10[0].gameObject.SetActive(true);
            All_Save.Achieve_10[1].gameObject.SetActive(false);
            All_Save.Achieve_10[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Achieve_10", All_Save.Achieve10_Index);

            //11 ( 4번 엔딩 )
            All_Save.Achieve11_Index = 0;
            All_Save.Achieve_11[0].gameObject.SetActive(true);
            All_Save.Achieve_11[1].gameObject.SetActive(false);
            All_Save.Achieve_11[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Achieve_11", All_Save.Achieve11_Index);

            //12 ( 엔딩 다 모았을 때 )
            All_Save.Achieve12_Index = 0;
            All_Save.Achieve_12[0].gameObject.SetActive(true);
            All_Save.Achieve_12[1].gameObject.SetActive(false);
            All_Save.Achieve_12[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Achieve_12", All_Save.Achieve12_Index);

            //1번째 앨범 잠금
            All_Save.Album1_Index = 0;
            All_Save.Album_1[0].gameObject.SetActive(true);
            All_Save.Album_1[1].gameObject.SetActive(false);
            All_Save.Album_1[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_1", All_Save.Album1_Index);


            //2번째 앨범 잠금
            All_Save.Album2_Index = 0;
            All_Save.Album_2[0].gameObject.SetActive(true);
            All_Save.Album_2[1].gameObject.SetActive(false);
            All_Save.Album_2[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_2", All_Save.Album2_Index);

            //3번째 앨범 잠금
            All_Save.Album3_Index = 0;
            All_Save.Album_3[0].gameObject.SetActive(true);
            All_Save.Album_3[1].gameObject.SetActive(false);
            All_Save.Album_3[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_3", All_Save.Album3_Index);

            //4번째 앨범 잠금
            All_Save.Album4_Index = 0;
            All_Save.Album_4[0].gameObject.SetActive(true);
            All_Save.Album_4[1].gameObject.SetActive(false);
            All_Save.Album_4[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_4", All_Save.Album4_Index);

            //5번째 앨범 잠그
            All_Save.Album5_Index = 0;
            All_Save.Album_5[0].gameObject.SetActive(true);
            All_Save.Album_5[1].gameObject.SetActive(false);
            All_Save.Album_5[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_5", All_Save.Album5_Index);

            //6번째 앨범 잠금
            All_Save.Album6_Index = 0;
            All_Save.Album_6[0].gameObject.SetActive(true);
            All_Save.Album_6[1].gameObject.SetActive(false);
            All_Save.Album_6[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_6", All_Save.Album6_Index);

            //7번째 앨범 잠금
            All_Save.Album7_Index = 0;
            All_Save.Album_7[0].gameObject.SetActive(true);
            All_Save.Album_7[1].gameObject.SetActive(false);
            All_Save.Album_7[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_7", All_Save.Album7_Index);

            //8번째 앨범 잠금
            All_Save.Album8_Index = 0;
            All_Save.Album_8[0].gameObject.SetActive(true);
            All_Save.Album_8[1].gameObject.SetActive(false);
            All_Save.Album_8[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_8", All_Save.Album8_Index);

            //9번째 앨범 잠금
            All_Save.Album9_Index = 0;
            All_Save.Album_9[0].gameObject.SetActive(true);
            All_Save.Album_9[1].gameObject.SetActive(false);
            All_Save.Album_9[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_9", All_Save.Album9_Index);

            //10번째 앨범 잠금
            All_Save.Album10_Index = 0;
            All_Save.Album_10[0].gameObject.SetActive(true);
            All_Save.Album_10[1].gameObject.SetActive(false);
            All_Save.Album_10[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_10", All_Save.Album10_Index);

            //11번째 앨범 잠금
            All_Save.Album11_Index = 0;
            All_Save.Album_11[0].gameObject.SetActive(true);
            All_Save.Album_11[1].gameObject.SetActive(false);
            All_Save.Album_11[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_11", All_Save.Album11_Index);

            //12번째 앨범 잠금
            All_Save.Album12_Index = 0;
            All_Save.Album_12[0].gameObject.SetActive(true);
            All_Save.Album_12[1].gameObject.SetActive(false);
            All_Save.Album_12[2].gameObject.SetActive(false);

            PlayerPrefs.SetInt("Album_12", All_Save.Album12_Index);


            //소리 두개 다 0.5로 리셋

            //SFX
            /*sfx.back_SFX_Vol = 0.5001f;

            sfx.back_SFX_Volume.value = sfx.back_SFX_Vol;
            sfx.back_SFX_Vol = PlayerPrefs.GetFloat("back_SFX_Vol", 0.5001f);


            sfx.sfx1.volume = sfx.back_SFX_Volume.value;
            sfx.sfx2.volume = sfx.back_SFX_Volume.value;
            sfx.sfx3.volume = sfx.back_SFX_Volume.value;
            sfx.sfx4.volume = sfx.back_SFX_Volume.value;
            sfx.sfx5.volume = sfx.back_SFX_Volume.value;
            sfx.sfx6.volume = sfx.back_SFX_Volume.value;
            Debug.Log("효과음 볼륨은" + sfx.back_SFX_Vol + "이다.");*/

            sfx.back_SFX_Vol = 0.5001f;
            sfx.back_SFX_Volume.value = sfx.back_SFX_Vol;
            sfx.back_SFX_Vol = sfx.back_SFX_Volume.value;
            sfx.sfx1.volume = sfx.back_SFX_Volume.value;
            sfx.sfx2.volume = sfx.back_SFX_Volume.value;
            sfx.sfx3.volume = sfx.back_SFX_Volume.value;
            sfx.sfx4.volume = sfx.back_SFX_Volume.value;
            sfx.sfx5.volume = sfx.back_SFX_Volume.value;
            sfx.sfx6.volume = sfx.back_SFX_Volume.value;

            PlayerPrefs.SetFloat("back_SFX_Vol", sfx.back_SFX_Vol);
            sfx.SFX_Sound.text = sfx.back_SFX_Vol.ToString();

            Debug.Log(sfx.back_SFX_Vol + "로 SFX 초기화 할거지롱");

            //SFX //솔직히 스피드 빼고 두 개는 되는 것 같긴 한데 넣어봄
            /*float SFX_Sd = PlayerPrefs.GetFloat("back_SFX_Vol");
            sfx.back_SFX_Vol = SFX_Sd;
            Debug.Log(SFX_Sd + "로 초기화 할거지롱");*/


            //BGM
            /*bgm.backVol = 0.5001f;

            bgm.backVolume.value = bgm.backVol;
            bgm.backVol = PlayerPrefs.GetFloat("backvol", 0.5001f);
            bgm.audio1.volume = bgm.backVolume.value;
            bgm.audio2.volume = bgm.backVolume.value;
            bgm.audio3.volume = bgm.backVolume.value;
            bgm.audio4.volume = bgm.backVolume.value;
            bgm.audio5.volume = bgm.backVolume.value;

            Debug.Log("배경음악 볼륨은"+bgm.backVol+"이다.");*/

            bgm.backVol = 0.5001f;
            bgm.backVolume.value = bgm.backVol;
            bgm.backVol = bgm.backVolume.value;
            bgm.audio1.volume = bgm.backVolume.value;
            bgm.audio2.volume = bgm.backVolume.value;
            bgm.audio3.volume = bgm.backVolume.value;
            bgm.audio4.volume = bgm.backVolume.value;
            bgm.audio5.volume = bgm.backVolume.value;


            PlayerPrefs.SetFloat("backvol", bgm.backVol);
            bgm.BGM_Sound.text = bgm.backVol.ToString();

            Debug.Log(bgm.BGM_Sound + "로 BGM 초기화 할거지롱");




            //티켓 수 리셋
            Tiket.Total = 10;


            //스피드와 소리는 리셋해보자
            //스피드 0.6으로 리셋
            speed.Speed = 0.6001f;
            
            Time.timeScale= speed.Speed;

            speed.back_Speed.value = speed.Speed;
            //이걸 하면 모든 씬에 5배속이 적용됨
   
            
            PlayerPrefs.SetFloat("Speed", 0.60001f);
            Debug.Log("초기화하고 싶은 스피드는" + speed.Speed + "이다.");



            //스피드 (속도 리셋이 안 되서 만듦)
            /*float Auto_Speed = PlayerPrefs.GetFloat("Speed");
            speed.Speed = Auto_Speed;
            Debug.Log(Auto_Speed + "로 초기화하장");*/


            FadeObject.Fade_Index = 8;

            FadeObject.fadeObject[1].gameObject.SetActive(false);
            FadeObject.fadeObject[2].gameObject.SetActive(false);
            FadeObject.fadeObject[3].gameObject.SetActive(false);
            FadeObject.fadeObject[4].gameObject.SetActive(false);
            FadeObject.fadeObject[5].gameObject.SetActive(false);
            FadeObject.fadeObject[6].gameObject.SetActive(false);
            FadeObject.fadeObject[7].gameObject.SetActive(false);
            FadeObject.fadeObject[8].gameObject.SetActive(true);
            FadeObject.fadeObject[9].gameObject.SetActive(false);
            FadeObject.fadeObject[10].gameObject.SetActive(false);
            FadeObject.fadeObject[11].gameObject.SetActive(false);
            //FadeObject.fadeObject[12].gameObject.SetActive(false);
            FadeObject.fadeObject[13].gameObject.SetActive(false);
            FadeObject.fadeObject[14].gameObject.SetActive(false);

            Setting.SetActive(false);


            


            //speed.Speed = speed.back_Speed.value;
            //PlayerPrefs.SetFloat("Speed", speed.Speed);
            //speed.Fast.text = speed.Speed.ToString();
            

            //속도는 되는데 동그라미하고 숫자가 변하질 않음


            
            SceneManager.LoadScene("Line");

            


            Wait1.m_Coroutine = Wait1.NewCoroutine();
            StartCoroutine(Wait1.m_Coroutine);
            Debug.Log("처음부터 시작하자");

            Debug.Log("게임 리셋");
            Debug.Log("게임 리셋하는데 타임 스케일은" + Time.timeScale + "이다.");


            //요 아래 3줄이 원래 있었던 거임
            /*Wait1.m_Coroutine = Wait1.NewCoroutine();
            StartCoroutine(Wait1.m_Coroutine);
            Debug.Log("처음부터 시작하자");*/






        }
    }
}
