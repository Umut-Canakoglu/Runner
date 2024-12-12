using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public int scoreVar = 0;
    public TextMeshProUGUI scoreText;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.tag == "Coin")
        {
            Debug.Log("Hit The Coin");
            scoreVar++;
        }
    }
    void Update()
    {
        scoreText.text = scoreVar.ToString();
    }
}
