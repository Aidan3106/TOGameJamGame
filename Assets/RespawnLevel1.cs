using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnLevel1 : MonoBehaviour
{
  
     [SerializeField] private Transform player;
    private void OnTriggerEnter2D(Collider2D Collision)
    {
            SceneManager.LoadScene("GameOverScreen");
    }

}
