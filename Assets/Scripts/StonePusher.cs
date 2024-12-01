using UnityEngine;

public class StonePusher : MonoBehaviour
{
    private Animator objectAnimator; 
    private bool canChangeAnimation = false;
    public bool CanComment;
    public GameObject OldComm;
    public GameObject OldComm2;
    


    private void Start()
    
    {
        CanComment = true;
    }

        void Update()
    {
        // ���������, ������ �� ������� "E"
        if (Input.GetKeyDown(KeyCode.E) && canChangeAnimation)
        {
            // ������ �������� �������
            ChangeObjectAnimation();
        }
    }

    

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Stone"))
        {
            
            objectAnimator = other.GetComponent<Animator>();
            canChangeAnimation = true;
        }

        if (other.CompareTag("Stone2"))
        {
            
            objectAnimator = other.GetComponent<Animator>();
            canChangeAnimation = true;
        }

        if (other.CompareTag("Stone3"))
        {
            
            objectAnimator = other.GetComponent<Animator>();
            canChangeAnimation = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // ���� ����� ����� �� �������� � ��������, ���������� ����
        if (other.CompareTag("Stone"))
        {
           
            objectAnimator = null;
            canChangeAnimation = false;
        }

        if (other.CompareTag("Stone2"))
        {
            
            objectAnimator = null;
            canChangeAnimation = false;
        }

        if (other.CompareTag("Stone3"))
        {
            
            objectAnimator = null;
            canChangeAnimation = false;
        }
    }

    void ChangeObjectAnimation()
    {
        // ���������, ��� �������� ������� ����������
        if (objectAnimator != null)
        {
            // ������ �������� ������� (��������, ����������� �� �������� "NewAnimation")
            objectAnimator.SetTrigger("ChangeAnimation");
            canChangeAnimation = false;
            //NumCom.SetActive(true);
            //OldComm.SetActive(false);
            //OldComm2.SetActive(false);
           
        }
    }

    

       
 }


    
