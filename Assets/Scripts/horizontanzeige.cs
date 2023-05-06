using System.Collections;
using System.Collections.Generic;
using UnityEngine;

////////////////////////////////////////////////////////////////////////////////////////////////////
//  Dieses Skript dient dem fixieren von Objekten gegnüber dem Boden auf unterschiedlichen Achsen
////////////////////////////////////////////////////////////////////////////////////////////////////

public class horizontanzeige : MonoBehaviour
{
    public GameObject ground;
    public bool isVertical;
    public bool isCompass;
    // Start is called before the first frame update
    void Start()
    {        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = ground.transform.rotation.eulerAngles;
        if (isVertical) rot.y = transform.rotation.eulerAngles.y;
        if (isCompass) {
            // Erzeuge eine Gegenrotation, wenn der Spieler gegenüber dem Boden rotiert
            transform.Rotate(0, rot.y-transform.rotation.eulerAngles.y, 0);
            return;
        }
        transform.rotation = Quaternion.Euler(rot.x, rot.y, rot.z);
    }
}
