using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MenuButtonsManeger : MonoBehaviour
{
    public List<GameObject> buttons;

    [Header( "Animation" )]
    public float duration = .2f;
    public float delay = .5f;

    private void Awake ()
    {
        HideAllButtons();
        ShowButtons();
    }

    private void HideAllButtons ()
    {
        foreach (var button in buttons)
        {
            button.transform.localScale = Vector3.zero;
            button.SetActive( false );
        }
    }

    private void ShowButtons()
    {
        foreach (var button in buttons)
        {
            button.SetActive(true);
            button.transform.DOScale(1, duration).SetDelay(delay);
        }
    }


    /*
    IEnumerator ShowButtonsWithDelay ()
    {
        foreach (var button in buttons)
        {
            button.SetActive(true);
            button.transform.DOScale(1, duration);
            yield
        }
    }
    */
}
