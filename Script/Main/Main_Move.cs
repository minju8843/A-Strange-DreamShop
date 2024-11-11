using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Main_Move : MonoBehaviour
{
    //public GameObject Main_Canvas;


    public Fast_2023 speed;
    //public GameObject Ticket_Count_Panel;

    public Save_Collection save;

    public GameObject Go_Black;
    //public GameObject Go_Empty;


    public AudioSource Main_BGM1;
    public AudioSource sfx1;

    public Fade_Collect FadeObject;
    public GameObject Line;

    public GameObject Setting_1;

    //여기 아랜 새로 추가한 거
    public Only_Line questObject;

    

    


    public R_Wait1 inside_0;
    public Sum_1_1_1 inside_1;
    public Sum_1_1_2 inside_2;

    public R_Wait1_2_1 inside_5;
    public R_Wait1_2_4 inside_8;
    public R_Wait1_3_1 inside_9;
    public R_Wait1_3_2 inside_13;
    public R_Wait1_3_5 inside_15;
    public R_Wait1_3_6 inside_11;

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

    public R_Wait1_6_1 inside_73;//1-6-1 안에 있는 거 저장 겸 리셋하려고 만듦
    public R_Wait_1_6_2 inside_77;//1-6-1 안에 있는 거 저장 겸 리셋하려고 만듦
    public R_Wait1_6_3 inside_81;
    public R_Wait1_6_4 inside_85;
    public R_Wait1_6_9 inside_89;
    public R_Wait1_6_30 inside_93;
    public R_Wait1_6_11 inside_97;
    public R_Wait1_6_12 inside_101;
    public R_Wait1_6_33 inside_105;
    public R_Wait1_6_34 inside_109;
    public R_Wait1_6_35 inside_113;
    public R_Wait1_6_36 inside_117;
    public R_Wait1_6_41 inside_121;
    public R_Wait_1_6_42 inside_125;
    public R_Wait1_6_43 inside_129;
    public R_Wait1_6_44 inside_133;

    public Like_1_4_11 like_1_4_11;
    public Line_141 inside_141;
    public Line_142 inside_142;
    public Line_143 inside_143;
    public Line_144 inside_144;
    public Line_145 inside_145;
    public Line_146 inside_146;

    public Fast_2023 Setting_fast;
    public SFX_2023 sfx_Manager;
    public Bgm_2023 bgm;


    public GameObject Main_Text;
    public GameObject Touch_Text;


    public GameObject Setting;

    void Start()
    {
        StartCoroutine(Wait_Zero());
        StartCoroutine(Wait_One());
        StartCoroutine(Wait_Two());

        /*if (SceneManager.GetActiveScene().name == "Main")
        {

            Time.timeScale = 1;


        }*/

        if (SceneManager.GetActiveScene().name == "Main")
        {

            Setting.SetActive(true);

        }

    }




    public IEnumerator Wait_Zero()
    {
        yield return new WaitForSeconds(0.0f);
        Main_Text.SetActive(false);
        Touch_Text.SetActive(false);


    }

    public IEnumerator Wait_One()
    {
        yield return new WaitForSeconds(1.0f);
        Main_Text.SetActive(true);


    }

    public IEnumerator Wait_Two()
    {
        yield return new WaitForSeconds(2.0f);
        Touch_Text.SetActive(true);

    }

    public void Go_Line()
    {
        StartCoroutine(WaitSecond_0());
        StartCoroutine(WaitSecond_1());

        IEnumerator WaitSecond_0()
        {
            yield return new WaitForSeconds(0.0f);
            Go_Black.SetActive(true);//없음->검정
            sfx1.Play();
        }

        IEnumerator WaitSecond_1()
        {
            //Time.timeScale = 1;
            //Go_Black.SetActive(true);//없음->검정
            //sfx1.Play();

            yield return new WaitForSeconds(0.6f);//원래 0.5였음

            //sfx1.Stop();
            Main_BGM1.Stop();

            //SceneManager.LoadScene("Line"); //이건 원래 있었음





            //Line.SetActive(true);//원래 있었음
            //Setting_1.SetActive(true);//원래 있었음


            //여기서 자동저장 한 거 가져올 예정

            //티켓은 가져올 수 없음

            

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
            int Auto_Circle_1= PlayerPrefs.GetInt("Time_Circle_1");
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

            //3번째 줄 리셋
            inside_1.Line_1_Index = 0;
            inside_1.inside_Line_1[0].gameObject.SetActive(false);
            inside_1.inside_Line_1[1].gameObject.SetActive(false);
            inside_1.inside_Line_1[2].gameObject.SetActive(false);
            inside_1.inside_Line_1[3].gameObject.SetActive(false);
            inside_1.inside_Line_1[4].gameObject.SetActive(false);
            inside_1.inside_Line_1[5].gameObject.SetActive(false);
            inside_1.inside_Line_1[6].gameObject.SetActive(false);
            inside_1.inside_Line_1[7].gameObject.SetActive(false);
            inside_1.inside_Line_1[8].gameObject.SetActive(false);
            inside_1.inside_Line_1[9].gameObject.SetActive(false);
            inside_1.inside_Line_1[10].gameObject.SetActive(false);
            inside_1.inside_Line_1[11].gameObject.SetActive(false);
            inside_1.inside_Line_1[12].gameObject.SetActive(false);

            //4번째 줄 리셋
            inside_2.Line_2_Index = 0;
            inside_2.inside_Line_2[0].gameObject.SetActive(false);
            inside_2.inside_Line_2[1].gameObject.SetActive(false);
            inside_2.inside_Line_2[2].gameObject.SetActive(false);
            inside_2.inside_Line_2[3].gameObject.SetActive(false);
            inside_2.inside_Line_2[4].gameObject.SetActive(false);
            inside_2.inside_Line_2[5].gameObject.SetActive(false);
            inside_2.inside_Line_2[6].gameObject.SetActive(false);
            inside_2.inside_Line_2[7].gameObject.SetActive(false);
            inside_2.inside_Line_2[8].gameObject.SetActive(false);
            inside_2.inside_Line_2[9].gameObject.SetActive(false);
            inside_2.inside_Line_2[10].gameObject.SetActive(false);
            inside_2.inside_Line_2[11].gameObject.SetActive(false);
            inside_2.inside_Line_2[12].gameObject.SetActive(false);

            //5번째 줄 리셋
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



            //8번째 줄 리셋
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

            //1-3-1
            inside_9.Line_9_Index = 0;
            inside_9.inside_Line_9[0].gameObject.SetActive(false);
            inside_9.inside_Line_9[1].gameObject.SetActive(false);
            inside_9.inside_Line_9[2].gameObject.SetActive(false);
            inside_9.inside_Line_9[3].gameObject.SetActive(false);
            inside_9.inside_Line_9[4].gameObject.SetActive(false);
            inside_9.inside_Line_9[5].gameObject.SetActive(false);
            inside_9.inside_Line_9[6].gameObject.SetActive(false);
            inside_9.inside_Line_9[7].gameObject.SetActive(false);
            inside_9.inside_Line_9[8].gameObject.SetActive(false);
            inside_9.inside_Line_9[9].gameObject.SetActive(false);
            inside_9.inside_Line_9[10].gameObject.SetActive(false);
            inside_9.inside_Line_9[11].gameObject.SetActive(false);
            inside_9.inside_Line_9[12].gameObject.SetActive(false);
            inside_9.inside_Line_9[13].gameObject.SetActive(false);
            inside_9.inside_Line_9[14].gameObject.SetActive(false);
            inside_9.inside_Line_9[15].gameObject.SetActive(false);
            inside_9.inside_Line_9[16].gameObject.SetActive(false);
            inside_9.inside_Line_9[17].gameObject.SetActive(false);
            inside_9.inside_Line_9[18].gameObject.SetActive(false);
            inside_9.inside_Line_9[19].gameObject.SetActive(false);
            inside_9.inside_Line_9[20].gameObject.SetActive(false);
            inside_9.inside_Line_9[21].gameObject.SetActive(false);
            inside_9.inside_Line_9[22].gameObject.SetActive(false);
            inside_9.inside_Line_9[23].gameObject.SetActive(false);
            inside_9.inside_Line_9[24].gameObject.SetActive(false);
            inside_9.inside_Line_9[25].gameObject.SetActive(false);
            inside_9.inside_Line_9[26].gameObject.SetActive(false);
            inside_9.inside_Line_9[27].gameObject.SetActive(false);
            inside_9.inside_Line_9[28].gameObject.SetActive(false);

            //1-3-2
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

            //1-3-5
            inside_15.Line_15_Index = 0;
            inside_15.inside_Line_15[0].gameObject.SetActive(false);
            inside_15.inside_Line_15[1].gameObject.SetActive(false);
            inside_15.inside_Line_15[2].gameObject.SetActive(false);
            inside_15.inside_Line_15[3].gameObject.SetActive(false);
            inside_15.inside_Line_15[4].gameObject.SetActive(false);
            inside_15.inside_Line_15[5].gameObject.SetActive(false);
            inside_15.inside_Line_15[6].gameObject.SetActive(false);
            inside_15.inside_Line_15[7].gameObject.SetActive(false);
            inside_15.inside_Line_15[8].gameObject.SetActive(false);
            inside_15.inside_Line_15[9].gameObject.SetActive(false);
            inside_15.inside_Line_15[10].gameObject.SetActive(false);
            inside_15.inside_Line_15[11].gameObject.SetActive(false);
            inside_15.inside_Line_15[12].gameObject.SetActive(false);
            inside_15.inside_Line_15[13].gameObject.SetActive(false);
            inside_15.inside_Line_15[14].gameObject.SetActive(false);
            inside_15.inside_Line_15[15].gameObject.SetActive(false);
            inside_15.inside_Line_15[16].gameObject.SetActive(false);
            inside_15.inside_Line_15[17].gameObject.SetActive(false);
            inside_15.inside_Line_15[18].gameObject.SetActive(false);
            inside_15.inside_Line_15[19].gameObject.SetActive(false);
            inside_15.inside_Line_15[20].gameObject.SetActive(false);
            inside_15.inside_Line_15[21].gameObject.SetActive(false);
            inside_15.inside_Line_15[22].gameObject.SetActive(false);

            //1-3-6
            inside_11.Line_11_Index = 0;
            inside_11.inside_Line_11[0].gameObject.SetActive(false);
            inside_11.inside_Line_11[1].gameObject.SetActive(false);
            inside_11.inside_Line_11[2].gameObject.SetActive(false);
            inside_11.inside_Line_11[3].gameObject.SetActive(false);
            inside_11.inside_Line_11[4].gameObject.SetActive(false);
            inside_11.inside_Line_11[5].gameObject.SetActive(false);
            inside_11.inside_Line_11[6].gameObject.SetActive(false);
            inside_11.inside_Line_11[7].gameObject.SetActive(false);
            inside_11.inside_Line_11[8].gameObject.SetActive(false);
            inside_11.inside_Line_11[9].gameObject.SetActive(false);
            inside_11.inside_Line_11[10].gameObject.SetActive(false);
            inside_11.inside_Line_11[11].gameObject.SetActive(false);
            inside_11.inside_Line_11[12].gameObject.SetActive(false);
            inside_11.inside_Line_11[13].gameObject.SetActive(false);
            inside_11.inside_Line_11[14].gameObject.SetActive(false);
            inside_11.inside_Line_11[15].gameObject.SetActive(false);
            inside_11.inside_Line_11[16].gameObject.SetActive(false);
            inside_11.inside_Line_11[17].gameObject.SetActive(false);
            inside_11.inside_Line_11[18].gameObject.SetActive(false);
            inside_11.inside_Line_11[19].gameObject.SetActive(false);
            inside_11.inside_Line_11[20].gameObject.SetActive(false);
            inside_11.inside_Line_11[21].gameObject.SetActive(false);
            inside_11.inside_Line_11[22].gameObject.SetActive(false);
            inside_11.inside_Line_11[23].gameObject.SetActive(false);
            inside_11.inside_Line_11[24].gameObject.SetActive(false);
            inside_11.inside_Line_11[25].gameObject.SetActive(false);
            inside_11.inside_Line_11[26].gameObject.SetActive(false);
            inside_11.inside_Line_11[27].gameObject.SetActive(false);
            inside_11.inside_Line_11[28].gameObject.SetActive(false);

            //N_1-3-1
            inside_17.Line_17_Index = 0;
            inside_17.inside_Line_17[0].gameObject.SetActive(false);
            inside_17.inside_Line_17[1].gameObject.SetActive(false);
            inside_17.inside_Line_17[2].gameObject.SetActive(false);
            inside_17.inside_Line_17[3].gameObject.SetActive(false);
            inside_17.inside_Line_17[4].gameObject.SetActive(false);
            inside_17.inside_Line_17[5].gameObject.SetActive(false);
            inside_17.inside_Line_17[6].gameObject.SetActive(false);
            inside_17.inside_Line_17[7].gameObject.SetActive(false);
            inside_17.inside_Line_17[8].gameObject.SetActive(false);
            inside_17.inside_Line_17[9].gameObject.SetActive(false);
            inside_17.inside_Line_17[10].gameObject.SetActive(false);
            inside_17.inside_Line_17[11].gameObject.SetActive(false);
            inside_17.inside_Line_17[12].gameObject.SetActive(false);
            inside_17.inside_Line_17[13].gameObject.SetActive(false);
            inside_17.inside_Line_17[14].gameObject.SetActive(false);
            inside_17.inside_Line_17[15].gameObject.SetActive(false);
            inside_17.inside_Line_17[16].gameObject.SetActive(false);
            inside_17.inside_Line_17[17].gameObject.SetActive(false);
            inside_17.inside_Line_17[18].gameObject.SetActive(false);
            inside_17.inside_Line_17[19].gameObject.SetActive(false);

            //N_1-3-2
            inside_21.Line_21_Index = 0;
            inside_21.inside_Line_21[0].gameObject.SetActive(false);
            inside_21.inside_Line_21[1].gameObject.SetActive(false);
            inside_21.inside_Line_21[2].gameObject.SetActive(false);
            inside_21.inside_Line_21[3].gameObject.SetActive(false);
            inside_21.inside_Line_21[4].gameObject.SetActive(false);
            inside_21.inside_Line_21[5].gameObject.SetActive(false);
            inside_21.inside_Line_21[6].gameObject.SetActive(false);
            inside_21.inside_Line_21[7].gameObject.SetActive(false);
            inside_21.inside_Line_21[8].gameObject.SetActive(false);
            inside_21.inside_Line_21[9].gameObject.SetActive(false);
            inside_21.inside_Line_21[10].gameObject.SetActive(false);
            inside_21.inside_Line_21[11].gameObject.SetActive(false);
            inside_21.inside_Line_21[12].gameObject.SetActive(false);
            inside_21.inside_Line_21[13].gameObject.SetActive(false);
            inside_21.inside_Line_21[14].gameObject.SetActive(false);
            inside_21.inside_Line_21[15].gameObject.SetActive(false);
            inside_21.inside_Line_21[16].gameObject.SetActive(false);
            inside_21.inside_Line_21[17].gameObject.SetActive(false);

            //N_1-3-5
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

            //N_1-3-6
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

            //1-4-1
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

            //1-4-3
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

            //1-4-9
            inside_34.Line_34_Index = 0;
            inside_34.inside_Line_34[0].gameObject.SetActive(false);
            inside_34.inside_Line_34[1].gameObject.SetActive(false);
            inside_34.inside_Line_34[2].gameObject.SetActive(false);
            inside_34.inside_Line_34[3].gameObject.SetActive(false);
            inside_34.inside_Line_34[4].gameObject.SetActive(false);
            inside_34.inside_Line_34[5].gameObject.SetActive(false);
            inside_34.inside_Line_34[6].gameObject.SetActive(false);
            inside_34.inside_Line_34[7].gameObject.SetActive(false);
            inside_34.inside_Line_34[8].gameObject.SetActive(false);
            inside_34.inside_Line_34[9].gameObject.SetActive(false);
            inside_34.inside_Line_34[10].gameObject.SetActive(false);
            inside_34.inside_Line_34[11].gameObject.SetActive(false);
            inside_34.inside_Line_34[12].gameObject.SetActive(false);
            inside_34.inside_Line_34[13].gameObject.SetActive(false);
            inside_34.inside_Line_34[14].gameObject.SetActive(false);
            inside_34.inside_Line_34[15].gameObject.SetActive(false);
            inside_34.inside_Line_34[16].gameObject.SetActive(false);
            inside_34.inside_Line_34[17].gameObject.SetActive(false);
            inside_34.inside_Line_34[18].gameObject.SetActive(false);
            inside_34.inside_Line_34[19].gameObject.SetActive(false);
            inside_34.inside_Line_34[20].gameObject.SetActive(false);
            inside_34.inside_Line_34[21].gameObject.SetActive(false);
            inside_34.inside_Line_34[22].gameObject.SetActive(false);
            inside_34.inside_Line_34[23].gameObject.SetActive(false);
            inside_34.inside_Line_34[24].gameObject.SetActive(false);
            inside_34.inside_Line_34[25].gameObject.SetActive(false);
            inside_34.inside_Line_34[26].gameObject.SetActive(false);
            inside_34.inside_Line_34[27].gameObject.SetActive(false);
            inside_34.inside_Line_34[28].gameObject.SetActive(false);
            inside_34.inside_Line_34[29].gameObject.SetActive(false);
            inside_34.inside_Line_34[30].gameObject.SetActive(false);
            inside_34.inside_Line_34[31].gameObject.SetActive(false);
            inside_34.inside_Line_34[32].gameObject.SetActive(false);
            inside_34.inside_Line_34[33].gameObject.SetActive(false);
            inside_34.inside_Line_34[34].gameObject.SetActive(false);
            inside_34.inside_Line_34[35].gameObject.SetActive(false);
            inside_34.inside_Line_34[36].gameObject.SetActive(false);
            inside_34.inside_Line_34[37].gameObject.SetActive(false);
            inside_34.inside_Line_34[38].gameObject.SetActive(false);
            inside_34.inside_Line_34[39].gameObject.SetActive(false);
            inside_34.inside_Line_34[40].gameObject.SetActive(false);
            inside_34.inside_Line_34[41].gameObject.SetActive(false);
            inside_34.inside_Line_34[42].gameObject.SetActive(false);
            inside_34.inside_Line_34[43].gameObject.SetActive(false);
            inside_34.inside_Line_34[44].gameObject.SetActive(false);
            inside_34.inside_Line_34[45].gameObject.SetActive(false);
            inside_34.inside_Line_34[46].gameObject.SetActive(false);
            inside_34.inside_Line_34[47].gameObject.SetActive(false);
            inside_34.inside_Line_34[48].gameObject.SetActive(false);
            inside_34.inside_Line_34[49].gameObject.SetActive(false);
            inside_34.inside_Line_34[50].gameObject.SetActive(false);
            inside_34.inside_Line_34[51].gameObject.SetActive(false);
            inside_34.inside_Line_34[52].gameObject.SetActive(false);
            inside_34.inside_Line_34[53].gameObject.SetActive(false);
            inside_34.inside_Line_34[54].gameObject.SetActive(false);
            inside_34.inside_Line_34[55].gameObject.SetActive(false);
            inside_34.inside_Line_34[56].gameObject.SetActive(false);
            inside_34.inside_Line_34[57].gameObject.SetActive(false);
            inside_34.inside_Line_34[58].gameObject.SetActive(false);
            inside_34.inside_Line_34[59].gameObject.SetActive(false);
            inside_34.inside_Line_34[60].gameObject.SetActive(false);
            inside_34.inside_Line_34[61].gameObject.SetActive(false);
            inside_34.inside_Line_34[62].gameObject.SetActive(false);
            inside_34.inside_Line_34[63].gameObject.SetActive(false);
            inside_34.inside_Line_34[64].gameObject.SetActive(false);
            inside_34.inside_Line_34[65].gameObject.SetActive(false);
            inside_34.inside_Line_34[66].gameObject.SetActive(false);
            inside_34.inside_Line_34[67].gameObject.SetActive(false);
            inside_34.inside_Line_34[68].gameObject.SetActive(false);
            inside_34.inside_Line_34[69].gameObject.SetActive(false);
            inside_34.inside_Line_34[70].gameObject.SetActive(false);

            //1-4-11
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

            //1-5-1
            inside_41.Line_41_Index = 0;
            inside_41.inside_Line_41[0].gameObject.SetActive(false);
            inside_41.inside_Line_41[1].gameObject.SetActive(false);
            inside_41.inside_Line_41[2].gameObject.SetActive(false);
            inside_41.inside_Line_41[3].gameObject.SetActive(false);
            inside_41.inside_Line_41[4].gameObject.SetActive(false);
            inside_41.inside_Line_41[5].gameObject.SetActive(false);
            inside_41.inside_Line_41[6].gameObject.SetActive(false);
            inside_41.inside_Line_41[7].gameObject.SetActive(false);
            inside_41.inside_Line_41[8].gameObject.SetActive(false);
            inside_41.inside_Line_41[9].gameObject.SetActive(false);
            inside_41.inside_Line_41[10].gameObject.SetActive(false);
            inside_41.inside_Line_41[11].gameObject.SetActive(false);
            inside_41.inside_Line_41[12].gameObject.SetActive(false);
            inside_41.inside_Line_41[13].gameObject.SetActive(false);
            inside_41.inside_Line_41[14].gameObject.SetActive(false);
            inside_41.inside_Line_41[15].gameObject.SetActive(false);
            inside_41.inside_Line_41[16].gameObject.SetActive(false);
            inside_41.inside_Line_41[17].gameObject.SetActive(false);
            inside_41.inside_Line_41[18].gameObject.SetActive(false);
            inside_41.inside_Line_41[19].gameObject.SetActive(false);
            inside_41.inside_Line_41[20].gameObject.SetActive(false);
            inside_41.inside_Line_41[21].gameObject.SetActive(false);
            inside_41.inside_Line_41[22].gameObject.SetActive(false);
            inside_41.inside_Line_41[23].gameObject.SetActive(false);
            inside_41.inside_Line_41[24].gameObject.SetActive(false);
            inside_41.inside_Line_41[25].gameObject.SetActive(false);
            inside_41.inside_Line_41[26].gameObject.SetActive(false);
            inside_41.inside_Line_41[27].gameObject.SetActive(false);
            inside_41.inside_Line_41[28].gameObject.SetActive(false);
            inside_41.inside_Line_41[29].gameObject.SetActive(false);
            inside_41.inside_Line_41[30].gameObject.SetActive(false);
            inside_41.inside_Line_41[31].gameObject.SetActive(false);
            inside_41.inside_Line_41[32].gameObject.SetActive(false);
            inside_41.inside_Line_41[33].gameObject.SetActive(false);
            inside_41.inside_Line_41[34].gameObject.SetActive(false);
            inside_41.inside_Line_41[35].gameObject.SetActive(false);
            inside_41.inside_Line_41[36].gameObject.SetActive(false);
            inside_41.inside_Line_41[37].gameObject.SetActive(false);
            inside_41.inside_Line_41[38].gameObject.SetActive(false);
            inside_41.inside_Line_41[39].gameObject.SetActive(false);
            inside_41.inside_Line_41[40].gameObject.SetActive(false);
            inside_41.inside_Line_41[41].gameObject.SetActive(false);
            inside_41.inside_Line_41[42].gameObject.SetActive(false);
            inside_41.inside_Line_41[43].gameObject.SetActive(false);
            inside_41.inside_Line_41[44].gameObject.SetActive(false);
            inside_41.inside_Line_41[45].gameObject.SetActive(false);
            inside_41.inside_Line_41[46].gameObject.SetActive(false);
            inside_41.inside_Line_41[47].gameObject.SetActive(false);
            inside_41.inside_Line_41[48].gameObject.SetActive(false);

            //1-5-2
            inside_57.Line_57_Index = 0;
            inside_57.inside_Line_57[0].gameObject.SetActive(false);
            inside_57.inside_Line_57[1].gameObject.SetActive(false);
            inside_57.inside_Line_57[2].gameObject.SetActive(false);
            inside_57.inside_Line_57[3].gameObject.SetActive(false);
            inside_57.inside_Line_57[4].gameObject.SetActive(false);
            inside_57.inside_Line_57[5].gameObject.SetActive(false);
            inside_57.inside_Line_57[6].gameObject.SetActive(false);
            inside_57.inside_Line_57[7].gameObject.SetActive(false);
            inside_57.inside_Line_57[8].gameObject.SetActive(false);
            inside_57.inside_Line_57[9].gameObject.SetActive(false);
            inside_57.inside_Line_57[10].gameObject.SetActive(false);
            inside_57.inside_Line_57[11].gameObject.SetActive(false);
            inside_57.inside_Line_57[12].gameObject.SetActive(false);
            inside_57.inside_Line_57[13].gameObject.SetActive(false);
            inside_57.inside_Line_57[14].gameObject.SetActive(false);
            inside_57.inside_Line_57[15].gameObject.SetActive(false);
            inside_57.inside_Line_57[16].gameObject.SetActive(false);
            inside_57.inside_Line_57[17].gameObject.SetActive(false);
            inside_57.inside_Line_57[18].gameObject.SetActive(false);
            inside_57.inside_Line_57[19].gameObject.SetActive(false);
            inside_57.inside_Line_57[20].gameObject.SetActive(false);
            inside_57.inside_Line_57[21].gameObject.SetActive(false);
            inside_57.inside_Line_57[22].gameObject.SetActive(false);
            inside_57.inside_Line_57[23].gameObject.SetActive(false);
            inside_57.inside_Line_57[24].gameObject.SetActive(false);
            inside_57.inside_Line_57[25].gameObject.SetActive(false);
            inside_57.inside_Line_57[26].gameObject.SetActive(false);
            inside_57.inside_Line_57[27].gameObject.SetActive(false);
            inside_57.inside_Line_57[28].gameObject.SetActive(false);
            inside_57.inside_Line_57[29].gameObject.SetActive(false);
            inside_57.inside_Line_57[30].gameObject.SetActive(false);
            inside_57.inside_Line_57[31].gameObject.SetActive(false);
            inside_57.inside_Line_57[32].gameObject.SetActive(false);
            inside_57.inside_Line_57[33].gameObject.SetActive(false);
            inside_57.inside_Line_57[34].gameObject.SetActive(false);
            inside_57.inside_Line_57[35].gameObject.SetActive(false);
            inside_57.inside_Line_57[36].gameObject.SetActive(false);
            inside_57.inside_Line_57[37].gameObject.SetActive(false);
            inside_57.inside_Line_57[38].gameObject.SetActive(false);
            inside_57.inside_Line_57[39].gameObject.SetActive(false);
            inside_57.inside_Line_57[40].gameObject.SetActive(false);
            inside_57.inside_Line_57[41].gameObject.SetActive(false);
            inside_57.inside_Line_57[42].gameObject.SetActive(false);
            inside_57.inside_Line_57[43].gameObject.SetActive(false);
            inside_57.inside_Line_57[44].gameObject.SetActive(false);
            inside_57.inside_Line_57[45].gameObject.SetActive(false);
            inside_57.inside_Line_57[46].gameObject.SetActive(false);
            inside_57.inside_Line_57[47].gameObject.SetActive(false);
            inside_57.inside_Line_57[48].gameObject.SetActive(false);
            inside_57.inside_Line_57[49].gameObject.SetActive(false);
            inside_57.inside_Line_57[50].gameObject.SetActive(false);
            inside_57.inside_Line_57[51].gameObject.SetActive(false);

            //1-5-5
            inside_45.Line_45_Index = 0;
            inside_45.inside_Line_45[0].gameObject.SetActive(false);
            inside_45.inside_Line_45[1].gameObject.SetActive(false);
            inside_45.inside_Line_45[2].gameObject.SetActive(false);
            inside_45.inside_Line_45[3].gameObject.SetActive(false);
            inside_45.inside_Line_45[4].gameObject.SetActive(false);
            inside_45.inside_Line_45[5].gameObject.SetActive(false);
            inside_45.inside_Line_45[6].gameObject.SetActive(false);
            inside_45.inside_Line_45[7].gameObject.SetActive(false);
            inside_45.inside_Line_45[8].gameObject.SetActive(false);
            inside_45.inside_Line_45[9].gameObject.SetActive(false);
            inside_45.inside_Line_45[10].gameObject.SetActive(false);
            inside_45.inside_Line_45[11].gameObject.SetActive(false);
            inside_45.inside_Line_45[12].gameObject.SetActive(false);
            inside_45.inside_Line_45[13].gameObject.SetActive(false);
            inside_45.inside_Line_45[14].gameObject.SetActive(false);
            inside_45.inside_Line_45[15].gameObject.SetActive(false);
            inside_45.inside_Line_45[16].gameObject.SetActive(false);
            inside_45.inside_Line_45[17].gameObject.SetActive(false);
            inside_45.inside_Line_45[18].gameObject.SetActive(false);
            inside_45.inside_Line_45[19].gameObject.SetActive(false);
            inside_45.inside_Line_45[20].gameObject.SetActive(false);
            inside_45.inside_Line_45[21].gameObject.SetActive(false);
            inside_45.inside_Line_45[22].gameObject.SetActive(false);
            inside_45.inside_Line_45[23].gameObject.SetActive(false);
            inside_45.inside_Line_45[24].gameObject.SetActive(false);
            inside_45.inside_Line_45[25].gameObject.SetActive(false);
            inside_45.inside_Line_45[26].gameObject.SetActive(false);
            inside_45.inside_Line_45[27].gameObject.SetActive(false);
            inside_45.inside_Line_45[28].gameObject.SetActive(false);
            inside_45.inside_Line_45[29].gameObject.SetActive(false);
            inside_45.inside_Line_45[30].gameObject.SetActive(false);
            inside_45.inside_Line_45[31].gameObject.SetActive(false);
            inside_45.inside_Line_45[32].gameObject.SetActive(false);
            inside_45.inside_Line_45[33].gameObject.SetActive(false);
            inside_45.inside_Line_45[34].gameObject.SetActive(false);
            inside_45.inside_Line_45[35].gameObject.SetActive(false);
            inside_45.inside_Line_45[36].gameObject.SetActive(false);
            inside_45.inside_Line_45[37].gameObject.SetActive(false);
            inside_45.inside_Line_45[38].gameObject.SetActive(false);
            inside_45.inside_Line_45[39].gameObject.SetActive(false);
            inside_45.inside_Line_45[40].gameObject.SetActive(false);
            inside_45.inside_Line_45[41].gameObject.SetActive(false);
            inside_45.inside_Line_45[42].gameObject.SetActive(false);
            inside_45.inside_Line_45[43].gameObject.SetActive(false);
            inside_45.inside_Line_45[44].gameObject.SetActive(false);
            inside_45.inside_Line_45[45].gameObject.SetActive(false);
            inside_45.inside_Line_45[46].gameObject.SetActive(false);
            inside_45.inside_Line_45[47].gameObject.SetActive(false);
            inside_45.inside_Line_45[48].gameObject.SetActive(false);


            //1-5-6
            inside_61.Line_61_Index = 0;
            inside_61.inside_Line_61[0].gameObject.SetActive(false);
            inside_61.inside_Line_61[1].gameObject.SetActive(false);
            inside_61.inside_Line_61[2].gameObject.SetActive(false);
            inside_61.inside_Line_61[3].gameObject.SetActive(false);
            inside_61.inside_Line_61[4].gameObject.SetActive(false);
            inside_61.inside_Line_61[5].gameObject.SetActive(false);
            inside_61.inside_Line_61[6].gameObject.SetActive(false);
            inside_61.inside_Line_61[7].gameObject.SetActive(false);
            inside_61.inside_Line_61[8].gameObject.SetActive(false);
            inside_61.inside_Line_61[9].gameObject.SetActive(false);
            inside_61.inside_Line_61[10].gameObject.SetActive(false);
            inside_61.inside_Line_61[11].gameObject.SetActive(false);
            inside_61.inside_Line_61[12].gameObject.SetActive(false);
            inside_61.inside_Line_61[13].gameObject.SetActive(false);
            inside_61.inside_Line_61[14].gameObject.SetActive(false);
            inside_61.inside_Line_61[15].gameObject.SetActive(false);
            inside_61.inside_Line_61[16].gameObject.SetActive(false);
            inside_61.inside_Line_61[17].gameObject.SetActive(false);
            inside_61.inside_Line_61[18].gameObject.SetActive(false);
            inside_61.inside_Line_61[19].gameObject.SetActive(false);
            inside_61.inside_Line_61[20].gameObject.SetActive(false);
            inside_61.inside_Line_61[21].gameObject.SetActive(false);
            inside_61.inside_Line_61[22].gameObject.SetActive(false);
            inside_61.inside_Line_61[23].gameObject.SetActive(false);
            inside_61.inside_Line_61[24].gameObject.SetActive(false);
            inside_61.inside_Line_61[25].gameObject.SetActive(false);
            inside_61.inside_Line_61[26].gameObject.SetActive(false);
            inside_61.inside_Line_61[27].gameObject.SetActive(false);
            inside_61.inside_Line_61[28].gameObject.SetActive(false);
            inside_61.inside_Line_61[29].gameObject.SetActive(false);
            inside_61.inside_Line_61[30].gameObject.SetActive(false);
            inside_61.inside_Line_61[31].gameObject.SetActive(false);
            inside_61.inside_Line_61[32].gameObject.SetActive(false);
            inside_61.inside_Line_61[33].gameObject.SetActive(false);
            inside_61.inside_Line_61[34].gameObject.SetActive(false);
            inside_61.inside_Line_61[35].gameObject.SetActive(false);
            inside_61.inside_Line_61[36].gameObject.SetActive(false);
            inside_61.inside_Line_61[37].gameObject.SetActive(false);
            inside_61.inside_Line_61[38].gameObject.SetActive(false);
            inside_61.inside_Line_61[39].gameObject.SetActive(false);
            inside_61.inside_Line_61[40].gameObject.SetActive(false);
            inside_61.inside_Line_61[41].gameObject.SetActive(false);
            inside_61.inside_Line_61[42].gameObject.SetActive(false);
            inside_61.inside_Line_61[43].gameObject.SetActive(false);
            inside_61.inside_Line_61[44].gameObject.SetActive(false);
            inside_61.inside_Line_61[45].gameObject.SetActive(false);
            inside_61.inside_Line_61[46].gameObject.SetActive(false);
            inside_61.inside_Line_61[47].gameObject.SetActive(false);
            inside_61.inside_Line_61[48].gameObject.SetActive(false);
            inside_61.inside_Line_61[49].gameObject.SetActive(false);
            inside_61.inside_Line_61[50].gameObject.SetActive(false);
            inside_61.inside_Line_61[51].gameObject.SetActive(false);

            //1-5-17
            inside_49.Line_49_Index = 0;
            inside_49.inside_Line_49[0].gameObject.SetActive(false);
            inside_49.inside_Line_49[1].gameObject.SetActive(false);
            inside_49.inside_Line_49[2].gameObject.SetActive(false);
            inside_49.inside_Line_49[3].gameObject.SetActive(false);
            inside_49.inside_Line_49[4].gameObject.SetActive(false);
            inside_49.inside_Line_49[5].gameObject.SetActive(false);
            inside_49.inside_Line_49[6].gameObject.SetActive(false);
            inside_49.inside_Line_49[7].gameObject.SetActive(false);
            inside_49.inside_Line_49[8].gameObject.SetActive(false);
            inside_49.inside_Line_49[9].gameObject.SetActive(false);
            inside_49.inside_Line_49[10].gameObject.SetActive(false);
            inside_49.inside_Line_49[11].gameObject.SetActive(false);
            inside_49.inside_Line_49[12].gameObject.SetActive(false);
            inside_49.inside_Line_49[13].gameObject.SetActive(false);
            inside_49.inside_Line_49[14].gameObject.SetActive(false);
            inside_49.inside_Line_49[15].gameObject.SetActive(false);
            inside_49.inside_Line_49[16].gameObject.SetActive(false);
            inside_49.inside_Line_49[17].gameObject.SetActive(false);
            inside_49.inside_Line_49[18].gameObject.SetActive(false);
            inside_49.inside_Line_49[19].gameObject.SetActive(false);
            inside_49.inside_Line_49[20].gameObject.SetActive(false);
            inside_49.inside_Line_49[21].gameObject.SetActive(false);
            inside_49.inside_Line_49[22].gameObject.SetActive(false);
            inside_49.inside_Line_49[23].gameObject.SetActive(false);
            inside_49.inside_Line_49[24].gameObject.SetActive(false);
            inside_49.inside_Line_49[25].gameObject.SetActive(false);
            inside_49.inside_Line_49[26].gameObject.SetActive(false);
            inside_49.inside_Line_49[27].gameObject.SetActive(false);
            inside_49.inside_Line_49[28].gameObject.SetActive(false);
            inside_49.inside_Line_49[29].gameObject.SetActive(false);
            inside_49.inside_Line_49[30].gameObject.SetActive(false);
            inside_49.inside_Line_49[31].gameObject.SetActive(false);
            inside_49.inside_Line_49[32].gameObject.SetActive(false);
            inside_49.inside_Line_49[33].gameObject.SetActive(false);
            inside_49.inside_Line_49[34].gameObject.SetActive(false);
            inside_49.inside_Line_49[35].gameObject.SetActive(false);
            inside_49.inside_Line_49[36].gameObject.SetActive(false);
            inside_49.inside_Line_49[37].gameObject.SetActive(false);
            inside_49.inside_Line_49[38].gameObject.SetActive(false);
            inside_49.inside_Line_49[39].gameObject.SetActive(false);
            inside_49.inside_Line_49[40].gameObject.SetActive(false);
            inside_49.inside_Line_49[41].gameObject.SetActive(false);
            inside_49.inside_Line_49[42].gameObject.SetActive(false);
            inside_49.inside_Line_49[43].gameObject.SetActive(false);
            inside_49.inside_Line_49[44].gameObject.SetActive(false);
            inside_49.inside_Line_49[45].gameObject.SetActive(false);
            inside_49.inside_Line_49[46].gameObject.SetActive(false);
            inside_49.inside_Line_49[47].gameObject.SetActive(false);
            inside_49.inside_Line_49[48].gameObject.SetActive(false);

            //1-5-18
            inside_65.Line_65_Index = 0;
            inside_65.inside_Line_65[0].gameObject.SetActive(false);
            inside_65.inside_Line_65[1].gameObject.SetActive(false);
            inside_65.inside_Line_65[2].gameObject.SetActive(false);
            inside_65.inside_Line_65[3].gameObject.SetActive(false);
            inside_65.inside_Line_65[4].gameObject.SetActive(false);
            inside_65.inside_Line_65[5].gameObject.SetActive(false);
            inside_65.inside_Line_65[6].gameObject.SetActive(false);
            inside_65.inside_Line_65[7].gameObject.SetActive(false);
            inside_65.inside_Line_65[8].gameObject.SetActive(false);
            inside_65.inside_Line_65[9].gameObject.SetActive(false);
            inside_65.inside_Line_65[10].gameObject.SetActive(false);
            inside_65.inside_Line_65[11].gameObject.SetActive(false);
            inside_65.inside_Line_65[12].gameObject.SetActive(false);
            inside_65.inside_Line_65[13].gameObject.SetActive(false);
            inside_65.inside_Line_65[14].gameObject.SetActive(false);
            inside_65.inside_Line_65[15].gameObject.SetActive(false);
            inside_65.inside_Line_65[16].gameObject.SetActive(false);
            inside_65.inside_Line_65[17].gameObject.SetActive(false);
            inside_65.inside_Line_65[18].gameObject.SetActive(false);
            inside_65.inside_Line_65[19].gameObject.SetActive(false);
            inside_65.inside_Line_65[20].gameObject.SetActive(false);
            inside_65.inside_Line_65[21].gameObject.SetActive(false);
            inside_65.inside_Line_65[22].gameObject.SetActive(false);
            inside_65.inside_Line_65[23].gameObject.SetActive(false);
            inside_65.inside_Line_65[24].gameObject.SetActive(false);
            inside_65.inside_Line_65[25].gameObject.SetActive(false);
            inside_65.inside_Line_65[26].gameObject.SetActive(false);
            inside_65.inside_Line_65[27].gameObject.SetActive(false);
            inside_65.inside_Line_65[28].gameObject.SetActive(false);
            inside_65.inside_Line_65[29].gameObject.SetActive(false);
            inside_65.inside_Line_65[30].gameObject.SetActive(false);
            inside_65.inside_Line_65[31].gameObject.SetActive(false);
            inside_65.inside_Line_65[32].gameObject.SetActive(false);
            inside_65.inside_Line_65[33].gameObject.SetActive(false);
            inside_65.inside_Line_65[34].gameObject.SetActive(false);
            inside_65.inside_Line_65[35].gameObject.SetActive(false);
            inside_65.inside_Line_65[36].gameObject.SetActive(false);
            inside_65.inside_Line_65[37].gameObject.SetActive(false);
            inside_65.inside_Line_65[38].gameObject.SetActive(false);
            inside_65.inside_Line_65[39].gameObject.SetActive(false);
            inside_65.inside_Line_65[40].gameObject.SetActive(false);
            inside_65.inside_Line_65[41].gameObject.SetActive(false);
            inside_65.inside_Line_65[42].gameObject.SetActive(false);
            inside_65.inside_Line_65[43].gameObject.SetActive(false);
            inside_65.inside_Line_65[44].gameObject.SetActive(false);
            inside_65.inside_Line_65[45].gameObject.SetActive(false);
            inside_65.inside_Line_65[46].gameObject.SetActive(false);
            inside_65.inside_Line_65[47].gameObject.SetActive(false);
            inside_65.inside_Line_65[48].gameObject.SetActive(false);
            inside_65.inside_Line_65[49].gameObject.SetActive(false);
            inside_65.inside_Line_65[50].gameObject.SetActive(false);
            inside_65.inside_Line_65[51].gameObject.SetActive(false);

            //1-5-21
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

            //1-5-22
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

            //1-6-1
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

            //1-6-2
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

            //1-6-3
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

            //1-6-4
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

            //1-6-9
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

            //1-6-30
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

            //1-6-11
            inside_97.Line_1_6_11_Index = 0;
            inside_97.inside_1_6_11[0].gameObject.SetActive(false);
            inside_97.inside_1_6_11[1].gameObject.SetActive(false);
            inside_97.inside_1_6_11[2].gameObject.SetActive(false);
            inside_97.inside_1_6_11[3].gameObject.SetActive(false);
            inside_97.inside_1_6_11[4].gameObject.SetActive(false);
            inside_97.inside_1_6_11[5].gameObject.SetActive(false);
            inside_97.inside_1_6_11[6].gameObject.SetActive(false);
            inside_97.inside_1_6_11[7].gameObject.SetActive(false);
            inside_97.inside_1_6_11[8].gameObject.SetActive(false);
            inside_97.inside_1_6_11[9].gameObject.SetActive(false);
            inside_97.inside_1_6_11[10].gameObject.SetActive(false);
            inside_97.inside_1_6_11[11].gameObject.SetActive(false);
            inside_97.inside_1_6_11[12].gameObject.SetActive(false);
            inside_97.inside_1_6_11[13].gameObject.SetActive(false);
            inside_97.inside_1_6_11[14].gameObject.SetActive(false);
            inside_97.inside_1_6_11[15].gameObject.SetActive(false);
            inside_97.inside_1_6_11[16].gameObject.SetActive(false);
            inside_97.inside_1_6_11[17].gameObject.SetActive(false);
            inside_97.inside_1_6_11[18].gameObject.SetActive(false);
            inside_97.inside_1_6_11[19].gameObject.SetActive(false);
            inside_97.inside_1_6_11[20].gameObject.SetActive(false);
            inside_97.inside_1_6_11[21].gameObject.SetActive(false);
            inside_97.inside_1_6_11[22].gameObject.SetActive(false);
            inside_97.inside_1_6_11[23].gameObject.SetActive(false);
            inside_97.inside_1_6_11[24].gameObject.SetActive(false);
            inside_97.inside_1_6_11[25].gameObject.SetActive(false);
            inside_97.inside_1_6_11[26].gameObject.SetActive(false);
            inside_97.inside_1_6_11[27].gameObject.SetActive(false);
            inside_97.inside_1_6_11[28].gameObject.SetActive(false);
            inside_97.inside_1_6_11[29].gameObject.SetActive(false);
            inside_97.inside_1_6_11[30].gameObject.SetActive(false);
            inside_97.inside_1_6_11[31].gameObject.SetActive(false);
            inside_97.inside_1_6_11[32].gameObject.SetActive(false);
            inside_97.inside_1_6_11[33].gameObject.SetActive(false);
            inside_97.inside_1_6_11[34].gameObject.SetActive(false);
            inside_97.inside_1_6_11[35].gameObject.SetActive(false);
            inside_97.inside_1_6_11[36].gameObject.SetActive(false);
            inside_97.inside_1_6_11[37].gameObject.SetActive(false);
            inside_97.inside_1_6_11[38].gameObject.SetActive(false);
            inside_97.inside_1_6_11[39].gameObject.SetActive(false);
            inside_97.inside_1_6_11[40].gameObject.SetActive(false);
            inside_97.inside_1_6_11[41].gameObject.SetActive(false);
            inside_97.inside_1_6_11[42].gameObject.SetActive(false);
            inside_97.inside_1_6_11[43].gameObject.SetActive(false);
            inside_97.inside_1_6_11[44].gameObject.SetActive(false);
            inside_97.inside_1_6_11[45].gameObject.SetActive(false);
            inside_97.inside_1_6_11[46].gameObject.SetActive(false);
            inside_97.inside_1_6_11[47].gameObject.SetActive(false);
            inside_97.inside_1_6_11[48].gameObject.SetActive(false);
            inside_97.inside_1_6_11[49].gameObject.SetActive(false);
            inside_97.inside_1_6_11[50].gameObject.SetActive(false);
            inside_97.inside_1_6_11[51].gameObject.SetActive(false);
            inside_97.inside_1_6_11[52].gameObject.SetActive(false);
            inside_97.inside_1_6_11[53].gameObject.SetActive(false);
            inside_97.inside_1_6_11[54].gameObject.SetActive(false);
            inside_97.inside_1_6_11[55].gameObject.SetActive(false);
            inside_97.inside_1_6_11[56].gameObject.SetActive(false);
            inside_97.inside_1_6_11[57].gameObject.SetActive(false);
            inside_97.inside_1_6_11[58].gameObject.SetActive(false);
            inside_97.inside_1_6_11[59].gameObject.SetActive(false);
            inside_97.inside_1_6_11[60].gameObject.SetActive(false);
            inside_97.inside_1_6_11[61].gameObject.SetActive(false);
            inside_97.inside_1_6_11[62].gameObject.SetActive(false);
            inside_97.inside_1_6_11[63].gameObject.SetActive(false);
            inside_97.inside_1_6_11[64].gameObject.SetActive(false);
            inside_97.inside_1_6_11[65].gameObject.SetActive(false);
            inside_97.inside_1_6_11[66].gameObject.SetActive(false);
            inside_97.inside_1_6_11[67].gameObject.SetActive(false);

            //1-6-12
            inside_101.Line_1_6_12_Index = 0;

            inside_101.inside_1_6_12[0].gameObject.SetActive(false);
            inside_101.inside_1_6_12[1].gameObject.SetActive(false);
            inside_101.inside_1_6_12[2].gameObject.SetActive(false);
            inside_101.inside_1_6_12[3].gameObject.SetActive(false);
            inside_101.inside_1_6_12[4].gameObject.SetActive(false);
            inside_101.inside_1_6_12[5].gameObject.SetActive(false);
            inside_101.inside_1_6_12[6].gameObject.SetActive(false);
            inside_101.inside_1_6_12[7].gameObject.SetActive(false);
            inside_101.inside_1_6_12[8].gameObject.SetActive(false);
            inside_101.inside_1_6_12[9].gameObject.SetActive(false);
            inside_101.inside_1_6_12[10].gameObject.SetActive(false);
            inside_101.inside_1_6_12[11].gameObject.SetActive(false);
            inside_101.inside_1_6_12[12].gameObject.SetActive(false);
            inside_101.inside_1_6_12[13].gameObject.SetActive(false);
            inside_101.inside_1_6_12[14].gameObject.SetActive(false);
            inside_101.inside_1_6_12[15].gameObject.SetActive(false);
            inside_101.inside_1_6_12[16].gameObject.SetActive(false);
            inside_101.inside_1_6_12[17].gameObject.SetActive(false);
            inside_101.inside_1_6_12[18].gameObject.SetActive(false);
            inside_101.inside_1_6_12[19].gameObject.SetActive(false);
            inside_101.inside_1_6_12[20].gameObject.SetActive(false);
            inside_101.inside_1_6_12[21].gameObject.SetActive(false);
            inside_101.inside_1_6_12[22].gameObject.SetActive(false);
            inside_101.inside_1_6_12[23].gameObject.SetActive(false);
            inside_101.inside_1_6_12[24].gameObject.SetActive(false);
            inside_101.inside_1_6_12[25].gameObject.SetActive(false);
            inside_101.inside_1_6_12[26].gameObject.SetActive(false);
            inside_101.inside_1_6_12[27].gameObject.SetActive(false);
            inside_101.inside_1_6_12[28].gameObject.SetActive(false);
            inside_101.inside_1_6_12[29].gameObject.SetActive(false);
            inside_101.inside_1_6_12[30].gameObject.SetActive(false);
            inside_101.inside_1_6_12[31].gameObject.SetActive(false);
            inside_101.inside_1_6_12[32].gameObject.SetActive(false);
            inside_101.inside_1_6_12[33].gameObject.SetActive(false);
            inside_101.inside_1_6_12[34].gameObject.SetActive(false);
            inside_101.inside_1_6_12[35].gameObject.SetActive(false);
            inside_101.inside_1_6_12[36].gameObject.SetActive(false);
            inside_101.inside_1_6_12[37].gameObject.SetActive(false);
            inside_101.inside_1_6_12[38].gameObject.SetActive(false);
            inside_101.inside_1_6_12[39].gameObject.SetActive(false);
            inside_101.inside_1_6_12[40].gameObject.SetActive(false);
            inside_101.inside_1_6_12[41].gameObject.SetActive(false);
            inside_101.inside_1_6_12[42].gameObject.SetActive(false);
            inside_101.inside_1_6_12[43].gameObject.SetActive(false);
            inside_101.inside_1_6_12[44].gameObject.SetActive(false);
            inside_101.inside_1_6_12[45].gameObject.SetActive(false);
            inside_101.inside_1_6_12[46].gameObject.SetActive(false);
            inside_101.inside_1_6_12[47].gameObject.SetActive(false);
            inside_101.inside_1_6_12[48].gameObject.SetActive(false);
            inside_101.inside_1_6_12[49].gameObject.SetActive(false);
            inside_101.inside_1_6_12[50].gameObject.SetActive(false);
            inside_101.inside_1_6_12[51].gameObject.SetActive(false);
            inside_101.inside_1_6_12[52].gameObject.SetActive(false);
            inside_101.inside_1_6_12[53].gameObject.SetActive(false);
            inside_101.inside_1_6_12[54].gameObject.SetActive(false);
            inside_101.inside_1_6_12[55].gameObject.SetActive(false);
            inside_101.inside_1_6_12[56].gameObject.SetActive(false);
            inside_101.inside_1_6_12[57].gameObject.SetActive(false);
            inside_101.inside_1_6_12[58].gameObject.SetActive(false);
            inside_101.inside_1_6_12[59].gameObject.SetActive(false);
            inside_101.inside_1_6_12[60].gameObject.SetActive(false);
            inside_101.inside_1_6_12[61].gameObject.SetActive(false);
            inside_101.inside_1_6_12[62].gameObject.SetActive(false);
            inside_101.inside_1_6_12[63].gameObject.SetActive(false);
            inside_101.inside_1_6_12[64].gameObject.SetActive(false);
            inside_101.inside_1_6_12[65].gameObject.SetActive(false);
            inside_101.inside_1_6_12[66].gameObject.SetActive(false);
            inside_101.inside_1_6_12[67].gameObject.SetActive(false);
            inside_101.inside_1_6_12[68].gameObject.SetActive(false);

            //1-6-33
            inside_105.Line_1_6_33_Index = 0;

            inside_105.inside_1_6_33[0].gameObject.SetActive(false);
            inside_105.inside_1_6_33[1].gameObject.SetActive(false);
            inside_105.inside_1_6_33[2].gameObject.SetActive(false);
            inside_105.inside_1_6_33[3].gameObject.SetActive(false);
            inside_105.inside_1_6_33[4].gameObject.SetActive(false);
            inside_105.inside_1_6_33[5].gameObject.SetActive(false);
            inside_105.inside_1_6_33[6].gameObject.SetActive(false);
            inside_105.inside_1_6_33[7].gameObject.SetActive(false);
            inside_105.inside_1_6_33[8].gameObject.SetActive(false);
            inside_105.inside_1_6_33[9].gameObject.SetActive(false);
            inside_105.inside_1_6_33[10].gameObject.SetActive(false);
            inside_105.inside_1_6_33[11].gameObject.SetActive(false);
            inside_105.inside_1_6_33[12].gameObject.SetActive(false);
            inside_105.inside_1_6_33[13].gameObject.SetActive(false);
            inside_105.inside_1_6_33[14].gameObject.SetActive(false);
            inside_105.inside_1_6_33[15].gameObject.SetActive(false);
            inside_105.inside_1_6_33[16].gameObject.SetActive(false);
            inside_105.inside_1_6_33[17].gameObject.SetActive(false);
            inside_105.inside_1_6_33[18].gameObject.SetActive(false);
            inside_105.inside_1_6_33[19].gameObject.SetActive(false);
            inside_105.inside_1_6_33[20].gameObject.SetActive(false);
            inside_105.inside_1_6_33[21].gameObject.SetActive(false);
            inside_105.inside_1_6_33[22].gameObject.SetActive(false);
            inside_105.inside_1_6_33[23].gameObject.SetActive(false);
            inside_105.inside_1_6_33[24].gameObject.SetActive(false);
            inside_105.inside_1_6_33[25].gameObject.SetActive(false);
            inside_105.inside_1_6_33[26].gameObject.SetActive(false);
            inside_105.inside_1_6_33[27].gameObject.SetActive(false);
            inside_105.inside_1_6_33[28].gameObject.SetActive(false);
            inside_105.inside_1_6_33[29].gameObject.SetActive(false);
            inside_105.inside_1_6_33[30].gameObject.SetActive(false);
            inside_105.inside_1_6_33[31].gameObject.SetActive(false);
            inside_105.inside_1_6_33[32].gameObject.SetActive(false);
            inside_105.inside_1_6_33[33].gameObject.SetActive(false);
            inside_105.inside_1_6_33[34].gameObject.SetActive(false);
            inside_105.inside_1_6_33[35].gameObject.SetActive(false);
            inside_105.inside_1_6_33[36].gameObject.SetActive(false);
            inside_105.inside_1_6_33[37].gameObject.SetActive(false);
            inside_105.inside_1_6_33[38].gameObject.SetActive(false);
            inside_105.inside_1_6_33[39].gameObject.SetActive(false);
            inside_105.inside_1_6_33[40].gameObject.SetActive(false);
            inside_105.inside_1_6_33[41].gameObject.SetActive(false);
            inside_105.inside_1_6_33[42].gameObject.SetActive(false);
            inside_105.inside_1_6_33[43].gameObject.SetActive(false);
            inside_105.inside_1_6_33[44].gameObject.SetActive(false);
            inside_105.inside_1_6_33[45].gameObject.SetActive(false);
            inside_105.inside_1_6_33[46].gameObject.SetActive(false);
            inside_105.inside_1_6_33[47].gameObject.SetActive(false);
            inside_105.inside_1_6_33[48].gameObject.SetActive(false);
            inside_105.inside_1_6_33[49].gameObject.SetActive(false);
            inside_105.inside_1_6_33[50].gameObject.SetActive(false);
            inside_105.inside_1_6_33[51].gameObject.SetActive(false);
            inside_105.inside_1_6_33[52].gameObject.SetActive(false);
            inside_105.inside_1_6_33[53].gameObject.SetActive(false);
            inside_105.inside_1_6_33[54].gameObject.SetActive(false);
            inside_105.inside_1_6_33[55].gameObject.SetActive(false);
            inside_105.inside_1_6_33[56].gameObject.SetActive(false);
            inside_105.inside_1_6_33[57].gameObject.SetActive(false);
            inside_105.inside_1_6_33[58].gameObject.SetActive(false);
            inside_105.inside_1_6_33[59].gameObject.SetActive(false);
            inside_105.inside_1_6_33[60].gameObject.SetActive(false);
            inside_105.inside_1_6_33[61].gameObject.SetActive(false);
            inside_105.inside_1_6_33[62].gameObject.SetActive(false);
            inside_105.inside_1_6_33[63].gameObject.SetActive(false);
            inside_105.inside_1_6_33[64].gameObject.SetActive(false);
            inside_105.inside_1_6_33[65].gameObject.SetActive(false);
            inside_105.inside_1_6_33[66].gameObject.SetActive(false);
            inside_105.inside_1_6_33[67].gameObject.SetActive(false);

            //1-6-34
            inside_109.Line_1_6_34_Index = 0;

            inside_109.inside_1_6_34[0].gameObject.SetActive(false);
            inside_109.inside_1_6_34[1].gameObject.SetActive(false);
            inside_109.inside_1_6_34[2].gameObject.SetActive(false);
            inside_109.inside_1_6_34[3].gameObject.SetActive(false);
            inside_109.inside_1_6_34[4].gameObject.SetActive(false);
            inside_109.inside_1_6_34[5].gameObject.SetActive(false);
            inside_109.inside_1_6_34[6].gameObject.SetActive(false);
            inside_109.inside_1_6_34[7].gameObject.SetActive(false);
            inside_109.inside_1_6_34[8].gameObject.SetActive(false);
            inside_109.inside_1_6_34[9].gameObject.SetActive(false);
            inside_109.inside_1_6_34[10].gameObject.SetActive(false);
            inside_109.inside_1_6_34[11].gameObject.SetActive(false);
            inside_109.inside_1_6_34[12].gameObject.SetActive(false);
            inside_109.inside_1_6_34[13].gameObject.SetActive(false);
            inside_109.inside_1_6_34[14].gameObject.SetActive(false);
            inside_109.inside_1_6_34[15].gameObject.SetActive(false);
            inside_109.inside_1_6_34[16].gameObject.SetActive(false);
            inside_109.inside_1_6_34[17].gameObject.SetActive(false);
            inside_109.inside_1_6_34[18].gameObject.SetActive(false);
            inside_109.inside_1_6_34[19].gameObject.SetActive(false);
            inside_109.inside_1_6_34[20].gameObject.SetActive(false);
            inside_109.inside_1_6_34[21].gameObject.SetActive(false);
            inside_109.inside_1_6_34[22].gameObject.SetActive(false);
            inside_109.inside_1_6_34[23].gameObject.SetActive(false);
            inside_109.inside_1_6_34[24].gameObject.SetActive(false);
            inside_109.inside_1_6_34[25].gameObject.SetActive(false);
            inside_109.inside_1_6_34[26].gameObject.SetActive(false);
            inside_109.inside_1_6_34[27].gameObject.SetActive(false);
            inside_109.inside_1_6_34[28].gameObject.SetActive(false);
            inside_109.inside_1_6_34[29].gameObject.SetActive(false);
            inside_109.inside_1_6_34[30].gameObject.SetActive(false);
            inside_109.inside_1_6_34[31].gameObject.SetActive(false);
            inside_109.inside_1_6_34[32].gameObject.SetActive(false);
            inside_109.inside_1_6_34[33].gameObject.SetActive(false);
            inside_109.inside_1_6_34[34].gameObject.SetActive(false);
            inside_109.inside_1_6_34[35].gameObject.SetActive(false);
            inside_109.inside_1_6_34[36].gameObject.SetActive(false);
            inside_109.inside_1_6_34[37].gameObject.SetActive(false);
            inside_109.inside_1_6_34[38].gameObject.SetActive(false);
            inside_109.inside_1_6_34[39].gameObject.SetActive(false);
            inside_109.inside_1_6_34[40].gameObject.SetActive(false);
            inside_109.inside_1_6_34[41].gameObject.SetActive(false);
            inside_109.inside_1_6_34[42].gameObject.SetActive(false);
            inside_109.inside_1_6_34[43].gameObject.SetActive(false);
            inside_109.inside_1_6_34[44].gameObject.SetActive(false);
            inside_109.inside_1_6_34[45].gameObject.SetActive(false);
            inside_109.inside_1_6_34[46].gameObject.SetActive(false);
            inside_109.inside_1_6_34[47].gameObject.SetActive(false);
            inside_109.inside_1_6_34[48].gameObject.SetActive(false);
            inside_109.inside_1_6_34[49].gameObject.SetActive(false);
            inside_109.inside_1_6_34[50].gameObject.SetActive(false);
            inside_109.inside_1_6_34[51].gameObject.SetActive(false);
            inside_109.inside_1_6_34[52].gameObject.SetActive(false);
            inside_109.inside_1_6_34[53].gameObject.SetActive(false);
            inside_109.inside_1_6_34[54].gameObject.SetActive(false);
            inside_109.inside_1_6_34[55].gameObject.SetActive(false);
            inside_109.inside_1_6_34[56].gameObject.SetActive(false);
            inside_109.inside_1_6_34[57].gameObject.SetActive(false);
            inside_109.inside_1_6_34[58].gameObject.SetActive(false);
            inside_109.inside_1_6_34[59].gameObject.SetActive(false);
            inside_109.inside_1_6_34[60].gameObject.SetActive(false);
            inside_109.inside_1_6_34[61].gameObject.SetActive(false);
            inside_109.inside_1_6_34[62].gameObject.SetActive(false);
            inside_109.inside_1_6_34[63].gameObject.SetActive(false);
            inside_109.inside_1_6_34[64].gameObject.SetActive(false);
            inside_109.inside_1_6_34[65].gameObject.SetActive(false);
            inside_109.inside_1_6_34[66].gameObject.SetActive(false);
            inside_109.inside_1_6_34[67].gameObject.SetActive(false);
            inside_109.inside_1_6_34[68].gameObject.SetActive(false);

            //1-6-35
            inside_113.Line_1_6_35_Index = 0;

            inside_113.inside_1_6_35[0].gameObject.SetActive(false);
            inside_113.inside_1_6_35[1].gameObject.SetActive(false);
            inside_113.inside_1_6_35[2].gameObject.SetActive(false);
            inside_113.inside_1_6_35[3].gameObject.SetActive(false);
            inside_113.inside_1_6_35[4].gameObject.SetActive(false);
            inside_113.inside_1_6_35[5].gameObject.SetActive(false);
            inside_113.inside_1_6_35[6].gameObject.SetActive(false);
            inside_113.inside_1_6_35[7].gameObject.SetActive(false);
            inside_113.inside_1_6_35[8].gameObject.SetActive(false);
            inside_113.inside_1_6_35[9].gameObject.SetActive(false);
            inside_113.inside_1_6_35[10].gameObject.SetActive(false);
            inside_113.inside_1_6_35[11].gameObject.SetActive(false);
            inside_113.inside_1_6_35[12].gameObject.SetActive(false);
            inside_113.inside_1_6_35[13].gameObject.SetActive(false);
            inside_113.inside_1_6_35[14].gameObject.SetActive(false);
            inside_113.inside_1_6_35[15].gameObject.SetActive(false);
            inside_113.inside_1_6_35[16].gameObject.SetActive(false);
            inside_113.inside_1_6_35[17].gameObject.SetActive(false);
            inside_113.inside_1_6_35[18].gameObject.SetActive(false);
            inside_113.inside_1_6_35[19].gameObject.SetActive(false);
            inside_113.inside_1_6_35[20].gameObject.SetActive(false);
            inside_113.inside_1_6_35[21].gameObject.SetActive(false);
            inside_113.inside_1_6_35[22].gameObject.SetActive(false);
            inside_113.inside_1_6_35[23].gameObject.SetActive(false);
            inside_113.inside_1_6_35[24].gameObject.SetActive(false);
            inside_113.inside_1_6_35[25].gameObject.SetActive(false);
            inside_113.inside_1_6_35[26].gameObject.SetActive(false);
            inside_113.inside_1_6_35[27].gameObject.SetActive(false);
            inside_113.inside_1_6_35[28].gameObject.SetActive(false);
            inside_113.inside_1_6_35[29].gameObject.SetActive(false);
            inside_113.inside_1_6_35[30].gameObject.SetActive(false);
            inside_113.inside_1_6_35[31].gameObject.SetActive(false);
            inside_113.inside_1_6_35[32].gameObject.SetActive(false);
            inside_113.inside_1_6_35[33].gameObject.SetActive(false);
            inside_113.inside_1_6_35[34].gameObject.SetActive(false);
            inside_113.inside_1_6_35[35].gameObject.SetActive(false);
            inside_113.inside_1_6_35[36].gameObject.SetActive(false);
            inside_113.inside_1_6_35[37].gameObject.SetActive(false);
            inside_113.inside_1_6_35[38].gameObject.SetActive(false);
            inside_113.inside_1_6_35[39].gameObject.SetActive(false);
            inside_113.inside_1_6_35[40].gameObject.SetActive(false);
            inside_113.inside_1_6_35[41].gameObject.SetActive(false);
            inside_113.inside_1_6_35[42].gameObject.SetActive(false);
            inside_113.inside_1_6_35[43].gameObject.SetActive(false);
            inside_113.inside_1_6_35[44].gameObject.SetActive(false);
            inside_113.inside_1_6_35[45].gameObject.SetActive(false);
            inside_113.inside_1_6_35[46].gameObject.SetActive(false);
            inside_113.inside_1_6_35[47].gameObject.SetActive(false);
            inside_113.inside_1_6_35[48].gameObject.SetActive(false);
            inside_113.inside_1_6_35[49].gameObject.SetActive(false);
            inside_113.inside_1_6_35[50].gameObject.SetActive(false);
            inside_113.inside_1_6_35[51].gameObject.SetActive(false);
            inside_113.inside_1_6_35[52].gameObject.SetActive(false);
            inside_113.inside_1_6_35[53].gameObject.SetActive(false);
            inside_113.inside_1_6_35[54].gameObject.SetActive(false);
            inside_113.inside_1_6_35[55].gameObject.SetActive(false);
            inside_113.inside_1_6_35[56].gameObject.SetActive(false);
            inside_113.inside_1_6_35[57].gameObject.SetActive(false);
            inside_113.inside_1_6_35[58].gameObject.SetActive(false);
            inside_113.inside_1_6_35[59].gameObject.SetActive(false);
            inside_113.inside_1_6_35[60].gameObject.SetActive(false);
            inside_113.inside_1_6_35[61].gameObject.SetActive(false);
            inside_113.inside_1_6_35[62].gameObject.SetActive(false);
            inside_113.inside_1_6_35[63].gameObject.SetActive(false);
            inside_113.inside_1_6_35[64].gameObject.SetActive(false);
            inside_113.inside_1_6_35[65].gameObject.SetActive(false);
            inside_113.inside_1_6_35[66].gameObject.SetActive(false);
            inside_113.inside_1_6_35[67].gameObject.SetActive(false);

            //1-6-36
            inside_117.Line_1_6_36_Index = 0;

            inside_117.inside_1_6_36[0].gameObject.SetActive(false);
            inside_117.inside_1_6_36[1].gameObject.SetActive(false);
            inside_117.inside_1_6_36[2].gameObject.SetActive(false);
            inside_117.inside_1_6_36[3].gameObject.SetActive(false);
            inside_117.inside_1_6_36[4].gameObject.SetActive(false);
            inside_117.inside_1_6_36[5].gameObject.SetActive(false);
            inside_117.inside_1_6_36[6].gameObject.SetActive(false);
            inside_117.inside_1_6_36[7].gameObject.SetActive(false);
            inside_117.inside_1_6_36[8].gameObject.SetActive(false);
            inside_117.inside_1_6_36[9].gameObject.SetActive(false);
            inside_117.inside_1_6_36[10].gameObject.SetActive(false);
            inside_117.inside_1_6_36[11].gameObject.SetActive(false);
            inside_117.inside_1_6_36[12].gameObject.SetActive(false);
            inside_117.inside_1_6_36[13].gameObject.SetActive(false);
            inside_117.inside_1_6_36[14].gameObject.SetActive(false);
            inside_117.inside_1_6_36[15].gameObject.SetActive(false);
            inside_117.inside_1_6_36[16].gameObject.SetActive(false);
            inside_117.inside_1_6_36[17].gameObject.SetActive(false);
            inside_117.inside_1_6_36[18].gameObject.SetActive(false);
            inside_117.inside_1_6_36[19].gameObject.SetActive(false);
            inside_117.inside_1_6_36[20].gameObject.SetActive(false);
            inside_117.inside_1_6_36[21].gameObject.SetActive(false);
            inside_117.inside_1_6_36[22].gameObject.SetActive(false);
            inside_117.inside_1_6_36[23].gameObject.SetActive(false);
            inside_117.inside_1_6_36[24].gameObject.SetActive(false);
            inside_117.inside_1_6_36[25].gameObject.SetActive(false);
            inside_117.inside_1_6_36[26].gameObject.SetActive(false);
            inside_117.inside_1_6_36[27].gameObject.SetActive(false);
            inside_117.inside_1_6_36[28].gameObject.SetActive(false);
            inside_117.inside_1_6_36[29].gameObject.SetActive(false);
            inside_117.inside_1_6_36[30].gameObject.SetActive(false);
            inside_117.inside_1_6_36[31].gameObject.SetActive(false);
            inside_117.inside_1_6_36[32].gameObject.SetActive(false);
            inside_117.inside_1_6_36[33].gameObject.SetActive(false);
            inside_117.inside_1_6_36[34].gameObject.SetActive(false);
            inside_117.inside_1_6_36[35].gameObject.SetActive(false);
            inside_117.inside_1_6_36[36].gameObject.SetActive(false);
            inside_117.inside_1_6_36[37].gameObject.SetActive(false);
            inside_117.inside_1_6_36[38].gameObject.SetActive(false);
            inside_117.inside_1_6_36[39].gameObject.SetActive(false);
            inside_117.inside_1_6_36[40].gameObject.SetActive(false);
            inside_117.inside_1_6_36[41].gameObject.SetActive(false);
            inside_117.inside_1_6_36[42].gameObject.SetActive(false);
            inside_117.inside_1_6_36[43].gameObject.SetActive(false);
            inside_117.inside_1_6_36[44].gameObject.SetActive(false);
            inside_117.inside_1_6_36[45].gameObject.SetActive(false);
            inside_117.inside_1_6_36[46].gameObject.SetActive(false);
            inside_117.inside_1_6_36[47].gameObject.SetActive(false);
            inside_117.inside_1_6_36[48].gameObject.SetActive(false);
            inside_117.inside_1_6_36[49].gameObject.SetActive(false);
            inside_117.inside_1_6_36[50].gameObject.SetActive(false);
            inside_117.inside_1_6_36[51].gameObject.SetActive(false);
            inside_117.inside_1_6_36[52].gameObject.SetActive(false);
            inside_117.inside_1_6_36[53].gameObject.SetActive(false);
            inside_117.inside_1_6_36[54].gameObject.SetActive(false);
            inside_117.inside_1_6_36[55].gameObject.SetActive(false);
            inside_117.inside_1_6_36[56].gameObject.SetActive(false);
            inside_117.inside_1_6_36[57].gameObject.SetActive(false);
            inside_117.inside_1_6_36[58].gameObject.SetActive(false);
            inside_117.inside_1_6_36[59].gameObject.SetActive(false);
            inside_117.inside_1_6_36[60].gameObject.SetActive(false);
            inside_117.inside_1_6_36[61].gameObject.SetActive(false);
            inside_117.inside_1_6_36[62].gameObject.SetActive(false);
            inside_117.inside_1_6_36[63].gameObject.SetActive(false);
            inside_117.inside_1_6_36[64].gameObject.SetActive(false);
            inside_117.inside_1_6_36[65].gameObject.SetActive(false);
            inside_117.inside_1_6_36[66].gameObject.SetActive(false);
            inside_117.inside_1_6_36[67].gameObject.SetActive(false);
            inside_117.inside_1_6_36[68].gameObject.SetActive(false);

            //1-6-41
            inside_121.Line_1_6_41_Index = 0;

            inside_121.inside_1_6_41[0].gameObject.SetActive(false);
            inside_121.inside_1_6_41[1].gameObject.SetActive(false);
            inside_121.inside_1_6_41[2].gameObject.SetActive(false);
            inside_121.inside_1_6_41[3].gameObject.SetActive(false);
            inside_121.inside_1_6_41[4].gameObject.SetActive(false);
            inside_121.inside_1_6_41[5].gameObject.SetActive(false);
            inside_121.inside_1_6_41[6].gameObject.SetActive(false);
            inside_121.inside_1_6_41[7].gameObject.SetActive(false);
            inside_121.inside_1_6_41[8].gameObject.SetActive(false);
            inside_121.inside_1_6_41[9].gameObject.SetActive(false);
            inside_121.inside_1_6_41[10].gameObject.SetActive(false);
            inside_121.inside_1_6_41[11].gameObject.SetActive(false);
            inside_121.inside_1_6_41[12].gameObject.SetActive(false);
            inside_121.inside_1_6_41[13].gameObject.SetActive(false);
            inside_121.inside_1_6_41[14].gameObject.SetActive(false);
            inside_121.inside_1_6_41[15].gameObject.SetActive(false);
            inside_121.inside_1_6_41[16].gameObject.SetActive(false);
            inside_121.inside_1_6_41[17].gameObject.SetActive(false);
            inside_121.inside_1_6_41[18].gameObject.SetActive(false);
            inside_121.inside_1_6_41[19].gameObject.SetActive(false);
            inside_121.inside_1_6_41[20].gameObject.SetActive(false);
            inside_121.inside_1_6_41[21].gameObject.SetActive(false);
            inside_121.inside_1_6_41[22].gameObject.SetActive(false);
            inside_121.inside_1_6_41[23].gameObject.SetActive(false);
            inside_121.inside_1_6_41[24].gameObject.SetActive(false);
            inside_121.inside_1_6_41[25].gameObject.SetActive(false);
            inside_121.inside_1_6_41[26].gameObject.SetActive(false);
            inside_121.inside_1_6_41[27].gameObject.SetActive(false);
            inside_121.inside_1_6_41[28].gameObject.SetActive(false);
            inside_121.inside_1_6_41[29].gameObject.SetActive(false);
            inside_121.inside_1_6_41[30].gameObject.SetActive(false);
            inside_121.inside_1_6_41[31].gameObject.SetActive(false);
            inside_121.inside_1_6_41[32].gameObject.SetActive(false);
            inside_121.inside_1_6_41[33].gameObject.SetActive(false);
            inside_121.inside_1_6_41[34].gameObject.SetActive(false);
            inside_121.inside_1_6_41[35].gameObject.SetActive(false);
            inside_121.inside_1_6_41[36].gameObject.SetActive(false);
            inside_121.inside_1_6_41[37].gameObject.SetActive(false);
            inside_121.inside_1_6_41[38].gameObject.SetActive(false);
            inside_121.inside_1_6_41[39].gameObject.SetActive(false);
            inside_121.inside_1_6_41[40].gameObject.SetActive(false);
            inside_121.inside_1_6_41[41].gameObject.SetActive(false);
            inside_121.inside_1_6_41[42].gameObject.SetActive(false);
            inside_121.inside_1_6_41[43].gameObject.SetActive(false);
            inside_121.inside_1_6_41[44].gameObject.SetActive(false);
            inside_121.inside_1_6_41[45].gameObject.SetActive(false);
            inside_121.inside_1_6_41[46].gameObject.SetActive(false);
            inside_121.inside_1_6_41[47].gameObject.SetActive(false);
            inside_121.inside_1_6_41[48].gameObject.SetActive(false);
            inside_121.inside_1_6_41[49].gameObject.SetActive(false);
            inside_121.inside_1_6_41[50].gameObject.SetActive(false);
            inside_121.inside_1_6_41[51].gameObject.SetActive(false);
            inside_121.inside_1_6_41[52].gameObject.SetActive(false);
            inside_121.inside_1_6_41[53].gameObject.SetActive(false);
            inside_121.inside_1_6_41[54].gameObject.SetActive(false);
            inside_121.inside_1_6_41[55].gameObject.SetActive(false);
            inside_121.inside_1_6_41[56].gameObject.SetActive(false);
            inside_121.inside_1_6_41[57].gameObject.SetActive(false);
            inside_121.inside_1_6_41[58].gameObject.SetActive(false);
            inside_121.inside_1_6_41[59].gameObject.SetActive(false);
            inside_121.inside_1_6_41[60].gameObject.SetActive(false);
            inside_121.inside_1_6_41[61].gameObject.SetActive(false);
            inside_121.inside_1_6_41[62].gameObject.SetActive(false);
            inside_121.inside_1_6_41[63].gameObject.SetActive(false);
            inside_121.inside_1_6_41[64].gameObject.SetActive(false);
            inside_121.inside_1_6_41[65].gameObject.SetActive(false);
            inside_121.inside_1_6_41[66].gameObject.SetActive(false);
            inside_121.inside_1_6_41[67].gameObject.SetActive(false);

            //1-6-42
            inside_125.Line_1_6_42_Index = 0;

            inside_125.inside_1_6_42[0].gameObject.SetActive(false);
            inside_125.inside_1_6_42[1].gameObject.SetActive(false);
            inside_125.inside_1_6_42[2].gameObject.SetActive(false);
            inside_125.inside_1_6_42[3].gameObject.SetActive(false);
            inside_125.inside_1_6_42[4].gameObject.SetActive(false);
            inside_125.inside_1_6_42[5].gameObject.SetActive(false);
            inside_125.inside_1_6_42[6].gameObject.SetActive(false);
            inside_125.inside_1_6_42[7].gameObject.SetActive(false);
            inside_125.inside_1_6_42[8].gameObject.SetActive(false);
            inside_125.inside_1_6_42[9].gameObject.SetActive(false);
            inside_125.inside_1_6_42[10].gameObject.SetActive(false);
            inside_125.inside_1_6_42[11].gameObject.SetActive(false);
            inside_125.inside_1_6_42[12].gameObject.SetActive(false);
            inside_125.inside_1_6_42[13].gameObject.SetActive(false);
            inside_125.inside_1_6_42[14].gameObject.SetActive(false);
            inside_125.inside_1_6_42[15].gameObject.SetActive(false);
            inside_125.inside_1_6_42[16].gameObject.SetActive(false);
            inside_125.inside_1_6_42[17].gameObject.SetActive(false);
            inside_125.inside_1_6_42[18].gameObject.SetActive(false);
            inside_125.inside_1_6_42[19].gameObject.SetActive(false);
            inside_125.inside_1_6_42[20].gameObject.SetActive(false);
            inside_125.inside_1_6_42[21].gameObject.SetActive(false);
            inside_125.inside_1_6_42[22].gameObject.SetActive(false);
            inside_125.inside_1_6_42[23].gameObject.SetActive(false);
            inside_125.inside_1_6_42[24].gameObject.SetActive(false);
            inside_125.inside_1_6_42[25].gameObject.SetActive(false);
            inside_125.inside_1_6_42[26].gameObject.SetActive(false);
            inside_125.inside_1_6_42[27].gameObject.SetActive(false);
            inside_125.inside_1_6_42[28].gameObject.SetActive(false);
            inside_125.inside_1_6_42[29].gameObject.SetActive(false);
            inside_125.inside_1_6_42[30].gameObject.SetActive(false);
            inside_125.inside_1_6_42[31].gameObject.SetActive(false);
            inside_125.inside_1_6_42[32].gameObject.SetActive(false);
            inside_125.inside_1_6_42[33].gameObject.SetActive(false);
            inside_125.inside_1_6_42[34].gameObject.SetActive(false);
            inside_125.inside_1_6_42[35].gameObject.SetActive(false);
            inside_125.inside_1_6_42[36].gameObject.SetActive(false);
            inside_125.inside_1_6_42[37].gameObject.SetActive(false);
            inside_125.inside_1_6_42[38].gameObject.SetActive(false);
            inside_125.inside_1_6_42[39].gameObject.SetActive(false);
            inside_125.inside_1_6_42[40].gameObject.SetActive(false);
            inside_125.inside_1_6_42[41].gameObject.SetActive(false);
            inside_125.inside_1_6_42[42].gameObject.SetActive(false);
            inside_125.inside_1_6_42[43].gameObject.SetActive(false);
            inside_125.inside_1_6_42[44].gameObject.SetActive(false);
            inside_125.inside_1_6_42[45].gameObject.SetActive(false);
            inside_125.inside_1_6_42[46].gameObject.SetActive(false);
            inside_125.inside_1_6_42[47].gameObject.SetActive(false);
            inside_125.inside_1_6_42[48].gameObject.SetActive(false);
            inside_125.inside_1_6_42[49].gameObject.SetActive(false);
            inside_125.inside_1_6_42[50].gameObject.SetActive(false);
            inside_125.inside_1_6_42[51].gameObject.SetActive(false);
            inside_125.inside_1_6_42[52].gameObject.SetActive(false);
            inside_125.inside_1_6_42[53].gameObject.SetActive(false);
            inside_125.inside_1_6_42[54].gameObject.SetActive(false);
            inside_125.inside_1_6_42[55].gameObject.SetActive(false);
            inside_125.inside_1_6_42[56].gameObject.SetActive(false);
            inside_125.inside_1_6_42[57].gameObject.SetActive(false);
            inside_125.inside_1_6_42[58].gameObject.SetActive(false);
            inside_125.inside_1_6_42[59].gameObject.SetActive(false);
            inside_125.inside_1_6_42[60].gameObject.SetActive(false);
            inside_125.inside_1_6_42[61].gameObject.SetActive(false);
            inside_125.inside_1_6_42[62].gameObject.SetActive(false);
            inside_125.inside_1_6_42[63].gameObject.SetActive(false);
            inside_125.inside_1_6_42[64].gameObject.SetActive(false);
            inside_125.inside_1_6_42[65].gameObject.SetActive(false);
            inside_125.inside_1_6_42[66].gameObject.SetActive(false);
            inside_125.inside_1_6_42[67].gameObject.SetActive(false);
            inside_125.inside_1_6_42[68].gameObject.SetActive(false);

            //1-6-43
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

            //1-6-44
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

            //Like_1_4_11
            like_1_4_11.Like_1_4_11_Index = 0;
            like_1_4_11.inside_Like_1_4_11[0].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[1].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[2].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[3].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[4].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[5].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[6].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[7].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[8].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[9].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[10].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[11].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[12].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[13].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[14].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[15].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[16].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[17].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[18].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[19].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[20].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[21].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[22].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[23].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[24].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[25].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[26].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[27].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[28].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[29].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[30].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[31].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[32].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[33].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[34].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[35].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[36].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[37].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[38].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[39].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[40].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[41].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[42].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[43].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[44].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[45].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[46].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[47].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[48].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[49].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[50].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[51].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[52].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[53].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[54].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[55].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[56].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[57].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[58].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[59].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[60].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[61].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[62].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[63].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[64].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[65].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[66].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[67].gameObject.SetActive(false);
            like_1_4_11.inside_Like_1_4_11[68].gameObject.SetActive(false);

            //141
            inside_141.Line_141_Index = 0;
            inside_141.inside_Line_141[0].gameObject.SetActive(false);
            inside_141.inside_Line_141[1].gameObject.SetActive(false);
            inside_141.inside_Line_141[2].gameObject.SetActive(false);
            inside_141.inside_Line_141[3].gameObject.SetActive(false);
            inside_141.inside_Line_141[4].gameObject.SetActive(false);
            inside_141.inside_Line_141[5].gameObject.SetActive(false);
            inside_141.inside_Line_141[6].gameObject.SetActive(false);
            inside_141.inside_Line_141[7].gameObject.SetActive(false);
            inside_141.inside_Line_141[8].gameObject.SetActive(false);
            inside_141.inside_Line_141[9].gameObject.SetActive(false);
            inside_141.inside_Line_141[10].gameObject.SetActive(false);
            inside_141.inside_Line_141[11].gameObject.SetActive(false);
            inside_141.inside_Line_141[12].gameObject.SetActive(false);
            inside_141.inside_Line_141[13].gameObject.SetActive(false);
            inside_141.inside_Line_141[14].gameObject.SetActive(false);
            inside_141.inside_Line_141[15].gameObject.SetActive(false);
            inside_141.inside_Line_141[16].gameObject.SetActive(false);
            inside_141.inside_Line_141[17].gameObject.SetActive(false);
            inside_141.inside_Line_141[18].gameObject.SetActive(false);
            inside_141.inside_Line_141[19].gameObject.SetActive(false);
            inside_141.inside_Line_141[20].gameObject.SetActive(false);
            inside_141.inside_Line_141[21].gameObject.SetActive(false);
            inside_141.inside_Line_141[22].gameObject.SetActive(false);
            inside_141.inside_Line_141[23].gameObject.SetActive(false);
            inside_141.inside_Line_141[24].gameObject.SetActive(false);
            inside_141.inside_Line_141[25].gameObject.SetActive(false);
            inside_141.inside_Line_141[26].gameObject.SetActive(false);
            inside_141.inside_Line_141[27].gameObject.SetActive(false);
            inside_141.inside_Line_141[28].gameObject.SetActive(false);
            inside_141.inside_Line_141[29].gameObject.SetActive(false);
            inside_141.inside_Line_141[30].gameObject.SetActive(false);
            inside_141.inside_Line_141[31].gameObject.SetActive(false);
            inside_141.inside_Line_141[32].gameObject.SetActive(false);
            inside_141.inside_Line_141[33].gameObject.SetActive(false);
            inside_141.inside_Line_141[34].gameObject.SetActive(false);
            inside_141.inside_Line_141[35].gameObject.SetActive(false);
            inside_141.inside_Line_141[36].gameObject.SetActive(false);
            inside_141.inside_Line_141[37].gameObject.SetActive(false);
            inside_141.inside_Line_141[38].gameObject.SetActive(false);
            inside_141.inside_Line_141[39].gameObject.SetActive(false);
            inside_141.inside_Line_141[40].gameObject.SetActive(false);
            inside_141.inside_Line_141[41].gameObject.SetActive(false);
            inside_141.inside_Line_141[42].gameObject.SetActive(false);
            inside_141.inside_Line_141[43].gameObject.SetActive(false);
            inside_141.inside_Line_141[44].gameObject.SetActive(false);
            inside_141.inside_Line_141[45].gameObject.SetActive(false);
            inside_141.inside_Line_141[46].gameObject.SetActive(false);
            inside_141.inside_Line_141[47].gameObject.SetActive(false);
            inside_141.inside_Line_141[48].gameObject.SetActive(false);

            //142
            inside_142.Line_142_Index = 0;
            inside_142.inside_Line_142[0].gameObject.SetActive(false);
            inside_142.inside_Line_142[1].gameObject.SetActive(false);
            inside_142.inside_Line_142[2].gameObject.SetActive(false);
            inside_142.inside_Line_142[3].gameObject.SetActive(false);
            inside_142.inside_Line_142[4].gameObject.SetActive(false);
            inside_142.inside_Line_142[5].gameObject.SetActive(false);
            inside_142.inside_Line_142[6].gameObject.SetActive(false);
            inside_142.inside_Line_142[7].gameObject.SetActive(false);
            inside_142.inside_Line_142[8].gameObject.SetActive(false);
            inside_142.inside_Line_142[9].gameObject.SetActive(false);
            inside_142.inside_Line_142[10].gameObject.SetActive(false);
            inside_142.inside_Line_142[11].gameObject.SetActive(false);
            inside_142.inside_Line_142[12].gameObject.SetActive(false);
            inside_142.inside_Line_142[13].gameObject.SetActive(false);
            inside_142.inside_Line_142[14].gameObject.SetActive(false);
            inside_142.inside_Line_142[15].gameObject.SetActive(false);
            inside_142.inside_Line_142[16].gameObject.SetActive(false);
            inside_142.inside_Line_142[17].gameObject.SetActive(false);
            inside_142.inside_Line_142[18].gameObject.SetActive(false);
            inside_142.inside_Line_142[19].gameObject.SetActive(false);
            inside_142.inside_Line_142[20].gameObject.SetActive(false);
            inside_142.inside_Line_142[21].gameObject.SetActive(false);
            inside_142.inside_Line_142[22].gameObject.SetActive(false);
            inside_142.inside_Line_142[23].gameObject.SetActive(false);
            inside_142.inside_Line_142[24].gameObject.SetActive(false);
            inside_142.inside_Line_142[25].gameObject.SetActive(false);
            inside_142.inside_Line_142[26].gameObject.SetActive(false);
            inside_142.inside_Line_142[27].gameObject.SetActive(false);
            inside_142.inside_Line_142[28].gameObject.SetActive(false);
            inside_142.inside_Line_142[29].gameObject.SetActive(false);
            inside_142.inside_Line_142[30].gameObject.SetActive(false);
            inside_142.inside_Line_142[31].gameObject.SetActive(false);
            inside_142.inside_Line_142[32].gameObject.SetActive(false);
            inside_142.inside_Line_142[33].gameObject.SetActive(false);
            inside_142.inside_Line_142[34].gameObject.SetActive(false);
            inside_142.inside_Line_142[35].gameObject.SetActive(false);
            inside_142.inside_Line_142[36].gameObject.SetActive(false);
            inside_142.inside_Line_142[37].gameObject.SetActive(false);
            inside_142.inside_Line_142[38].gameObject.SetActive(false);
            inside_142.inside_Line_142[39].gameObject.SetActive(false);
            inside_142.inside_Line_142[40].gameObject.SetActive(false);
            inside_142.inside_Line_142[41].gameObject.SetActive(false);
            inside_142.inside_Line_142[42].gameObject.SetActive(false);
            inside_142.inside_Line_142[43].gameObject.SetActive(false);
            inside_142.inside_Line_142[44].gameObject.SetActive(false);
            inside_142.inside_Line_142[45].gameObject.SetActive(false);
            inside_142.inside_Line_142[46].gameObject.SetActive(false);
            inside_142.inside_Line_142[47].gameObject.SetActive(false);
            inside_142.inside_Line_142[48].gameObject.SetActive(false);
            inside_142.inside_Line_142[49].gameObject.SetActive(false);
            inside_142.inside_Line_142[50].gameObject.SetActive(false);
            inside_142.inside_Line_142[51].gameObject.SetActive(false);

            //143
            inside_143.Line_143_Index = 0;
            inside_143.inside_Line_143[0].gameObject.SetActive(false);
            inside_143.inside_Line_143[1].gameObject.SetActive(false);
            inside_143.inside_Line_143[2].gameObject.SetActive(false);
            inside_143.inside_Line_143[3].gameObject.SetActive(false);
            inside_143.inside_Line_143[4].gameObject.SetActive(false);
            inside_143.inside_Line_143[5].gameObject.SetActive(false);
            inside_143.inside_Line_143[6].gameObject.SetActive(false);
            inside_143.inside_Line_143[7].gameObject.SetActive(false);
            inside_143.inside_Line_143[8].gameObject.SetActive(false);
            inside_143.inside_Line_143[9].gameObject.SetActive(false);
            inside_143.inside_Line_143[10].gameObject.SetActive(false);
            inside_143.inside_Line_143[11].gameObject.SetActive(false);
            inside_143.inside_Line_143[12].gameObject.SetActive(false);
            inside_143.inside_Line_143[13].gameObject.SetActive(false);
            inside_143.inside_Line_143[14].gameObject.SetActive(false);
            inside_143.inside_Line_143[15].gameObject.SetActive(false);
            inside_143.inside_Line_143[16].gameObject.SetActive(false);
            inside_143.inside_Line_143[17].gameObject.SetActive(false);
            inside_143.inside_Line_143[18].gameObject.SetActive(false);
            inside_143.inside_Line_143[19].gameObject.SetActive(false);
            inside_143.inside_Line_143[20].gameObject.SetActive(false);
            inside_143.inside_Line_143[21].gameObject.SetActive(false);
            inside_143.inside_Line_143[22].gameObject.SetActive(false);
            inside_143.inside_Line_143[23].gameObject.SetActive(false);
            inside_143.inside_Line_143[24].gameObject.SetActive(false);
            inside_143.inside_Line_143[25].gameObject.SetActive(false);
            inside_143.inside_Line_143[26].gameObject.SetActive(false);
            inside_143.inside_Line_143[27].gameObject.SetActive(false);
            inside_143.inside_Line_143[28].gameObject.SetActive(false);
            inside_143.inside_Line_143[29].gameObject.SetActive(false);
            inside_143.inside_Line_143[30].gameObject.SetActive(false);
            inside_143.inside_Line_143[31].gameObject.SetActive(false);
            inside_143.inside_Line_143[32].gameObject.SetActive(false);
            inside_143.inside_Line_143[33].gameObject.SetActive(false);
            inside_143.inside_Line_143[34].gameObject.SetActive(false);
            inside_143.inside_Line_143[35].gameObject.SetActive(false);
            inside_143.inside_Line_143[36].gameObject.SetActive(false);
            inside_143.inside_Line_143[37].gameObject.SetActive(false);
            inside_143.inside_Line_143[38].gameObject.SetActive(false);
            inside_143.inside_Line_143[39].gameObject.SetActive(false);
            inside_143.inside_Line_143[40].gameObject.SetActive(false);
            inside_143.inside_Line_143[41].gameObject.SetActive(false);
            inside_143.inside_Line_143[42].gameObject.SetActive(false);
            inside_143.inside_Line_143[43].gameObject.SetActive(false);
            inside_143.inside_Line_143[44].gameObject.SetActive(false);
            inside_143.inside_Line_143[45].gameObject.SetActive(false);
            inside_143.inside_Line_143[46].gameObject.SetActive(false);
            inside_143.inside_Line_143[47].gameObject.SetActive(false);
            inside_143.inside_Line_143[48].gameObject.SetActive(false);
            inside_143.inside_Line_143[49].gameObject.SetActive(false);
            inside_143.inside_Line_143[50].gameObject.SetActive(false);
            inside_143.inside_Line_143[51].gameObject.SetActive(false);
            inside_143.inside_Line_143[52].gameObject.SetActive(false);
            inside_143.inside_Line_143[53].gameObject.SetActive(false);
            inside_143.inside_Line_143[54].gameObject.SetActive(false);
            inside_143.inside_Line_143[55].gameObject.SetActive(false);
            inside_143.inside_Line_143[56].gameObject.SetActive(false);
            inside_143.inside_Line_143[57].gameObject.SetActive(false);
            inside_143.inside_Line_143[58].gameObject.SetActive(false);
            inside_143.inside_Line_143[59].gameObject.SetActive(false);
            inside_143.inside_Line_143[60].gameObject.SetActive(false);
            inside_143.inside_Line_143[62].gameObject.SetActive(false);
            inside_143.inside_Line_143[63].gameObject.SetActive(false);
            inside_143.inside_Line_143[64].gameObject.SetActive(false);
            inside_143.inside_Line_143[65].gameObject.SetActive(false);
            inside_143.inside_Line_143[66].gameObject.SetActive(false);
            inside_143.inside_Line_143[67].gameObject.SetActive(false);

            //144
            inside_144.Line_144_Index = 0;
            inside_144.inside_Line_144[0].gameObject.SetActive(false);
            inside_144.inside_Line_144[1].gameObject.SetActive(false);
            inside_144.inside_Line_144[2].gameObject.SetActive(false);
            inside_144.inside_Line_144[3].gameObject.SetActive(false);
            inside_144.inside_Line_144[4].gameObject.SetActive(false);
            inside_144.inside_Line_144[5].gameObject.SetActive(false);
            inside_144.inside_Line_144[6].gameObject.SetActive(false);
            inside_144.inside_Line_144[7].gameObject.SetActive(false);
            inside_144.inside_Line_144[8].gameObject.SetActive(false);
            inside_144.inside_Line_144[9].gameObject.SetActive(false);
            inside_144.inside_Line_144[10].gameObject.SetActive(false);
            inside_144.inside_Line_144[11].gameObject.SetActive(false);
            inside_144.inside_Line_144[12].gameObject.SetActive(false);
            inside_144.inside_Line_144[13].gameObject.SetActive(false);
            inside_144.inside_Line_144[14].gameObject.SetActive(false);
            inside_144.inside_Line_144[15].gameObject.SetActive(false);
            inside_144.inside_Line_144[16].gameObject.SetActive(false);
            inside_144.inside_Line_144[17].gameObject.SetActive(false);
            inside_144.inside_Line_144[18].gameObject.SetActive(false);
            inside_144.inside_Line_144[19].gameObject.SetActive(false);
            inside_144.inside_Line_144[20].gameObject.SetActive(false);
            inside_144.inside_Line_144[21].gameObject.SetActive(false);
            inside_144.inside_Line_144[22].gameObject.SetActive(false);
            inside_144.inside_Line_144[23].gameObject.SetActive(false);
            inside_144.inside_Line_144[24].gameObject.SetActive(false);
            inside_144.inside_Line_144[25].gameObject.SetActive(false);
            inside_144.inside_Line_144[26].gameObject.SetActive(false);
            inside_144.inside_Line_144[27].gameObject.SetActive(false);
            inside_144.inside_Line_144[28].gameObject.SetActive(false);
            inside_144.inside_Line_144[29].gameObject.SetActive(false);
            inside_144.inside_Line_144[30].gameObject.SetActive(false);
            inside_144.inside_Line_144[31].gameObject.SetActive(false);
            inside_144.inside_Line_144[32].gameObject.SetActive(false);
            inside_144.inside_Line_144[33].gameObject.SetActive(false);
            inside_144.inside_Line_144[34].gameObject.SetActive(false);
            inside_144.inside_Line_144[35].gameObject.SetActive(false);
            inside_144.inside_Line_144[36].gameObject.SetActive(false);
            inside_144.inside_Line_144[37].gameObject.SetActive(false);
            inside_144.inside_Line_144[38].gameObject.SetActive(false);
            inside_144.inside_Line_144[39].gameObject.SetActive(false);
            inside_144.inside_Line_144[40].gameObject.SetActive(false);
            inside_144.inside_Line_144[41].gameObject.SetActive(false);
            inside_144.inside_Line_144[42].gameObject.SetActive(false);
            inside_144.inside_Line_144[43].gameObject.SetActive(false);
            inside_144.inside_Line_144[44].gameObject.SetActive(false);
            inside_144.inside_Line_144[45].gameObject.SetActive(false);
            inside_144.inside_Line_144[46].gameObject.SetActive(false);
            inside_144.inside_Line_144[47].gameObject.SetActive(false);
            inside_144.inside_Line_144[48].gameObject.SetActive(false);
            inside_144.inside_Line_144[49].gameObject.SetActive(false);
            inside_144.inside_Line_144[50].gameObject.SetActive(false);
            inside_144.inside_Line_144[51].gameObject.SetActive(false);
            inside_144.inside_Line_144[52].gameObject.SetActive(false);
            inside_144.inside_Line_144[53].gameObject.SetActive(false);
            inside_144.inside_Line_144[54].gameObject.SetActive(false);
            inside_144.inside_Line_144[55].gameObject.SetActive(false);
            inside_144.inside_Line_144[56].gameObject.SetActive(false);
            inside_144.inside_Line_144[57].gameObject.SetActive(false);
            inside_144.inside_Line_144[58].gameObject.SetActive(false);
            inside_144.inside_Line_144[59].gameObject.SetActive(false);
            inside_144.inside_Line_144[60].gameObject.SetActive(false);
            inside_144.inside_Line_144[62].gameObject.SetActive(false);
            inside_144.inside_Line_144[63].gameObject.SetActive(false);
            inside_144.inside_Line_144[64].gameObject.SetActive(false);
            inside_144.inside_Line_144[65].gameObject.SetActive(false);
            inside_144.inside_Line_144[66].gameObject.SetActive(false);
            inside_144.inside_Line_144[67].gameObject.SetActive(false);
            inside_144.inside_Line_144[68].gameObject.SetActive(false);

            //145
            inside_145.Line_145_Index = 0;
            inside_145.inside_Line_145[0].gameObject.SetActive(false);
            inside_145.inside_Line_145[1].gameObject.SetActive(false);
            inside_145.inside_Line_145[2].gameObject.SetActive(false);
            inside_145.inside_Line_145[3].gameObject.SetActive(false);
            inside_145.inside_Line_145[4].gameObject.SetActive(false);
            inside_145.inside_Line_145[5].gameObject.SetActive(false);
            inside_145.inside_Line_145[6].gameObject.SetActive(false);
            inside_145.inside_Line_145[7].gameObject.SetActive(false);
            inside_145.inside_Line_145[8].gameObject.SetActive(false);
            inside_145.inside_Line_145[9].gameObject.SetActive(false);
            inside_145.inside_Line_145[10].gameObject.SetActive(false);
            inside_145.inside_Line_145[11].gameObject.SetActive(false);
            inside_145.inside_Line_145[12].gameObject.SetActive(false);
            inside_145.inside_Line_145[13].gameObject.SetActive(false);
            inside_145.inside_Line_145[14].gameObject.SetActive(false);
            inside_145.inside_Line_145[15].gameObject.SetActive(false);
            inside_145.inside_Line_145[16].gameObject.SetActive(false);
            inside_145.inside_Line_145[17].gameObject.SetActive(false);
            inside_145.inside_Line_145[18].gameObject.SetActive(false);
            inside_145.inside_Line_145[19].gameObject.SetActive(false);
            inside_145.inside_Line_145[20].gameObject.SetActive(false);
            inside_145.inside_Line_145[21].gameObject.SetActive(false);
            inside_145.inside_Line_145[22].gameObject.SetActive(false);
            inside_145.inside_Line_145[23].gameObject.SetActive(false);
            inside_145.inside_Line_145[24].gameObject.SetActive(false);
            inside_145.inside_Line_145[25].gameObject.SetActive(false);
            inside_145.inside_Line_145[26].gameObject.SetActive(false);
            inside_145.inside_Line_145[27].gameObject.SetActive(false);
            inside_145.inside_Line_145[28].gameObject.SetActive(false);
            inside_145.inside_Line_145[29].gameObject.SetActive(false);
            inside_145.inside_Line_145[30].gameObject.SetActive(false);
            inside_145.inside_Line_145[31].gameObject.SetActive(false);
            inside_145.inside_Line_145[32].gameObject.SetActive(false);
            inside_145.inside_Line_145[33].gameObject.SetActive(false);
            inside_145.inside_Line_145[34].gameObject.SetActive(false);
            inside_145.inside_Line_145[35].gameObject.SetActive(false);
            inside_145.inside_Line_145[36].gameObject.SetActive(false);
            inside_145.inside_Line_145[37].gameObject.SetActive(false);
            inside_145.inside_Line_145[38].gameObject.SetActive(false);
            inside_145.inside_Line_145[39].gameObject.SetActive(false);
            inside_145.inside_Line_145[40].gameObject.SetActive(false);
            inside_145.inside_Line_145[41].gameObject.SetActive(false);
            inside_145.inside_Line_145[42].gameObject.SetActive(false);
            inside_145.inside_Line_145[43].gameObject.SetActive(false);
            inside_145.inside_Line_145[44].gameObject.SetActive(false);
            inside_145.inside_Line_145[45].gameObject.SetActive(false);
            inside_145.inside_Line_145[46].gameObject.SetActive(false);
            inside_145.inside_Line_145[47].gameObject.SetActive(false);
            inside_145.inside_Line_145[48].gameObject.SetActive(false);
            inside_145.inside_Line_145[49].gameObject.SetActive(false);
            inside_145.inside_Line_145[50].gameObject.SetActive(false);
            inside_145.inside_Line_145[51].gameObject.SetActive(false);
            inside_145.inside_Line_145[52].gameObject.SetActive(false);
            inside_145.inside_Line_145[53].gameObject.SetActive(false);
            inside_145.inside_Line_145[54].gameObject.SetActive(false);
            inside_145.inside_Line_145[55].gameObject.SetActive(false);
            inside_145.inside_Line_145[56].gameObject.SetActive(false);
            inside_145.inside_Line_145[57].gameObject.SetActive(false);
            inside_145.inside_Line_145[58].gameObject.SetActive(false);
            inside_145.inside_Line_145[59].gameObject.SetActive(false);
            inside_145.inside_Line_145[60].gameObject.SetActive(false);
            inside_145.inside_Line_145[62].gameObject.SetActive(false);
            inside_145.inside_Line_145[63].gameObject.SetActive(false);
            inside_145.inside_Line_145[64].gameObject.SetActive(false);
            inside_145.inside_Line_145[65].gameObject.SetActive(false);
            inside_145.inside_Line_145[66].gameObject.SetActive(false);
            inside_145.inside_Line_145[67].gameObject.SetActive(false);

            //146
            inside_146.Line_146_Index = 0;
            inside_146.inside_Line_146[0].gameObject.SetActive(false);
            inside_146.inside_Line_146[1].gameObject.SetActive(false);
            inside_146.inside_Line_146[2].gameObject.SetActive(false);
            inside_146.inside_Line_146[3].gameObject.SetActive(false);
            inside_146.inside_Line_146[4].gameObject.SetActive(false);
            inside_146.inside_Line_146[5].gameObject.SetActive(false);
            inside_146.inside_Line_146[6].gameObject.SetActive(false);
            inside_146.inside_Line_146[7].gameObject.SetActive(false);
            inside_146.inside_Line_146[8].gameObject.SetActive(false);
            inside_146.inside_Line_146[9].gameObject.SetActive(false);
            inside_146.inside_Line_146[10].gameObject.SetActive(false);
            inside_146.inside_Line_146[11].gameObject.SetActive(false);
            inside_146.inside_Line_146[12].gameObject.SetActive(false);
            inside_146.inside_Line_146[13].gameObject.SetActive(false);
            inside_146.inside_Line_146[14].gameObject.SetActive(false);
            inside_146.inside_Line_146[15].gameObject.SetActive(false);
            inside_146.inside_Line_146[16].gameObject.SetActive(false);
            inside_146.inside_Line_146[17].gameObject.SetActive(false);
            inside_146.inside_Line_146[18].gameObject.SetActive(false);
            inside_146.inside_Line_146[19].gameObject.SetActive(false);
            inside_146.inside_Line_146[20].gameObject.SetActive(false);
            inside_146.inside_Line_146[21].gameObject.SetActive(false);
            inside_146.inside_Line_146[22].gameObject.SetActive(false);
            inside_146.inside_Line_146[23].gameObject.SetActive(false);
            inside_146.inside_Line_146[24].gameObject.SetActive(false);
            inside_146.inside_Line_146[25].gameObject.SetActive(false);
            inside_146.inside_Line_146[26].gameObject.SetActive(false);
            inside_146.inside_Line_146[27].gameObject.SetActive(false);
            inside_146.inside_Line_146[28].gameObject.SetActive(false);
            inside_146.inside_Line_146[29].gameObject.SetActive(false);
            inside_146.inside_Line_146[30].gameObject.SetActive(false);
            inside_146.inside_Line_146[31].gameObject.SetActive(false);
            inside_146.inside_Line_146[32].gameObject.SetActive(false);
            inside_146.inside_Line_146[33].gameObject.SetActive(false);
            inside_146.inside_Line_146[34].gameObject.SetActive(false);
            inside_146.inside_Line_146[35].gameObject.SetActive(false);
            inside_146.inside_Line_146[36].gameObject.SetActive(false);
            inside_146.inside_Line_146[37].gameObject.SetActive(false);
            inside_146.inside_Line_146[38].gameObject.SetActive(false);
            inside_146.inside_Line_146[39].gameObject.SetActive(false);
            inside_146.inside_Line_146[40].gameObject.SetActive(false);
            inside_146.inside_Line_146[41].gameObject.SetActive(false);
            inside_146.inside_Line_146[42].gameObject.SetActive(false);
            inside_146.inside_Line_146[43].gameObject.SetActive(false);
            inside_146.inside_Line_146[44].gameObject.SetActive(false);
            inside_146.inside_Line_146[45].gameObject.SetActive(false);
            inside_146.inside_Line_146[46].gameObject.SetActive(false);
            inside_146.inside_Line_146[47].gameObject.SetActive(false);
            inside_146.inside_Line_146[48].gameObject.SetActive(false);
            inside_146.inside_Line_146[49].gameObject.SetActive(false);
            inside_146.inside_Line_146[50].gameObject.SetActive(false);
            inside_146.inside_Line_146[51].gameObject.SetActive(false);
            inside_146.inside_Line_146[52].gameObject.SetActive(false);
            inside_146.inside_Line_146[53].gameObject.SetActive(false);
            inside_146.inside_Line_146[54].gameObject.SetActive(false);
            inside_146.inside_Line_146[55].gameObject.SetActive(false);
            inside_146.inside_Line_146[56].gameObject.SetActive(false);
            inside_146.inside_Line_146[57].gameObject.SetActive(false);
            inside_146.inside_Line_146[58].gameObject.SetActive(false);
            inside_146.inside_Line_146[59].gameObject.SetActive(false);
            inside_146.inside_Line_146[60].gameObject.SetActive(false);
            inside_146.inside_Line_146[62].gameObject.SetActive(false);
            inside_146.inside_Line_146[63].gameObject.SetActive(false);
            inside_146.inside_Line_146[64].gameObject.SetActive(false);
            inside_146.inside_Line_146[65].gameObject.SetActive(false);
            inside_146.inside_Line_146[66].gameObject.SetActive(false);
            inside_146.inside_Line_146[67].gameObject.SetActive(false);
            inside_146.inside_Line_146[68].gameObject.SetActive(false);

            //라인 순서 가져오고

            int Auto_Line_Index = PlayerPrefs.GetInt("Auto_Index");


            Debug.Log(Auto_Line_Index + "라인 불러오기");

            questObject.Line_Index = Auto_Line_Index;
            questObject.questObject[Auto_Line_Index].gameObject.SetActive(true);



            

            if (Auto_Line_Index == 0)
            {
                inside_0.NewCoroutine();

                //inside_0.m_Coroutine = inside_0.NewCoroutine();
                //StartCoroutine(inside_0.m_Coroutine);
                Debug.Log("0 리셋하자");
            }

            if (Auto_Line_Index == 3)
            {


                questObject.Go_Thrid_Line();//원래 있던 거

                inside_1.NewCoroutine();//새로 만든 거


                //inside_1.m_Coroutine = inside_1.NewCoroutine();
                //StartCoroutine(inside_1.m_Coroutine);
                Debug.Log("1같은 3 리셋하자");
            }

            if (Auto_Line_Index == 4)
            {
                questObject.Go_Fourth_Line();
                inside_2.NewCoroutine();

                //inside_2.m_Coroutine = inside_2.NewCoroutine();
                //StartCoroutine(inside_2.m_Coroutine);
                Debug.Log("2같은 4 리셋하자");
            }

            if (Auto_Line_Index == 5)
            {
                questObject.Go_Fifth_Line();

                inside_5.NewCoroutine();
                //inside_5.m_Coroutine = inside_5.NewCoroutine();
                //StartCoroutine(inside_5.m_Coroutine);
                Debug.Log("5번째 리셋하자");
            }

            if (Auto_Line_Index == 6)
            {
                questObject.Go_Six_Line();

                inside_8.NewCoroutine();
                //inside_8.m_Coroutine = inside_8.NewCoroutine();
                //StartCoroutine(inside_8.m_Coroutine);
                Debug.Log("6번째 리셋하자");
            }

            if (Auto_Line_Index == 7)
            {
                questObject.Go_Seven_Line();

                inside_5.NewCoroutine();
                //inside_5.m_Coroutine = inside_5.NewCoroutine();
                //StartCoroutine(inside_5.m_Coroutine);
                Debug.Log("7번째 리셋하자");
            }

            if (Auto_Line_Index == 8)
            {
                

                questObject.Go_Eight_Line();
                inside_8.NewCoroutine();
                //inside_8.m_Coroutine = inside_8.NewCoroutine();
                //StartCoroutine(inside_8.m_Coroutine);
                Debug.Log("8번째 리셋하자");
            }

            if (Auto_Line_Index == 9)
            {
                questObject.Go_Nine_Line();

                inside_9.NewCoroutine();
                //inside_9.m_Coroutine = inside_9.NewCoroutine();
                //StartCoroutine(inside_9.m_Coroutine);
                Debug.Log("9번째 리셋하자");
            }

            if (Auto_Line_Index == 10)
            {
                questObject.Go_Ten_Line();

                inside_9.NewCoroutine();
                //inside_9.m_Coroutine = inside_9.NewCoroutine();
                //StartCoroutine(inside_9.m_Coroutine);
                Debug.Log("10번째 리셋하자");
            }

            if (Auto_Line_Index == 11)
            {
                questObject.Go_Eleven_Line();
                inside_11.NewCoroutine();

                //inside_11.m_Coroutine = inside_11.NewCoroutine();
                //StartCoroutine(inside_11.m_Coroutine);
                Debug.Log("11번째 리셋하자");
            }

            if (Auto_Line_Index == 12)
            {
                questObject.Go_Twelve_Line();
                inside_11.NewCoroutine();

                /*inside_11.m_Coroutine = inside_11.NewCoroutine();
                StartCoroutine(inside_11.m_Coroutine);*/
                Debug.Log("12번째 리셋하자");
            }

            if (Auto_Line_Index == 13)
            {
                questObject.Go_Thirteen_Line();
                inside_13.NewCoroutine();

                //inside_13.m_Coroutine = inside_13.NewCoroutine();
                //StartCoroutine(inside_13.m_Coroutine);
                Debug.Log("13번째 리셋하자");
            }

            if (Auto_Line_Index == 14)
            {
                questObject.Go_Fourteen_Line();
                inside_13.NewCoroutine();

                //inside_13.m_Coroutine = inside_13.NewCoroutine();
                //StartCoroutine(inside_13.m_Coroutine);
                Debug.Log("14번째 리셋하자");
            }

            if (Auto_Line_Index == 15)
            {
                questObject.Go_Fifteen_Line();
                inside_15.NewCoroutine();

                //inside_15.m_Coroutine = inside_15.NewCoroutine();
                //StartCoroutine(inside_15.m_Coroutine);
                Debug.Log("15번째 리셋하자");
            }

            if (Auto_Line_Index == 16)
            {
                questObject.Go_Sixteen_Line();

                inside_15.NewCoroutine();
                //inside_15.m_Coroutine = inside_15.NewCoroutine();
                //StartCoroutine(inside_15.m_Coroutine);
                Debug.Log("16번째 리셋하자");
            }

            if (Auto_Line_Index == 17)
            {
                questObject.Go_Seventeen_Line();
                inside_17.NewCoroutine();

                //inside_17.m_Coroutine = inside_17.NewCoroutine();
                //StartCoroutine(inside_17.m_Coroutine);
                Debug.Log("17번째 리셋하자");
            }

            if (Auto_Line_Index == 18)
            {
                questObject.Go_Eighteen_Line();
                inside_17.NewCoroutine();

                //inside_17.m_Coroutine = inside_17.NewCoroutine();
                //StartCoroutine(inside_17.m_Coroutine);
                Debug.Log("18번째 리셋하자");
            }

            if (Auto_Line_Index == 19)
            {
                questObject.Go_Nineteen_Line();
                inside_19.NewCoroutine();

                //inside_19.m_Coroutine = inside_19.NewCoroutine();
                //StartCoroutine(inside_19.m_Coroutine);
                Debug.Log("19번째 리셋하자");
            }

            if (Auto_Line_Index == 20)
            {
                questObject.Go_Twenty_Line();
                inside_19.NewCoroutine();


                //inside_19.m_Coroutine = inside_19.NewCoroutine();
                //StartCoroutine(inside_19.m_Coroutine);
                Debug.Log("20번째 리셋하자");
            }

            if (Auto_Line_Index == 21)
            {
                questObject.Go_TwentyOne_Line();
                inside_21.NewCoroutine();

                //inside_21.m_Coroutine = inside_21.NewCoroutine();
                //StartCoroutine(inside_21.m_Coroutine);
                Debug.Log("21번째 리셋하자");
            }

            if (Auto_Line_Index == 22)
            {
                questObject.Go_TwentyTwo_Line();
                inside_21.NewCoroutine();

                //inside_21.m_Coroutine = inside_21.NewCoroutine();
                //StartCoroutine(inside_21.m_Coroutine);
                Debug.Log("22번째 리셋하자");
            }

            if (Auto_Line_Index == 23)
            {
                questObject.Go_TwentyThree_Line();
                inside_23.NewCoroutine();

                //inside_23.m_Coroutine = inside_23.NewCoroutine();
                //StartCoroutine(inside_23.m_Coroutine);
                Debug.Log("23번째 리셋하자");
            }

            if (Auto_Line_Index == 24)
            {
                questObject.Go_TwentyFour_Line();
                inside_23.NewCoroutine();

                //inside_23.m_Coroutine = inside_23.NewCoroutine();
                //StartCoroutine(inside_23.m_Coroutine);
                Debug.Log("24번째 리셋하자");
            }

            if (Auto_Line_Index == 25)
            {
                questObject.Go_TwentyFive_Line();
                inside_25.NewCoroutine();

                //inside_25.m_Coroutine = inside_25.NewCoroutine();
                //StartCoroutine(inside_25.m_Coroutine);
                Debug.Log("25번째 리셋하자");
            }

            if (Auto_Line_Index == 26)
            {
                questObject.Go_TwentySix_Line();
                inside_25.NewCoroutine();

                //inside_25.m_Coroutine = inside_25.NewCoroutine();
                //StartCoroutine(inside_25.m_Coroutine);
                Debug.Log("26번째 리셋하자");
            }

            if (Auto_Line_Index == 27)
            {
                questObject.Go_TwentySeven_Line();
                inside_25.NewCoroutine();

                //inside_25.m_Coroutine = inside_25.NewCoroutine();
                //StartCoroutine(inside_25.m_Coroutine);
                Debug.Log("27번째 리셋하자");
            }

            if (Auto_Line_Index == 28)
            {
                questObject.Go_TwentyEight_Line();
                inside_25.NewCoroutine();

                //inside_25.m_Coroutine = inside_25.NewCoroutine();
                //StartCoroutine(inside_25.m_Coroutine);
                Debug.Log("28번째 리셋하자");
            }

            if (Auto_Line_Index == 29)
            {
                questObject.Go_TwentyNine_Line();
                inside_29.NewCoroutine();

                //inside_29.m_Coroutine = inside_29.NewCoroutine();
                //StartCoroutine(inside_29.m_Coroutine);
                Debug.Log("29번째 리셋하자");
            }

            if (Auto_Line_Index == 30)
            {
                questObject.Go_Thirty_Line();
                inside_29.NewCoroutine();

                //inside_29.m_Coroutine = inside_29.NewCoroutine();
                //StartCoroutine(inside_29.m_Coroutine);
                Debug.Log("30번째 리셋하자");
            }

            if (Auto_Line_Index == 31)
            {
                questObject.Go_ThirtyOne_Line();
                inside_29.NewCoroutine();

                //inside_29.m_Coroutine = inside_29.NewCoroutine();
                //StartCoroutine(inside_29.m_Coroutine);
                Debug.Log("31번째 리셋하자");
            }

            if (Auto_Line_Index == 32)
            {
                questObject.Go_ThirtyTwo_Line();
                inside_29.NewCoroutine();

                //inside_29.m_Coroutine = inside_29.NewCoroutine();
                //StartCoroutine(inside_29.m_Coroutine);
                Debug.Log("32번째 리셋하자");
            }

            if (Auto_Line_Index == 33)
            {
                questObject.Go_ThirtyThree_Line();
                inside_34.NewCoroutine();

                //inside_34.m_Coroutine = inside_34.NewCoroutine();
                //StartCoroutine(inside_34.m_Coroutine);
                Debug.Log("33번째 리셋하자");
            }

            if (Auto_Line_Index == 34)
            {
                questObject.Go_ThirtyFour_Line();
                inside_34.NewCoroutine();

                //inside_34.m_Coroutine = inside_34.NewCoroutine();
                //StartCoroutine(inside_34.m_Coroutine);
                Debug.Log("34번째 리셋하자");
            }

            if (Auto_Line_Index == 35)
            {
                questObject.Go_ThirtyFive_Line();
                inside_34.NewCoroutine();

                //inside_34.m_Coroutine = inside_34.NewCoroutine();
                //StartCoroutine(inside_34.m_Coroutine);
                Debug.Log("35번째 리셋하자");
            }

            if (Auto_Line_Index == 36)
            {
                questObject.Go_ThirtySix_Line();
                inside_34.NewCoroutine();

                //inside_34.m_Coroutine = inside_34.NewCoroutine();
                //StartCoroutine(inside_34.m_Coroutine);
                Debug.Log("36번째 리셋하자");
            }

            if (Auto_Line_Index == 37)
            {
                questObject.Go_ThirtySeven_Line();
                inside_37.NewCoroutine();

                //inside_37.m_Coroutine = inside_37.NewCoroutine();
                //StartCoroutine(inside_37.m_Coroutine);
                Debug.Log("37번째 리셋하자");
            }

            if (Auto_Line_Index == 38)
            {
                questObject.Go_ThirtyEight_Line();
                inside_37.NewCoroutine();

                //inside_37.m_Coroutine = inside_37.NewCoroutine();
                //StartCoroutine(inside_37.m_Coroutine);
                Debug.Log("38번째 리셋하자");
            }

            if (Auto_Line_Index == 39)
            {
                questObject.Go_ThirtyNine_Line();
                inside_37.NewCoroutine();

                //inside_37.m_Coroutine = inside_37.NewCoroutine();
                //StartCoroutine(inside_37.m_Coroutine);
                Debug.Log("39번째 리셋하자");
            }

            if (Auto_Line_Index == 40)
            {
                questObject.Go_Forty_Line();
                inside_37.NewCoroutine();

                //inside_37.m_Coroutine = inside_37.NewCoroutine();
                //StartCoroutine(inside_37.m_Coroutine);
                Debug.Log("40번째 리셋하자");
            }

            if (Auto_Line_Index == 41)
            {
                questObject.Go_41_Line();
                inside_41.NewCoroutine();

                //inside_41.m_Coroutine = inside_41.NewCoroutine();
                //StartCoroutine(inside_41.m_Coroutine);
                Debug.Log("41번째 리셋하자");
            }

            if (Auto_Line_Index == 42)
            {
                questObject.Go_42_Line();
                inside_41.NewCoroutine();

                //inside_41.m_Coroutine = inside_41.NewCoroutine();
                //StartCoroutine(inside_41.m_Coroutine);
                Debug.Log("42번째 리셋하자");
            }

            if (Auto_Line_Index == 43)
            {
                questObject.Go_43_Line();
                inside_41.NewCoroutine();

                //inside_41.m_Coroutine = inside_41.NewCoroutine();
                //StartCoroutine(inside_41.m_Coroutine);
                Debug.Log("43번째 리셋하자");
            }

            if (Auto_Line_Index == 44)
            {
                questObject.Go_44_Line();
                inside_41.NewCoroutine();

                //inside_41.m_Coroutine = inside_41.NewCoroutine();
                //StartCoroutine(inside_41.m_Coroutine);
                Debug.Log("44번째 리셋하자");
            }

            if (Auto_Line_Index == 45)
            {
                questObject.Go_45_Line();
                inside_45.NewCoroutine();

                //inside_45.m_Coroutine = inside_45.NewCoroutine();
                //StartCoroutine(inside_45.m_Coroutine);
                Debug.Log("45번째 리셋하자");
            }

            if (Auto_Line_Index == 46)
            {
                questObject.Go_46_Line();
                inside_45.NewCoroutine();

                //inside_45.m_Coroutine = inside_45.NewCoroutine();
                //StartCoroutine(inside_45.m_Coroutine);
                Debug.Log("46번째 리셋하자");
            }

            if (Auto_Line_Index == 47)
            {
                questObject.Go_47_Line();
                inside_45.NewCoroutine();

                //inside_45.m_Coroutine = inside_45.NewCoroutine();
                //StartCoroutine(inside_45.m_Coroutine);
                Debug.Log("47번째 리셋하자");
            }

            if (Auto_Line_Index == 48)
            {
                questObject.Go_48_Line();
                inside_45.NewCoroutine();

                //inside_45.m_Coroutine = inside_45.NewCoroutine();
                //StartCoroutine(inside_45.m_Coroutine);
                Debug.Log("48번째 리셋하자");
            }

            if (Auto_Line_Index == 49)
            {
                questObject.Go_49_Line();
                inside_49.NewCoroutine();

                //inside_49.m_Coroutine = inside_49.NewCoroutine();
                //StartCoroutine(inside_49.m_Coroutine);
                Debug.Log("49번째 리셋하자");
            }

            if (Auto_Line_Index == 50)
            {
                questObject.Go_50_Line();
                inside_49.NewCoroutine();

                //inside_49.m_Coroutine = inside_49.NewCoroutine();
                //StartCoroutine(inside_49.m_Coroutine);
                Debug.Log("50번째 리셋하자");
            }

            if (Auto_Line_Index == 51)
            {
                questObject.Go_51_Line();
                inside_49.NewCoroutine();

                //inside_49.m_Coroutine = inside_49.NewCoroutine();
                //StartCoroutine(inside_49.m_Coroutine);
                Debug.Log("51번째 리셋하자");
            }

            if (Auto_Line_Index == 52)
            {
                questObject.Go_52_Line();
                inside_49.NewCoroutine();

                //inside_49.m_Coroutine = inside_49.NewCoroutine();
                //StartCoroutine(inside_49.m_Coroutine);
                Debug.Log("52번째 리셋하자");
            }


            if (Auto_Line_Index == 53)
            {
                questObject.Go_53_Line();
                inside_53.NewCoroutine();

                //inside_53.m_Coroutine = inside_53.NewCoroutine();
                //StartCoroutine(inside_53.m_Coroutine);
                Debug.Log("53번째 리셋하자");
            }

            if (Auto_Line_Index == 54)
            {
                questObject.Go_54_Line();
                inside_53.NewCoroutine();

                //inside_53.m_Coroutine = inside_53.NewCoroutine();
                //StartCoroutine(inside_53.m_Coroutine);
                Debug.Log("54번째 리셋하자");
            }

            if (Auto_Line_Index == 55)
            {
                questObject.Go_55_Line();
                inside_53.NewCoroutine();

                //inside_53.m_Coroutine = inside_53.NewCoroutine();
                //StartCoroutine(inside_53.m_Coroutine);
                Debug.Log("55번째 리셋하자");
            }

            if (Auto_Line_Index == 56)
            {
                questObject.Go_56_Line();
                inside_53.NewCoroutine();

                //inside_53.m_Coroutine = inside_53.NewCoroutine();
                //StartCoroutine(inside_53.m_Coroutine);
                Debug.Log("56번째 리셋하자");
            }

            if (Auto_Line_Index == 57)
            {
                questObject.Go_57_Line();
                inside_57.NewCoroutine();

                //inside_57.m_Coroutine = inside_57.NewCoroutine();
                //StartCoroutine(inside_57.m_Coroutine);
                Debug.Log("57번째 리셋하자");
            }

            if (Auto_Line_Index == 58)
            {
                questObject.Go_58_Line();
                inside_57.NewCoroutine();

                //inside_57.m_Coroutine = inside_57.NewCoroutine();
                //StartCoroutine(inside_57.m_Coroutine);
                Debug.Log("58번째 리셋하자");
            }

            if (Auto_Line_Index == 59)
            {
                questObject.Go_59_Line();
                inside_57.NewCoroutine();

                //inside_57.m_Coroutine = inside_57.NewCoroutine();
                //StartCoroutine(inside_57.m_Coroutine);
                Debug.Log("59번째 리셋하자");
            }

            if (Auto_Line_Index == 60)
            {
                questObject.Go_60_Line();
                inside_57.NewCoroutine();

                //inside_57.m_Coroutine = inside_57.NewCoroutine();
                //StartCoroutine(inside_57.m_Coroutine);
                Debug.Log("60번째 리셋하자");
            }

            if (Auto_Line_Index == 61)
            {
                questObject.Go_61_Line();
                inside_61.NewCoroutine();

                //inside_61.m_Coroutine = inside_61.NewCoroutine();
                //StartCoroutine(inside_61.m_Coroutine);
                Debug.Log("61번째 리셋하자");
            }

            if (Auto_Line_Index == 62)
            {
                questObject.Go_62_Line();
                inside_61.NewCoroutine();

                //inside_61.m_Coroutine = inside_61.NewCoroutine();
                //StartCoroutine(inside_61.m_Coroutine);
                Debug.Log("62번째 리셋하자");
            }

            if (Auto_Line_Index == 63)
            {
                questObject.Go_63_Line();
                inside_61.NewCoroutine();

                //inside_61.m_Coroutine = inside_61.NewCoroutine();
                //StartCoroutine(inside_61.m_Coroutine);
                Debug.Log("63번째 리셋하자");
            }

            if (Auto_Line_Index == 64)
            {
                questObject.Go_64_Line();
                inside_61.NewCoroutine();

                //inside_61.m_Coroutine = inside_61.NewCoroutine();
                //StartCoroutine(inside_61.m_Coroutine);
                Debug.Log("64번째 리셋하자");
            }

            if (Auto_Line_Index == 65)
            {
                questObject.Go_65_Line();
                inside_65.NewCoroutine();

                //inside_65.m_Coroutine = inside_65.NewCoroutine();
                //StartCoroutine(inside_65.m_Coroutine);
                Debug.Log("65번째 리셋하자");
            }

            if (Auto_Line_Index == 66)
            {
                questObject.Go_66_Line();
                inside_65.NewCoroutine();

                //inside_65.m_Coroutine = inside_65.NewCoroutine();
                //StartCoroutine(inside_65.m_Coroutine);
                Debug.Log("66번째 리셋하자");
            }

            if (Auto_Line_Index == 67)
            {
                questObject.Go_67_Line();
                inside_65.NewCoroutine();

                //inside_65.m_Coroutine = inside_65.NewCoroutine();
                //StartCoroutine(inside_65.m_Coroutine);
                Debug.Log("67번째 리셋하자");
            }

            if (Auto_Line_Index == 68)
            {
                questObject.Go_68_Line();
                inside_65.NewCoroutine();

                //inside_65.m_Coroutine = inside_65.NewCoroutine();
                //StartCoroutine(inside_65.m_Coroutine);
                Debug.Log("68번째 리셋하자");
            }

            if (Auto_Line_Index == 69)
            {
                questObject.Go_69_Line();
                inside_69.NewCoroutine();

                //inside_69.m_Coroutine = inside_69.NewCoroutine();
                //StartCoroutine(inside_69.m_Coroutine);
                Debug.Log("69번째 리셋하자");
            }

            if (Auto_Line_Index == 70)
            {
                questObject.Go_70_Line();
                inside_69.NewCoroutine();

                //inside_69.m_Coroutine = inside_69.NewCoroutine();
                //StartCoroutine(inside_69.m_Coroutine);
                Debug.Log("70번째 리셋하자");
            }

            if (Auto_Line_Index == 71)
            {
                questObject.Go_71_Line();
                inside_69.NewCoroutine();

                //inside_69.m_Coroutine = inside_69.NewCoroutine();
                //StartCoroutine(inside_69.m_Coroutine);
                Debug.Log("71번째 리셋하자");
            }

            if (Auto_Line_Index == 72)
            {
                questObject.Go_72_Line();
                inside_69.NewCoroutine();

                //inside_69.m_Coroutine = inside_69.NewCoroutine();
                //StartCoroutine(inside_69.m_Coroutine);
                Debug.Log("72번째 리셋하자");
            }

            if (Auto_Line_Index == 73)
            {
                questObject.Go_73_Line();
                inside_73.WaitSecond_0();

                //inside_73.m_Coroutine = inside_73.WaitSecond_0();
                //StartCoroutine(inside_73.m_Coroutine);
                Debug.Log("73번째 리셋하자");
            }

            if (Auto_Line_Index == 74)
            {
                questObject.Go_74_Line();
                inside_73.WaitSecond_0();

                //inside_73.m_Coroutine = inside_73.WaitSecond_0();
                //StartCoroutine(inside_73.m_Coroutine);
                Debug.Log("74번째 리셋하자");
            }

            if (Auto_Line_Index == 75)
            {
                questObject.Go_75_Line();
                inside_73.WaitSecond_0();

                //inside_73.m_Coroutine = inside_73.WaitSecond_0();
                //StartCoroutine(inside_73.m_Coroutine);
                Debug.Log("75번째 리셋하자");
            }

            if (Auto_Line_Index == 76)
            {
                questObject.Go_76_Line();
                inside_73.WaitSecond_0();

                //inside_73.m_Coroutine = inside_73.WaitSecond_0();
                //StartCoroutine(inside_73.m_Coroutine);
                Debug.Log("76번째 리셋하자");
            }

            if (Auto_Line_Index == 77)
            {
                questObject.Go_77_Line();
                inside_77.WaitSecond_0();

                //inside_77.m_Coroutine = inside_77.WaitSecond_0();
                //StartCoroutine(inside_77.m_Coroutine);
                Debug.Log("77번째 리셋하자");
            }

            if (Auto_Line_Index == 78)
            {
                questObject.Go_78_Line();
                inside_77.WaitSecond_0();

                //inside_77.m_Coroutine = inside_77.WaitSecond_0();
                //StartCoroutine(inside_77.m_Coroutine);
                Debug.Log("78번째 리셋하자");
            }

            if (Auto_Line_Index == 79)
            {
                questObject.Go_79_Line();
                inside_77.WaitSecond_0();

                //inside_77.m_Coroutine = inside_77.WaitSecond_0();
                //StartCoroutine(inside_77.m_Coroutine);
                Debug.Log("79번째 리셋하자");
            }

            if (Auto_Line_Index == 80)
            {
                questObject.Go_80_Line();
                inside_77.WaitSecond_0();

                //inside_77.m_Coroutine = inside_77.WaitSecond_0();
                //StartCoroutine(inside_77.m_Coroutine);
                Debug.Log("80번째 리셋하자");
            }

            if (Auto_Line_Index == 81)
            {
                questObject.Go_81_Line();
                inside_81.WaitSecond_0();

                //inside_81.m_Coroutine = inside_81.WaitSecond_0();
                //StartCoroutine(inside_81.m_Coroutine);
                Debug.Log("81번째 리셋하자");
            }

            if (Auto_Line_Index == 82)
            {
                questObject.Go_82_Line();
                inside_81.WaitSecond_0();

                //inside_81.m_Coroutine = inside_81.WaitSecond_0();
                //StartCoroutine(inside_81.m_Coroutine);
                Debug.Log("82번째 리셋하자");
            }

            if (Auto_Line_Index == 83)
            {
                questObject.Go_83_Line();
                inside_81.WaitSecond_0();

                //inside_81.m_Coroutine = inside_81.WaitSecond_0();
                //StartCoroutine(inside_81.m_Coroutine);
                Debug.Log("83번째 리셋하자");
            }

            if (Auto_Line_Index == 84)
            {
                questObject.Go_84_Line();
                inside_81.WaitSecond_0();

                //inside_81.m_Coroutine = inside_81.WaitSecond_0();
                //StartCoroutine(inside_81.m_Coroutine);
                Debug.Log("84번째 리셋하자");
            }

            if (Auto_Line_Index == 85)
            {
                questObject.Go_85_Line();
                inside_85.WaitSecond_0();

                //inside_85.m_Coroutine = inside_85.WaitSecond_0();
                //StartCoroutine(inside_85.m_Coroutine);
                Debug.Log("85번째 리셋하자");
            }

            if (Auto_Line_Index == 86)
            {
                questObject.Go_86_Line();
                inside_85.WaitSecond_0();

                //inside_85.m_Coroutine = inside_85.WaitSecond_0();
                //StartCoroutine(inside_85.m_Coroutine);
                Debug.Log("86번째 리셋하자");
            }

            if (Auto_Line_Index == 87)
            {
                questObject.Go_87_Line();
                inside_85.WaitSecond_0();

                //inside_85.m_Coroutine = inside_85.WaitSecond_0();
                //StartCoroutine(inside_85.m_Coroutine);
                Debug.Log("87번째 리셋하자");
            }

            if (Auto_Line_Index == 88)
            {
                questObject.Go_88_Line();
                inside_85.WaitSecond_0();

                //inside_85.m_Coroutine = inside_85.WaitSecond_0();
                //StartCoroutine(inside_85.m_Coroutine);
                Debug.Log("88번째 리셋하자");
            }

            if (Auto_Line_Index == 89)
            {
                questObject.Go_89_Line();
                inside_89.WaitSecond_0();

                //inside_89.m_Coroutine = inside_89.WaitSecond_0();
                //StartCoroutine(inside_89.m_Coroutine);
                Debug.Log("89번째 리셋하자"); ;
            }

            if (Auto_Line_Index == 90)
            {
                questObject.Go_90_Line();
                inside_89.WaitSecond_0();

                //inside_89.m_Coroutine = inside_89.WaitSecond_0();
                //StartCoroutine(inside_89.m_Coroutine);
                Debug.Log("90번째 리셋하자");
            }

            if (Auto_Line_Index == 91)
            {
                questObject.Go_91_Line();
                inside_89.WaitSecond_0();

                //inside_89.m_Coroutine = inside_89.WaitSecond_0();
                //StartCoroutine(inside_89.m_Coroutine);
                Debug.Log("91번째 리셋하자");
            }

            if (Auto_Line_Index == 92)
            {
                questObject.Go_92_Line();
                inside_89.WaitSecond_0();

                //inside_89.m_Coroutine = inside_89.WaitSecond_0();
                //StartCoroutine(inside_89.m_Coroutine);
                Debug.Log("92번째 리셋하자");
            }

            if (Auto_Line_Index == 93)
            {
                questObject.Go_93_Line();
                inside_93.WaitSecond_0();

                //inside_93.m_Coroutine = inside_93.WaitSecond_0();
                //StartCoroutine(inside_93.m_Coroutine);
                Debug.Log("93번째 리셋하자");
            }

            if (Auto_Line_Index == 94)
            {
                questObject.Go_94_Line();
                inside_93.WaitSecond_0();

                //inside_93.m_Coroutine = inside_93.WaitSecond_0();
                //StartCoroutine(inside_93.m_Coroutine);
                Debug.Log("94번째 리셋하자");
            }

            if (Auto_Line_Index == 95)
            {
                questObject.Go_95_Line();
                inside_93.WaitSecond_0();

                //inside_93.m_Coroutine = inside_93.WaitSecond_0();
                //StartCoroutine(inside_93.m_Coroutine);
                Debug.Log("95번째 리셋하자");
            }

            if (Auto_Line_Index == 96)
            {
                questObject.Go_96_Line();
                inside_93.WaitSecond_0();

                //inside_93.m_Coroutine = inside_93.WaitSecond_0();
                //StartCoroutine(inside_93.m_Coroutine);
                Debug.Log("96번째 리셋하자");
            }

            if (Auto_Line_Index == 97)
            {
                questObject.Go_97_Line();
                inside_97.WaitSecond_0();

                //inside_97.m_Coroutine = inside_97.WaitSecond_0();
                //StartCoroutine(inside_97.m_Coroutine);
                Debug.Log("97번째 리셋하자");
            }

            if (Auto_Line_Index == 98)
            {
                questObject.Go_98_Line();
                inside_97.WaitSecond_0();

                //inside_97.m_Coroutine = inside_97.WaitSecond_0();
                //StartCoroutine(inside_97.m_Coroutine);
                Debug.Log("98번째 리셋하자");
            }

            if (Auto_Line_Index == 99)
            {
                questObject.Go_99_Line();
                inside_97.WaitSecond_0();

                //inside_97.m_Coroutine = inside_97.WaitSecond_0();
                //StartCoroutine(inside_97.m_Coroutine);
                Debug.Log("99번째 리셋하자");
            }

            if (Auto_Line_Index == 100)
            {
                questObject.Go_100_Line();
                inside_97.WaitSecond_0();

                //inside_97.m_Coroutine = inside_97.WaitSecond_0();
                //StartCoroutine(inside_97.m_Coroutine);
                Debug.Log("100번째 리셋하자");
            }

            if (Auto_Line_Index == 101)
            {
                questObject.Go_101_Line();
                inside_101.WaitSecond_0();

                //inside_101.m_Coroutine = inside_101.WaitSecond_0();
                //StartCoroutine(inside_101.m_Coroutine);
                Debug.Log("101번째 리셋하자");
            }

            if (Auto_Line_Index == 102)
            {
                questObject.Go_102_Line();
                inside_101.WaitSecond_0();

                //inside_101.m_Coroutine = inside_101.WaitSecond_0();
                //StartCoroutine(inside_101.m_Coroutine);
                Debug.Log("102번째 리셋하자");
            }

            if (Auto_Line_Index == 103)
            {
                questObject.Go_103_Line();
                inside_101.WaitSecond_0();

                //inside_101.m_Coroutine = inside_101.WaitSecond_0();
                //StartCoroutine(inside_101.m_Coroutine);
                Debug.Log("103번째 리셋하자");
            }

            if (Auto_Line_Index == 104)
            {
                questObject.Go_104_Line();
                inside_101.WaitSecond_0();

                //inside_101.m_Coroutine = inside_101.WaitSecond_0();
                //StartCoroutine(inside_101.m_Coroutine);
                Debug.Log("104번째 리셋하자");
            }

            if (Auto_Line_Index == 105)
            {
                questObject.Go_105_Line();
                inside_105.WaitSecond_0();

                //inside_105.m_Coroutine = inside_105.WaitSecond_0();
                //StartCoroutine(inside_105.m_Coroutine);
                Debug.Log("105번째 리셋하자");
            }

            if (Auto_Line_Index == 106)
            {
                questObject.Go_106_Line();
                inside_105.WaitSecond_0();

                //inside_105.m_Coroutine = inside_105.WaitSecond_0();
                //StartCoroutine(inside_105.m_Coroutine);
                Debug.Log("106번째 리셋하자");
            }

            if (Auto_Line_Index == 107)
            {
                questObject.Go_107_Line();
                inside_105.WaitSecond_0();

                //inside_105.m_Coroutine = inside_105.WaitSecond_0();
                //StartCoroutine(inside_105.m_Coroutine);
                Debug.Log("107번째 리셋하자");
            }

            if (Auto_Line_Index == 108)
            {
                questObject.Go_108_Line();
                inside_105.WaitSecond_0();

                //inside_105.m_Coroutine = inside_105.WaitSecond_0();
                //StartCoroutine(inside_105.m_Coroutine);
                Debug.Log("108번째 리셋하자");
            }

            if (Auto_Line_Index == 109)
            {
                questObject.Go_109_Line();
                inside_109.WaitSecond_0();

                //inside_109.m_Coroutine = inside_109.WaitSecond_0();
                //StartCoroutine(inside_109.m_Coroutine);
                Debug.Log("109번째 리셋하자");
            }

            if (Auto_Line_Index == 110)
            {
                questObject.Go_110_Line();
                inside_109.WaitSecond_0();

                //inside_109.m_Coroutine = inside_109.WaitSecond_0();
                //StartCoroutine(inside_109.m_Coroutine);
                Debug.Log("110번째 리셋하자");
            }

            if (Auto_Line_Index == 111)
            {
                questObject.Go_111_Line();
                inside_109.WaitSecond_0();

                //inside_109.m_Coroutine = inside_109.WaitSecond_0();
                //StartCoroutine(inside_109.m_Coroutine);
                Debug.Log("111번째 리셋하자");
            }

            if (Auto_Line_Index == 112)
            {
                questObject.Go_112_Line();
                inside_109.WaitSecond_0();

                //inside_109.m_Coroutine = inside_109.WaitSecond_0();
                //StartCoroutine(inside_109.m_Coroutine);
                Debug.Log("112번째 리셋하자");
            }

            if (Auto_Line_Index == 113)
            {
                questObject.Go_113_Line();
                inside_113.WaitSecond_0();

                //inside_113.m_Coroutine = inside_113.WaitSecond_0();
                //StartCoroutine(inside_113.m_Coroutine);
                Debug.Log("113번째 리셋하자");
            }

            if (Auto_Line_Index == 114)
            {
                questObject.Go_114_Line();
                inside_113.WaitSecond_0();

                //inside_113.m_Coroutine = inside_113.WaitSecond_0();
                //StartCoroutine(inside_113.m_Coroutine);
                Debug.Log("114번째 리셋하자");
            }

            if (Auto_Line_Index == 115)
            {
                questObject.Go_115_Line();
                inside_113.WaitSecond_0();

                //inside_113.m_Coroutine = inside_113.WaitSecond_0();
                //StartCoroutine(inside_113.m_Coroutine);
                Debug.Log("115번째 리셋하자");
            }

            if (Auto_Line_Index == 116)
            {
                questObject.Go_116_Line();
                inside_113.WaitSecond_0();

                //inside_113.m_Coroutine = inside_113.WaitSecond_0();
                //StartCoroutine(inside_113.m_Coroutine);
                Debug.Log("116번째 리셋하자");
            }

            if (Auto_Line_Index == 117)
            {
                questObject.Go_117_Line();
                inside_117.WaitSecond_0();

                //inside_117.m_Coroutine = inside_117.WaitSecond_0();
                //StartCoroutine(inside_117.m_Coroutine);
                Debug.Log("117번째 리셋하자");
            }

            if (Auto_Line_Index == 118)
            {
                questObject.Go_118_Line();
                inside_117.WaitSecond_0();

                //inside_117.m_Coroutine = inside_117.WaitSecond_0();
                //StartCoroutine(inside_117.m_Coroutine);
                Debug.Log("118번째 리셋하자");
            }

            if (Auto_Line_Index == 119)
            {
                questObject.Go_119_Line();
                inside_117.WaitSecond_0();

                //inside_117.m_Coroutine = inside_117.WaitSecond_0();
                //StartCoroutine(inside_117.m_Coroutine);
                Debug.Log("119번째 리셋하자");
            }

            if (Auto_Line_Index == 120)
            {
                questObject.Go_120_Line();
                inside_117.WaitSecond_0();

                //inside_117.m_Coroutine = inside_117.WaitSecond_0();
                //StartCoroutine(inside_117.m_Coroutine);
                Debug.Log("120번째 리셋하자");
            }

            if (Auto_Line_Index == 121)
            {
                questObject.Go_121_Line();
                inside_121.WaitSecond_0();

                //inside_121.m_Coroutine = inside_121.WaitSecond_0();
                //StartCoroutine(inside_121.m_Coroutine);
                Debug.Log("121번째 리셋하자");
            }

            if (Auto_Line_Index == 122)
            {
                questObject.Go_122_Line();
                inside_121.WaitSecond_0();

                //inside_121.m_Coroutine = inside_121.WaitSecond_0();
                //StartCoroutine(inside_121.m_Coroutine);
                Debug.Log("122번째 리셋하자");
            }

            if (Auto_Line_Index == 123)
            {
                questObject.Go_123_Line();
                inside_121.WaitSecond_0();

                //inside_121.m_Coroutine = inside_121.WaitSecond_0();
                //StartCoroutine(inside_121.m_Coroutine);
                Debug.Log("123번째 리셋하자");
            }

            if (Auto_Line_Index == 124)
            {
                questObject.Go_124_Line();
                inside_121.WaitSecond_0();

                //inside_121.m_Coroutine = inside_121.WaitSecond_0();
                //StartCoroutine(inside_121.m_Coroutine);
                Debug.Log("124번째 리셋하자");
            }

            if (Auto_Line_Index == 125)
            {
                questObject.Go_125_Line();
                inside_125.WaitSecond_0();

                //inside_125.m_Coroutine = inside_125.WaitSecond_0();
                //StartCoroutine(inside_125.m_Coroutine);
                Debug.Log("125번째 리셋하자");
            }

            if (Auto_Line_Index == 126)
            {
                questObject.Go_126_Line();
                inside_125.WaitSecond_0();

                //inside_125.m_Coroutine = inside_125.WaitSecond_0();
                //StartCoroutine(inside_125.m_Coroutine);
                Debug.Log("126번째 리셋하자");
            }

            if (Auto_Line_Index == 127)
            {
                questObject.Go_127_Line();
                inside_125.WaitSecond_0();

                //inside_125.m_Coroutine = inside_125.WaitSecond_0();
                //StartCoroutine(inside_125.m_Coroutine);
                Debug.Log("127번째 리셋하자");
            }

            if (Auto_Line_Index == 128)
            {
                questObject.Go_128_Line();
                inside_125.WaitSecond_0();

                //inside_125.m_Coroutine = inside_125.WaitSecond_0();
                //StartCoroutine(inside_125.m_Coroutine);
                Debug.Log("128번째 리셋하자");
            }

            if (Auto_Line_Index == 129)
            {
                questObject.Go_129_Line();
                inside_129.WaitSecond_0();

                //inside_129.m_Coroutine = inside_129.WaitSecond_0();
                //StartCoroutine(inside_129.m_Coroutine);
                Debug.Log("129번째 리셋하자");
            }

            if (Auto_Line_Index == 130)
            {
                questObject.Go_130_Line();
                inside_129.WaitSecond_0();

                //inside_129.m_Coroutine = inside_129.WaitSecond_0();
                //StartCoroutine(inside_129.m_Coroutine);
                Debug.Log("130번째 리셋하자");
            }

            if (Auto_Line_Index == 131)
            {
                questObject.Go_131_Line();
                inside_129.WaitSecond_0();

                //inside_129.m_Coroutine = inside_129.WaitSecond_0();
                //StartCoroutine(inside_129.m_Coroutine);
                Debug.Log("131번째 리셋하자");
            }

            if (Auto_Line_Index == 132)
            {
                questObject.Go_132_Line();
                inside_129.WaitSecond_0();

                //inside_129.m_Coroutine = inside_129.WaitSecond_0();
                //StartCoroutine(inside_129.m_Coroutine);
                Debug.Log("132번째 리셋하자");
            }

            if (Auto_Line_Index == 133)
            {
                questObject.Go_133_Line();
                inside_133.WaitSecond_0();

                //inside_133.m_Coroutine = inside_133.WaitSecond_0();
                //StartCoroutine(inside_133.m_Coroutine);
                Debug.Log("133번째 리셋하자");
            }

            if (Auto_Line_Index == 134)
            {
                questObject.Go_134_Line();
                inside_133.WaitSecond_0();

                //inside_133.m_Coroutine = inside_133.WaitSecond_0();
                //StartCoroutine(inside_133.m_Coroutine);
                Debug.Log("134번째 리셋하자");
            }

            if (Auto_Line_Index == 135)
            {
                questObject.Go_135_Line();
                inside_133.WaitSecond_0();

                //inside_133.m_Coroutine = inside_133.WaitSecond_0();
                //StartCoroutine(inside_133.m_Coroutine);
                Debug.Log("135번째 리셋하자");
            }

            if (Auto_Line_Index == 136)
            {
                questObject.Go_136_Line();
                inside_133.WaitSecond_0();

                //inside_133.m_Coroutine = inside_133.WaitSecond_0();
                //StartCoroutine(inside_133.m_Coroutine);
                Debug.Log("136번째 리셋하자");
            }

            if (Auto_Line_Index == 140)
            {
                like_1_4_11.WaitSecond_0();

                //like_1_4_11.m_Coroutine = like_1_4_11.WaitSecond_0();
                //StartCoroutine(like_1_4_11.m_Coroutine);
                Debug.Log("140번째 리셋하자");
            }

            if (Auto_Line_Index == 141)
            {
                questObject.True_Go_141();
                inside_141.WaitSecond_0();

                //inside_141.m_Coroutine = inside_141.WaitSecond_0();
                //StartCoroutine(inside_141.m_Coroutine);
                Debug.Log("141 리셋하자");
            }

            if (Auto_Line_Index == 142)
            {
                questObject.Lie_Go_142();
                inside_142.WaitSecond_0();

                //inside_142.m_Coroutine = inside_142.WaitSecond_0();
                //StartCoroutine(inside_142.m_Coroutine);
                Debug.Log("142 리셋하자");
            }

            if (Auto_Line_Index == 143)
            {
                questObject.Witch_Go_143();
                inside_143.WaitSecond_0();

                //inside_143.m_Coroutine = inside_143.WaitSecond_0();
                //StartCoroutine(inside_143.m_Coroutine);
                Debug.Log("143 리셋하자");
            }

            if (Auto_Line_Index == 144)
            {
                questObject.See_Go_144();
                inside_144.WaitSecond_0();

                //inside_144.m_Coroutine = inside_144.WaitSecond_0();
                //StartCoroutine(inside_144.m_Coroutine);
                Debug.Log("144 리셋하자");
            }

            if (Auto_Line_Index == 145)
            {
                questObject.Witch_Go_145();
                inside_145.WaitSecond_0();

                //inside_145.m_Coroutine = inside_145.WaitSecond_0();
                //StartCoroutine(inside_145.m_Coroutine);
                Debug.Log("145 리셋하자");
            }

            if (Auto_Line_Index == 146)
            {
                questObject.See_Go_146();
                inside_146.WaitSecond_0();

                //inside_146.m_Coroutine = inside_146.WaitSecond_0();
                //StartCoroutine(inside_146.m_Coroutine);
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

            //SFX 
            float SFX_Sd = PlayerPrefs.GetFloat("back_SFX_Vol");
            sfx_Manager.back_SFX_Vol = SFX_Sd;
            Debug.Log(SFX_Sd + "가 저장한 효과음 크기");

            //BGM
            float BGM_Sound_Save = PlayerPrefs.GetFloat("backvol");
            bgm.backVol = BGM_Sound_Save;
            Debug.Log(BGM_Sound_Save + "가 저장한 배경음 크기");

            /*bgm.backVol = PlayerPrefs.GetFloat("backvol");

            bgm.backVolume.value = bgm.backVol;

            bgm.audio1.volume = bgm.backVolume.value;
            bgm.audio2.volume = bgm.backVolume.value;
            bgm.audio3.GetComponent<AudioSource>().volume = bgm.backVolume.value;
            bgm.audio4.volume = bgm.backVolume.value;
            bgm.audio5.volume = bgm.backVolume.value;

            Debug.Log("저장했던 배경음 크기는" + bgm.backVolume.value + "다.");*/

            //스피드
            float Auto_Speed = PlayerPrefs.GetFloat("Speed");
            Setting_fast.Speed = Auto_Speed;
            Debug.Log(Auto_Speed + "가 저장한 스피드");


            

            //원래 요 2줄 이었음
            Debug.Log(Time.timeScale);
            SceneManager.LoadScene("Line");

            /*AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Line");
            while (!asyncLoad.isDone)
            {
                yield return null;
            }*/


            Line.SetActive(true);//원래 있었음
            Setting_1.SetActive(true);//원래 있었음




        }


    }
}
