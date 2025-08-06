using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;

public class UIUtil : Singleton<UIUtil>
{
    public void ShowUI(GameObject gameobject)
    {
        if (gameobject == null || gameobject.activeSelf == true) return;

        gameobject.SetActive(true);
        gameobject.transform.localScale = Vector3.one * 0.2f;

        var seq = DOTween.Sequence();

        seq.Append(gameobject.transform.DOScale(1.1f, 0.2f));
        seq.Append(gameobject.transform.DOScale(1f, 0.1f));

        seq.Play();
    }

    public void HideUI(GameObject gameobject)
    {
        if (gameobject == null || gameobject.activeSelf == false) return;

        gameobject.transform.localScale = Vector3.one;

        var seq = DOTween.Sequence();

        seq.Append(gameobject.transform.DOScale(1.1f, 0.1f));
        seq.Append(gameobject.transform.DOScale(0.2f, 0.2f));

        seq.Play().OnComplete(() =>
        {
            gameobject.SetActive(false);
        });
    }
}
