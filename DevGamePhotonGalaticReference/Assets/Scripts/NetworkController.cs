using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkController : MonoBehaviourPunCallbacks
{
    public static NetworkController Instancia { get; private set; }

    private void Awake()
    {
        if(Instancia !=null && Instancia != this)
        {
            gameObject.SetActive(false);
            return;
        }

        Instancia = this;
        DontDestroyOnLoad(gameObject);
    }


    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Conectando ao servidor");
    }
}
