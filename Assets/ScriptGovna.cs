using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScriptGovna : MonoBehaviour
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

    // ����� ��� �������� �� ��������� �����
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
