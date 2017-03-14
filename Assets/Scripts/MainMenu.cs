using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {


		void OnGUI() {

			if (GUI.Button (new Rect (400, 10, 400, 100), "Play")) {

				SceneManager.LoadScene (1);

			}

			if (GUI.Button (new Rect (400, 200, 400, 100), "Instructions")) {

				SceneManager.LoadScene (2);
			}


		}


	}