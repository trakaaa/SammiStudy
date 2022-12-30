using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{
    [SerializeField] private Text TextTime;              //�����  UI Text
    private bool Timebool = true;    //�ڷ�ƾ ȣ���� ���� ���� ����
    public int DelayCount = 3;        //ȭ�鿡 ��� �� ������ ����
    public static bool teststart = false;

    // Update is called once per frame
    void Update()
    {
        //���� ������ ������ 0 �̶��
        if (DelayCount == 0)
        {
            //�ڷ�ƾ ����
            StopCoroutine("TimeDelay");
        }
        //���� ���� ������ �� �̶��
        if (Timebool)
        {
            //�ڷ�ƾ ȣ��
            StartCoroutine("TimeDelay");
        }
    }

    //�ڷ�ƾ ȣ��
    IEnumerator TimeDelay()
    {
        Timebool = false;
        //UI Text�� ������ ���� ����
        //TextTime.text = DelayCount.ToString();
        TextTime.text = "<color=blue>" + DelayCount + "</color>";
        //ToastMsg.Instrance.showMessage(DelayCount.ToString(), 1.0f);

        //1�� ��
        yield return new WaitForSeconds(1.0f);
        Debug.Log(DelayCount);

        //������ ���� 1����
        DelayCount--;

        //���� ������ ������ 0�̸�
        if (DelayCount == 0)
        {
            //TextTime.text = "Start";
            //�ؽ�Ʈ �ǳ��� ������� ��
            GameObject.Find("Text").SetActive(false);

            teststart = true;
        }
        //�ٽ� ���� ���� ������ �ڷ�ƾ ȣ��
        Timebool = true;
    }

}