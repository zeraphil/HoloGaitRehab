using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteppeBehavior : MonoBehaviour {

    public Material OffMaterial;
    public Material OnMaterial;

    public float blendDuration = 1.0f;
    // Use this for initialization
    bool steppedOn = false;

    void Start()
    {
    }
    void Update()
    {
        //float lerp = Mathf.PingPong(Time.time, blendDuration) / blendDuration;
        //rend.material.Lerp(OffMaterial, OnMaterial, lerp);
    }

    private void OnTriggerEnter(Collider other)
    {
    

        if(!steppedOn)
            StartCoroutine(TurnOnAnimation(GetComponent<Renderer>()));
        
        steppedOn = true;
    }

    IEnumerator TurnOnAnimation(Renderer rend)
    {
        Debug.Log("Steppedon");
        float elapsedTime = 0;

        while (elapsedTime < blendDuration)
        {
            float lerp = elapsedTime / blendDuration;
            rend.material.Lerp(OffMaterial, OnMaterial, lerp);
            elapsedTime += Time.deltaTime;
            Debug.Log("elapsed time" + elapsedTime);
            yield return null;
        }
    }
}
