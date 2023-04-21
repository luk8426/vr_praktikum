using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyXR : MonoBehaviour
{
    public float rotationSpeed;
    public GameObject controlStick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        //float inputYaw = controlStick.transform.rotation.eulerAngles.y * rotationSpeed * Time.deltaTime;
        float inputPitch = controlStick.transform.rotation.eulerAngles.z * rotationSpeed * Time.deltaTime * -1;
        float inputRoll = controlStick.transform.rotation.eulerAngles.x * rotationSpeed * Time.deltaTime * -1;
        this.transform.Rotate (inputPitch, 0, inputRoll);
        
    }
}
