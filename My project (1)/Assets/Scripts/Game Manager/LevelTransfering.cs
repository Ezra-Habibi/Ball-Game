using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTransfering : MonoBehaviour {

    public Button[] levelButtons;

    // Start is called before the first frame update
    void Start()
    {

            for(int i = 0; i < levelButtons.Length; i++)
              {
                    levelButtons[i].interactable = false;
              }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
