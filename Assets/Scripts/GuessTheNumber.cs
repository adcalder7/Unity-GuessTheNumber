using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GuessTheNumber : MonoBehaviour {

	public InputField input;
	public Text infoText;
	public Button resetButton;

	public int from = 0;
	public int to = 10;

	private int guessNumber;
	private int userGuess;

	// Use this for initialization
	void Start () {
		Init ();
	}
	
	// Update is called once per frame
	void Update () {
		if (string.IsNullOrEmpty (input.text))
			return;
		
		var ugi = int.Parse (input.text);

		if (ugi == guessNumber) {
			infoText.text = "Bingo!";
			input.interactable = false;
			resetButton.interactable = true;
		} else if (ugi < guessNumber) {
			infoText.text = "Try a higher number";
		} else if (ugi > guessNumber) {
			infoText.text = "Try a lower number";
		}
	}

	private void Init() {
		infoText.text = "Enter a number between " + from + " and " + to;
		input.text = "";
		guessNumber = Random.Range (from, to);
		input.interactable = true;
		resetButton.interactable = false;
	}

	public void Reset() {
		Init ();
	}
}
