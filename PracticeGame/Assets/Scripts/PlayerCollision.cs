using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    void OnCollisionEnter(Collision COllisionInfo)
    {
        if(COllisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled= false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
