using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SideWalls : MonoBehaviour {


    public TextMesh score1;
    public TextMesh score2;
    public Rigidbody2D raccoonRigidBody;
    public TextMesh winText;
    public TextMesh fannyPasse;

    private int raccoonMaxScore = 10;

    void raccoonBallStart()
    {
        float rand = Random.Range(0, 2);
        // pour ne pas commencer toujours du même côté
        if (rand < 1)
        {
            raccoonRigidBody.AddForce(new Vector2(-10, -15));
        }
        else
        {
            raccoonRigidBody.AddForce(new Vector2(30, 15));
        }
    }

    void ResetBall()
    {
        raccoonRigidBody.velocity = new Vector2(0, 0);
        raccoonRigidBody.position = new Vector3(0, 0, -.1f);
    }


    void loadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }


    



    void OnTriggerEnter2D(Collider2D hitInfo) {
		if (hitInfo.name == "Ball")
		{
			string wallName = transform.name;

            if (wallName == "RightWall" || wallName == "LeftWall")
            {
                if (wallName == "RightWall")
                {
                    score1.text = (int.Parse(score1.text) + 1).ToString();
                    ResetBall();
                    if (int.Parse(score1.text) < raccoonMaxScore) {
                        Invoke("raccoonBallStart", 2);
                    }
                }
                else if (wallName == "LeftWall")
                {
                    score2.text = (int.Parse(score2.text) + 1).ToString();
                    ResetBall();
                    if (int.Parse(score2.text) < raccoonMaxScore)
                    {
                        Invoke("raccoonBallStart", 2);
                    }
                   
                }


                if (int.Parse(score1.text) >= raccoonMaxScore) {
                    winText.text = "RACCON 1 WON DA GAME";
                    raccoonRigidBody.velocity = new Vector2(0, 0);
                    raccoonRigidBody.position = new Vector3(0, 0, -.1f);
                    Invoke("loadMenuScene", 5);
                }

                if (int.Parse(score2.text) >= raccoonMaxScore)
                {
                    winText.text = "RACCON 2 WON DA GAME";
                    raccoonRigidBody.velocity = new Vector2(0, 0);
                    raccoonRigidBody.position = new Vector3(0, 0, -.1f);
                    Invoke("loadMenuScene", 5);
                }




            }

        }
	}
}
