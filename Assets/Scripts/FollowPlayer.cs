using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public CarScript car; // Assign the Carscript component in the Inspector
    public float followDistance = 10f; // Adjust the follow distance as needed

    private void Update()
    {
        // Set the script's GameObject position to follow the player
        transform.position = car.transform.position - car.transform.forward * followDistance;
    }
}