using System.Collections;
using System.Collections.Generic;
using UnityEngine;

////////////////////////////////////////////////////////////////////////////////////////////////////
//  Dieses Skript implementiert das Anschalten von Lichtern bei Nacht
//  Dadurch, dass der Shader bei Spotlights das Licht nicht dynamisch ändern kann, ist es überall deaktiviert
////////////////////////////////////////////////////////////////////////////////////////////////////

public class turnLightOnAtNight : MonoBehaviour
{
    public Light sun;
    public int r;
    public int g;
    public int b; 
    // Start is called before the first frame update
    void Start()
    {
        r = initalizeColor(r);
        g = initalizeColor(g);
        b = initalizeColor(b);
        this.GetComponent<Light>().color = new Color(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (sun.color.r <= 0.85){
            this.GetComponent<Light>().color = new Color(r, g, b);
        }
        
    }
    int initalizeColor(int color){
        if (color==0) return 255;
        else return color;
    }
}
