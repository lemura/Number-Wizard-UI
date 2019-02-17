using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

    // Use this for initialization
    int max;
    int min;
    int guess;
    public int maxGuessesAllowed = 10; /* это значение переписывается значением указанным в редакторе */
    public Text text;

    void Start () {
        StartGame();
	}
    
    void StartGame() {
        max = 1000;
        min = 1;
        NextGuess();
    }
	    
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
            GuessHigher();
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            GuessLower();
        }
    }

    public void GuessHigher() {
        min = guess;
        NextGuess();
    }
    public void GuessLower()  {
        max = guess;
        NextGuess();
    }

    void NextGuess() {
        guess = Random.Range(min, max);
        text.text = guess.ToString();
        maxGuessesAllowed = maxGuessesAllowed - 1;
        if (maxGuessesAllowed <= 0)
        {
           SceneManager.LoadScene("Win");
        }
    }
}
