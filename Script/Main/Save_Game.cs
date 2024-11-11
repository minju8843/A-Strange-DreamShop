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

    public Only_Line questObject;//LineObject��ũ��Ʈ �ҷ����� ����
    public Fade_Collect fadeObject;//���̵� ��ũ��Ʈ �ҷ�������


    public void Click_Game_Save()//���� ������ ���� ��ư ������ ��
    {
        Game_Data_Save.SetActive(true);
    }

    public void Game_Save_No()
    {//���� ������ ���� ��ư ������ ���
        Game_Data_Save.SetActive(false);
    }

    public void Game_Save_Yes()
    {//���� ������ ���� ��ư ������ Ȯ��(���� ������ ����Ǵ� �κ�)
        Game_Data_Save.SetActive(false);

        Debug.Log("���� ����");
        //PlayerPrefs.SetInt("BGM_Index", questObject.BGM_Index);
        
        //��-�� ��縦 �����ϴ°�
        PlayerPrefs.SetInt("Index", questObject.Line_Index);

        //1 ��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
        /*PlayerPrefs.SetInt("First_Ending", All_Save.Ending1_Index);

        //2 ��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Second_Ending", All_Save.Ending2_Index);

        //3 ��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Thrid_Ending", All_Save.Ending3_Index);

        //4 ��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Fourth_Ending", All_Save.Ending4_Index);

        //���� ĳ���Ͱ� ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Boss", All_Save.Boss_Index);

        //�Ҹ� ĳ���Ͱ� ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Sori", All_Save.Sori_Index);

        //��¥ ���� ĳ���Ͱ� ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Fake_Boss", All_Save.Fake_Boss_Index);

        //������ ĳ���Ͱ� ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Black_Face_Man", All_Save.Black_Face_Man_Index);

        //é��1 Ÿ�Ӷ����� ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("TimeLine", All_Save.Time_Line_Open_Index);

        //é��1 Ÿ�Ӷ��ο��� �߰����� ������ ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("TimeLine_Run", All_Save.Time_Run_Index);

        //1��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Achieve_1", All_Save.Achieve1_Index);

        //2��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Achieve_2", All_Save.Achieve2_Index);

        //3��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Achieve_3", All_Save.Achieve3_Index);

        //4��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Achieve_4", All_Save.Achieve4_Index);

        //5��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Achieve_5", All_Save.Achieve5_Index);

        //6��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Achieve_6", All_Save.Achieve6_Index);

        //7��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Achieve_7", All_Save.Achieve7_Index);

        //8��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Achieve_8", All_Save.Achieve8_Index);

        //9��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Achieve_9", All_Save.Achieve9_Index);

        //10��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Achieve_10", All_Save.Achieve10_Index);

        //11��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Achieve_11", All_Save.Achieve11_Index);

        //12��° ������ ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Achieve_12", All_Save.Achieve12_Index);


        //1��° �ٹ��� ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Album_1", All_Save.Album1_Index);

        //2��° �ٹ��� ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Album_2", All_Save.Album2_Index);

        //3��° �ٹ��� ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Album_3", All_Save.Album3_Index);

        //4��° �ٹ��� ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Album_4", All_Save.Album4_Index);

        //5��° �ٹ��� ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Album_5", All_Save.Album5_Index);

        //6��° �ٹ��� ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Album_6", All_Save.Album6_Index);

        //7��° �ٹ��� ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Album_7", All_Save.Album7_Index);

        //8��° �ٹ��� ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Album_8", All_Save.Album8_Index);

        //9��° �ٹ��� ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Album_9", All_Save.Album9_Index);

        //10��° �ٹ��� ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Album_10", All_Save.Album10_Index);

        //11��° �ٹ��� ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Album_11", All_Save.Album11_Index);

        //12��° �ٹ��� ���µǾ��°� / ���� ������ �ʾҴ°�
        PlayerPrefs.SetInt("Album_12", All_Save.Album12_Index);*/


        Debug.Log(questObject.Line_Index + "����");
        //PlayerPrefs.SetInt("Fade_Index", fadeObject.Fade_Index);
        //PlayerPrefs.Save();

        Successful_Save.SetActive(true);
    }


    public void Game_Save_Yes_Ok()
    {//���� ������ ���� ��ư ������ Ȯ���ϰ� ������ ����Ȯ��
        //�Ǿ����ϴ� Ȯ�� �ߴ� ��
        Game_Data_Save.SetActive(false);
        Successful_Save.SetActive(false);
    }
}
