using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleUI : MonoBehaviour
{
    [Header("���� ���� Ŭ�� �� �̵��� �� �̸�")]
    [SerializeField] private string gameSceneName;

    [Header("����â")]
    [SerializeField] private GameObject objOption;

    //���� ���� ��ư�� ������ �Լ�
    public void OnClickStart()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    //���� ��ư�� ������ �Լ�
    public void OnClickHelp()
    {

    }

    //���� ��ư�� ������ �Լ�
    public void OnClickSettings()
    {
        UIUtil.Instance.ShowUI(objOption);
    }

    //���� ���� ��ư�� ������ �Լ�
    public void OnClickQuit()
    {

    }
}
