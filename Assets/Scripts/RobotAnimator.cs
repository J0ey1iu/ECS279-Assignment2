using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotAnimator : MonoBehaviour
{

    public GameObject Robot;

    void Start()
    {
        Robot.SetActive(true);
        print("Robot is set active. \n");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            print("Space is pushed. \n");
            Robot.GetComponent<Animator>().Play("jump");
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            print("Forward is pushed. \n");
            Robot.GetComponent<Animator>().Play("walk");
        }
    }
}
