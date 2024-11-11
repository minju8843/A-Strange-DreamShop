using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ending_Cradit : MonoBehaviour
{
    public GameObject Ticket_Count_Panel;

    public GameObject Black_EningCradit;//검은색으로 물들인 다음 엔딩크레딧 나오는 거
                                        //public GameObject Ending_Cradit_Inside;//엔딩크레딧 내용물

    public Only_Line QuestObject;

    public GameObject Text_Button_Continue;


    public GameObject Go_Restart_Empty;
    public GameObject ReStart;

    public Fade_Collect FadeObject;

    public R_Wait1_6_1 inside6_1;

    public Restart ReStart_1;

    //public GameObject Go_All_Ending;

    public GameObject EndingCradit;//엔딩크레딧 내용물 담고 있는 거

    public IEnumerator EndingCradit_Coroutine;
    public bool m_IsCoroutineing;

    // Start is called before the first frame update
    void Start()
    {
        EndingCradit_Coroutine = WaitSecond_New();

        //StartCoroutine(WaitSecond_0());

        //StartCoroutine(WaitSecond_1());
        //엔딩크레딧이 몇 초가 나오냐에 따라 다름
    }

    void Update()
    {

        StartCoroutine(EndingCradit_Coroutine);

    }

    public IEnumerator WaitSecond_New()
    {
        yield return StartCoroutine(WaitSecond_0());

        yield return StartCoroutine(WaitSecond_1());

        //yield return StartCoroutine(WaitSecond_2());

        //yield return StartCoroutine(WaitSecond_3());
    }

    public IEnumerator WaitSecond_0()
    {
        yield return new WaitForSeconds(0.0f);

        Ticket_Count_Panel.SetActive(false);


        QuestObject.BGM_Index = 4;

        QuestObject.Audio_Object[0].gameObject.SetActive(false);
        QuestObject.Audio_Object[1].gameObject.SetActive(false);
        QuestObject.Audio_Object[2].gameObject.SetActive(false);
        QuestObject.Audio_Object[3].gameObject.SetActive(false);
        QuestObject.Audio_Object[4].gameObject.SetActive(true);


        Text_Button_Continue.SetActive(false);

        FadeObject.Fade_Index = 11;

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



    }

    //WaitSecond_1()은 시간만 빠를 뿐 원래 잘됐었음
    public IEnumerator WaitSecond_1()//엔딩크레딧 이름 없어지고 3초 후에 실행
    {

        Debug.Log("엔딩크레딧 코루틴 시작");
        //m_IsCoroutineing = true;
        yield return new WaitForSeconds(24.5f);

        //13초였음 //원래 WaitForSeconds(13.5f)였음 

        //현재 23초로 수정. //1.5초 뒤에 나타남


        QuestObject.Line_Index = 139;

        QuestObject.questObject[137].gameObject.SetActive(false);
        QuestObject.questObject[0].gameObject.SetActive(false);
        //QuestObject.questObject[128].gameObject.SetActive(false);
        QuestObject.questObject[139].gameObject.SetActive(true);

        QuestObject.questObject[147].gameObject.SetActive(false);
        QuestObject.questObject[148].gameObject.SetActive(false);
        QuestObject.questObject[149].gameObject.SetActive(false);


        //Go_Restart_Empty.SetActive(true);


        //SceneManager.LoadScene("ReStart");
        //restart로 씬 이동을 없앤 결과는 : 

        //ReStart.SetActive(true);


        Debug.Log("엔딩크레딧 코루틴 종료됨");
        //m_IsCoroutineing = false;


        ReStart_1.ReSet_Coroutine = ReStart_1.WaitSecond_0();
        StartCoroutine(ReStart_1.ReSet_Coroutine);
        Debug.Log("ReStart화면 리셋하장");

        //02.05 리스타트로 가보고 안 되면 지우기
        //SceneManager.LoadScene("ReStart");

    }

    



}
