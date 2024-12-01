using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextSceneButton : MonoBehaviour
{
    public Button nextSceneButton;
    
    

    private void Start()
    {
       // Saver = GetComponent<SaveLoadScript>();
    }
    public void LoadNextScene()
    {
        
       
           
            SceneManager.LoadScene("10Bunker");
           
           
        
    }
}
