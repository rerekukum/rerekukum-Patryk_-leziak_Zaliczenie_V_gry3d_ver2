
using UnityEngine;

public class CameraController : MonoBehaviour
{
   public Transform target;

   public float smoothSpeed =2f;
   public float yOffset=1;
  

    void Update()
    {
       Vector3 newPos = new Vector3(target.position.x, target.position.y+yOffset,-10f);
       transform.position = Vector3.Slerp(transform.position, newPos, smoothSpeed*Time.deltaTime);
    }
}
