// using System.Collections.Generic;
using UnityEngine;




public enum GameState { LOADING, MENU, SETTINGS, PLAY, PAUSE, OVER, CREDITS, COUNT }; 

public class GameManager : MonoBehaviour {
    // TODO: 
    // Add 3 lives ... have the ghosts cause death (placeholder ready)
    // update the score 
    // play some more music! 
  
    // singleton 
    public int m_score = 0;
	public int m_lives = 3;
	public int m_level = 1; 

    public  GameState m_gameState; 

    private static GameManager m_instance; 
	public static GameManager Instance { get { return m_instance; } }

	public void Awake() {
		Debug.Log("Game Starts...");
		if(m_instance != this && m_instance != null) {
			Destroy(this.gameObject);
			return;
		} else {
			m_instance = this;
		}

        //  m_gameState = GameState.LOADING; 
	}

    void Start() {
       
    }


    public GameState GetGameState(){
        return m_gameState;
    }









}
