using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Game_Load_Yes : MonoBehaviour
{
    //public GameObject Ticket_Count_Panel;

    public Save_Collection save;

    public Fast_2023 Setting_fast;
    public SFX_2023 sfx_Manager;
    public Bgm_2023 bgm;

    public GameObject Game_Data_Load;
    public GameObject Successful_Load;

    public Only_Line questObject;//챕터1 대사들 모아놓은 거
    //public GameObject Go_Black;
    //public GameObject Go_Empty;

    public Fade_Collect FadeObject;

    public IEnumerator m_Coroutine;

    public GameObject Setting;

    public R_Wait1 inside_0;
    public Sum_1_1_1 inside_1;
    public Sum_1_1_2 inside_2;

    public R_Wait1_2_1 inside_5;
    public R_Wait1_2_4 inside_8;
    public R_Wait1_3_1 inside_9;
    public R_Wait1_3_2 inside_13;
    public R_Wait1_3_5 inside_15;
    public R_Wait1_3_6 inside_11;

    //여기부턴 안했음
    public Next_1_3_1 inside_17;
    public Next_1_3_2 inside_21;
    public Next_1_3_5 inside_23;
    public Next_1_3_6 inside_19;

    public R_Wait1_4_1 inside_25;
    public R_Wait1_4_3 inside_29;
    public R_Wait1_4_9 inside_34;
    public R_Wait1_4_11 inside_37;

    public R_Wait1_5_1 inside_41;
    public R_Wait1_5_2 inside_57;
    public R_Wait1_5_5 inside_45;
    public R_Wait1_5_6 inside_61;
    public R_Wait1_5_17 inside_49;
    public R_Wait1_5_18 inside_65;
    public R_Wait1_5_21 inside_53;
    public R_Wait1_5_22 inside_69;




    //여기부터는 했음
    public R_Wait1_6_1 inside1_6_1;//1-6-1 안에 있는 거 저장 겸 리셋하려고 만듦
    public R_Wait_1_6_2 inside1_6_2;//1-6-1 안에 있는 거 저장 겸 리셋하려고 만듦
    public R_Wait1_6_3 inside1_6_3;
    public R_Wait1_6_4 inside1_6_4;
    public R_Wait1_6_9 inside1_6_9;
    public R_Wait1_6_30 inside1_6_30;
    public R_Wait1_6_11 inside1_6_11;
    public R_Wait1_6_12 inside1_6_12;
    public R_Wait1_6_33 inside1_6_33;
    public R_Wait1_6_34 inside1_6_34;
    public R_Wait1_6_35 inside1_6_35;
    public R_Wait1_6_36 inside1_6_36;
    public R_Wait1_6_41 inside1_6_41;
    public R_Wait_1_6_42 inside1_6_42;
    public R_Wait1_6_43 inside1_6_43;
    public R_Wait1_6_44 inside1_6_44;

    public Like_1_4_11 like_1_4_11;
    public Line_141 inside_141;
    public Line_142 inside_142;
    public Line_143 inside_143;
    public Line_144 inside_144;
    public Line_145 inside_145;
    public Line_146 inside_146;


    //멈추는게 fix에 있고 게임 로드하는 게 이 스크립트의 update에 있으면
    //->갑자기 그냥 화면이 꺼져버림. 그것 말고는 괜찮음

    //멈추는게 fix에 있고 게임 로드하는 게 이 스크립트의 fix에 있으면
    //->갑자기 그냥 화면이 꺼져버림. 그것 말고는 괜찮음


    //멈추고 재생하는 게 update에 있고 게임 로드하는 게 이 스크립트에 있으면
    //이때 오브젝트가 true 일 때를 제외했다.
    //=>실패

    //멈추고 재생하는 게 update에 있고 게임 로드하는 게 이 스크립트에 있으면
    //=>ㅜㅠ

    //Game_Load_Yes_Ok() 바로 밑에 놓으면
    //=>대실패


    //void Update()
    //{
        /*if (Successful_Load.activeSelf == true&&SceneManager.GetActiveScene().name == "Setting")
        {

            Time.timeScale = 1;
            Debug.Log("게임 로드 타임 스케일은"+Time.timeScale+"이다.");
            //함수가 아니라 그 로드에 성공했습니다
            //대사 나오면 그 함수 실행과 동시에 타임스케일 1로 하면 됨

        }

        if (Successful_Load.activeSelf == true && questObject.questObject[0].gameObject.activeSelf==true)
        {

            Time.timeScale = 1;
            Debug.Log("게임 로드 타임 스케일은" + Time.timeScale + "이다.");

        }

        if (Successful_Load.activeSelf == true && questObject.questObject[3].gameObject.activeSelf == true)
        {

            Time.timeScale = 1;
            Debug.Log("게임 로드 타임 스케일은" + Time.timeScale + "이다.");

        }

        if (Successful_Load.activeSelf == true && questObject.questObject[4].gameObject.activeSelf == true)
        {

            Time.timeScale = 1;
            Debug.Log("게임 로드 타임 스케일은" + Time.timeScale + "이다.");

        }*/
    //}

    public void Game_Load_Yes_Ok()
    {//게임 데이터 로드 클릭하고 확인 누르고 성공적으로 불러와졌을 경우

        /*if (Successful_Load.activeSelf == true && SceneManager.GetActiveScene().name == "Setting")
        {

            Time.timeScale = 1;
            Debug.Log("게임 로드 타임 스케일은" + Time.timeScale + "이다.");
            //함수가 아니라 그 로드에 성공했습니다
            //대사 나오면 그 함수 실행과 동시에 타임스케일 1로 하면 됨

        }*/

        

        StartCoroutine(WaitSecond_1());
        StartCoroutine(WaitSecond_2());

        

        IEnumerator WaitSecond_1()
        {
            yield return new WaitForSeconds(0.0f);
            

            Game_Data_Load.SetActive(false);
            Successful_Load.SetActive(false);

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


        }

        IEnumerator WaitSecond_2()
        {
            

            yield return new WaitForSeconds(1.5f);
            
            /*if (Successful_Load.activeSelf == true && SceneManager.GetActiveScene().name == "Setting")
            {

                Time.timeScale = 1;
                Debug.Log("게임 로드 타임 스케일은" + Time.timeScale + "이다.");
                //함수가 아니라 그 로드에 성공했습니다
                //대사 나오면 그 함수 실행과 동시에 타임스케일 1로 하면 됨

            }*/

            //여긴 로드할 것들...
            Debug.Log("게임 로드");

            //SFX 
            /*float SFX_Sd = PlayerPrefs.GetFloat("back_SFX_Vol");
            sfx_Manager.back_SFX_Vol = SFX_Sd;
            Debug.Log(SFX_Sd + "가 저장한 효과음 크기");


            //BGM
            float BGM_Sound = PlayerPrefs.GetFloat("backvol");
            bgm.backVol = BGM_Sound;
            Debug.Log(BGM_Sound + "가 저장한 배경음 크기");

            //스피드
            float Auto_Speed = PlayerPrefs.GetFloat("Speed");
            Setting_fast.Speed = Auto_Speed;
            Debug.Log(Auto_Speed + "가 저장한 스피드");*/

            //엔딩1
            int Ending_1 = PlayerPrefs.GetInt("First_Ending");
            save.Ending1_Index = Ending_1;
            save.Ending1[Ending_1].gameObject.SetActive(true);


            //엔딩2
            int Ending_2 = PlayerPrefs.GetInt("Second_Ending");
            save.Ending2_Index = Ending_2;
            save.Ending2[Ending_2].gameObject.SetActive(true);

            //엔딩3
            int Ending_3 = PlayerPrefs.GetInt("Thrid_Ending");
            save.Ending3_Index = Ending_3;
            save.Ending3[Ending_3].gameObject.SetActive(true);


            //엔딩4
            int Ending_4 = PlayerPrefs.GetInt("Fourth_Ending");
            save.Ending4_Index = Ending_4;
            save.Ending4[Ending_4].gameObject.SetActive(true);


            //사장
            int Auto_Boss = PlayerPrefs.GetInt("Boss");
            save.Boss_Index = Auto_Boss;
            save.Boss[Auto_Boss].gameObject.SetActive(true);

            //소리
            int Auto_Sori = PlayerPrefs.GetInt("Sori");
            save.Sori_Index = Auto_Sori;
            save.Sori[Auto_Sori].gameObject.SetActive(true);

            //가짜 사장
            int Auto_Fake_Boss = PlayerPrefs.GetInt("Fake_Boss");
            save.Fake_Boss_Index = Auto_Fake_Boss;
            save.Fake_Boss[Auto_Fake_Boss].gameObject.SetActive(true);


            //조율자
            int Auto_Black_Face_Man = PlayerPrefs.GetInt("Black_Face_Man");
            save.Black_Face_Man_Index = Auto_Black_Face_Man;
            save.Black_Face_Man[Auto_Black_Face_Man].gameObject.SetActive(true);


            //타임라인 큰 네모
            int Auto_TimeLine_1 = PlayerPrefs.GetInt("TimeLine");
            save.Time_Line_Open_Index = Auto_TimeLine_1;
            save.Time_Line_Open[Auto_TimeLine_1].gameObject.SetActive(true);

            //타임라인 중간부터 시작
            int Auto_Time_Run = PlayerPrefs.GetInt("TimeLine_Run");
            save.Time_Run_Index = Auto_Time_Run;
            save.Time_Run[Auto_Time_Run].gameObject.SetActive(true);


            //타임라인 안에 동그라미1
            int Auto_Circle_1 = PlayerPrefs.GetInt("Time_Circle_1");
            save.Time_Circle_1_Index = Auto_Circle_1;
            save.Time_Circle_1[Auto_Circle_1].gameObject.SetActive(true);

            //타임라인 안에 동그라미2
            int Auto_Circle_2 = PlayerPrefs.GetInt("Time_Circle_2");
            save.Time_Circle_2_Index = Auto_Circle_2;
            save.Time_Circle_2[Auto_Circle_2].gameObject.SetActive(true);


            //1번 업적
            int Auto_Achieve_1 = PlayerPrefs.GetInt("Achieve_1");
            save.Achieve1_Index = Auto_Achieve_1;
            save.Achieve_1[Auto_Achieve_1].gameObject.SetActive(true);

            //2번 업적
            int Auto_Achieve_2 = PlayerPrefs.GetInt("Achieve_2");
            save.Achieve2_Index = Auto_Achieve_2;
            save.Achieve_2[Auto_Achieve_2].gameObject.SetActive(true);

            //3번 업적
            //얘는 멀쩡해
            int Auto_Achieve_3 = PlayerPrefs.GetInt("Achieve_3");
            save.Achieve3_Index = Auto_Achieve_3;
            save.Achieve_3[Auto_Achieve_3].gameObject.SetActive(true);

            //4번 업적
            //얘는 멀쩡해
            int Auto_Achieve_4 = PlayerPrefs.GetInt("Achieve_4");
            save.Achieve4_Index = Auto_Achieve_4;
            save.Achieve_4[Auto_Achieve_4].gameObject.SetActive(true);

            //5번 업적
            int Auto_Achieve_5 = PlayerPrefs.GetInt("Achieve_5");
            save.Achieve5_Index = Auto_Achieve_5;
            save.Achieve_5[Auto_Achieve_5].gameObject.SetActive(true);

            //6번 업적
            int Auto_Achieve_6 = PlayerPrefs.GetInt("Achieve_6");
            save.Achieve6_Index = Auto_Achieve_6;
            save.Achieve_6[Auto_Achieve_6].gameObject.SetActive(true);

            //7번 업적
            int Auto_Achieve_7 = PlayerPrefs.GetInt("Achieve_7");
            save.Achieve7_Index = Auto_Achieve_7;
            save.Achieve_7[Auto_Achieve_7].gameObject.SetActive(true);

            //8번 업적
            int Auto_Achieve_8 = PlayerPrefs.GetInt("Achieve_8");
            save.Achieve8_Index = Auto_Achieve_8;
            save.Achieve_8[Auto_Achieve_8].gameObject.SetActive(true);

            //9번 업적
            int Auto_Achieve_9 = PlayerPrefs.GetInt("Achieve_9");
            save.Achieve9_Index = Auto_Achieve_9;
            save.Achieve_9[Auto_Achieve_9].gameObject.SetActive(true);

            //10번 업적
            int Auto_Achieve_10 = PlayerPrefs.GetInt("Achieve_10");
            save.Achieve10_Index = Auto_Achieve_10;
            save.Achieve_10[Auto_Achieve_10].gameObject.SetActive(true);

            //11번 업적
            int Auto_Achieve_11 = PlayerPrefs.GetInt("Achieve_11");
            save.Achieve11_Index = Auto_Achieve_11;
            save.Achieve_11[Auto_Achieve_11].gameObject.SetActive(true);

            //12번 업적
            //얘는 멀쩡해
            int Auto_Achieve_12 = PlayerPrefs.GetInt("Achieve_12");
            save.Achieve12_Index = Auto_Achieve_12;
            save.Achieve_12[Auto_Achieve_12].gameObject.SetActive(true);


            //1번 앨범
            int Auto_Album_1 = PlayerPrefs.GetInt("Album_1");
            save.Album1_Index = Auto_Album_1;
            save.Album_1[Auto_Album_1].gameObject.SetActive(true);

            //2번 앨범
            int Auto_Album_2 = PlayerPrefs.GetInt("Album_2");
            save.Album2_Index = Auto_Album_2;
            save.Album_2[Auto_Album_2].gameObject.SetActive(true);

            //3번 앨범
            int Auto_Album_3 = PlayerPrefs.GetInt("Album_3");
            save.Album3_Index = Auto_Album_3;
            save.Album_3[Auto_Album_3].gameObject.SetActive(true);

            //4번 앨범
            int Auto_Album_4 = PlayerPrefs.GetInt("Album_4");
            save.Album4_Index = Auto_Album_4;
            save.Album_4[Auto_Album_4].gameObject.SetActive(true);

            //5번 앨범
            int Auto_Album_5 = PlayerPrefs.GetInt("Album_5");
            save.Album5_Index = Auto_Album_5;
            save.Album_5[Auto_Album_5].gameObject.SetActive(true);

            //6번 앨범
            int Auto_Album_6 = PlayerPrefs.GetInt("Album_6");
            save.Album6_Index = Auto_Album_6;
            save.Album_6[Auto_Album_6].gameObject.SetActive(true);

            //7번 앨범
            int Auto_Album_7 = PlayerPrefs.GetInt("Album_7");
            save.Album7_Index = Auto_Album_7;
            save.Album_7[Auto_Album_7].gameObject.SetActive(true);

            //8번 앨범
            int Auto_Album_8 = PlayerPrefs.GetInt("Album_8");
            save.Album8_Index = Auto_Album_8;
            save.Album_8[Auto_Album_8].gameObject.SetActive(true);

            //9번 앨범
            int Auto_Album_9 = PlayerPrefs.GetInt("Album_9");
            save.Album9_Index = Auto_Album_9;
            save.Album_9[Auto_Album_9].gameObject.SetActive(true);

            //10번 앨범
            int Auto_Album_10 = PlayerPrefs.GetInt("Album_10");
            save.Album10_Index = Auto_Album_10;
            save.Album_10[Auto_Album_10].gameObject.SetActive(true);

            //11번 앨범
            int Auto_Album_11 = PlayerPrefs.GetInt("Album_11");
            save.Album11_Index = Auto_Album_11;
            save.Album_11[Auto_Album_11].gameObject.SetActive(true);

            //12번 앨범
            int Auto_Album_12 = PlayerPrefs.GetInt("Album_12");
            save.Album12_Index = Auto_Album_12;
            save.Album_12[Auto_Album_12].gameObject.SetActive(true);




            //1번째 라인 리셋
            inside_0.Line_0_Index = 0;
            inside_0.inside_Line_0[0].gameObject.SetActive(false);
            inside_0.inside_Line_0[1].gameObject.SetActive(false);
            inside_0.inside_Line_0[2].gameObject.SetActive(false);
            inside_0.inside_Line_0[3].gameObject.SetActive(false);
            inside_0.inside_Line_0[4].gameObject.SetActive(false);
            inside_0.inside_Line_0[5].gameObject.SetActive(false);
            inside_0.inside_Line_0[6].gameObject.SetActive(false);
            inside_0.inside_Line_0[7].gameObject.SetActive(false);
            inside_0.inside_Line_0[8].gameObject.SetActive(false);
            inside_0.inside_Line_0[9].gameObject.SetActive(false);
            inside_0.inside_Line_0[10].gameObject.SetActive(false);
            inside_0.inside_Line_0[11].gameObject.SetActive(false);
            inside_0.inside_Line_0[12].gameObject.SetActive(false);


            //int BGM_Index = PlayerPrefs.GetInt("BGM_Index");
            int Line_Index = PlayerPrefs.GetInt("Index");
            Debug.Log(Line_Index + "불러오기");

            

            questObject.Line_Index = Line_Index;
            questObject.questObject[Line_Index].gameObject.SetActive(true);

            /*questObject.BGM_Index = BGM_Index;
            questObject.Audio_Object[BGM_Index].gameObject.SetActive(true);*/

    


            if (Line_Index == 0)
            {
                

                inside_0.m_Coroutine = inside_0.NewCoroutine();
                StartCoroutine(inside_0.m_Coroutine);
                Debug.Log("0 리셋하자");





            }

            if (Line_Index == 3)
            {
                questObject.Go_Thrid_Line();
                inside_1.m_Coroutine = inside_1.NewCoroutine();
                StartCoroutine(inside_1.m_Coroutine);
                Debug.Log("1같은 3 리셋하자");
            }

            if (Line_Index == 4)
            {
                questObject.Go_Fourth_Line();
                inside_2.m_Coroutine = inside_2.NewCoroutine();
                StartCoroutine(inside_2.m_Coroutine);
                Debug.Log("2같은 4 리셋하자");
            }

            if (Line_Index == 5)
            {
                questObject.Go_Fifth_Line();

                inside_5.m_Coroutine = inside_5.NewCoroutine();
                StartCoroutine(inside_5.m_Coroutine);
                Debug.Log("5번째 리셋하자");
            }

            if (Line_Index == 6)
            {
                questObject.Go_Six_Line();

                inside_8.m_Coroutine = inside_8.NewCoroutine();
                StartCoroutine(inside_8.m_Coroutine);
                Debug.Log("6번째 리셋하자");
            }

            if (Line_Index == 7)
            {
                questObject.Go_Seven_Line();
                inside_5.m_Coroutine = inside_5.NewCoroutine();
                StartCoroutine(inside_5.m_Coroutine);
                Debug.Log("7번째 리셋하자");
            }

            if (Line_Index == 8)
            {
                //8번째 라인이 리셋 안 됨

                questObject.Go_Eight_Line();
                inside_8.m_Coroutine = inside_8.NewCoroutine();
                StartCoroutine(inside_8.m_Coroutine);
                Debug.Log("8번째 리셋하자");
            }

            if (Line_Index == 9)
            {
                questObject.Go_Nine_Line();
                inside_9.m_Coroutine = inside_9.NewCoroutine();
                StartCoroutine(inside_9.m_Coroutine);
                Debug.Log("9번째 리셋하자");
            }

            if (Line_Index == 10)
            {
                questObject.Go_Ten_Line();
                inside_9.m_Coroutine = inside_9.NewCoroutine();
                StartCoroutine(inside_9.m_Coroutine);
                Debug.Log("10번째 리셋하자");
            }

            if (Line_Index == 11)
            {
                questObject.Go_Eleven_Line();
                inside_11.m_Coroutine = inside_11.NewCoroutine();
                StartCoroutine(inside_11.m_Coroutine);
                Debug.Log("11번째 리셋하자");
            }

            if (Line_Index == 12)
            {
                questObject.Go_Twelve_Line();
                inside_11.m_Coroutine = inside_11.NewCoroutine();
                StartCoroutine(inside_11.m_Coroutine);
                Debug.Log("12번째 리셋하자");
            }

            if (Line_Index == 13)
            {
                questObject.Go_Thirteen_Line();
                inside_13.m_Coroutine = inside_13.NewCoroutine();
                StartCoroutine(inside_13.m_Coroutine);
                Debug.Log("13번째 리셋하자");
            }

            if (Line_Index == 14)
            {
                questObject.Go_Fourteen_Line();
                inside_13.m_Coroutine = inside_13.NewCoroutine();
                StartCoroutine(inside_13.m_Coroutine);
                Debug.Log("14번째 리셋하자");
            }

            if (Line_Index == 15)
            {
                questObject.Go_Fifteen_Line();
                inside_15.m_Coroutine = inside_15.NewCoroutine();
                StartCoroutine(inside_15.m_Coroutine);
                Debug.Log("15번째 리셋하자");
            }

            if (Line_Index == 16)
            {
                questObject.Go_Sixteen_Line();
                inside_15.m_Coroutine = inside_15.NewCoroutine();
                StartCoroutine(inside_15.m_Coroutine);
                Debug.Log("16번째 리셋하자");
            }

            if (Line_Index == 17)
            {
                questObject.Go_Seventeen_Line();
                inside_17.m_Coroutine = inside_17.NewCoroutine();
                StartCoroutine(inside_17.m_Coroutine);
                Debug.Log("17번째 리셋하자");
            }

            if (Line_Index == 18)
            {
                questObject.Go_Eighteen_Line();
                inside_17.m_Coroutine = inside_17.NewCoroutine();
                StartCoroutine(inside_17.m_Coroutine);
                Debug.Log("18번째 리셋하자");
            }

            if (Line_Index == 19)
            {
                questObject.Go_Nineteen_Line();
                inside_19.m_Coroutine = inside_19.NewCoroutine();
                StartCoroutine(inside_19.m_Coroutine);
                Debug.Log("19번째 리셋하자");
            }

            if (Line_Index == 20)
            {
                questObject.Go_Twenty_Line();
                inside_19.m_Coroutine = inside_19.NewCoroutine();
                StartCoroutine(inside_19.m_Coroutine);
                Debug.Log("20번째 리셋하자");
            }

            if (Line_Index == 21)
            {
                questObject.Go_TwentyOne_Line();
                inside_21.m_Coroutine = inside_21.NewCoroutine();
                StartCoroutine(inside_21.m_Coroutine);
                Debug.Log("21번째 리셋하자");
            }

            if (Line_Index == 22)
            {
                questObject.Go_TwentyTwo_Line();
                inside_21.m_Coroutine = inside_21.NewCoroutine();
                StartCoroutine(inside_21.m_Coroutine);
                Debug.Log("22번째 리셋하자");
            }

            if (Line_Index == 23)
            {
                questObject.Go_TwentyThree_Line();
                inside_23.m_Coroutine = inside_23.NewCoroutine();
                StartCoroutine(inside_23.m_Coroutine);
                Debug.Log("23번째 리셋하자");
            }

            if (Line_Index == 24)
            {
                questObject.Go_TwentyFour_Line();
                inside_23.m_Coroutine = inside_23.NewCoroutine();
                StartCoroutine(inside_23.m_Coroutine);
                Debug.Log("24번째 리셋하자");
            }

            if (Line_Index == 25)
            {
                questObject.Go_TwentyFive_Line();
                inside_25.m_Coroutine = inside_25.NewCoroutine();
                StartCoroutine(inside_25.m_Coroutine);
                Debug.Log("25번째 리셋하자");
            }

            if (Line_Index == 26)
            {
                questObject.Go_TwentySix_Line();
                inside_25.m_Coroutine = inside_25.NewCoroutine();
                StartCoroutine(inside_25.m_Coroutine);
                Debug.Log("26번째 리셋하자");
            }

            if (Line_Index == 27)
            {
                questObject.Go_TwentySeven_Line();
                inside_25.m_Coroutine = inside_25.NewCoroutine();
                StartCoroutine(inside_25.m_Coroutine);
                Debug.Log("27번째 리셋하자");
            }

            if (Line_Index == 28)
            {
                questObject.Go_TwentyEight_Line();
                inside_25.m_Coroutine = inside_25.NewCoroutine();
                StartCoroutine(inside_25.m_Coroutine);
                Debug.Log("28번째 리셋하자");
            }

            if (Line_Index == 29)
            {
                questObject.Go_TwentyNine_Line();
                inside_29.m_Coroutine = inside_29.NewCoroutine();
                StartCoroutine(inside_29.m_Coroutine);
                Debug.Log("29번째 리셋하자");
            }

            if (Line_Index == 30)
            {
                questObject.Go_Thirty_Line();
                inside_29.m_Coroutine = inside_29.NewCoroutine();
                StartCoroutine(inside_29.m_Coroutine);
                Debug.Log("30번째 리셋하자");
            }

            if (Line_Index == 31)
            {
                questObject.Go_ThirtyOne_Line();
                inside_29.m_Coroutine = inside_29.NewCoroutine();
                StartCoroutine(inside_29.m_Coroutine);
                Debug.Log("31번째 리셋하자");
            }

            if (Line_Index == 32)
            {
                questObject.Go_ThirtyTwo_Line();
                inside_29.m_Coroutine = inside_29.NewCoroutine();
                StartCoroutine(inside_29.m_Coroutine);
                Debug.Log("32번째 리셋하자");
            }

            if (Line_Index == 33)
            {
                questObject.Go_ThirtyThree_Line();
                inside_34.m_Coroutine = inside_34.NewCoroutine();
                StartCoroutine(inside_34.m_Coroutine);
                Debug.Log("33번째 리셋하자");
            }

            if (Line_Index == 34)
            {
                questObject.Go_ThirtyFour_Line();
                inside_34.m_Coroutine = inside_34.NewCoroutine();
                StartCoroutine(inside_34.m_Coroutine);
                Debug.Log("34번째 리셋하자");
            }

            if (Line_Index == 35)
            {
                questObject.Go_ThirtyFive_Line();
                inside_34.m_Coroutine = inside_34.NewCoroutine();
                StartCoroutine(inside_34.m_Coroutine);
                Debug.Log("35번째 리셋하자");
            }

            if (Line_Index == 36)
            {
                questObject.Go_ThirtySix_Line();
                inside_34.m_Coroutine = inside_34.NewCoroutine();
                StartCoroutine(inside_34.m_Coroutine);
                Debug.Log("36번째 리셋하자");
            }

            if (Line_Index == 37)
            {
                questObject.Go_ThirtySeven_Line();
                inside_37.m_Coroutine = inside_37.NewCoroutine();
                StartCoroutine(inside_37.m_Coroutine);
                Debug.Log("37번째 리셋하자");
            }

            if (Line_Index == 38)
            {
                questObject.Go_ThirtyEight_Line();
                inside_37.m_Coroutine = inside_37.NewCoroutine();
                StartCoroutine(inside_37.m_Coroutine);
                Debug.Log("38번째 리셋하자");
            }

            if (Line_Index == 39)
            {
                questObject.Go_ThirtyNine_Line();
                inside_37.m_Coroutine = inside_37.NewCoroutine();
                StartCoroutine(inside_37.m_Coroutine);
                Debug.Log("39번째 리셋하자");
            }

            if (Line_Index == 40)
            {
                questObject.Go_Forty_Line();
                inside_37.m_Coroutine = inside_37.NewCoroutine();
                StartCoroutine(inside_37.m_Coroutine);
                Debug.Log("40번째 리셋하자");
            }

            if (Line_Index == 41)
            {
                questObject.Go_41_Line();
                inside_41.m_Coroutine = inside_41.NewCoroutine();
                StartCoroutine(inside_41.m_Coroutine);
                Debug.Log("41번째 리셋하자");
            }

            if (Line_Index == 42)
            {
                questObject.Go_42_Line();
                inside_41.m_Coroutine = inside_41.NewCoroutine();
                StartCoroutine(inside_41.m_Coroutine);
                Debug.Log("42번째 리셋하자");
            }

            if (Line_Index == 43)
            {
                questObject.Go_43_Line();
                inside_41.m_Coroutine = inside_41.NewCoroutine();
                StartCoroutine(inside_41.m_Coroutine);
                Debug.Log("43번째 리셋하자");
            }

            if (Line_Index == 44)
            {
                questObject.Go_44_Line();
                inside_41.m_Coroutine = inside_41.NewCoroutine();
                StartCoroutine(inside_41.m_Coroutine);
                Debug.Log("44번째 리셋하자");
            }

            if (Line_Index == 45)
            {
                questObject.Go_45_Line();
                inside_45.m_Coroutine = inside_45.NewCoroutine();
                StartCoroutine(inside_45.m_Coroutine);
                Debug.Log("45번째 리셋하자");
            }

            if (Line_Index == 46)
            {
                questObject.Go_46_Line();
                inside_45.m_Coroutine = inside_45.NewCoroutine();
                StartCoroutine(inside_45.m_Coroutine);
                Debug.Log("46번째 리셋하자");
            }

            if (Line_Index == 47)
            {
                questObject.Go_47_Line();
                inside_45.m_Coroutine = inside_45.NewCoroutine();
                StartCoroutine(inside_45.m_Coroutine);
                Debug.Log("47번째 리셋하자");
            }

            if (Line_Index == 48)
            {
                questObject.Go_48_Line();
                inside_45.m_Coroutine = inside_45.NewCoroutine();
                StartCoroutine(inside_45.m_Coroutine);
                Debug.Log("48번째 리셋하자");
            }

            if (Line_Index == 49)
            {
                questObject.Go_49_Line();
                inside_49.m_Coroutine = inside_49.NewCoroutine();
                StartCoroutine(inside_49.m_Coroutine);
                Debug.Log("49번째 리셋하자");
            }

            if (Line_Index == 50)
            {
                questObject.Go_50_Line();
                inside_49.m_Coroutine = inside_49.NewCoroutine();
                StartCoroutine(inside_49.m_Coroutine);
                Debug.Log("50번째 리셋하자");
            }

            if (Line_Index == 51)
            {
                questObject.Go_51_Line();
                inside_49.m_Coroutine = inside_49.NewCoroutine();
                StartCoroutine(inside_49.m_Coroutine);
                Debug.Log("51번째 리셋하자");
            }

            if (Line_Index == 52)
            {
                questObject.Go_52_Line();
                inside_49.m_Coroutine = inside_49.NewCoroutine();
                StartCoroutine(inside_49.m_Coroutine);
                Debug.Log("52번째 리셋하자");
            }


            if (Line_Index == 53)
            {
                questObject.Go_53_Line();
                inside_53.m_Coroutine = inside_53.NewCoroutine();
                StartCoroutine(inside_53.m_Coroutine);
                Debug.Log("53번째 리셋하자");
            }

            if (Line_Index == 54)
            {
                questObject.Go_54_Line();
                inside_53.m_Coroutine = inside_53.NewCoroutine();
                StartCoroutine(inside_53.m_Coroutine);
                Debug.Log("54번째 리셋하자");
            }

            if (Line_Index == 55)
            {
                questObject.Go_55_Line();
                inside_53.m_Coroutine = inside_53.NewCoroutine();
                StartCoroutine(inside_53.m_Coroutine);
                Debug.Log("55번째 리셋하자");
            }

            if (Line_Index == 56)
            {
                questObject.Go_56_Line();
                inside_53.m_Coroutine = inside_53.NewCoroutine();
                StartCoroutine(inside_53.m_Coroutine);
                Debug.Log("56번째 리셋하자");
            }

            if (Line_Index == 57)
            {
                questObject.Go_57_Line();
                inside_57.m_Coroutine = inside_57.NewCoroutine();
                StartCoroutine(inside_57.m_Coroutine);
                Debug.Log("57번째 리셋하자");
            }

            if (Line_Index == 58)
            {
                questObject.Go_58_Line();
                inside_57.m_Coroutine = inside_57.NewCoroutine();
                StartCoroutine(inside_57.m_Coroutine);
                Debug.Log("58번째 리셋하자");
            }

            if (Line_Index == 59)
            {
                questObject.Go_59_Line();
                inside_57.m_Coroutine = inside_57.NewCoroutine();
                StartCoroutine(inside_57.m_Coroutine);
                Debug.Log("59번째 리셋하자");
            }

            if (Line_Index == 60)
            {
                questObject.Go_60_Line();
                inside_57.m_Coroutine = inside_57.NewCoroutine();
                StartCoroutine(inside_57.m_Coroutine);
                Debug.Log("60번째 리셋하자");
            }

            if (Line_Index == 61)
            {
                questObject.Go_61_Line();
                inside_61.m_Coroutine = inside_61.NewCoroutine();
                StartCoroutine(inside_61.m_Coroutine);
                Debug.Log("61번째 리셋하자");
            }

            if (Line_Index == 62)
            {
                questObject.Go_62_Line();
                inside_61.m_Coroutine = inside_61.NewCoroutine();
                StartCoroutine(inside_61.m_Coroutine);
                Debug.Log("62번째 리셋하자");
            }

            if (Line_Index == 63)
            {
                questObject.Go_63_Line();
                inside_61.m_Coroutine = inside_61.NewCoroutine();
                StartCoroutine(inside_61.m_Coroutine);
                Debug.Log("63번째 리셋하자");
            }

            if (Line_Index == 64)
            {
                questObject.Go_64_Line();
                inside_61.m_Coroutine = inside_61.NewCoroutine();
                StartCoroutine(inside_61.m_Coroutine);
                Debug.Log("64번째 리셋하자");
            }

            if (Line_Index == 65)
            {
                questObject.Go_65_Line();
                inside_65.m_Coroutine = inside_65.NewCoroutine();
                StartCoroutine(inside_65.m_Coroutine);
                Debug.Log("65번째 리셋하자");
            }

            if (Line_Index == 66)
            {
                questObject.Go_66_Line();
                inside_65.m_Coroutine = inside_65.NewCoroutine();
                StartCoroutine(inside_65.m_Coroutine);
                Debug.Log("66번째 리셋하자");
            }

            if (Line_Index == 67)
            {
                questObject.Go_67_Line();
                inside_65.m_Coroutine = inside_65.NewCoroutine();
                StartCoroutine(inside_65.m_Coroutine);
                Debug.Log("67번째 리셋하자");
            }

            if (Line_Index == 68)
            {
                questObject.Go_68_Line();
                inside_65.m_Coroutine = inside_65.NewCoroutine();
                StartCoroutine(inside_65.m_Coroutine);
                Debug.Log("68번째 리셋하자");
            }

            if (Line_Index == 69)
            {
                questObject.Go_69_Line();
                inside_69.m_Coroutine = inside_69.NewCoroutine();
                StartCoroutine(inside_69.m_Coroutine);
                Debug.Log("69번째 리셋하자");
            }

            if (Line_Index == 70)
            {
                questObject.Go_70_Line();
                inside_69.m_Coroutine = inside_69.NewCoroutine();
                StartCoroutine(inside_69.m_Coroutine);
                Debug.Log("70번째 리셋하자");
            }

            if (Line_Index == 71)
            {
                questObject.Go_71_Line();
                inside_69.m_Coroutine = inside_69.NewCoroutine();
                StartCoroutine(inside_69.m_Coroutine);
                Debug.Log("71번째 리셋하자");
            }

            if (Line_Index == 72)
            {
                questObject.Go_72_Line();
                inside_69.m_Coroutine = inside_69.NewCoroutine();
                StartCoroutine(inside_69.m_Coroutine);
                Debug.Log("72번째 리셋하자");
            }

            if (Line_Index == 73)
            {
                questObject.Go_73_Line();
                inside1_6_1.m_Coroutine = inside1_6_1.WaitSecond_0();
                StartCoroutine(inside1_6_1.m_Coroutine);
                Debug.Log("73번째 리셋하자");
            }

            if (Line_Index == 74)
            {
                questObject.Go_74_Line();
                inside1_6_1.m_Coroutine = inside1_6_1.WaitSecond_0();
                StartCoroutine(inside1_6_1.m_Coroutine);
                Debug.Log("74번째 리셋하자");
            }

            if (Line_Index == 75)
            {
                questObject.Go_75_Line();
                inside1_6_1.m_Coroutine = inside1_6_1.WaitSecond_0();
                StartCoroutine(inside1_6_1.m_Coroutine);
                Debug.Log("75번째 리셋하자");
            }

            if (Line_Index == 76)
            {
                questObject.Go_76_Line();
                inside1_6_1.m_Coroutine = inside1_6_1.WaitSecond_0();
                StartCoroutine(inside1_6_1.m_Coroutine);
                Debug.Log("76번째 리셋하자");
            }

            if (Line_Index == 77)
            {
                questObject.Go_77_Line();
                inside1_6_2.m_Coroutine = inside1_6_2.WaitSecond_0();
                StartCoroutine(inside1_6_2.m_Coroutine);
                Debug.Log("77번째 리셋하자");
            }

            if (Line_Index == 78)
            {
                questObject.Go_78_Line();
                inside1_6_2.m_Coroutine = inside1_6_2.WaitSecond_0();
                StartCoroutine(inside1_6_2.m_Coroutine);
                Debug.Log("78번째 리셋하자");
            }

            if (Line_Index == 79)
            {
                questObject.Go_79_Line();
                inside1_6_2.m_Coroutine = inside1_6_2.WaitSecond_0();
                StartCoroutine(inside1_6_2.m_Coroutine);
                Debug.Log("79번째 리셋하자");
            }

            if (Line_Index == 80)
            {
                questObject.Go_80_Line();
                inside1_6_2.m_Coroutine = inside1_6_2.WaitSecond_0();
                StartCoroutine(inside1_6_2.m_Coroutine);
                Debug.Log("80번째 리셋하자");
            }

            if (Line_Index == 81)
            {
                questObject.Go_81_Line();
                inside1_6_3.m_Coroutine = inside1_6_3.WaitSecond_0();
                StartCoroutine(inside1_6_3.m_Coroutine);
                Debug.Log("81번째 리셋하자");
            }

            if (Line_Index == 82)
            {
                questObject.Go_82_Line();
                inside1_6_3.m_Coroutine = inside1_6_3.WaitSecond_0();
                StartCoroutine(inside1_6_3.m_Coroutine);
                Debug.Log("82번째 리셋하자");
            }

            if (Line_Index == 83)
            {
                questObject.Go_83_Line();
                inside1_6_3.m_Coroutine = inside1_6_3.WaitSecond_0();
                StartCoroutine(inside1_6_3.m_Coroutine);
                Debug.Log("83번째 리셋하자");
            }

            if (Line_Index == 84)
            {
                questObject.Go_84_Line();
                inside1_6_3.m_Coroutine = inside1_6_3.WaitSecond_0();
                StartCoroutine(inside1_6_3.m_Coroutine);
                Debug.Log("84번째 리셋하자");
            }

            if (Line_Index == 85)
            {
                questObject.Go_85_Line();
                inside1_6_4.m_Coroutine = inside1_6_4.WaitSecond_0();
                StartCoroutine(inside1_6_4.m_Coroutine);
                Debug.Log("85번째 리셋하자");
            }

            if (Line_Index == 86)
            {
                questObject.Go_86_Line();
                inside1_6_4.m_Coroutine = inside1_6_4.WaitSecond_0();
                StartCoroutine(inside1_6_4.m_Coroutine);
                Debug.Log("86번째 리셋하자");
            }

            if (Line_Index == 87)
            {
                questObject.Go_87_Line();
                inside1_6_4.m_Coroutine = inside1_6_4.WaitSecond_0();
                StartCoroutine(inside1_6_4.m_Coroutine);
                Debug.Log("87번째 리셋하자");
            }

            if (Line_Index == 88)
            {
                questObject.Go_88_Line();
                inside1_6_4.m_Coroutine = inside1_6_4.WaitSecond_0();
                StartCoroutine(inside1_6_4.m_Coroutine);
                Debug.Log("88번째 리셋하자");
            }

            if (Line_Index == 89)
            {
                questObject.Go_89_Line();
                inside1_6_9.m_Coroutine = inside1_6_9.WaitSecond_0();
                StartCoroutine(inside1_6_9.m_Coroutine);
                Debug.Log("89번째 리셋하자"); ;
            }

            if (Line_Index == 90)
            {
                questObject.Go_90_Line();
                inside1_6_9.m_Coroutine = inside1_6_9.WaitSecond_0();
                StartCoroutine(inside1_6_9.m_Coroutine);
                Debug.Log("90번째 리셋하자");
            }

            if (Line_Index == 91)
            {
                questObject.Go_91_Line();
                inside1_6_9.m_Coroutine = inside1_6_9.WaitSecond_0();
                StartCoroutine(inside1_6_9.m_Coroutine);
                Debug.Log("91번째 리셋하자");
            }

            if (Line_Index == 92)
            {
                questObject.Go_92_Line();
                inside1_6_9.m_Coroutine = inside1_6_9.WaitSecond_0();
                StartCoroutine(inside1_6_9.m_Coroutine);
                Debug.Log("92번째 리셋하자");
            }

            if (Line_Index == 93)
            {
                questObject.Go_93_Line();
                inside1_6_30.m_Coroutine = inside1_6_30.WaitSecond_0();
                StartCoroutine(inside1_6_30.m_Coroutine);
                Debug.Log("93번째 리셋하자");
            }

            if (Line_Index == 94)
            {
                questObject.Go_94_Line();
                inside1_6_30.m_Coroutine = inside1_6_30.WaitSecond_0();
                StartCoroutine(inside1_6_30.m_Coroutine);
                Debug.Log("94번째 리셋하자");
            }

            if (Line_Index == 95)
            {
                questObject.Go_95_Line();
                inside1_6_30.m_Coroutine = inside1_6_30.WaitSecond_0();
                StartCoroutine(inside1_6_30.m_Coroutine);
                Debug.Log("95번째 리셋하자");
            }

            if (Line_Index == 96)
            {
                questObject.Go_96_Line();
                inside1_6_30.m_Coroutine = inside1_6_30.WaitSecond_0();
                StartCoroutine(inside1_6_30.m_Coroutine);
                Debug.Log("96번째 리셋하자");
            }

            if (Line_Index == 97)
            {
                questObject.Go_97_Line();
                inside1_6_11.m_Coroutine = inside1_6_11.WaitSecond_0();
                StartCoroutine(inside1_6_11.m_Coroutine);
                Debug.Log("97번째 리셋하자");
            }

            if (Line_Index == 98)
            {
                questObject.Go_98_Line();
                inside1_6_11.m_Coroutine = inside1_6_11.WaitSecond_0();
                StartCoroutine(inside1_6_11.m_Coroutine);
                Debug.Log("98번째 리셋하자");
            }

            if (Line_Index == 99)
            {
                questObject.Go_99_Line();
                inside1_6_11.m_Coroutine = inside1_6_11.WaitSecond_0();
                StartCoroutine(inside1_6_11.m_Coroutine);
                Debug.Log("99번째 리셋하자");
            }

            if (Line_Index == 100)
            {
                questObject.Go_100_Line();
                inside1_6_11.m_Coroutine = inside1_6_11.WaitSecond_0();
                StartCoroutine(inside1_6_11.m_Coroutine);
                Debug.Log("100번째 리셋하자");
            }

            if (Line_Index == 101)
            {
                questObject.Go_101_Line();
                inside1_6_12.m_Coroutine = inside1_6_12.WaitSecond_0();
                StartCoroutine(inside1_6_12.m_Coroutine);
                Debug.Log("101번째 리셋하자");
            }

            if (Line_Index == 102)
            {
                questObject.Go_102_Line();
                inside1_6_12.m_Coroutine = inside1_6_12.WaitSecond_0();
                StartCoroutine(inside1_6_12.m_Coroutine);
                Debug.Log("102번째 리셋하자");
            }

            if (Line_Index == 103)
            {
                questObject.Go_103_Line();
                inside1_6_12.m_Coroutine = inside1_6_12.WaitSecond_0();
                StartCoroutine(inside1_6_12.m_Coroutine);
                Debug.Log("103번째 리셋하자");
            }

            if (Line_Index == 104)
            {
                questObject.Go_104_Line();
                inside1_6_12.m_Coroutine = inside1_6_12.WaitSecond_0();
                StartCoroutine(inside1_6_12.m_Coroutine);
                Debug.Log("104번째 리셋하자");
            }

            if (Line_Index == 105)
            {
                questObject.Go_105_Line();
                inside1_6_33.m_Coroutine = inside1_6_33.WaitSecond_0();
                StartCoroutine(inside1_6_33.m_Coroutine);
                Debug.Log("105번째 리셋하자");
            }

            if (Line_Index == 106)
            {
                questObject.Go_106_Line();
                inside1_6_33.m_Coroutine = inside1_6_33.WaitSecond_0();
                StartCoroutine(inside1_6_33.m_Coroutine);
                Debug.Log("106번째 리셋하자");
            }

            if (Line_Index == 107)
            {
                questObject.Go_107_Line();
                inside1_6_33.m_Coroutine = inside1_6_33.WaitSecond_0();
                StartCoroutine(inside1_6_33.m_Coroutine);
                Debug.Log("107번째 리셋하자");
            }

            if (Line_Index == 108)
            {
                questObject.Go_108_Line();
                inside1_6_33.m_Coroutine = inside1_6_33.WaitSecond_0();
                StartCoroutine(inside1_6_33.m_Coroutine);
                Debug.Log("108번째 리셋하자");
            }

            if (Line_Index == 109)
            {
                questObject.Go_109_Line();
                inside1_6_34.m_Coroutine = inside1_6_34.WaitSecond_0();
                StartCoroutine(inside1_6_34.m_Coroutine);
                Debug.Log("109번째 리셋하자");
            }

            if (Line_Index == 110)
            {
                questObject.Go_110_Line();
                inside1_6_34.m_Coroutine = inside1_6_34.WaitSecond_0();
                StartCoroutine(inside1_6_34.m_Coroutine);
                Debug.Log("110번째 리셋하자");
            }

            if (Line_Index == 111)
            {
                questObject.Go_111_Line();
                inside1_6_34.m_Coroutine = inside1_6_34.WaitSecond_0();
                StartCoroutine(inside1_6_34.m_Coroutine);
                Debug.Log("111번째 리셋하자");
            }

            if (Line_Index == 112)
            {
                questObject.Go_112_Line();
                inside1_6_34.m_Coroutine = inside1_6_34.WaitSecond_0();
                StartCoroutine(inside1_6_34.m_Coroutine);
                Debug.Log("112번째 리셋하자");
            }

            if (Line_Index == 113)
            {
                questObject.Go_113_Line();
                inside1_6_35.m_Coroutine = inside1_6_35.WaitSecond_0();
                StartCoroutine(inside1_6_35.m_Coroutine);
                Debug.Log("113번째 리셋하자");
            }

            if (Line_Index == 114)
            {
                questObject.Go_114_Line();
                inside1_6_35.m_Coroutine = inside1_6_35.WaitSecond_0();
                StartCoroutine(inside1_6_35.m_Coroutine);
                Debug.Log("114번째 리셋하자");
            }

            if (Line_Index == 115)
            {
                questObject.Go_115_Line();
                inside1_6_35.m_Coroutine = inside1_6_35.WaitSecond_0();
                StartCoroutine(inside1_6_35.m_Coroutine);
                Debug.Log("115번째 리셋하자");
            }

            if (Line_Index == 116)
            {
                questObject.Go_116_Line();
                inside1_6_35.m_Coroutine = inside1_6_35.WaitSecond_0();
                StartCoroutine(inside1_6_35.m_Coroutine);
                Debug.Log("116번째 리셋하자");
            }

            if (Line_Index == 117)
            {
                questObject.Go_117_Line();
                inside1_6_36.m_Coroutine = inside1_6_36.WaitSecond_0();
                StartCoroutine(inside1_6_36.m_Coroutine);
                Debug.Log("117번째 리셋하자");
            }

            if (Line_Index == 118)
            {
                questObject.Go_118_Line();
                inside1_6_36.m_Coroutine = inside1_6_36.WaitSecond_0();
                StartCoroutine(inside1_6_36.m_Coroutine);
                Debug.Log("118번째 리셋하자");
            }

            if (Line_Index == 119)
            {
                questObject.Go_119_Line();
                inside1_6_36.m_Coroutine = inside1_6_36.WaitSecond_0();
                StartCoroutine(inside1_6_36.m_Coroutine);
                Debug.Log("119번째 리셋하자");
            }

            if (Line_Index == 120)
            {
                questObject.Go_120_Line();
                inside1_6_36.m_Coroutine = inside1_6_36.WaitSecond_0();
                StartCoroutine(inside1_6_36.m_Coroutine);
                Debug.Log("120번째 리셋하자");
            }

            if (Line_Index == 121)
            {
                questObject.Go_121_Line();
                inside1_6_41.m_Coroutine = inside1_6_41.WaitSecond_0();
                StartCoroutine(inside1_6_41.m_Coroutine);
                Debug.Log("121번째 리셋하자");
            }

            if (Line_Index == 122)
            {
                questObject.Go_122_Line();
                inside1_6_41.m_Coroutine = inside1_6_41.WaitSecond_0();
                StartCoroutine(inside1_6_41.m_Coroutine);
                Debug.Log("122번째 리셋하자");
            }

            if (Line_Index == 123)
            {
                questObject.Go_123_Line();
                inside1_6_41.m_Coroutine = inside1_6_41.WaitSecond_0();
                StartCoroutine(inside1_6_41.m_Coroutine);
                Debug.Log("123번째 리셋하자");
            }

            if (Line_Index == 124)
            {
                questObject.Go_124_Line();
                inside1_6_41.m_Coroutine = inside1_6_41.WaitSecond_0();
                StartCoroutine(inside1_6_41.m_Coroutine);
                Debug.Log("124번째 리셋하자");
            }

            if (Line_Index == 125)
            {
                questObject.Go_125_Line();
                inside1_6_42.m_Coroutine = inside1_6_42.WaitSecond_0();
                StartCoroutine(inside1_6_42.m_Coroutine);
                Debug.Log("125번째 리셋하자");
            }

            if (Line_Index == 126)
            {
                questObject.Go_126_Line();
                inside1_6_42.m_Coroutine = inside1_6_42.WaitSecond_0();
                StartCoroutine(inside1_6_42.m_Coroutine);
                Debug.Log("126번째 리셋하자");
            }

            if (Line_Index == 127)
            {
                questObject.Go_127_Line();
                inside1_6_42.m_Coroutine = inside1_6_42.WaitSecond_0();
                StartCoroutine(inside1_6_42.m_Coroutine);
                Debug.Log("127번째 리셋하자");
            }

            if (Line_Index == 128)
            {
                questObject.Go_128_Line();
                inside1_6_42.m_Coroutine = inside1_6_42.WaitSecond_0();
                StartCoroutine(inside1_6_42.m_Coroutine);
                Debug.Log("128번째 리셋하자");
            }

            if (Line_Index == 129)
            {
                questObject.Go_129_Line();
                inside1_6_43.m_Coroutine = inside1_6_43.WaitSecond_0();
                StartCoroutine(inside1_6_43.m_Coroutine);
                Debug.Log("129번째 리셋하자");
            }

            if (Line_Index == 130)
            {
                questObject.Go_130_Line();
                inside1_6_43.m_Coroutine = inside1_6_43.WaitSecond_0();
                StartCoroutine(inside1_6_43.m_Coroutine);
                Debug.Log("130번째 리셋하자");
            }

            if (Line_Index == 131)
            {
                questObject.Go_131_Line();
                inside1_6_43.m_Coroutine = inside1_6_43.WaitSecond_0();
                StartCoroutine(inside1_6_43.m_Coroutine);
                Debug.Log("131번째 리셋하자");
            }

            if (Line_Index == 132)
            {
                questObject.Go_132_Line();
                inside1_6_43.m_Coroutine = inside1_6_43.WaitSecond_0();
                StartCoroutine(inside1_6_43.m_Coroutine);
                Debug.Log("132번째 리셋하자");
            }

            if (Line_Index == 133)
            {
                questObject.Go_133_Line();
                inside1_6_44.m_Coroutine = inside1_6_44.WaitSecond_0();
                StartCoroutine(inside1_6_44.m_Coroutine);
                Debug.Log("133번째 리셋하자");
            }

            if (Line_Index == 134)
            {
                questObject.Go_134_Line();
                inside1_6_44.m_Coroutine = inside1_6_44.WaitSecond_0();
                StartCoroutine(inside1_6_44.m_Coroutine);
                Debug.Log("134번째 리셋하자");
            }

            if (Line_Index == 135)
            {
                questObject.Go_135_Line();
                inside1_6_44.m_Coroutine = inside1_6_44.WaitSecond_0();
                StartCoroutine(inside1_6_44.m_Coroutine);
                Debug.Log("135번째 리셋하자");
            }

            if (Line_Index == 136)
            {
                questObject.Go_136_Line();
                inside1_6_44.m_Coroutine = inside1_6_44.WaitSecond_0();
                StartCoroutine(inside1_6_44.m_Coroutine);
                Debug.Log("136번째 리셋하자");
            }

            if (Line_Index == 140)
            {
                like_1_4_11.m_Coroutine = like_1_4_11.WaitSecond_0();
                StartCoroutine(like_1_4_11.m_Coroutine);
                Debug.Log("140번째 리셋하자");
            }

            if (Line_Index == 141)
            {
                questObject.True_Go_141();

                inside_141.m_Coroutine = inside_141.WaitSecond_0();
                StartCoroutine(inside_141.m_Coroutine);
                Debug.Log("141 리셋하자");
            }

            if (Line_Index == 142)
            {
                questObject.Lie_Go_142();

                inside_142.m_Coroutine = inside_142.WaitSecond_0();
                StartCoroutine(inside_142.m_Coroutine);
                Debug.Log("142 리셋하자");
            }

            if (Line_Index == 143)
            {
                questObject.Witch_Go_143();

                inside_143.m_Coroutine = inside_143.WaitSecond_0();
                StartCoroutine(inside_143.m_Coroutine);
                Debug.Log("143 리셋하자");
            }

            if (Line_Index == 144)
            {
                questObject.See_Go_144();

                inside_144.m_Coroutine = inside_144.WaitSecond_0();
                StartCoroutine(inside_144.m_Coroutine);
                Debug.Log("144 리셋하자");
            }

            if (Line_Index == 145)
            {
                questObject.Witch_Go_145();
                inside_145.m_Coroutine = inside_145.WaitSecond_0();
                StartCoroutine(inside_145.m_Coroutine);
                Debug.Log("145 리셋하자");
            }

            if (Line_Index == 146)
            {
                questObject.See_Go_146();

                inside_146.m_Coroutine = inside_146.WaitSecond_0();
                StartCoroutine(inside_146.m_Coroutine);
                Debug.Log("146 리셋하자");
            }

      
        

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
            FadeObject.fadeObject[12].gameObject.SetActive(false);
            FadeObject.fadeObject[13].gameObject.SetActive(false);
            FadeObject.fadeObject[14].gameObject.SetActive(false);


            //원래 요 2줄 이었음
            Setting.SetActive(false);
            

            Debug.Log(Time.timeScale);
;            SceneManager.LoadScene("Line");
            //Ticket_Count_Panel.SetActive(true);

        }

    }

}
