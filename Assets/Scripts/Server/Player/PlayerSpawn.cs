using UnityEngine;
using Photon.Pun;

public class PlayerSpawn : MonoBehaviour
{
    public GameObject playerPrefab;

    private void Start()
    {
        PhotonNetwork.Instantiate(playerPrefab.name, playerPrefab.GetComponent<Player>().spawnPosition, Quaternion.identity);
    }
}
