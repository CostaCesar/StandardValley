using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorFilters : MonoBehaviour
{
    public Toggle toggleNone;
    public Toggle toggleProtan;
    public Toggle toggleDeutan;
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = UnityEngine.Camera.main.GetComponent<Camera>();
        
        if (PlayerPrefs.GetInt("ToggleBool") == 1)
            toggleNone.isOn = true;
        else toggleNone.isOn = false;

        if (PlayerPrefs.GetInt("ToggleBool2") == 1)
            toggleProtan.isOn = true;
        else toggleProtan.isOn = false;
        
        if (PlayerPrefs.GetInt("ToggleBool3") == 1)
            toggleDeutan.isOn = true;
        else toggleDeutan.isOn = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (toggleNone.isOn == true)
        {
            PlayerPrefs.SetInt("ToggleBool", 1);
            cam.filter.mode = ColorBlindMode.Normal;
        }
        else PlayerPrefs.SetInt("ToggleBool", 0);

        if (toggleProtan.isOn == true)
        {
            PlayerPrefs.SetInt("ToggleBool2", 1);
            cam.filter.mode = ColorBlindMode.Protanopia;
        }
        else PlayerPrefs.SetInt("ToggleBool2", 0);
        
        if (toggleDeutan.isOn == true)
        {
            PlayerPrefs.SetInt("ToggleBool3", 1);
            cam.filter.mode = ColorBlindMode.Deuteranopia;
        }
        else PlayerPrefs.SetInt("ToggleBool3", 0);
    }

}
