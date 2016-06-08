using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameStartBtnClass : MonoBehaviour {

    Button GameStartBtn;
    Text info_edu;
    Text info_strength;
    Text info_skill;
    Text info_art;
    Text info_lovely;

	void Start ()
    { 
        GameStartBtn = GameObject.Find("GameStart").GetComponent<Button>();
        GameStartBtn.onClick.AddListener(() => { GameStartGo(); });
    }
	void GameStartGo()
    {
        AllMarbleData._instance.MainUICanvasOBj.SetActive(false);
        AllMarbleData._instance.SubUICanvasObj.SetActive(true);
        if (AllMarbleData._instance.SubUICanvasObj.activeSelf == true)
        {
            AllMarbleData._instance.UIObject.gameObject.AddComponent<SubUIClass>();
            //캐릭터 생성
            D_Manager.Instance.RandomIndex = Random.Range(1, 5);
            AllMarbleData._instance.Player_Ch = Instantiate(Resources.Load("Character/Player_0" + D_Manager.Instance.RandomIndex, typeof(GameObject))) as GameObject;
            AllMarbleData._instance.Player_Ch.transform.position = new Vector3(-6.4f, 97.5f, 100f);
            AllMarbleData._instance.Player_Ch.transform.rotation = Quaternion.Euler(0, 180, 0);
            AllMarbleData._instance.Player_Ch.transform.localScale = new Vector3(3, 3, 3);

            //캐릭터 정보 능력치

            info_art = GameObject.Find("info_art").GetComponent<Text>();
            info_lovely = GameObject.Find("info_lovely").GetComponent<Text>();
            info_skill = GameObject.Find("info_skill").GetComponent<Text>();
            info_strength = GameObject.Find("info_strength").GetComponent<Text>();
            info_edu = GameObject.Find("info_edu").GetComponent<Text>();

            info_edu.text = PlayerPrefs.GetInt("edu").ToString();
            info_art.text = PlayerPrefs.GetInt("art").ToString();
            info_lovely.text = PlayerPrefs.GetInt("lovely").ToString();
            info_skill.text = PlayerPrefs.GetInt("skill").ToString();
            info_strength.text = PlayerPrefs.GetInt("strength").ToString();

        }
    }
}
