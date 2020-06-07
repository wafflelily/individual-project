using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightingdown : MonoBehaviour
{
    //changes the global direction lighting intensity on button push

    public OVRInput.Button touchbuttondown;
    public OVRInput.Button touchbuttonup;
    public Light light1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(touchbuttonup))
        {
            light1.intensity+=1;
        }

        if (OVRInput.GetDown(touchbuttondown))
        {
            light1.intensity-=1;
        }
    }
}
