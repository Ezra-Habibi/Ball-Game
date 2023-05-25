using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeathScript : MonoBehaviour
{

    public GameObject player;

    public void FixedUpdate(){
        if(player.transform.position.y <= -1){
            Invoke("RestartGame", 0.3f);
        }
    }

    public void OnCollisionEnter(Collision col)
    {
        if(col.collider.tag == "Enemy")
        {
            Invoke("RestartGame", 0.3f);
        }
    }

    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
