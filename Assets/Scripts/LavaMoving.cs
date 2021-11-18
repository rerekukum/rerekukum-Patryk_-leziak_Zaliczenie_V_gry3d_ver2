
using UnityEngine;
using System.Collections;

public class LavaMoving : MonoBehaviour
{



    void Start()
    {

        FunctionTimer.Create(MoveLava, 3f);

        Vector3 newPosition = transform.position; // We store the current position
       
    }

    private void MoveLava()
    {
        
         transform.position += new Vector3(0,6 * Time.deltaTime, 0);

    }
    // Move to the target end position.

}