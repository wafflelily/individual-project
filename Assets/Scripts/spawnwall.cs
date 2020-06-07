using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnwall : MonoBehaviour
{
    //creates an object at hand position

    public OVRInput.Button touchbutton;
    OVRInput.Button buttonup = OVRInput.Button.SecondaryThumbstickUp;
    OVRInput.Button buttondown = OVRInput.Button.SecondaryThumbstickDown;
    public Transform tSpace;
    public GameObject wall;
    public OVRInput.Controller Ocontroller;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(touchbutton))
        {
            Vector3 position = tSpace.TransformPoint(OVRInput.GetLocalControllerPosition(Ocontroller));
            Vector3 rotation = tSpace.TransformDirection(OVRInput.GetLocalControllerRotation(Ocontroller).eulerAngles);
            GameObject object1 = Instantiate(wall, position, Quaternion.Euler(rotation));
 
            if (OVRInput.Get(buttonup))
            {
                Renderer renderer1 = object1.GetComponent<Renderer>();

                renderer1.material.SetColor("_Color", Color.grey); 
            }

            if (OVRInput.Get(buttondown))
            {
                Renderer renderer1 = object1.GetComponent<Renderer>();

                renderer1.material.SetColor("_Color", Color.red);
            }
        }
    }
}
