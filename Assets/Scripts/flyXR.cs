using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyXR : MonoBehaviour
{
    public float rotationSpeed;
    public GameObject controlStick;
    private Vector3 initPosPivot;
    private Vector3 initRotPivot;

    public Transform seahawk;

    // Start is called before the first frame update
    void Start()
    {
        initPosPivot = controlStick.transform.localPosition;
        initRotPivot = controlStick.transform.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    { 
        float angle = controlStick.transform.localEulerAngles.y;
        angle = (angle > 180) ? angle - 360 : angle;
        float inputYaw = angle * rotationSpeed * Time.deltaTime;
        Debug.Log(inputYaw);
        //float inputPitch = controlStick.transform.localEulerAngles.z * rotationSpeed * Time.deltaTime * 1;
        //float inputRoll = controlStick.transform.localEulerAngles.x * rotationSpeed * Time.deltaTime * -1;
        this.transform.Rotate (0, inputYaw, 0);
        
    }

    void LateUpdate(){
        controlStick.transform.localPosition = initPosPivot;
        //controlStick.transform.localEulerAngles = initRotPivot;
    }
}
