using UnityEngine;
using TMPro; // ���� ����������� TextMeshPro

public class CommentSwitcher : MonoBehaviour
{
    public TextMeshProUGUI commentText1; // ������ ��������� ����
    public TextMeshProUGUI commentText2; // ������ ��������� ����
    public TextMeshProUGUI commentText3; // ������ ��������� ����
    public GameObject ramka;
    private string[] comments = new string[3]; // ������ ��� �������� ������������
    private int currentIndex = 0; // ������ �������� �����������

    void Start()
    {
        // ������������� ������������
        comments[0] = "It seems that there used to be a pond here. But the water is gone, or dried up after a long time... I'm sure it was very beautiful here at one time.";
        comments[1] = "This strange rock reminds me of something. Only something is missing... Water, exactly!";
        comments[2] = "This rock is somehow connected with the lake. Perhaps it's a matter of reflection.";

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
        commentText3.text = comments[currentIndex];
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
        commentText3.gameObject.SetActive(false);
        ramka.SetActive(false);
    }

    void ShowComments()
    {
        // ���������� �����������
        commentText1.gameObject.SetActive(true);
        commentText2.gameObject.SetActive(true);
        commentText3.gameObject.SetActive(true);
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