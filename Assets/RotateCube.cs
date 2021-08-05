using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotateCube : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    RenderTexture renderTexture;
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        transform.eulerAngles += Vector3.up * speed * Time.deltaTime;
    }
    private void LateUpdate()
    {

    }
}
