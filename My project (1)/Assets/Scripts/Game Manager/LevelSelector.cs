using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public string buttonString;

   public  void LevelSelecting()
    {
        SceneManager.LoadScene(buttonString);
    }
}
