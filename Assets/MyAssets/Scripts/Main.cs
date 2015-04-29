using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

    public GameObject GameStartButton;
    public GameObject StarFighter;
    public GameObject GameOverButton;

    public bool IsGameOver { get; set; }

    // Use this for initialization
    void Start()
    {
        this.IsGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.IsGameOver)
        {
            this.GameOverButton.SetActive(true);
        }
    }

    public void OnClickGameStartButton()
    {
        Instantiate(this.StarFighter);
        this.GameStartButton.SetActive(false);
    }

    public void OnClickGameOverButton()
    {
        Application.LoadLevel("MainScene");
    }
}
