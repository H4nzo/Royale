using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;

public class NetworkManagerUI : MonoBehaviour
{
    [SerializeField] private Button serverBTN;
    [SerializeField] private Button hostBTN;
    [SerializeField] private Button clientBTN;


    private void Awake()
    {
            Debug.Log("Awake is called");
            serverBTN.onClick.AddListener(() =>
            {
                Debug.Log("Server Selected");
                NetworkManager.Singleton.StartServer();
            });
            hostBTN.onClick.AddListener(() =>
           {
               Debug.Log("Host Selected");
               NetworkManager.Singleton.StartHost();

           });
            clientBTN.onClick.AddListener(() =>
           {
               Debug.Log("Client Selected");
               NetworkManager.Singleton.StartClient();

           });
        Debug.Log("Awake is called");
        //  NetworkManager.Singleton.StartHost();

        // StartCoroutine(StartHost());
    }

    public void StartServer()
    {
        
        Debug.Log("Server Selected");
        NetworkManager.Singleton.StartServer();
    }

    IEnumerator StartHost()
    {
        yield return new WaitForSeconds(4f);
        Debug.Log("Host Selected");
        NetworkManager.Singleton.StartHost();
    }

    public void StartClient()
    {
        Debug.Log("Client Selected");
        NetworkManager.Singleton.StartClient();
    }



}
