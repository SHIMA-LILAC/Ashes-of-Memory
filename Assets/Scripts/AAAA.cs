using System.Linq;
using UnityEngine;

public class AAAA : MonoBehaviour, GetInfoInterface, SaveInterface

{
    SaveLoadScript Saver;
    public PlayerData Data;

    

    private void Start()
    {
        Saver = GetComponent<SaveLoadScript>();
        if (Saver != null)
        {
            Saver.LoadGame(this.gameObject);
            Debug.Log("GameLoaded");
        }

    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    // ���������, �������� �� ������, � ������� ���������� �����, ��������
    //    if (collision.CompareTag("Candy"))
    //    {
    //        canCollectCandy = collision.gameObject;

    //    }
    //}

    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Candy")) ;
    //    {
    //        canCollectCandy = null;
    //    }
    //}


    public void Update()
    {
        //if (canCollectCandy != null && Input.GetKeyDown(KeyCode.E))
        //{
        //    Debug.Log("+ ���� �������");
        //    Data.CandyCount++;

        //    for (int i = 0; i < Data.CollectedCandies.Length; i++)
        //    {
        //        if (Data.CollectedCandies[i] == "")
        //        {
        //            Data.CollectedCandies[i] = canCollectCandy.gameObject.name;
        //            break;
        //        }
        //    }

        //    Destroy(canCollectCandy);

        //}


    //    if (Data.CandyCount >= 10)
    //    {
    //        if (Drawing != null && Penta != null)
    //        {
    //            Drawing.SetActive(false);
    //            Penta.SetActive(true);
    //        }
    //        //���� ������� ���, ����� � ��� �� ����� ����� ��������� ��������� ����������� � ��������� ����������� �������� ����.


    //    }

    //    if (Data.CandyCount == 15)
    //    {
    //        // ������ ��������� �������, ��� ���� �����, � ��� � ������� �������

    //    }
    }

    void GetInfoInterface.LoadGame(PlayerData data)
    {
        Data = data;
        transform.position = Data.playerPos;
        Debug.Log("posSet");

        //GameObject[] PickupObjects = GameObject.FindGameObjectsWithTag("Candy");
        //for (int i = 0; i < PickupObjects.Length; i++)
        //{
        //    if ((Data.CollectedCandies.Contains(PickupObjects[i].gameObject.name)))
        //    {
        //        Destroy(PickupObjects[i].gameObject);
        //    }
        //}
    }

    void GetInfoInterface.TryGetData(SaveLoadScript target)
    {
        target.gameObject.GetComponent<SaveInterface>().GiveData(Data, this.gameObject.transform.position);
    }

    void SaveInterface.GiveData(PlayerData data, Vector2 playerPos)
    {

    }

    //public void AddCandy(int CandiesToAdd)
    //{
    //    Debug.Log("+ ��� �������");
    //    Data.CandyCount = Data.CandyCount + CandiesToAdd;
    //}
}