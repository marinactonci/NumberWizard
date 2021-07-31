using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] Text guessNumber;
    int guess;

    // Start is called before the first frame update
    void Start() {
        StartGame();
    }

    void StartGame() {
        NextGuess();
    }

    void NextGuess() {
        guess = Random.Range(min, max);
        guessNumber.text = guess.ToString();
    }

    public void OnPressHigher() {
        min = guess;
        NextGuess();
    }

    public void OnPressLower() {
        max = guess;
        NextGuess();
    }
}
