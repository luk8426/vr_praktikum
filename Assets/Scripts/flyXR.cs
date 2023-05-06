using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///////////////////////////////////////////////////////////////////////////////////////////
//  Dieses Skript implementiert das Steuern des Helikopters durch ein virtuellen Joystick
///////////////////////////////////////////////////////////////////////////////////////////

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
        // Da Winkel immer positiv sind, müssen diese umgerechnet werden
        angle = (angle > 180) ? angle - 360 : angle;
        // Auslesen der jeweiligen WInkel des Joysticks
        float inputYaw = angle * rotationSpeed * Time.deltaTime;
        //Debug.Log(inputYaw);
        float inputPitch = controlStick.transform.localEulerAngles.z * rotationSpeed * Time.deltaTime * 1;
        float inputRoll = controlStick.transform.localEulerAngles.x * rotationSpeed * Time.deltaTime * -1;
        this.transform.Rotate (inputRoll, inputYaw, inputPitch);
        
    }

    void LateUpdate(){
        controlStick.transform.localPosition = initPosPivot;
        //controlStick.transform.localEulerAngles = initRotPivot;
    }
}
