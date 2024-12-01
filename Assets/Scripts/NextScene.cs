using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    private bool canTransition = false;
    SaveLoadScript Saver;
    [SerializeField] string targetScene;
    GameObject Player;

    
    private void Start()
    {
        Saver = GetComponent<SaveLoadScript>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Проверяем, столкнулись ли мы с нужным объектом
        if (collision.gameObject.CompareTag("Player"))
        {
            canTransition = true;
            Debug.Log("переход");
            Player = collision.gameObject;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // Проверяем, вышли ли мы из столкновения с нужным объектом
        if (collision.gameObject.CompareTag("Player"))
        {
            canTransition = false;
            Player = null;
        }
    }

    public void Update()
    {
        // Проверяем, нажата ли клавиша "E" и можно ли переходить на новую сцену
        if (canTransition == true && Input.GetKeyDown(KeyCode.E) && Player != null)
        {

            Saver.SaveGame(Player);
            SceneManager.LoadScene(targetScene);
            Debug.Log("AAA");
        }
    }

    public void LoadScene()
    {
        if(Saver != null) { 
             Saver.SaveGame(Player);
        SceneManager.LoadScene(targetScene);
        Debug.Log("AAA");
        }
       
    }
}
