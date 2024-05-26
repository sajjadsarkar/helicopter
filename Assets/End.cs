using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public GameObject Win;
    private void Start()
    {
        Win.SetActive(false);

    }
    private void OnTriggerEnter(Collider other)
    {

        if(GameManager.Instance.totalCoin < GameManager.Instance.howMuchCoinToCollect)
        {
            GameManager.Instance.GameOver();
        }
        if (GameManager.Instance.totalCoin == GameManager.Instance.howMuchCoinToCollect)
        
            {
            Win.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
