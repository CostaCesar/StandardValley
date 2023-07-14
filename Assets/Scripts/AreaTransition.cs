using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AreaTransition : MonoBehaviour
{
    private Camera cameraScript;
    public Vector2 newMinPosition;
    public Vector2 newMaxPosition;
    
    public Vector3 MoveToPos;
    void Start()
    {
        cameraScript = UnityEngine.Camera.main.GetComponent<Camera>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        MoveToPos.z = -1;
        if (other.tag == "Player")
        {
            cameraScript.minPosition = newMinPosition;
            cameraScript.maxPosition = newMaxPosition;
            other.transform.position = MoveToPos;
        }
    }
}
