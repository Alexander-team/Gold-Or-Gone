using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIStart : MonoBehaviour
{

    [SerializeField] public GameObject UIBase;
    [SerializeField] public GameObject UISetting;
    [SerializeField] public GameObject UIMaker;

    private void Awake()
    {
        UIBase = GameObject.Find("UI/Base");
        UISetting = GameObject.Find("UI/Setting");
        UIMaker = GameObject.Find("UI/Maker");
        UISetting.SetActive(false);
        UIMaker.SetActive(false);
    }
    public void StartGame()                //开始游戏
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void UIButtonSetting()          //设置菜单
    {
        UIBase.SetActive(false);
        UISetting.SetActive(true);
        UIMaker.SetActive(false);
    }

    public void UIButtonQuit()             //退出游戏
    {
        Debug.Log("Game is Quit!");
        Application.Quit();
    }

    public void UIButtonBack()          //返回菜单
    {
        UIBase.SetActive(true);
        UISetting.SetActive(false);
        UIMaker.SetActive(false);
    }

    public void UIButtonMaker()         //制作者名单
    {
        UIBase.SetActive(false);
        UISetting.SetActive(false);
        UIMaker.SetActive(true);
    }
}
