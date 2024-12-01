using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Begg : MonoBehaviour
{
    public Button nextSceneButton; // ������ �� ������, ������� ������ ���������
    public float delayTime = 5f; // ����� �������� � ��������

    void Start()
    {
        // ��������� ������ ��� ������
        nextSceneButton.gameObject.SetActive(false);

        // ��������� �������� ��� ��������
        StartCoroutine(ShowButtonAfterDelay());
    }

    IEnumerator ShowButtonAfterDelay()
    {
        // ���� ��������� �����
        yield return new WaitForSeconds(delayTime);

        // �������� ������
        nextSceneButton.gameObject.SetActive(true);
    }

    public void LoadNextScene()
    {



        SceneManager.LoadScene("1MainMenu");



    }

}
