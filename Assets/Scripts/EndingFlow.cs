using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingFlow : MonoBehaviour
{
    public float moveSpeed = -1.0f;
    public float moveTime = 0.3f;
    public Vector3 StartPosition = new Vector3(0, 600, 0);
    public GameObject button;

    private void Awake()
    {
        transform.position += StartPosition;
        button.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
       // StartCoroutine(flowEndingCredit());  
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(0, moveSpeed, 0);
        transform.Translate(move);

        if (transform.position.y <= -100)
        {
            button.SetActive(true);
        }
    }

    //IEnumerator flowEndingCredit()
    //{
    //    Vector3 move = new Vector3(0, moveSpeed, 0);

    //    while (transform.position.y > -2000.0f)
    //    {
    //        transform.Translate(move);
    //        yield return new WaitForSeconds(moveTime);

    //    }

    //}

}
