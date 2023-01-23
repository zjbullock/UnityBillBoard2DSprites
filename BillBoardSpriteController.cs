using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillBoardSpriteController : MonoBehaviour
{

    [SerializeField]
    [Tooltip("The main Camera in the scene.  Can be modified if necessary.")]
    private GameObject mainCamera;

    [SerializeField]
    [Tooltip("Determines if the sprite should bend to face the camera should its raise or lower")]
    private bool billBoardVertically;


    void Awake() {
    }
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if( mainCamera == null) {
            mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        }
        
        if(mainCamera != null) {
            Vector3 targetPosition = new Vector3(mainCamera.transform.position.x, billBoardVertically ? mainCamera.transform.position.y : transform.position.y , mainCamera.transform.position.z);
            transform.LookAt(2 * transform.position - targetPosition);
        }
    }
}
