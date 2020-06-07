using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class materialcycle : MonoBehaviour
{
    //changes the material of an object type to a different colour

    public OVRInput.Button touchbutton;
    public Color color1;
    public Material material1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(touchbutton))
        {
            material1.SetColor("_Color", color1);
        }
    }
}
