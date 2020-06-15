using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarController : MonoBehaviour
{
    private Vector3 acceleration;
    private Compass compass;
    private Quaternion gyro;
    private GUIStyle labelStyle;
    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        this.acceleration = Input.acceleration;
        this.compass = Input.compass;
        this.gyro = Input.gyro.attitude;
        Debug.Log(gyro.x);
        transform.position -= transform.right * gyro.x;
        if (transform.position.x >= 1.5) transform.position = new Vector3(1.5f, transform.position.y, transform.position.z);
        if (transform.position.x <= -1.5) transform.position = new Vector3(-1.5f, transform.position.y, transform.position.z);
    }
}
