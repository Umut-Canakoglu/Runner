using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Spawning Objects
    [Header("Spawning Objects")]
    public GameObject Coin;
    public GameObject Box;
    public GameObject Triangle;

    //Random Position
    [Header("Random Position")]
    public float MaxX;
    public float MinX;
    public float MaxY;
    public float MinY;


    //Select Object
    private GameObject item;


    //Spawn
    private bool canSpawn;
    private Vector2 randPosition;

    void Start()
    {
        canSpawn = true;
    }

    void Update()
    {
        if(canSpawn){
            canSpawn = false;
            randPosition = randPos();
            StartCoroutine(spawn());
        }
    }

    IEnumerator spawn(){
        //Select random object
        int pickedItem = Random.Range(0,3);
        if(pickedItem == 0){
            item = Coin;
        } else if(pickedItem == 1){
            item = Box;
        } else if(pickedItem == 2){
            item = Triangle;
        }

        //Spawn selected object
        Instantiate(item, randPosition, Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(2,4));
        canSpawn = true;
    }

    private Vector2 randPos(){
        //Select random position
        float RandX = Random.Range(MinX, MaxX);
        float RandY = Random.Range(MinY, MaxY);
        return new Vector2(RandX, RandY);
    }


}
