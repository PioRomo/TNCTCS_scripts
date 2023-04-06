using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimeGirlScript : MonoBehaviour
{
    public Transform player;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player") {
            transform.LookAt(player);
        }
    }
}
