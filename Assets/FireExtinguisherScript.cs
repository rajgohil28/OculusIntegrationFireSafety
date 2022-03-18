using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtinguisherScript : OVRGrabbable
{
    [SerializeField] private ParticleSystem _foamParticleEffect;
    private Material _extinguisherMaterial;
    [SerializeField] Material AlternateMaterial;
    private Renderer _Renderer;
    private bool extinguishing = false;
    public bool ExtinguisherButtonPressed = false;

    // Start is called before the first frame update
    [System.Obsolete]
    protected override void Start()
    {
        base.Start();
        _Renderer = GetComponent<Renderer>();
        _extinguisherMaterial = _Renderer.material;
        _foamParticleEffect.enableEmission = false;
    }

    // Update is called once per frame

    [System.Obsolete]
    void Update()
    {
        if ((OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) > 0f) && extinguishing)
        {

            _foamParticleEffect.enableEmission = true;
            ExtinguisherButtonPressed = true;
        }
        else
        {

            _foamParticleEffect.enableEmission = false;
            ExtinguisherButtonPressed = false;
        }
    }
    public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        base.GrabBegin(hand, grabPoint);

        extinguishing = true;
    }
    
    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(linearVelocity, angularVelocity);
        extinguishing = false;
    }

}
