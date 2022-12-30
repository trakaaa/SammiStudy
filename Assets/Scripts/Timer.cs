using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    [Header("Time Control")]
    public float limitTime;
    public Text textTimer;
    int min;
    float sec;

	void Update()
    {
        if (GameStart.teststart)
        {
            if (limitTime > 0)
            {
                limitTime -= Time.deltaTime;

                if (limitTime >= 20f)
                {
                    //min = (int)limitTime / 60;
                    //sec = limitTime % 60;
                    //textTimer.text = min + " : " + (int)sec;
                    textTimer.text = "<color=white>" + (int)limitTime + "</color>";
                }
                if (limitTime < 20f)
                {
                    textTimer.text = "<color=red>" + (int)limitTime + "</color>";
                }
            }
            else
            {
                GameStart.teststart = false;
                SceneManager.LoadScene("GameOver");
                // Invoke("GameOverScene", 3f);
            }
        }
    }

	//void GameOverScene()
	//{
	//	//new WaitForSeconds(1);

	//	SceneManager.LoadScene("GameOver");
	//}
}