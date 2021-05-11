using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class TailMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector3 tailTarget;
    [SerializeField] private float zOffSet;
    public GameObject tailTargetObject;
    public static SnakeMovement mainSnake;


    void Start()
    {
        mainSnake = GameObject.FindWithTag("Player").GetComponent<SnakeMovement>();
        if(mainSnake != null)
            speed = mainSnake.speed;
       // tailTargetObject = mainSnake.tailObjects[mainSnake.tailObjects.Count - 2 ];
    }

    void FixedUpdate()
    {
        tailTarget = tailTargetObject.transform.position;
        transform.LookAt(tailTarget);
        transform.position = Vector3.Lerp(transform.position, tailTarget, Time.deltaTime * speed);
        tailTarget.z -= zOffSet;
    }
}
