using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Begg : MonoBehaviour
{
    public Button nextSceneButton; // Ссылка на кнопку, которая должна появиться
    public float delayTime = 5f; // Время задержки в секундах

    void Start()
    {
        // Отключаем кнопку при старте
        nextSceneButton.gameObject.SetActive(false);

        // Запускаем корутину для задержки
        StartCoroutine(ShowButtonAfterDelay());
    }

    IEnumerator ShowButtonAfterDelay()
    {
        // Ждем указанное время
        yield return new WaitForSeconds(delayTime);

        // Включаем кнопку
        nextSceneButton.gameObject.SetActive(true);
    }

    public void LoadNextScene()
    {



        SceneManager.LoadScene("1MainMenu");



    }

}
