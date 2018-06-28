using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

 
public class BackButton : MonoBehaviour
{

	int sceneIndex;	
	 void start()
	 {
		 sceneIndex=SceneManager.GetActiveScene().buildIndex;
	 }
	 
	 void Update()
	 {
		 if(Input.GetKeyDown(KeyCode.Escape))
		 {
			 //go out of the application
			 if(sceneIndex>0)
			 {
				 SceneManager.LoadScene(sceneIndex-1);
			 }
			 else
			 {
				 Application.Quit();
			 }
			 
		 }
		 
	 }
	// for loading new scenes you can call this function in another classes
	public void LoadNextScene()
	 {
		SceneManager.LoadScene(sceneIndex+1);
	 }
	 
}
