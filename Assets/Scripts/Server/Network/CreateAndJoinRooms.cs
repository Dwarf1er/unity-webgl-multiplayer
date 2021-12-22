using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    private Button createButton;
    private Button joinButton;
    private TMP_InputField createInputField;
    private TMP_InputField joinInputField;

    private void Start()
    {
        createButton = GameObject.Find("CreateButton").GetComponent<Button>();
        joinButton = GameObject.Find("JoinButton").GetComponent<Button>();
        createInputField = GameObject.Find("CreateInputField").GetComponent<TMP_InputField>();
        joinInputField = GameObject.Find("JoinInputField").GetComponent<TMP_InputField>();

        createButton.onClick.AddListener(() => CreateRoom());
        joinButton.onClick.AddListener(() => JoinRoom());
    }

    private void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createInputField.text);
    }

    private void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInputField.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
