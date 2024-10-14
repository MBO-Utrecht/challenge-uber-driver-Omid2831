using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class CarScript : MonoBehaviour
{
    public int score = 0;
    public Text gameOverText;
    public GameObject Player;
    // Start is called before the first frame update
    public GameController gameController;

    bool hashPackage = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Game over:" + gameController.GameOver);
        if (gameController.GameOver == false)
        {
            MoveCar();
        }
    }
    // the  car's direction  is determined by the input from the player
    void MoveCar()
    {

        float Speed = 10f;
        float throttle = Input.GetAxis("Vertical");
        float steer = Input.GetAxis("Horizontal");

        Debug.Log(throttle);
        Debug.Log(steer);

        transform.Translate(0, throttle * (Speed * 2) * Time.deltaTime, 0);

        transform.Rotate(0, 0, -steer * (Speed * 10) * Time.deltaTime);
    }
    // this is  the collision detection function where you see Obsticles 

    void OnCollisionEnter2D(Collision2D col)
    {


        Debug.Log("Collided with" + col.gameObject.name);
        if (other.gameObject.CompareTag("Package"))
        {
            Debug.Log("Package touched!");
            if (hashPackage == false)
            {
                score--;
                Destroy(col.gameObject);
                gameController.score -= 1;
                hashPackage = true;

            }
            if(other.gameObject.CompareTag("Customer")){
                Debug.Log("Customer touched!");
                 if (hashPackage == true)
            {
                score++;
                Destroy(col.gameObject);
                gameController.score += 1;
                hashPackage = false;

            }
            }
        }
    }

}
