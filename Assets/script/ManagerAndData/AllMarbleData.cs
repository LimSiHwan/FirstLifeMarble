using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AllMarbleData : MonoBehaviour {

    public static AllMarbleData _instance;
    
    public GameObject[] Marble;
    public AnimationClip MarbleAnimation;
    
    //UI 카메라
    public Camera UICam;
    public GameObject UICanvasOBj;
    public GameObject MainUICanvasOBj; //메인 UI
    public GameObject SubUICanvasObj; //서브 UI
    public Canvas UICanvas;

    public GameObject UIObject;
    public GameObject DiceButton; //주사위 버튼
    public GameObject testImage;
    public Text UI_ResultText;

    //캐릭터 생성
    
    public GameObject Player_Ch;

    //결과 touch이벤트
    public GameObject M_Success;
    public GameObject M_Fail;
    public Text FailTxt;

    //능력치 UI text, 이미지
    public Text ArtTxt;
    public Text StrengthTxt;
    public Text LovelyTxt;
    public Text EduTxt;
    public Text SkillTxt;
    public Text MoneyTxt;
    public Text StatSort1; // 정렬된 능력치 텍스트 1
    public Text StatSort2; // 정렬된 능력지 텍스트 2
    public GameObject ArtImg;
    public GameObject EduImg;
    public GameObject SkillImg;
    public GameObject StrengthImg;
    public GameObject Lovelyimg;
    public GameObject ArtImg1;
    public GameObject EduImg1;
    public GameObject SkillImg1;
    public GameObject StrengthImg1;
    public GameObject Lovelyimg1;
    //로그 텍스트
    public Text LogTxt;
    //미션 텍스트
    public Text MissionTxt;
    public Text MissionStatTxt;
    //점프, 주사위 버튼 사운드 테스트용 사운드
    public AudioClip JumpSound;
    public AudioClip DiceBtnSound;

    void Awake ()
    {
        _instance = this;
        

        UICam = Instantiate(Resources.Load("UI/UICamera", typeof(Camera))) as Camera;
        UICam.transform.position = new Vector3(0, 100, 0);
        UICam.farClipPlane = 150;

        MainUICanvasOBj = GameObject.Find("MainCanvas");
        SubUICanvasObj = GameObject.Find("SubUICanvas");
        UICanvasOBj = GameObject.Find("UICanvas");

        SubUICanvasObj.SetActive(false);
        UICanvasOBj.SetActive(false);

        UIObject = GameObject.Find("UIObject");
        UIObject.gameObject.AddComponent<GameStartBtnClass>(); //게임시작할때 메인화면
    }
}
