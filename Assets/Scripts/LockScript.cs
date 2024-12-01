using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockScript : MonoBehaviour
{
    public PlayerData Data;
    public GameObject Door;
    public GameObject commentOld;
    public GameObject commentNew;
    public GameObject Num;
    bool canStartLock;
   // public GameObject Laaa;

    private void Start()
    {

        canStartLock = true;


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Проверяем, столкнулись ли мы с нужным объектом
        if (collision.gameObject.CompareTag("Num"))
        {
            canStartLock = false;
        }

    }
    void Update()
    {



        if (Input.GetKeyDown(KeyCode.E) && !canStartLock && commentOld)
        {
            canStartLock = true;
            Door.SetActive(true);
            commentOld.SetActive(false);
            commentNew.SetActive(false);
            Num.SetActive(false);
           // Laaa.SetActive(true);
        }
    }
}
