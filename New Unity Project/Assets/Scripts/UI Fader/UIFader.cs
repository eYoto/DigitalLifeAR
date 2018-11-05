using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFader : MonoBehaviour {

    public CanvasGroup uiElement;

    public void FadeIn()
    {
        StartCoroutine(FadeUI(uiElement, uiElement.alpha, 1));
        uiElement.gameObject.SetActive(true);
    }

    public void FadeOut()
    {
        StartCoroutine(FadeUI(uiElement, uiElement.alpha, 0));
        if(uiElement.alpha == 0)
        uiElement.gameObject.SetActive(false);
    }

    public void ToggleMenu()
    {
        if (uiElement.alpha == 0)
            FadeIn();
        else
            FadeOut();
    }

    public IEnumerator FadeUI(CanvasGroup indexUI, float start, float end, float lerpTime = 0.5f)
    {
        float _timeStartedLerping = Time.time;
        float timeSinceStarted = Time.time - _timeStartedLerping;
        float percentageComplete = timeSinceStarted / lerpTime;

        while (true)
        {
            timeSinceStarted = Time.time - _timeStartedLerping;
            percentageComplete = timeSinceStarted / lerpTime;

            float currentValue = Mathf.Lerp(start, end, percentageComplete);

            indexUI.alpha = currentValue;

            if (percentageComplete >= 1) break;

            yield return new WaitForEndOfFrame();
        }
    }




}
