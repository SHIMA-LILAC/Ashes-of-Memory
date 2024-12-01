using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liana : MonoBehaviour
{

    public PlayerData Data;
    public GameObject OldVine;
    public GameObject commentOld;
    public GameObject commentNew;
    public GameObject liana;
    bool ChangeVines;
    public GameObject Lock;
    // Start is called before the first frame update
    void Start()
    {
        ChangeVines = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Проверяем, столкнулись ли мы с нужным объектом
        if (collision.gameObject.CompareTag("Ebanina"))
        {
            ChangeVines = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !ChangeVines && commentOld)
        {
            ChangeVines = true;
            OldVine.SetActive(false);
            commentOld.SetActive(false);
            commentNew.SetActive(true);
            liana.SetActive(true);
            Lock.SetActive(true);
        }
    }
}
