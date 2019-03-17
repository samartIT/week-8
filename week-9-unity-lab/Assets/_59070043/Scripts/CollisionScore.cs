using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScore : MonoBehaviour
{
    private void OnCollisionExit(Collision collision)
    {
        if (Timer.timeLeft >= 0 && Timer.timeLeft <= 1)
        {
            print("Enter: " + collision.collider.name);
            if (collision.collider.name == "Player")
            {
                Destroy(collision.collider.gameObject);
            }
        }

    }
    private void OnCollisionStay(Collision collision)
    {
        if (Timer.timeLeft >= 0 && Timer.timeLeft <= 1)
        {
            print("Enter: " + collision.collider.name);
            if (collision.collider.name == "Player")
            {
                Destroy(collision.collider.gameObject);
            }
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        print("Enter: " + collision.collider.name);
        if (collision.collider.name != "Player" && collision.collider.name != "Floor" && collision.collider.name != "Wall1" && collision.collider.name != "Wall2" && collision.collider.name != "Wall3" && collision.collider.name != "Wall4")
        {
            Destroy(collision.collider.gameObject);
            ScoreUpdate.currentscore += 1;
        }
        if (collision.collider.name == "Wall1" || collision.collider.name == "Wall2" || collision.collider.name == "Wall3" || collision.collider.name == "Wall4")
        {
            ScoreUpdate.currentscore -= 1;
        }
        if (Timer.timeLeft >= 0 && Timer.timeLeft  <= 1)
        {
            print("Enter: " + collision.collider.name);
            if (collision.collider.name == "Player")
            {
                Destroy(collision.collider.gameObject);
            }
        }
    }
}
