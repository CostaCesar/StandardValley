using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    [SerializeField] private Vector2 minPosition;
    [SerializeField] private Vector2 maxPosition;
    [SerializeField] private float cameraSmooth;
    
    void LateUpdate()
    {
        if (transform.position != target.position)
        {
            Vector3 targetPosition = new  Vector3(
                target.transform.position.x,
                target.transform.position.y, 
                transform.position.z);

            //clamp in between
            targetPosition.x = Mathf.Clamp(targetPosition.x, minPosition.x, 
            maxPosition.x);
            targetPosition.y = Mathf.Clamp(targetPosition.y, minPosition.y, 
            maxPosition.y);
                    
            // Se cameraSmooth > 0, mover suavemente a camera
            if(cameraSmooth > 0)
                transform.position = Vector3.Lerp(transform.position, targetPosition, cameraSmooth);
            else transform.position = targetPosition;
        }
    }

}
