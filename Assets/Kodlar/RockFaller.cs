using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockFaller : MonoBehaviour
{
    float SonDusenTasZamani;
    float TetiklenmeZamani;
    [SerializeField] GameObject Rock;
    GameObject Player;

    void Start()
    {
        Player=GameObject.FindWithTag("Player");
        TetiklenmeZamani=1;
        SonDusenTasZamani=0f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 RockSpawnPosition;
     if(Time.time>=TetiklenmeZamani+SonDusenTasZamani)
     {
        SonDusenTasZamani= Time.time;
        RockSpawnPosition=Player.transform.position;
        RockSpawnPosition.y+=5f;
        Instantiate(Rock, RockSpawnPosition, Quaternion.identity);
     }   
    }
}
