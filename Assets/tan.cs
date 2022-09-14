using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tan : MonoBehaviour
{
    [SerializeField] GameObject blue;
    [SerializeField] GameObject red;
    [SerializeField] Text ui;

    [SerializeField] float degree;
    Vector3 dir;


    void Start()
    {
        
    }

    // 여기서 각도를 측정하는 부분
    
    void Update()
    {
        dir = red.transform.position - blue.transform.position;
        degree = Mathf.Atan2(dir.z,dir.x)*Mathf.Rad2Deg;
        ui.text = degree.ToString();
    }
}
