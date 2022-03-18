using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableCube : OVRGrabbable
{
    [SerializeField] private Material _isGrabbableMaterial;
    private Material _originalMaterial;
    private Renderer _renderer;
    private bool _changeColorHolder = false;
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        _renderer = GetComponent<Renderer>();
        _originalMaterial = _renderer.material;
    }
    void Update()
    {
        if(OVRInput.Get(OVRInput.Button.One) && _changeColorHolder)
        {
            _renderer.material = _isGrabbableMaterial;
        }
        else
        {
            _renderer.material = _originalMaterial;
        }
    }
    public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        base.GrabBegin(hand, grabPoint);
        _changeColorHolder = true;
        //_renderer.material = _isGrabbableMaterial;
    }
    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(linearVelocity, angularVelocity);
        _changeColorHolder = false;
        //_renderer.material = _originalMaterial;
    }
}
