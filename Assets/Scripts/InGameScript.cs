using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameScript : MonoBehaviour
{

    public GameObject Gate;


    private void Awake()
    {
        Gate.SetActive(false);
    }

    private void Start()
    {
        //StartCoroutine(FadeOut());
    }

    private void Update()
    {
    }



}
