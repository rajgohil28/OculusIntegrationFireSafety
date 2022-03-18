using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtinguisherFoamScript : MonoBehaviour
{
    private ParticleSystem _particles;
    // Start is called before the first frame update
    void Start()
    {
        _particles = GetComponent<ParticleSystem>();
        _particles.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (OVRInput.Get(OVRInput.Button.One))
        {
            _particles.Play();
        }
        else
        {
            _particles.Stop();
        }*/
        if (Input.GetKeyDown(KeyCode.K))
        {
            _particles.Play();
        }
    }
}
