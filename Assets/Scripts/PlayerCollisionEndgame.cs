
using UnityEngine;

public class PlayerCollisionEndgame : MonoBehaviour
{
  public PlayerController movement;
  


  private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Lava"))
        {
            GetComponent<PlayerController>().enabled=false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
