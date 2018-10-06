using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour {

    public List<Transform> balls;

    void Start()
    {
       Ball[] ballsObjects = GameObject.FindObjectsOfType<Ball>();
        foreach (Ball ball in ballsObjects)
        {
            balls.Add(ball.gameObject.transform);
        }
    }

    public void AddBall(Transform ball)
    {

    }
    public void RemoveBall()
    {

    }

}
