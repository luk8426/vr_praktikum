using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///////////////////////////////////////////////////////////////////////
//  Dieses Skript implementiert die rote Gegner-Kugel im Level Hard 
///////////////////////////////////////////////////////////////////////

public class follower : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Prüfe ob die Spielkugel auf dem richtigen Board ist
        if (System.Math.Abs(Player.transform.position.x - transform.position.x) <= 1){
            Vector3 direction = new Vector3(Player.transform.position.x - transform.position.x, Player.transform.position.y - transform.position.y, Player.transform.position.z - transform.position.z);
            // Normailsieren, damit sich der Gegner gleichmäßig bewegt
            direction.Normalize();
            transform.position = transform.position + (direction / 300);
        }
    }
}
