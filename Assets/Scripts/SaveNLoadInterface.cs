using Unity;
using UnityEngine;

public interface SaveInterface
{


    public void GiveData(PlayerData data, Vector2 playerPos);

}
public interface GetInfoInterface
{
    public void TryGetData(SaveLoadScript target);

    public void LoadGame(PlayerData data);
}