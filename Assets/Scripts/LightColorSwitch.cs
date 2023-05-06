using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

////////////////////////////////////////////////////////////////////////////////////////////////////
//  Dieses Skript implemeniert den Nebel und den Tag-Nacht-Wechsel
////////////////////////////////////////////////////////////////////////////////////////////////////

public class LightColorSwitch : MonoBehaviour
{
     public float r;
     public float g;
     public float b;
     public bool darken = false;

     public Material night_mat;

     public GameObject spotlight;
 
     public float smooth = 40;

     public float fog_density_limit = 0.002f;
     void Start(){
         this.GetComponent<Light>().color = new Color(r, g, b);
         spotlight.SetActive(false);
     }
     void Update(){
        // Diese Zeile erhöht die Nebeldichte kontinuierlich
        if (RenderSettings.fogDensity < fog_density_limit) RenderSettings.fogDensity += Time.deltaTime/100000;
        if (Input.GetKey(KeyCode.N)){
            darken = true;
        } 
        if (darken){
            r -= Time.deltaTime/smooth;
            g -= Time.deltaTime/smooth;
            if (r <= 0) r = 0;   
            if (g <= 0) g = 0;   
            if (b <= 0) b = 0;
            this.GetComponent<Light>().color = new Color (r, g, b);
            if (r <= 0.35) {
                // Ab einem Schwellwert wird dem Himmel eine neue Textur verpasst
                RenderSettings.skybox=night_mat;
                
            }
        }
     }
 }