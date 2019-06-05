using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum LevelState { INTRO, PLAY, DEATH, COUNT };

public class LevelManager : MonoBehaviour {

    // DONE - Singleton 
    // Able to pause all ghoset and player 
    // play audio 
    // reset ghosts to original locations 
    // track points 
    // track dots remaining 
    // track lives remaining 
    // enable / disable HUD (or call HUDMAnager) 


    private GameState m_gs; 

    public LevelState m_levelState;

    private static LevelManager m_instance; 
	public static LevelManager Instance { get { return m_instance; } }

    public LevelState State { get { return m_levelState; } }
     
	public void Awake() {
		Debug.Log("Game Starts...");
		if(m_instance != this && m_instance != null) {
			Destroy(this.gameObject);
			return;
		} else {
			m_instance = this;
		}
	}

    void Start() {
        m_gs = GameManager.Instance.GetGameState(); 
        // m_levelState = LevelState.INTRO; 
    }


    void Update(){
        m_gs = GameManager.Instance.GetGameState(); 
        // only execute if we're in the gameplay state (no play, no levels)
        if(m_gs == GameState.PLAY) {
            // Debug.Log();
            switch(m_levelState){
                case LevelState.INTRO:
                    Debug.Log("INTRO");
                    break; 
                case LevelState.PLAY:
                    Debug.Log("PLAYING!!!");
                    break;
                case LevelState.DEATH:
                    Debug.Log("DEATH");
                    break;
                default: 
                    // I think you hit a tree Jim
                    Debug.LogWarning("Problem with Level Manager Update Loop");
                    break;
            }

        }



    }



}
