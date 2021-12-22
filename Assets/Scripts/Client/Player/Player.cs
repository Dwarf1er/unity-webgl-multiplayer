using UnityEngine;
using Photon.Pun;

public class Player : MonoBehaviour
{
    public Vector3 spawnPosition;
    private PhotonView photonView;
    private float speed;

    private void Start()
    {
        spawnPosition = new Vector3(0f, 0.5f, 0f);
        photonView = GetComponent<PhotonView>();
        speed = 15f;
    }

    private void Update()
    {
        if(photonView.IsMine)
        {
            Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
            transform.position += input.normalized * speed * Time.deltaTime;
        }
    }
}
