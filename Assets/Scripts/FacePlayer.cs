using System.Collections;
using System.Collections.Generic;
using UnityEngine;

////////////////////////////////////////////////////////////////////////////////////////
//  Dieses Skript implementiert das Behalten eines Objekts im Blickfeld des Spielers
////////////////////////////////////////////////////////////////////////////////////////

public class FacePlayer : MonoBehaviour
{
    public GameObject player;
    public float distance;

    private float offset = 0.5F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = player.transform.position + distance * player.transform.forward - offset * player.transform.up;
        this.transform.rotation = player.transform.rotation;
    }
}
