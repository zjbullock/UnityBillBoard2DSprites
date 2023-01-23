using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowController : MonoBehaviour
{
    // Start is called before the first frame update



    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null) {
            renderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            renderer.receiveShadows = true;
        }

    }

    // Update is called once per frame

}
