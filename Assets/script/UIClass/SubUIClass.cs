using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SubUIClass : MonoBehaviour {

    Button StartGame;
    GameObject StartControll;
    GameObject MainCam;
	void Start ()
    {
        MainCam = GameObject.Find("MainCamera");
        StartControll = GameObject.Find("StartControll");
        StartGame = GameObject.Find("StartGameBtn").GetComponent<Button>();
        StartGame.onClick.AddListener(() => { GameStartGo(); });
    }
	void GameStartGo()
    {
        AllMarbleData._instance.SubUICanvasObj.SetActive(false);
        AllMarbleData._instance.UICanvasOBj.SetActive(true);
        if(AllMarbleData._instance.UICanvasOBj.activeSelf == true)
        {
            //캐릭터 마블판으로 이동
            AllMarbleData._instance.Player_Ch.transform.position = new Vector3(AllMarbleData._instance.Marble[0].transform.position.x, 0.23f, AllMarbleData._instance.Marble[0].transform.position.z);
            AllMarbleData._instance.Player_Ch.transform.localScale = new Vector3(0.65f, 0.65f, 0.65f);
            AllMarbleData._instance.Player_Ch.name = "Player";

            //메인 카메라에 줌 클래스 부착
            MainCam.AddComponent<CameraZoomClass>();

            AllMarbleData._instance.UIObject.gameObject.AddComponent<D_UIClass>(); //UI 버튼 클래스 추가
            AllMarbleData._instance.UIObject.gameObject.AddComponent<MissionTxtClass>();
            AllMarbleData._instance.UIObject.gameObject.AddComponent<EventClass>();
            StartControll.AddComponent<StartControll>();
            AllMarbleData._instance.UICanvas = GameObject.Find("UICanvas").GetComponent<Canvas>();
            AllMarbleData._instance.UICanvas.renderMode = RenderMode.ScreenSpaceCamera;//캔버스에 렌더모드를 카메라로 전환
            AllMarbleData._instance.UICanvas.worldCamera = AllMarbleData._instance.UICam;//카메라 셋팅

            AllMarbleData._instance.DiceButton = GameObject.Find("DiceAndItemBtn");

            AllMarbleData._instance.UI_ResultText = GameObject.Find("EventText").GetComponent<Text>(); //테스트용 이벤트
            AllMarbleData._instance.testImage = GameObject.Find("TestImage"); //테스트용 뒷배경이미지
            AllMarbleData._instance.testImage.SetActive(false);

           
            AllMarbleData._instance.Player_Ch.transform.position = new Vector3(AllMarbleData._instance.Marble[0].transform.position.x, 0.23f, AllMarbleData._instance.Marble[0].transform.position.z);

            //능력치
            AllMarbleData._instance.StatSort1 = GameObject.Find("statsort1").GetComponent<Text>();
            AllMarbleData._instance.StatSort2 = GameObject.Find("statsort2").GetComponent<Text>();
            AllMarbleData._instance.ArtImg = GameObject.Find("artimg");
            AllMarbleData._instance.EduImg = GameObject.Find("eduimg");
            AllMarbleData._instance.StrengthImg = GameObject.Find("strengthimg");
            AllMarbleData._instance.Lovelyimg = GameObject.Find("lovelyimg");
            AllMarbleData._instance.SkillImg = GameObject.Find("skillimg");

            AllMarbleData._instance.ArtImg1 = GameObject.Find("artimg1");
            AllMarbleData._instance.EduImg1 = GameObject.Find("eduimg1");
            AllMarbleData._instance.StrengthImg1 = GameObject.Find("strengthimg1");
            AllMarbleData._instance.Lovelyimg1 = GameObject.Find("lovelyimg1");
            AllMarbleData._instance.SkillImg1 = GameObject.Find("skillimg1");

            AllMarbleData._instance.MoneyTxt = GameObject.Find("moneyTxt").GetComponent<Text>();
            if (!PlayerPrefs.HasKey("money"))
            {
                PlayerPrefs.SetFloat("money", 1000000);
            }
            AllMarbleData._instance.MoneyTxt.text = PlayerPrefs.GetFloat("money").ToString("#,##0") + "원";
            //로그텍스트
            AllMarbleData._instance.LogTxt = GameObject.Find("Text4").GetComponent<Text>();
            //미션텍스트
            AllMarbleData._instance.MissionTxt = GameObject.Find("MissionTxt").GetComponent<Text>();
            AllMarbleData._instance.MissionStatTxt = GameObject.Find("MissionStat").GetComponent<Text>();
            //미션 수행, 무시
            AllMarbleData._instance.M_Success = GameObject.Find("M_Success"); //미션 수행
            AllMarbleData._instance.M_Fail = GameObject.Find("M_Fail"); //미션 무시
            AllMarbleData._instance.FailTxt = GameObject.Find("Fail_txt").GetComponent<Text>();
        }
    }
}
