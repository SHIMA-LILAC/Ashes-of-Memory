using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; // ���������� ���������� ��� ������ � �������

public class CommentTrigger : MonoBehaviour
{
    public GameObject commentUI; // ������ �� UI ������� � ������������
    public TextMeshProUGUI commentText; // ������ �� ��������� ��������� �����������
    public string nextSceneName; // ��� �����, �� ������� ����� �������
    public GameObject DialogueBox;
   
    private bool commentRead = false;
   

    void Start()
    {
        commentUI.SetActive(false); // �������� ����������� ��� ������
    }

    void Update()
    {
       
                // ���� ����������� ��� ��������, ���� ������� ������� E ��� �������� �� ������ �����
                if (Input.GetKeyDown(KeyCode.E) && commentRead)
                {
                    SceneManager.LoadScene(nextSceneName);
                }
            
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           
            Debug.Log("Player entered the trigger zone"); // ���������� ���������
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            commentUI.SetActive(false); // �������� �����������, ���� ����� ����� �� ����
            Debug.Log("Player exited the trigger zone"); // ���������� ���������
            DialogueBox.SetActive(false);
        }
    }

    // ���������� �� ������� �������, ����� ����� �������� ������� � ���������
    public void OnCommentRead()
    {
        Debug.Log("Comment read!"); // ���������� ���������
        commentRead = true;
        commentText.text = "We thought we had inhabited an empty planet! But it turns out that completely different creatures used to live here! We are somewhat alike... It's a pity that I can only see you in a picture. We need to tell the rest of us. Press E.";
        commentUI.SetActive(true); // ���������� ����������� �����������
        DialogueBox.SetActive(true);
        
    }
}