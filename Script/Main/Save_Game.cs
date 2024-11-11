using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class Save_Game : MonoBehaviour
{
    public Save_Collection All_Save;
    public GameObject Game_Data_Save;
    public GameObject Successful_Save;

    public Only_Line questObject;//LineObject스크립트 불러오기 위함
    public Fade_Collect fadeObject;//페이드 스크립트 불러오려고


    public void Click_Game_Save()//게임 데이터 저장 버튼 눌렀을 때
    {
        Game_Data_Save.SetActive(true);
    }

    public void Game_Save_No()
    {//게임 데이터 저장 버튼 누르고 취소
        Game_Data_Save.SetActive(false);
    }

    public void Game_Save_Yes()
    {//게임 데이터 저장 버튼 누르고 확인(게임 데이터 저장되는 부분)
        Game_Data_Save.SetActive(false);

        Debug.Log("게임 저장");
        //PlayerPrefs.SetInt("BGM_Index", questObject.BGM_Index);
        
        //몇-몇 대사를 저장하는가
        PlayerPrefs.SetInt("Index", questObject.Line_Index);

        //1 번째 엔딩이 오픈되었는가 / 아직 열리지 않았는가
        /*PlayerPrefs.SetInt("First_Ending", All_Save.Ending1_Index);

        //2 번째 엔딩이 오픈되었는가 / 아직 열리지 않았는가
        PlayerPrefs.SetInt("Second_Ending", All_Save.Ending2_Index);

        //3 번째 엔딩이 오픈되었는가 / 아직 열리지 않았는가
        PlayerPrefs.SetInt("Thrid_Ending", All_Save.Ending3_Index);

        //4 번째 엔딩이 오픈되었는가 / 아직 열리지 않았는가
        PlayerPrefs.SetInt("Fourth_Ending", All_Save.Ending4_Index);

        //사장 캐릭터가 오픈되었는가 / 아직 열리지 않았는가
        PlayerPrefs.SetInt("Boss", All_Save.Boss_Index);

        //소리 캐릭터가 오픈되었는가 / 아직 열리지 않았는가
        PlayerPrefs.SetInt("Sori", All_Save.Sori_Index);

        //가짜 사장 캐릭터가 오픈되었는가 / 아직 열리지 않았는가
        PlayerPrefs.SetInt("Fake_Boss", All_Save.Fake_Boss_Index);

        //조울자 캐릭터가 오픈되었는가 / 아직 열리지 않았는가
        PlayerPrefs.SetInt("Black_Face_Man", All_Save.Black_Face_Man_Index);

        //챕터1 타임라인이 오픈되었는가 / 아직 열리지 않았는가
        PlayerPrefs.SetInt("TimeLine", All_Save.Time_Line_Open_Index);

        //챕터1 타임라인에서 중간부터 시작이 오픈되었는가 / 아직 열리지 않았는가
        PlayerPrefs.SetInt("TimeLine_Run", All_Save.Time_Run_Index);

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

        //8번째 없적이 오픈되었는가 / 아직 열리지 않았는가
        PlayerPrefs.SetInt("Achieve_8", All_Save.Achieve8_Index);

        //9번째 없적이 오픈되었는가 / 아직 열리지 않았는가
        PlayerPrefs.SetInt("Achieve_9", All_Save.Achieve9_Index);

        //10번째 없적이 오픈되었는가 / 아직 열리지 않았는가
        PlayerPrefs.SetInt("Achieve_10", All_Save.Achieve10_Index);

        //11번째 없적이 오픈되었는가 / 아직 열리지 않았는가
        PlayerPrefs.SetInt("Achieve_11", All_Save.Achieve11_Index);

        //12번째 없적이 오픈되었는가 / 아직 열리지 않았는가
        PlayerPrefs.SetInt("Achieve_12", All_Save.Achieve12_Index);


        //1번째 앨범이 오픈되었는가 / 아직 열리지 않았는가
        PlayerPrefs.SetInt("Album_1", All_Save.Album1_Index);

        //2번째 앨범이 오픈되었는가 / 아직 열리지 않았는가
        PlayerPrefs.SetInt("Album_2", All_Save.Album2_Index);

        //3번째 앨범이 오픈되었는가 / 아직 열리지 않았는가
        PlayerPrefs.SetInt("Album_3", All_Save.Album3_Index);

        //4번째 앨범이 오픈되었는가 / 아직 열리지 않았는가
        PlayerPrefs.SetInt("Album_4", All_Save.Album4_Index);

        //5번째 앨범이 오픈되었는가 / 아직 열리지 않았는가
        PlayerPrefs.SetInt("Album_5", All_Save.Album5_Index);

        //6번째 앨범이 오픈되었는가 / 아직 열리지 않았는가
        PlayerPrefs.SetInt("Album_6", All_Save.Album6_Index);

        //7번째 앨범이 오픈되었는가 / 아직 열리지 않았는가
        PlayerPrefs.SetInt("Album_7", All_Save.Album7_Index);

        //8번째 앨범이 오픈되었는가 / 아직 열리지 않았는가
        PlayerPrefs.SetInt("Album_8", All_Save.Album8_Index);

        //9번째 앨범이 오픈되었는가 / 아직 열리지 않았는가
        PlayerPrefs.SetInt("Album_9", All_Save.Album9_Index);

        //10번째 앨범이 오픈되었는가 / 아직 열리지 않았는가
        PlayerPrefs.SetInt("Album_10", All_Save.Album10_Index);

        //11번째 앨범이 오픈되었는가 / 아직 열리지 않았는가
        PlayerPrefs.SetInt("Album_11", All_Save.Album11_Index);

        //12번째 앨범이 오픈되었는가 / 아직 열리지 않았는가
        PlayerPrefs.SetInt("Album_12", All_Save.Album12_Index);*/


        Debug.Log(questObject.Line_Index + "저장");
        //PlayerPrefs.SetInt("Fade_Index", fadeObject.Fade_Index);
        //PlayerPrefs.Save();

        Successful_Save.SetActive(true);
    }


    public void Game_Save_Yes_Ok()
    {//게임 데이터 저장 버튼 누르고 확인하고 성공적 저장확인
        //되었습니다 확인 뜨는 곳
        Game_Data_Save.SetActive(false);
        Successful_Save.SetActive(false);
    }
}
