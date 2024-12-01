using UnityEngine;
using TMPro; // ���� ����������� TextMeshPro

public class CommentSChanger : MonoBehaviour
{
    public TextMeshProUGUI commentText1; // ������ ��������� ����
    public TextMeshProUGUI commentText2; // ������ ��������� ����
    
    public GameObject ramka;
    private string[] comments = new string[3]; // ������ ��� �������� ������������
    private int currentIndex = 0; // ������ �������� �����������

    void Start()
    {
        // ������������� ������������
        comments[0] = "Wow! I've never been here before. My mother forbade me to approach these strange stones. ";
        comments[1] = "These ruins haunt me. Somehow strange they lie... It's not just like that, right?";
       

        // �������� ����������� ��� ������
        HideComments();
    }

    void Update()
    {
        // �������� ������� ������� "E"
        if (Input.GetKeyDown(KeyCode.E))
        {
            SwitchComment();
        }
    }

    void UpdateComment()
    {
        // ���������� ������ � ��������� �����
        commentText1.text = comments[currentIndex];
        commentText2.text = comments[currentIndex];
        
    }

    void SwitchComment()
    {
        // ������������ �� ��������� �����������
        currentIndex = (currentIndex + 1) % comments.Length;
        UpdateComment();
    }

    void HideComments()
    {
        // �������� �����������
        commentText1.gameObject.SetActive(false);
        commentText2.gameObject.SetActive(false);
        
        ramka.SetActive(false);
    }

    void ShowComments()
    {
        // ���������� �����������
        commentText1.gameObject.SetActive(true);
        commentText2.gameObject.SetActive(true);
       
        ramka.SetActive(true);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // ���������, �������� �� ������ �������
        if (other.CompareTag("Player"))
        {
            // ���������� ����������� � ������������� ������ �����������
            ShowComments();
            UpdateComment();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // ���������, �������� �� ������ �������
        if (other.CompareTag("Player"))
        {
            // �������� �����������
            HideComments();
        }
    }
}