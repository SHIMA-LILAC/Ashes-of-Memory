using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Button selectedButton; // ������ �� ������, ������� ����� ���������
    public CommentTrigger commentTrigger; // ������ �� ������ � ������������

    void Update()
    {
        // ���������, ������� �� ������
        if (selectedButton != null && selectedButton.gameObject.activeInHierarchy)
        {
            if (selectedButton.interactable && selectedButton.GetComponent<Button>().IsInteractable())
            {
                Debug.Log("Selected button is interactable"); // ���������� ���������
                commentTrigger.OnCommentRead(); // ���������� ������ � ������������, ��� ������� ���������
            }
        }
    }
}