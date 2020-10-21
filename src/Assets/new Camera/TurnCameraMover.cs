using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnCameraMover : MonoBehaviour
{
    [SerializeField]
    private GameObject targetModel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(targetModel.transform.position.x + 3.0f * Mathf.Sin(Time.time), 2.0f, targetModel.transform.position.z +  3.0f * Mathf.Cos(Time.time));

        this.transform.LookAt(targetModel.transform.position);
    }
}
