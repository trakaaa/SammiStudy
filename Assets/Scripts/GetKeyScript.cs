using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GetKeyScript : MonoBehaviour
{
    public int KeyCount = 0;
    public GameObject Gate;
    public Image FadeOutCanvas;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Key")
        {
            KeyCount++;

            ToastMsg.Instrance.showMessage("키를 먹었습니다 " + KeyCount.ToString() + "/5" , 1.0f);

            //other.gameObject.SetActive(false);
            Destroy(other.gameObject);
            
            if (KeyCount >= 5)
            {
                Invoke("GateOpen", 3f);
            }
        }

        if (other.gameObject.tag == "NextScene")
        {
            GameObject.Find("Text2").SetActive(false);
            ToastMsg.Instrance.showMessage("탈출", 3f);
            StartCoroutine(FadeOut());
            Invoke("EndingScene", 3f);
        }

    }

    void GateOpen()
    {
        ToastMsg.Instrance.showMessage("키를 모두 수집했습니다. 탈출구가 열렸습니다.", 1.0f);
        Gate.SetActive(true);
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (other.gameObject.tag == "Key")
    //    {
    //        ToastMsg.Instrance.showMessage("키를 먹었습니다", 1.0f);
    //    }
    //}

    void EndingScene()
    {
        new WaitForSeconds(2);

        SceneManager.LoadScene("Ending");
    }

    IEnumerator FadeOut()
    {
        float fadeCount = 0;
        while (fadeCount < 1)
        {
            fadeCount += 0.01f;

            FadeOutCanvas.color = new Color(255, 255, 255, fadeCount);

            yield return new WaitForSeconds(0.01f);
        }

    }


}
