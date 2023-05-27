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
            
            int currentLevel = SceneManager.GetActiveScene().buildIndex;
            if (currentLevel >= PlayerPrefs.GetInt("levelReached"))
            {
                PlayerPrefs.SetInt("levelReached", currentLevel);
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
