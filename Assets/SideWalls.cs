using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWalls : MonoBehaviour {


    public TextMesh score1;
    public TextMesh score2;
    public Rigidbody2D raccoonRigidBody;

    void raccoonBallStart()
    {
        float rand = Random.Range(0, 2);
        // pour ne pas commencer toujours du même côté
        if (rand < 2)
        {
            raccoonRigidBody.AddForce(new Vector2(10, -15));
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
        //transform.position = new Vector3(0, 0, -0.1f);  // Stopper la balle
    }


    void OnTriggerEnter2D(Collider2D hitInfo) {
		if (hitInfo.name == "Ball")
		{
			string wallName = transform.name;
            Debug.Log(wallName);
			if (wallName == "RightWall")
            {
                score1.text = (int.Parse(score1.text) + 1).ToString();
                ResetBall();
                Invoke("raccoonBallStart", 2);
            }
            else if (wallName == "LeftWall")
            {
                score2.text = (int.Parse(score2.text) + 1).ToString();
                ResetBall();
                Invoke("raccoonBallStart", 2);
            }
            

        }
	}
}
