using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Game_Load : MonoBehaviour
{
    public GameObject Game_Data_Load;
    public GameObject Successful_Load;
    public GameObject Successful_ReSet;

    public GameObject Game_ReSet;
    public Game_Load_Yes load_yes;

    //public Only_Line questObject;//LineObject스크립트 불러오기 위함
    //public Fade_Collect fadeObject;//페이드 스크립트 불러오려고

    /*public R_Wait1 inside_0;
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
    public Line_146 inside_146;*/


    public void Click_Game_Load()
    {//게임 데이터 로드 클릭했을 때 나오는 거

        Game_Data_Load.SetActive(true);
    }

    public void Game_Load_Yes()
    {//게임 데이터 로드 클릭하고 확인 눌렀을 경우

        Game_Data_Load.SetActive(false);
        Successful_Load.SetActive(true);



    }


    public void Game_Load_No()
    {//게임 데이터 로드 클릭하고 취소 눌렀을 경우

        Game_Data_Load.SetActive(false);

    }

    public void Game_ReSet_Yes()
    {//게임 데이터 리셋 클릭하고 취소 눌렀을 경우

        Game_ReSet.SetActive(false);
        Successful_ReSet.SetActive(true);

    }

    public void Game_ReSet_No()
    {//게임 데이터 리셋 클릭하고 취소 눌렀을 경우

        Game_ReSet.SetActive(false);

    }

    public void Game_ReSet_Click()
    {//게임 데이터 리셋 클릭하고 취소 눌렀을 경우

        Game_ReSet.SetActive(true);

    }


    /*public void Game_Load_Yes_Ok()
    {//게임 데이터 로드 클릭하고 확인 누르고 성공적으로 불러와졌을 경우
        Game_Data_Load.SetActive(false);
        Successful_Load.SetActive(false);
    }*/


}
