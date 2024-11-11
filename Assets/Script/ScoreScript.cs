using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering.UI;

public class ScoreScript : MonoBehaviour
{
    public GameObject Ball;
    public GameObject Point1, Point2;
    public BallBounceScript BbScript;
    public TextMeshProUGUI PlayerScoreText1;
    public TextMeshProUGUI PlayerScoreText2;
    public TextMeshProUGUI ActualPlayer;


    public int PlayerScoreA;
    public int PlayerScoreB;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            
            if (gameObject.name == "PointPosition2")
            {
                Debug.Log("Punto per A");
                AddScore(1);
                if (BbScript.BallVelocity < 0)
                {
                    BbScript.BallVelocity = BbScript.BallVelocity * (-1);
                }
                else if (BbScript.BallVelocity > 0)
                {
                    BbScript.BallVelocity = BbScript.BallVelocity * (+1);
                }






            }

            else if (gameObject.name == "PointPosition1")
            {
                Debug.Log("Punto per B");
                AddScore(2);
                if (BbScript.BallVelocity > 0)
                {
                    BbScript.BallVelocity = BbScript.BallVelocity * (-1);
                }

                else if (BbScript.BallVelocity < 0)
                {
                    BbScript.BallVelocity = BbScript.BallVelocity * (+1);
                }







            }

            
        }
    }


    public void AddScore(int PlayerID)
    {
        if (PlayerID == 1)
        {
            PlayerScoreA++;
            PlayerScoreText1.text = PlayerScoreA.ToString();
        }

        if (PlayerID == 2)
        {
            PlayerScoreB++;
            PlayerScoreText2.text = PlayerScoreB.ToString();
        }


    }

}
