using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizontanzeige : MonoBehaviour
{
    public GameObject ground;
    public bool isVertical;
    public bool isCompass;
    private float orientation_y;
    // Start is called before the first frame update
    void Start()
    {
        orientation_y = transform.rotation.eulerAngles.y;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = ground.transform.rotation.eulerAngles;
        if (isVertical) rot.y = transform.rotation.eulerAngles.y;
        if (isCompass) {
            transform.Rotate(0, rot.y, 0);
        }
        transform.rotation = Quaternion.Euler(rot.x, rot.y, rot.z);
    }
}
