using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class useSinCosTan : MonoBehaviour
{
    [SerializeField] float xSpeed;
    [SerializeField] float ySpeed;
    [SerializeField] float scaleX;
    [SerializeField] float scaleY;
    Vector3 dirX;
    Vector3 dirY;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dirX =Vector3.right * Mathf.Cos(xSpeed*Time.time)*scaleX;
        dirY= Vector3.forward * Mathf.Sin(ySpeed * Time.time) * scaleY;
        transform.position += dirX + dirY;
    }
}
