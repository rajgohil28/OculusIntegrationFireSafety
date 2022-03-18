using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtinguisherControllerScript : MonoBehaviour
{
    private Camera mainCam;
    private FireExtinguisherScript fireScript;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
        fireScript = FindObjectOfType<FireExtinguisherScript>();
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {

        if (FindObjectOfType<FireExtinguisherScript>().ExtinguisherButtonPressed)
        {
            ExtinguisherTriggerPressed();
        }
    }

    [System.Obsolete]
    public void ExtinguisherTriggerPressed()
    {
        RaycastHit hit;
        Ray ray = mainCam.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.tag == "Fire")
            {
                GameObject Fire = hit.collider.gameObject;
                Fire.GetComponent<DecreaseFire>().DecreaseFireRate();
            }
        }
    }
}
