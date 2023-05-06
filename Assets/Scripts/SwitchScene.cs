using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

////////////////////////////////////////////////////////////////////////////////////////////////////
//  Dieses Skript implementiert das Wechseln in eine neue Szene beim Schieben einer Türe
////////////////////////////////////////////////////////////////////////////////////////////////////

public class SwitchScene : MonoBehaviour
{
    public string scene;
    private Vector3 start;
    // Start is called before the first frame update
    void Start()
    {
        start = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z > start.z){
            this.transform.position = start;
        }
        if (this.transform.position.z < start.z-0.7){
            SceneManager.LoadScene(scene);
        }    
    }
}
