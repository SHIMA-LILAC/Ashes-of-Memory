using UnityEngine;

public class StoneController : MonoBehaviour
{
    
    
    private TextMesh commentText;

    public int movedStonesCount = 0;
    public GameObject newCollisionObject; // —сылка на новую коллизию

    void Start()
    {
       
        commentText = GetComponentInChildren<TextMesh>();
    }

    void OnMouseDown()
    {
          
            commentText.gameObject.SetActive(false); // —крываем комментарий

         
    }
}