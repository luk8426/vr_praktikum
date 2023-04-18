using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayFlightData : MonoBehaviour
{
    public TextMeshProUGUI textSpeed;
    public TextMeshProUGUI textHeight;
    public GameObject player;
    public float warningHeight;
    public GameObject warnImage;
    private FlyJoystick flyJoystick;
    private bool warn;
    public float blinkIntervall;
    private float time_d = 0;
    // Start is called before the first frame update
    void Start()
    {
        flyJoystick = player.GetComponent<FlyJoystick>();
    }

    // Update is called once per frame
    void Update()
    {
        textHeight.text = "Alt.: " + System.Math.Round(player.transform.position.y, 2) + " m";
        textSpeed.text = "Speed: " + System.Math.Round(flyJoystick.speed, 2) + " km/h";

        if (player.transform.position.y < warningHeight){
            warn = true;
            textHeight.color = new Color(255, 0, 0);
            warnImage.SetActive(true);
        }
        else{
            warnImage.SetActive(false);
            time_d = 0;
            textHeight.color = new Color(255, 255, 255);
            warn = false;
        }

        if (warn){
            time_d += Time.deltaTime;
            if (time_d > 2 * blinkIntervall){
                warnImage.SetActive(true);
                textHeight.color = new Color(255, 0, 0);
                time_d = 0;
            }
            else if (time_d > blinkIntervall) {
                warnImage.SetActive(false);
                textHeight.color = new Color(255, 255, 255);
            }
        }

    }
}
