using UnityEngine;

public class StoneController : MonoBehaviour
{
    
    
    private TextMesh commentText;

    public int movedStonesCount = 0;
    public GameObject newCollisionObject; // ������ �� ����� ��������

    void Start()
    {
       
        commentText = GetComponentInChildren<TextMesh>();
    }

    void OnMouseDown()
    {
          
            commentText.gameObject.SetActive(false); // �������� �����������

         
    }
}