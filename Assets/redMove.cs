using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redMove : MonoBehaviour
{
    float x;
    float y;
    Vector3 dir;

    [SerializeField]float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        dir = ((Vector3.forward * y) + (Vector3.right * x)).normalized;
        transform.position += dir * speed * Time.deltaTime;
    }
}
