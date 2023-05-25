using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndPoint : MonoBehaviour
{

    // Update is called once per frame
    public void OnCollisionEnter(Collision col)
    {
        if(col.collider.name == "Player"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
