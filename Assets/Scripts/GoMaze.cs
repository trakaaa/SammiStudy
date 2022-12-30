using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoMaze : MonoBehaviour
{

public void SceneChange()
    {
        SceneManager.LoadScene("MazeRun");
    }
}
