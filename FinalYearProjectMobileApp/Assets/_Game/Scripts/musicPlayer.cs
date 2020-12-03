using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class musicPlayer : MonoBehaviour
{

	//Loading level 1 in game

  // allow music to load to next level 
  private void Awake()
  {
     DontDestroyOnLoad(this.gameObject);
  }

	// called before first frame update 
    void Start()
    {
        Invoke("LoadFirstLevel", 3); // invoke the method after passed seconds 
    }

  private void LoadFirstLevel1()
  {
  	SceneManager.LoadScene(1);
  }
}
