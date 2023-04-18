using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyJoystick : MonoBehaviour
{
    public float speed;
    public float speedAmplifier;
    public float rotationSpeed;
    public bool isModel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputYaw = 0;
        if (!isModel){
        speed = Input.GetAxis("Throttle") * speedAmplifier;
        this.transform.Translate (Vector3.forward * speed * Time.deltaTime);
        inputYaw = Input.GetAxis("Yaw") * rotationSpeed * Time.deltaTime;
        }

        float inputPitch = Input.GetAxis("Pitch") * rotationSpeed * Time.deltaTime;
        float inputRoll = Input.GetAxis("Roll") * rotationSpeed * Time.deltaTime;
        this.transform.Rotate (inputPitch, inputYaw, inputRoll);
    }
}
