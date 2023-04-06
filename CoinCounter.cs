using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public static CoinCounter instance;
    public TextMeshProUGUI text; 
    public static int coinAmount; 

    public GameObject cube; 

    private void Awake()
    {
        instance = this; 
    }

    // Start is called before the first frame update
    void Start()
    {
        text.text = "COINS: " + coinAmount.ToString(); 
    }

    

    public void IncreaseCoins() {
        coinAmount++;
        text.text = "COINS: " + coinAmount.ToString();
        if (coinAmount == 12)
        {
            Instantiate(cube, new Vector3(-272 , 2, -9), Quaternion.identity);
            text.text = "When you're ready, find a way out of town.";
            
        }
    }
}
