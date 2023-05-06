using System.Collections;
using System.Collections.Generic;
using UnityEngine;

////////////////////////////////////////////////////////////////////////////////////////////////////
//  Dieses Skript implementiert die Drehbewegung des Modell-Helikopters
////////////////////////////////////////////////////////////////////////////////////////////////////

public class rotateModel : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localRotation = player.transform.rotation;
        Vector3 newAngles = this.transform.localEulerAngles;
        // Die y-Komponente soll sich nicht ändern
        this.transform.localRotation = Quaternion.Euler(newAngles.x, 0, newAngles.z);
    }
}
