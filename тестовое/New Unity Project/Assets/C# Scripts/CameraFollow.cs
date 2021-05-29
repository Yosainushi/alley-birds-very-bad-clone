using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform heroPos;
    // Update is called once per frame
    void Update()
    {
        if (heroPos.position.y>transform.position.y)
        {
            transform.position = new Vector3(transform.position.x,heroPos.position.y,transform.position.z);
        }
    }
}
