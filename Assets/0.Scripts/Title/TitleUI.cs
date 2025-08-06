using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleUI : MonoBehaviour
{
    [Header("게임 시작 클릭 시 이동할 씬 이름")]
    [SerializeField] private string gameSceneName;

    [Header("설정창")]
    [SerializeField] private GameObject objOption;

    //게임 시작 버튼에 연결할 함수
    public void OnClickStart()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    //설명 버튼에 연결할 함수
    public void OnClickHelp()
    {

    }

    //설정 버튼에 연결할 함수
    public void OnClickSettings()
    {
        UIUtil.Instance.ShowUI(objOption);
    }

    //게임 종료 버튼에 연결할 함수
    public void OnClickQuit()
    {

    }
}
