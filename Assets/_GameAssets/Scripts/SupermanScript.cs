using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupermanScript : MonoBehaviour
{
    public GameObject leftController;
    public GameObject rightController;
    public float maxHandsDistance = 0.5f;
    public float maxSpeed = 1;
    private float speed = 0;
    private Transform cameraTransform; 
    private CharacterController characterController;

    private float distance = 0;

    void Start()
    {
        cameraTransform = GameObject.Find("Main Camera").transform;
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        distance = (leftController.transform.position - rightController.transform.position).magnitude;
        if (distance < maxHandsDistance && distance > 0) {
            speed = 1/distance * maxSpeed; 
        } else if (distance <=0 ) {
            speed = maxSpeed;
        } else {
            speed = 0;
        }
        characterController.Move(cameraTransform.forward * speed * Time.deltaTime);  
    }
}
