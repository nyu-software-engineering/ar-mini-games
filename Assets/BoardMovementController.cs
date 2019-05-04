﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BoardMovementController : MonoBehaviour
{
    int isHit = -1;
    float x;
    float y;
    float z;
    float timeCounter = 0;
    public float timeCounterSpeed = 1;
    float rx, ry, rz = 0;
    public int score;
    int currentRound = 1;
    public GameObject bullseye;  
    public Text scoreText; 
   

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "InnerBoard")
        {

            Debug.Log("tag inner board");
            isHit = isHit * -1;


        }
    }

    void Start(){
        score = GetComponent<BoardController>().score;
    }



    // Update is called once per frame
    void Update()
    {
        // for game testing only
        //if (Input.GetMouseButtonUp(0))
        //{
        //    isHit = isHit * -1;
        //    Debug.Log("yo " + isHit);
        //}
        // end of for game testing only



        if (isHit == 1)
        {
            timeCounter += Time.deltaTime;
        }
        else
        {
            timeCounter -= Time.deltaTime;
        }
       

       
        DifficultyManager();


    }


 

    void BoardMovement(float x, float y, float z){
        x = Mathf.Cos(timeCounter * timeCounterSpeed);
        y = Mathf.Sin(timeCounter * timeCounterSpeed);
        z = 5;
        transform.position = new Vector3(x, y, z);


        transform.Rotate(rx, ry, rz);
      

    }



    void DifficultyManager(){
        score = GetComponent<BoardController>().score;
//        Debug.Log("score " + score);

        if (score > 10f && score <= 20f){
            timeCounterSpeed = 1.5f;
            x = Mathf.Cos(timeCounter * timeCounterSpeed);
            y = Mathf.Sin(timeCounter * timeCounterSpeed);
            z = 5;
            transform.position = new Vector3(x, 0, z);
 
        }
        else if (score > 20f && score <= 40f){
            timeCounterSpeed = 2f;
            x = Mathf.Cos(timeCounter * timeCounterSpeed);
            y = Mathf.Sin(timeCounter * timeCounterSpeed);
            z = 5;
            transform.position = new Vector3(0, y, z);
        }

        else if(score > 40f && score <= 60f){

            timeCounterSpeed = 1f;
      
            x = Mathf.Cos(timeCounter * timeCounterSpeed);
            y = Mathf.Sin(timeCounter * timeCounterSpeed);
            z = 5;
            transform.position = new Vector3(x, y, z);
            rx = 1.0f;
        }

        else if (score > 60f && score <= 80f)
        {

            timeCounterSpeed = 1.5f;
            x = Mathf.Cos(timeCounter * timeCounterSpeed);
            y = Mathf.Sin(timeCounter * timeCounterSpeed);
            z = 5;
            transform.position = new Vector3(x, y, z);
            rx = 1.0f;
        }

        else if (score > 80f && score <= 100f)
        {

            timeCounterSpeed = 2f;
            timeCounterSpeed = 2f;
            x = Mathf.Cos(timeCounter * timeCounterSpeed);
            y = Mathf.Sin(timeCounter * timeCounterSpeed);
            z = 5;
            transform.position = new Vector3(x, y, z);
            rx = 1.0f;
        }





    }
        

}
