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
        // Проверяем, нажата ли клавиша "E"
        if (Input.GetKeyDown(KeyCode.E) && canChangeAnimation)
        {
            // Меняем анимацию объекта
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
        // Если игрок вышел из коллизии с объектом, сбрасываем флаг
       

        if (other.CompareTag("Stone3"))
        {

            objectAnimator = null;
            canChangeAnimation = false;
        }
    }

    void ChangeObjectAnimation()
    {
        // Проверяем, что аниматор объекта существует
        if (objectAnimator != null)
        {
            // Меняем анимацию объекта (например, переключаем на анимацию "NewAnimation")
            objectAnimator.SetTrigger("ChangeAnimation");
            canChangeAnimation = false;
            NumCom.SetActive(true);
            OldComm3.SetActive(false);

        }
    }



}
