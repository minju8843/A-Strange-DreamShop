using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Album : MonoBehaviour
{
    public GameObject Album;
    public Animator anim;
    public GameObject Album_Text;//연한 검정 화면
    public Animator text_Size_anim;
    public Animator Black_Color;

    public GameObject Album_2;
    public Animator anim_2;
    public GameObject Album_Text_2;//연한 검정 화면
    public Animator text_Size_anim_2;
    public Animator Black_Color_2;

    public GameObject Album_3;
    public Animator anim_3;
    public GameObject Album_Text_3;//연한 검정 화면
    public Animator text_Size_anim_3;
    public Animator Black_Color_3;

    public GameObject Album_4;
    public Animator anim_4;
    public GameObject Album_Text_4;//연한 검정 화면
    public Animator text_Size_anim_4;
    public Animator Black_Color_4;

    public GameObject Album_5;
    public Animator anim_5;
    public GameObject Album_Text_5;//연한 검정 화면
    public Animator text_Size_anim_5;
    public Animator Black_Color_5;

    public GameObject Album_6;
    public Animator anim_6;
    public GameObject Album_Text_6;//연한 검정 화면
    public Animator text_Size_anim_6;
    public Animator Black_Color_6;

    public GameObject Album_7;
    public Animator anim_7;
    public GameObject Album_Text_7;//연한 검정 화면
    public Animator text_Size_anim_7;
    public Animator Black_Color_7;

    public GameObject Album_8;
    public Animator anim_8;
    public GameObject Album_Text_8;//연한 검정 화면
    public Animator text_Size_anim_8;
    public Animator Black_Color_8;

    public GameObject Album_9;
    public Animator anim_9;
    public GameObject Album_Text_9;//연한 검정 화면
    public Animator text_Size_anim_9;
    public Animator Black_Color_9;

    public GameObject Album_10;
    public Animator anim_10;
    public GameObject Album_Text_10;//연한 검정 화면
    public Animator text_Size_anim_10;
    public Animator Black_Color_10;

    public GameObject Album_11;
    public Animator anim_11;
    public GameObject Album_Text_11;//연한 검정 화면
    public Animator text_Size_anim_11;
    public Animator Black_Color_11;

    public GameObject Album_12;
    public Animator anim_12;
    public GameObject Album_Text_12;//연한 검정 화면
    public Animator text_Size_anim_12;
    public Animator Black_Color_12;


    void Start()
    {
        anim.SetBool("B_On", false);
        Black_Color.SetBool("Black_C", false);
        text_Size_anim.SetBool("Text", false);
        Album_Text.SetActive(false);

        anim_2.SetBool("B_On", false);
        Black_Color_2.SetBool("Black_C", false);
        text_Size_anim_2.SetBool("Text", false);
        Album_Text_2.SetActive(false);

        anim_3.SetBool("B_On", false);
        Black_Color_3.SetBool("Black_C", false);
        text_Size_anim_3.SetBool("Text", false);
        Album_Text_3.SetActive(false);

        anim_4.SetBool("B_On", false);
        Black_Color_4.SetBool("Black_C", false);
        text_Size_anim_4.SetBool("Text", false);
        Album_Text_4.SetActive(false);

        anim_2.SetBool("B_On", false);
        Black_Color_5.SetBool("Black_C", false);
        text_Size_anim_5.SetBool("Text", false);
        Album_Text_5.SetActive(false);

        anim_6.SetBool("B_On", false);
        Black_Color_6.SetBool("Black_C", false);
        text_Size_anim_6.SetBool("Text", false);
        Album_Text_6.SetActive(false);

        anim_7.SetBool("B_On", false);
        Black_Color_7.SetBool("Black_C", false);
        text_Size_anim_7.SetBool("Text", false);
        Album_Text_7.SetActive(false);

        anim_8.SetBool("B_On", false);
        Black_Color_8.SetBool("Black_C", false);
        text_Size_anim_8.SetBool("Text", false);
        Album_Text_8.SetActive(false);

        anim_9.SetBool("B_On", false);
        Black_Color_9.SetBool("Black_C", false);
        text_Size_anim_9.SetBool("Text", false);
        Album_Text_9.SetActive(false);

        anim_10.SetBool("B_On", false);
        Black_Color_10.SetBool("Black_C", false);
        text_Size_anim_10.SetBool("Text", false);
        Album_Text_10.SetActive(false);

        anim_11.SetBool("B_On", false);
        Black_Color_11.SetBool("Black_C", false);
        text_Size_anim_11.SetBool("Text", false);
        Album_Text_11.SetActive(false);

        anim_12.SetBool("B_On", false);
        Black_Color_12.SetBool("Black_C", false);
        text_Size_anim_12.SetBool("Text", false);
        Album_Text_12.SetActive(false);




    }

    //첫 번째 앨범

    public void Second_Album()//첫 번재 앨범 그림 선택 시
    {
        Album.SetActive(true);
        
        anim.SetBool("B_On", true);

        Album_Text.SetActive(false);//원래 이거였음
 

        text_Size_anim.SetBool("Text", false);

    

    }

    public void Back_To_Album()//다시 앨범 화면으로 돌아감
    {
        anim.SetBool("B_On", false);
        StartCoroutine(Stay_Black_1());
    }

    IEnumerator Stay_Black_1()
    {
        yield return new WaitForSecondsRealtime(1.0f);
        Black_Color.SetBool("Black_C", false);
        text_Size_anim.SetBool("Text", false);
    }

    public void Album_text()//이미지가 있는 화면을 눌렀을 때
    {
        StartCoroutine(Wait_Zero1());


    }

    IEnumerator Wait_Zero1()
    {
        yield return new WaitForSecondsRealtime(0.0f);

        Album_Text.SetActive(true);//글씨 검은 화면 생기기
        text_Size_anim.SetBool("Text", true);

        Black_Color.SetBool("Black_C", true);

    }

    public void Album_Image()//검은 화면을 눌렀을 때
    {

        StartCoroutine(Wait_Zero());
        StartCoroutine(Wait_One());
    }

    IEnumerator Wait_Zero()
    {
        yield return new WaitForSecondsRealtime(0.0f);
        text_Size_anim.SetBool("Text", false);
        Black_Color.SetBool("Black_C", false);

    }

    IEnumerator Wait_One()
    {
        

        yield return new WaitForSecondsRealtime(0.15f);

        Album_Text.SetActive(false);//글씨 검은 화면 지우기

    }


    //두 번째 앨범

    public void Real_Second_Album()//첫 번재 앨범 그림 선택 시
    {
        Album_2.SetActive(true);
        anim_2.SetBool("B_On", true);
        Album_Text_2.SetActive(false);//원래 이거였음
        text_Size_anim_2.SetBool("Text", false);

    }



    public void Real_Second_Back_To_Album()//다시 앨범 화면으로 돌아감
    {
        anim_2.SetBool("B_On", false);
        StartCoroutine(Stay_Black_2());
    }

    IEnumerator Stay_Black_2()
    {
        yield return new WaitForSecondsRealtime(1.0f);
        Black_Color_2.SetBool("Black_C", false);
        text_Size_anim_2.SetBool("Text", false);
    }



    public void Real_Second_Album_text()//이미지가 있는 화면을 눌렀을 때
    {
        StartCoroutine(Real_Second_Wait_Zero1());
    }

    IEnumerator Real_Second_Wait_Zero1()
    {
        yield return new WaitForSecondsRealtime(0.0f);
        Album_Text_2.SetActive(true);//글씨 검은 화면 생기기
        text_Size_anim_2.SetBool("Text", true);
        Black_Color_2.SetBool("Black_C", true);

    }

    public void Real_Second_Album_Image()//검은 화면을 눌렀을 때
    {
        StartCoroutine(Real_Second_Wait_Zero());
        StartCoroutine(Real_Second_Wait_One());
    }

    IEnumerator Real_Second_Wait_Zero()
    {
        yield return new WaitForSecondsRealtime(0.0f);
        text_Size_anim_2.SetBool("Text", false);
        Black_Color_2.SetBool("Black_C", false);

    }

    IEnumerator Real_Second_Wait_One()
    {
        yield return new WaitForSecondsRealtime(0.15f);
        Album_Text_2.SetActive(false);//글씨 검은 화면 지우기
    }

    //세 번째 앨범

    public void Real_Third_Album()//세 번재 앨범 그림 선택 시
    {
        Album_3.SetActive(true);
        anim_3.SetBool("B_On", true);
        Album_Text_3.SetActive(false);//원래 이거였음
        text_Size_anim_3.SetBool("Text", false);

    }



    public void Real_Third_Back_To_Album()//다시 앨범 화면으로 돌아감
    {
        anim_3.SetBool("B_On", false);
        StartCoroutine(Stay_Black_3());
    }

    IEnumerator Stay_Black_3()
    {
        yield return new WaitForSecondsRealtime(1.0f);
        Black_Color_3.SetBool("Black_C", false);
        text_Size_anim_3.SetBool("Text", false);
    }


    public void Real_Third_Album_text()//이미지가 있는 화면을 눌렀을 때
    {
        StartCoroutine(Real_Third_Wait_Zero1());
    }

    IEnumerator Real_Third_Wait_Zero1()
    {
        yield return new WaitForSecondsRealtime(0.0f);
        Album_Text_3.SetActive(true);//글씨 검은 화면 생기기
        text_Size_anim_3.SetBool("Text", true);
        Black_Color_3.SetBool("Black_C", true);

    }

    public void Real_Third_Album_Image()//검은 화면을 눌렀을 때
    {
        StartCoroutine(Real_Third_Wait_Zero());
        StartCoroutine(Real_Third_Wait_One());
    }

    IEnumerator Real_Third_Wait_Zero()
    {
        yield return new WaitForSecondsRealtime(0.0f);
        text_Size_anim_3.SetBool("Text", false);
        Black_Color_3.SetBool("Black_C", false);

    }

    IEnumerator Real_Third_Wait_One()
    {
        yield return new WaitForSecondsRealtime(0.15f);
        Album_Text_3.SetActive(false);//글씨 검은 화면 지우기
    }

    //세 번째 끝

    //네 번째 앨범

    public void Real_4_Album()//세 번재 앨범 그림 선택 시
    {
        Album_4.SetActive(true);
        anim_4.SetBool("B_On", true);
        Album_Text_4.SetActive(false);//원래 이거였음
        text_Size_anim_4.SetBool("Text", false);

    }

    public void Real_4_Back_To_Album()//다시 앨범 화면으로 돌아감
    {
        anim_4.SetBool("B_On", false);
        StartCoroutine(Stay_Black_4());
    }

    IEnumerator Stay_Black_4()
    {
        yield return new WaitForSecondsRealtime(1.0f);
        Black_Color_4.SetBool("Black_C", false);
        text_Size_anim_4.SetBool("Text", false);
    }

    public void Real_4_Album_text()//이미지가 있는 화면을 눌렀을 때
    {
        StartCoroutine(Real_4_Wait_Zero1());
    }

    IEnumerator Real_4_Wait_Zero1()
    {
        yield return new WaitForSecondsRealtime(0.0f);
        Album_Text_4.SetActive(true);//글씨 검은 화면 생기기
        text_Size_anim_4.SetBool("Text", true);
        Black_Color_4.SetBool("Black_C", true);

    }

    public void Real_4_Album_Image()//검은 화면을 눌렀을 때
    {
        StartCoroutine(Real_4_Wait_Zero());
        StartCoroutine(Real_4_Wait_One());
    }

    IEnumerator Real_4_Wait_Zero()
    {
        yield return new WaitForSecondsRealtime(0.0f);
        text_Size_anim_4.SetBool("Text", false);
        Black_Color_4.SetBool("Black_C", false);

    }

    IEnumerator Real_4_Wait_One()
    {
        yield return new WaitForSecondsRealtime(0.15f);
        Album_Text_4.SetActive(false);//글씨 검은 화면 지우기
    }

    //네 번째 끝

    //다섯 번째 앨범

    public void Real_5_Album()//세 번재 앨범 그림 선택 시
    {
        Album_5.SetActive(true);
        anim_5.SetBool("B_On", true);
        Album_Text_5.SetActive(false);//원래 이거였음
        text_Size_anim_5.SetBool("Text", false);

    }

    public void Real_5_Back_To_Album()//다시 앨범 화면으로 돌아감
    {
        anim_5.SetBool("B_On", false);
        StartCoroutine(Stay_Black_5());
    }

    IEnumerator Stay_Black_5()
    {
        yield return new WaitForSecondsRealtime(1.0f);
        Black_Color_5.SetBool("Black_C", false);
        text_Size_anim_5.SetBool("Text", false);
    }
    public void Real_5_Album_text()//이미지가 있는 화면을 눌렀을 때
    {
        StartCoroutine(Real_5_Wait_Zero1());
    }

    IEnumerator Real_5_Wait_Zero1()
    {
        yield return new WaitForSecondsRealtime(0.0f);
        Album_Text_5.SetActive(true);//글씨 검은 화면 생기기
        text_Size_anim_5.SetBool("Text", true);
        Black_Color_5.SetBool("Black_C", true);

    }

    public void Real_5_Album_Image()//검은 화면을 눌렀을 때
    {
        StartCoroutine(Real_5_Wait_Zero());
        StartCoroutine(Real_5_Wait_One());
    }

    IEnumerator Real_5_Wait_Zero()
    {
        yield return new WaitForSecondsRealtime(0.0f);
        text_Size_anim_5.SetBool("Text", false);
        Black_Color_5.SetBool("Black_C", false);

    }

    IEnumerator Real_5_Wait_One()
    {
        yield return new WaitForSecondsRealtime(0.15f);
        Album_Text_5.SetActive(false);//글씨 검은 화면 지우기
    }

    //다섯 번째 끝

    //여섯 번째 앨범

    public void Real_6_Album()//세 번재 앨범 그림 선택 시
    {
        Album_6.SetActive(true);
        anim_6.SetBool("B_On", true);
        Album_Text_6.SetActive(false);//원래 이거였음
        text_Size_anim_6.SetBool("Text", false);

    }

    public void Real_6_Back_To_Album()//다시 앨범 화면으로 돌아감
    {
        anim_6.SetBool("B_On", false);
        StartCoroutine(Stay_Black_6());
    }

    IEnumerator Stay_Black_6()
    {
        yield return new WaitForSecondsRealtime(1.0f);
        Black_Color_6.SetBool("Black_C", false);
        text_Size_anim_6.SetBool("Text", false);
    }

    public void Real_6_Album_text()//이미지가 있는 화면을 눌렀을 때
    {
        StartCoroutine(Real_6_Wait_Zero1());
    }

    IEnumerator Real_6_Wait_Zero1()
    {
        yield return new WaitForSecondsRealtime(0.0f);
        Album_Text_6.SetActive(true);//글씨 검은 화면 생기기
        text_Size_anim_6.SetBool("Text", true);
        Black_Color_6.SetBool("Black_C", true);

    }

    public void Real_6_Album_Image()//검은 화면을 눌렀을 때
    {
        StartCoroutine(Real_6_Wait_Zero());
        StartCoroutine(Real_6_Wait_One());
    }

    IEnumerator Real_6_Wait_Zero()
    {
        yield return new WaitForSecondsRealtime(0.0f);
        text_Size_anim_6.SetBool("Text", false);
        Black_Color_6.SetBool("Black_C", false);

    }

    IEnumerator Real_6_Wait_One()
    {
        yield return new WaitForSecondsRealtime(0.15f);
        Album_Text_6.SetActive(false);//글씨 검은 화면 지우기
    }

    //여섯 번째 끝

    //일곱 번째 앨범

    public void Real_7_Album()//세 번재 앨범 그림 선택 시
    {
        Album_7.SetActive(true);
        anim_7.SetBool("B_On", true);
        Album_Text_7.SetActive(false);//원래 이거였음
        text_Size_anim_7.SetBool("Text", false);

    }

    public void Real_7_Back_To_Album()//다시 앨범 화면으로 돌아감
    {
        anim_7.SetBool("B_On", false);
        StartCoroutine(Stay_Black_7());
    }

    IEnumerator Stay_Black_7()
    {
        yield return new WaitForSecondsRealtime(1.0f);
        Black_Color_7.SetBool("Black_C", false);
        text_Size_anim_7.SetBool("Text", false);
    }

    public void Real_7_Album_text()//이미지가 있는 화면을 눌렀을 때
    {
        StartCoroutine(Real_7_Wait_Zero1());
    }

    IEnumerator Real_7_Wait_Zero1()
    {
        yield return new WaitForSecondsRealtime(0.0f);
        Album_Text_7.SetActive(true);//글씨 검은 화면 생기기
        text_Size_anim_7.SetBool("Text", true);
        Black_Color_7.SetBool("Black_C", true);

    }

    public void Real_7_Album_Image()//검은 화면을 눌렀을 때
    {
        StartCoroutine(Real_7_Wait_Zero());
        StartCoroutine(Real_7_Wait_One());
    }

    IEnumerator Real_7_Wait_Zero()
    {
        yield return new WaitForSecondsRealtime(0.0f);
        text_Size_anim_7.SetBool("Text", false);
        Black_Color_7.SetBool("Black_C", false);

    }

    IEnumerator Real_7_Wait_One()
    {
        yield return new WaitForSecondsRealtime(0.15f);
        Album_Text_7.SetActive(false);//글씨 검은 화면 지우기
    }

    //일곱번째 끝

    //여덟 번째 앨범

    public void Real_8_Album()//세 번재 앨범 그림 선택 시
    {
        Album_8.SetActive(true);
        anim_8.SetBool("B_On", true);
        Album_Text_8.SetActive(false);//원래 이거였음
        text_Size_anim_8.SetBool("Text", false);

    }

    public void Real_8_Back_To_Album()//다시 앨범 화면으로 돌아감
    {
        anim_8.SetBool("B_On", false);
        StartCoroutine(Stay_Black_8());
    }

    IEnumerator Stay_Black_8()
    {
        yield return new WaitForSecondsRealtime(1.0f);
        Black_Color_8.SetBool("Black_C", false);
        text_Size_anim_8.SetBool("Text", false);
    }

    public void Real_8_Album_text()//이미지가 있는 화면을 눌렀을 때
    {
        StartCoroutine(Real_8_Wait_Zero1());
    }

    IEnumerator Real_8_Wait_Zero1()
    {
        yield return new WaitForSecondsRealtime(0.0f);
        Album_Text_8.SetActive(true);//글씨 검은 화면 생기기
        text_Size_anim_8.SetBool("Text", true);
        Black_Color_8.SetBool("Black_C", true);

    }

    public void Real_8_Album_Image()//검은 화면을 눌렀을 때
    {
        StartCoroutine(Real_8_Wait_Zero());
        StartCoroutine(Real_8_Wait_One());
    }

    IEnumerator Real_8_Wait_Zero()
    {
        yield return new WaitForSecondsRealtime(0.0f);
        text_Size_anim_8.SetBool("Text", false);
        Black_Color_8.SetBool("Black_C", false);

    }

    IEnumerator Real_8_Wait_One()
    {
        yield return new WaitForSecondsRealtime(0.15f);
        Album_Text_8.SetActive(false);//글씨 검은 화면 지우기
    }

    //여덟번째 끝

    //아홉 번째 앨범

    public void Real_9_Album()//세 번재 앨범 그림 선택 시
    {
        Album_9.SetActive(true);
        anim_9.SetBool("B_On", true);
        Album_Text_9.SetActive(false);//원래 이거였음
        text_Size_anim_9.SetBool("Text", false);

    }

    public void Real_9_Back_To_Album()//다시 앨범 화면으로 돌아감
    {
        anim_9.SetBool("B_On", false);
        StartCoroutine(Stay_Black_9());
    }

    IEnumerator Stay_Black_9()
    {
        yield return new WaitForSecondsRealtime(1.0f);
        Black_Color_9.SetBool("Black_C", false);
        text_Size_anim_9.SetBool("Text", false);
    }

    public void Real_9_Album_text()//이미지가 있는 화면을 눌렀을 때
    {
        StartCoroutine(Real_9_Wait_Zero1());
    }

    IEnumerator Real_9_Wait_Zero1()
    {
        yield return new WaitForSecondsRealtime(0.0f);
        Album_Text_9.SetActive(true);//글씨 검은 화면 생기기
        text_Size_anim_9.SetBool("Text", true);
        Black_Color_9.SetBool("Black_C", true);

    }

    public void Real_9_Album_Image()//검은 화면을 눌렀을 때
    {
        StartCoroutine(Real_9_Wait_Zero());
        StartCoroutine(Real_9_Wait_One());
    }

    IEnumerator Real_9_Wait_Zero()
    {
        yield return new WaitForSecondsRealtime(0.0f);
        text_Size_anim_9.SetBool("Text", false);
        Black_Color_9.SetBool("Black_C", false);

    }

    IEnumerator Real_9_Wait_One()
    {
        yield return new WaitForSecondsRealtime(0.15f);
        Album_Text_9.SetActive(false);//글씨 검은 화면 지우기
    }

    //아홉번째 끝

    //열 번째 앨범

    public void Real_10_Album()//세 번재 앨범 그림 선택 시
    {
        Album_10.SetActive(true);
        anim_10.SetBool("B_On", true);
        Album_Text_10.SetActive(false);//원래 이거였음
        text_Size_anim_10.SetBool("Text", false);

    }

    public void Real_10_Back_To_Album()//다시 앨범 화면으로 돌아감
    {
        anim_10.SetBool("B_On", false);
        StartCoroutine(Stay_Black_10());
    }

    IEnumerator Stay_Black_10()
    {
        yield return new WaitForSecondsRealtime(1.0f);
        Black_Color_10.SetBool("Black_C", false);
        text_Size_anim_10.SetBool("Text", false);
    }

    public void Real_10_Album_text()//이미지가 있는 화면을 눌렀을 때
    {
        StartCoroutine(Real_10_Wait_Zero1());
    }

    IEnumerator Real_10_Wait_Zero1()
    {
        yield return new WaitForSecondsRealtime(0.0f);
        Album_Text_10.SetActive(true);//글씨 검은 화면 생기기
        text_Size_anim_10.SetBool("Text", true);
        Black_Color_10.SetBool("Black_C", true);

    }

    public void Real_10_Album_Image()//검은 화면을 눌렀을 때
    {
        StartCoroutine(Real_10_Wait_Zero());
        StartCoroutine(Real_10_Wait_One());
    }

    IEnumerator Real_10_Wait_Zero()
    {
        yield return new WaitForSecondsRealtime(0.0f);
        text_Size_anim_10.SetBool("Text", false);
        Black_Color_10.SetBool("Black_C", false);

    }

    IEnumerator Real_10_Wait_One()
    {
        yield return new WaitForSecondsRealtime(0.15f);
        Album_Text_10.SetActive(false);//글씨 검은 화면 지우기
    }

    //열 번째 끝

    //열 한 번째 앨범

    public void Real_11_Album()//세 번재 앨범 그림 선택 시
    {
        Album_11.SetActive(true);
        anim_11.SetBool("B_On", true);
        Album_Text_11.SetActive(false);//원래 이거였음
        text_Size_anim_11.SetBool("Text", false);

    }

    public void Real_11_Back_To_Album()//다시 앨범 화면으로 돌아감
    {
        anim_11.SetBool("B_On", false);
        StartCoroutine(Stay_Black_11());
    }

    IEnumerator Stay_Black_11()
    {
        yield return new WaitForSecondsRealtime(1.0f);
        Black_Color_11.SetBool("Black_C", false);
        text_Size_anim_11.SetBool("Text", false);
    }

    public void Real_11_Album_text()//이미지가 있는 화면을 눌렀을 때
    {
        StartCoroutine(Real_11_Wait_Zero1());
    }

    IEnumerator Real_11_Wait_Zero1()
    {
        yield return new WaitForSecondsRealtime(0.0f);
        Album_Text_11.SetActive(true);//글씨 검은 화면 생기기
        text_Size_anim_11.SetBool("Text", true);
        Black_Color_11.SetBool("Black_C", true);

    }

    public void Real_11_Album_Image()//검은 화면을 눌렀을 때
    {
        StartCoroutine(Real_11_Wait_Zero());
        StartCoroutine(Real_11_Wait_One());
    }

    IEnumerator Real_11_Wait_Zero()
    {
        yield return new WaitForSecondsRealtime(0.0f);
        text_Size_anim_11.SetBool("Text", false);
        Black_Color_11.SetBool("Black_C", false);

    }

    IEnumerator Real_11_Wait_One()
    {
        yield return new WaitForSecondsRealtime(0.15f);
        Album_Text_11.SetActive(false);//글씨 검은 화면 지우기
    }

    //열 한 번째 끝

    //열 두 번째 앨범

    public void Real_12_Album()//세 번재 앨범 그림 선택 시
    {
        Album_12.SetActive(true);
        anim_12.SetBool("B_On", true);
        Album_Text_12.SetActive(false);//원래 이거였음
        text_Size_anim_12.SetBool("Text", false);

    }

    public void Real_12_Back_To_Album()//다시 앨범 화면으로 돌아감
    {
        anim_12.SetBool("B_On", false);
        StartCoroutine(Stay_Black_12());
    }

    IEnumerator Stay_Black_12()
    {
        yield return new WaitForSecondsRealtime(1.0f);
        Black_Color_12.SetBool("Black_C", false);
        text_Size_anim_12.SetBool("Text", false);
    }

    public void Real_12_Album_text()//이미지가 있는 화면을 눌렀을 때
    {
        StartCoroutine(Real_12_Wait_Zero1());
    }

    IEnumerator Real_12_Wait_Zero1()
    {
        yield return new WaitForSecondsRealtime(0.0f);
        Album_Text_12.SetActive(true);//글씨 검은 화면 생기기
        text_Size_anim_12.SetBool("Text", true);
        Black_Color_12.SetBool("Black_C", true);

    }

    public void Real_12_Album_Image()//검은 화면을 눌렀을 때
    {
        StartCoroutine(Real_12_Wait_Zero());
        StartCoroutine(Real_12_Wait_One());
    }

    IEnumerator Real_12_Wait_Zero()
    {
        yield return new WaitForSecondsRealtime(0.0f);
        text_Size_anim_12.SetBool("Text", false);
        Black_Color_12.SetBool("Black_C", false);

    }

    IEnumerator Real_12_Wait_One()
    {
        yield return new WaitForSecondsRealtime(0.15f);
        Album_Text_12.SetActive(false);//글씨 검은 화면 지우기
    }
}
