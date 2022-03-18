using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecreaseFire : MonoBehaviour
{
    private ParticleSystem _fireParticles;
    [SerializeField] private float ExtinguishingRate = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        _fireParticles = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    [System.Obsolete]
    public void DecreaseFireRate()
    {
        StartCoroutine(Decreasefire());
    }

    [System.Obsolete]
    IEnumerator Decreasefire()
    {
        yield return new WaitForSeconds(3f);
        _fireParticles.enableEmission = false;
    }
}
