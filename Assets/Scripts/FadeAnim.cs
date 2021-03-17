using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeAnim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void FadeMeIn(CanvasGroup cg, float d)
    {
        StartCoroutine(FadeIn(cg, d));
    }

    public void FadeMeOut(CanvasGroup cg, float d)
    {
        StartCoroutine(FadeOut(cg, d));
    }

    IEnumerator FadeOut(CanvasGroup canvasGroup, float delay)
    {
        yield return new WaitForSecondsRealtime(delay);
        while (canvasGroup.alpha > 0)
        {
            canvasGroup.alpha -= Time.deltaTime / 2;
            yield return null;
        }
        canvasGroup.interactable = false;
        yield return null;
    }

    IEnumerator FadeIn(CanvasGroup canvasGroup, float delay)
    {
        yield return new WaitForSecondsRealtime(delay);
        while (canvasGroup.alpha < 0.95)
        {
            canvasGroup.alpha += Time.deltaTime;
            yield return null;
        }
        canvasGroup.interactable = false;
        yield return null;
    }

}
