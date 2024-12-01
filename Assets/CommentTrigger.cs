using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; // Подключаем библиотеку для работы с текстом

public class CommentTrigger : MonoBehaviour
{
    public GameObject commentUI; // Ссылка на UI элемент с комментарием
    public TextMeshProUGUI commentText; // Ссылка на текстовый компонент комментария
    public string nextSceneName; // Имя сцены, на которую нужно перейти
    public GameObject DialogueBox;
   
    private bool commentRead = false;
   

    void Start()
    {
        commentUI.SetActive(false); // Скрываем комментарий при старте
    }

    void Update()
    {
       
                // Если комментарий уже прочитан, ждем нажатия клавиши E для перехода на другую сцену
                if (Input.GetKeyDown(KeyCode.E) && commentRead)
                {
                    SceneManager.LoadScene(nextSceneName);
                }
            
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           
            Debug.Log("Player entered the trigger zone"); // Отладочное сообщение
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            commentUI.SetActive(false); // Скрываем комментарий, если игрок вышел из зоны
            Debug.Log("Player exited the trigger zone"); // Отладочное сообщение
            DialogueBox.SetActive(false);
        }
    }

    // Вызывается из другого скрипта, когда игрок прочитал записку в инвентаре
    public void OnCommentRead()
    {
        Debug.Log("Comment read!"); // Отладочное сообщение
        commentRead = true;
        commentText.text = "We thought we had inhabited an empty planet! But it turns out that completely different creatures used to live here! We are somewhat alike... It's a pity that I can only see you in a picture. We need to tell the rest of us. Press E.";
        commentUI.SetActive(true); // Показываем обновленный комментарий
        DialogueBox.SetActive(true);
        
    }
}