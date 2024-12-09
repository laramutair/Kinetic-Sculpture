using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class move : MonoBehaviour
{

  public GameObject[] balls; 
    public float speed = 1.5f;  

    Vector3[] initialLocalPositions;

    void Start()
    {
        initialLocalPositions = new Vector3[balls.Length];
        for (int i = 0; i < balls.Length; i++)
        {
            initialLocalPositions[i] = balls[i].transform.localPosition;
        }
    }

    void Update()
    {
        for (int i = 0; i < balls.Length; i++)
        {
            float xNew = Mathf.Sin(Time.time * speed + i) *0.4f;
            
            balls[i].transform.localPosition = new Vector3(initialLocalPositions[i].x + xNew,initialLocalPositions[i].y,initialLocalPositions[i].z);
        }
    }
}
