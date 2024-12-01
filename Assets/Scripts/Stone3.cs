using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone3 : MonoBehaviour
{

    private Animator objectAnimator;
    private bool canChangeAnimation = false;
    public GameObject OldComm3;
    public GameObject NumCom;
    // Start is called before the first frame update
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

       

        if (other.CompareTag("Stone3"))
        {

            objectAnimator = other.GetComponent<Animator>();
            canChangeAnimation = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // ���� ����� ����� �� �������� � ��������, ���������� ����
       

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
            NumCom.SetActive(true);
            OldComm3.SetActive(false);

        }
    }



}
