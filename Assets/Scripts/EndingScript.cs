using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingScript : MonoBehaviour
{
    public Image FadeOutCanvas;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeOut());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator FadeOut()
    {
        float fadeCount = 1.0f;
        while (fadeCount > 0)
        {
            fadeCount -= 0.01f;

            FadeOutCanvas.color = new Color(255, 255, 255, fadeCount);

            yield return new WaitForSeconds(0.01f);
        }

    }


    //IEnumerator FadeOut()
    //{
    //    float fadeCount = 255;

    //    //Debug.Log(fadeCount.ToString() + "½ÃÀÛ");

    //    while (fadeCount > 0)
    //    {
    //        fadeCount -= 1.0f;

    //        //Debug.Log(fadeCount.ToString());

    //        FadeOutCanvas.color = new Color(fadeCount, fadeCount, fadeCount, 1.0f);

    //        yield return new WaitForSeconds(0.01f);
    //    }

    //}
}
