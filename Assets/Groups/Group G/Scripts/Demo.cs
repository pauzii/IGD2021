using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Demo : MonoBehaviour
{
	public Sprite isAI;
	public Sprite noAI;

	public Button Player1_AIButton;
	public Button Player2_AIButton;
	public Button Player3_AIButton;
	public Button Player4_AIButton;

	public GameObject Player1_Controls;
	public GameObject Player2_Controls;
	public GameObject Player3_Controls;
	public GameObject Player4_Controls;

	public GameObject StartButton;

	private bool Player1_AI = true;
	private bool Player2_AI = true;
	private bool Player3_AI = true;
	private bool Player4_AI = true;

    void Awake()
    {
		PlayerPrefs.SetString("Player1_AI", "False");
		PlayerPrefs.SetString("Player2_AI", "True");
		PlayerPrefs.SetString("Player3_AI", "True");
		PlayerPrefs.SetString("Player4_AI", "True");
	}

    void Start()
	{
		Player1_AI = PlayerPrefs.GetString("Player1_AI").Equals("True");
		Player2_AI = PlayerPrefs.GetString("Player2_AI").Equals("True");
		Player3_AI = PlayerPrefs.GetString("Player3_AI").Equals("True");
		Player4_AI = PlayerPrefs.GetString("Player4_AI").Equals("True");
		ApplyGUI();
	}

	public void TogglePlayer1_AI()
	{
		Player1_AI = !Player1_AI;
		string value = Player1_AI == true ? "True" : "False";
		PlayerPrefs.SetString("Player1_AI", value);
		ApplyGUI();
	}

	public void TogglePlayer2_AI()
	{
		Player2_AI = !Player2_AI;
		string value = Player2_AI == true ? "True" : "False";
		PlayerPrefs.SetString("Player2_AI", value);
		ApplyGUI();
	}

	public void TogglePlayer3_AI()
	{
		Player3_AI = !Player3_AI;
		string value = Player3_AI == true ? "True" : "False";
		PlayerPrefs.SetString("Player3_AI", value);
		ApplyGUI();
	}

	public void TogglePlayer4_AI()
	{
		Player4_AI = !Player4_AI;
		string value = Player4_AI == true ? "True" : "False";
		PlayerPrefs.SetString("Player4_AI", value);
		ApplyGUI();
	}

	public void DeactivateStartButton()
    {
		StartButton.SetActive(false);
	}

	private void ApplyGUI()
	{
		if (Player1_AI)
		{
			Player1_AIButton.GetComponent<Image>().sprite = isAI;
			Player1_Controls.SetActive(false);
		}
		else
		{
			Player1_AIButton.GetComponent<Image>().sprite = noAI;
			Player1_Controls.SetActive(true);
		}
		if (Player2_AI)
		{
			Player2_AIButton.GetComponent<Image>().sprite = isAI;
			Player2_Controls.SetActive(false);
		}
		else
		{
			Player2_AIButton.GetComponent<Image>().sprite = noAI;
			Player2_Controls.SetActive(true);
		}
		if (Player3_AI)
		{
			Player3_AIButton.GetComponent<Image>().sprite = isAI;
			Player3_Controls.SetActive(false);
		}
		else
		{
			Player3_AIButton.GetComponent<Image>().sprite = noAI;
			Player3_Controls.SetActive(true);
		}
		if (Player4_AI)
		{
			Player4_AIButton.GetComponent<Image>().sprite = isAI;
			Player4_Controls.SetActive(false);
		}
		else
		{
			Player4_AIButton.GetComponent<Image>().sprite = noAI;
			Player4_Controls.SetActive(true);
		}
	}
}
