using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject Ball;

    [Header("Player1")]
    public GameObject Player1Paddle;
    public GameObject Player1Goal;

    [Header("Player2")]
    public GameObject Player2Paddle;
    public GameObject Player2Goal;

    [Header("PlayerUI")]
    public GameObject Player1Text;
    public GameObject Player2Text;

    private int player1score;
    private int player2score;

    private void ResetPosition()
    {
        Ball.GetComponent<Ball>().Reset();
    }

    public void Player1Scored()
    {
        player1score++;
        Player1Text.GetComponent<TextMeshProUGUI>().text = player1score.ToString();
        ResetPosition();
    }

    public void Player2Scored()
    {
        player2score++;
        Player2Text.GetComponent<TextMeshProUGUI>().text = player2score.ToString();
        ResetPosition();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
