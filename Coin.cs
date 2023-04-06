using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin")) {
            Destroy(other.gameObject);
            CoinCounter.instance.IncreaseCoins(); 
        }
    }
}
