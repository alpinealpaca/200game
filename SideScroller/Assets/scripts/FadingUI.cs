using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadingUI : MonoBehaviour
{
    public class myFadePanelClass : MonoBehaviour

    {
        /*public Image myPanel;
        float fadeTime = 3f;
        Color colorToFadeTo;


        void Start()
        {
            colorToFadeTo = new Color(1f, 1f, 1f, 0f);
            myPanel.CrossFadeColor(colorToFadeTo, fadeTime, true, true);
        }*/

        /*[SerializeField] private float fadeSpeed = 1.0f; // Speed of the fade effect

        private CanvasGroup fadeCanvasGroup;

        private float alpha = 1.0f;

        void Awake()
        {
            fadeCanvasGroup = GetComponent<CanvasGroup>();
            if (fadeCanvasGroup == null)
                Debug.LogError("[warning] Please add Canvas Group component to the Fade Canvas for the fade effect");
            if (fadeCanvasGroup != null) fadeCanvasGroup.alpha = alpha;
        }

        void Update()
        {
            if (alpha >= 0.0f)
            {
                alpha -= Time.deltaTime * fadeSpeed;
                fadeCanvasGroup.alpha = alpha;
                Debug.Log(alpha);
            }
        }*/

    }

}