using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer1Goal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (!isPlayer1Goal)
            {
                print("Player 1 Scored!");
                GameObject.Find("GameManager").GetComponent<GameManager>().Player1Scored();
            }
            else
            {
                print("Player 2 Scored!");
                GameObject.Find("GameManager").GetComponent<GameManager>().Player2Scored();
            }
        }
    }
}
