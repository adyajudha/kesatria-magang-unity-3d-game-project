using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit Trigger");
        //Player.transform.position = new Vector3(0, 6, 0);
        Player.transform.position = respawnPoint.transform.position;
    }
}
