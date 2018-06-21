using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToHub : MonoBehaviour
{
    public CoinManager coinManager;
    public CoinScript coinScript;

    public void Return()
    {
        coinScript.AddCoins(coinManager.GetCoins());
        SceneManager.LoadScene(0);
    }
}
