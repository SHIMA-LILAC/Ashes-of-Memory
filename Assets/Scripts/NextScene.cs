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
        // ���������, ����������� �� �� � ������ ��������
        if (collision.gameObject.CompareTag("Player"))
        {
            canTransition = true;
            Debug.Log("�������");
            Player = collision.gameObject;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // ���������, ����� �� �� �� ������������ � ������ ��������
        if (collision.gameObject.CompareTag("Player"))
        {
            canTransition = false;
            Player = null;
        }
    }

    public void Update()
    {
        // ���������, ������ �� ������� "E" � ����� �� ���������� �� ����� �����
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
