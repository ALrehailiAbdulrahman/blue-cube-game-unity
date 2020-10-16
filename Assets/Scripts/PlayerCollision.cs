
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovments Movment;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle")
        {
          Movment.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            
        }

    }
}
