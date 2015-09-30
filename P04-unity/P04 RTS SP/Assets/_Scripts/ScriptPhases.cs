using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public enum Phases
{
	GAMESTART,
	ROLL,
	TRADE,//Extra Credit.
	BUILD,
	PROCESS,//For furture use.
	ENDGAME
}


/// <summary>
/// @Author: Andrew Seba
/// @Description: Controls phases of the game.
/// </summary>
public class ScriptPhases : MonoBehaviour {

	public Text textCurPhase;
	public Text textNextPhase;

	Phases phase;
	bool nextPhase = true; //controls when the engine will go to the next phase.
	int turnNumber = 0;
    int curPhaseIndex = 0;

    //This will restart the curPhaseIndex to 0 when you reach this num.
    const int ROTATE = 6;


    void Start()
    {
        curPhaseIndex = (int)Convert.ChangeType(phase, phase.GetTypeCode());
        textCurPhase.text = "Current Phase: " + phase.ToString();
        textNextPhase.text = "Next Phase: " + ((Phases)curPhaseIndex + 1).ToString();
    }

    /// <summary>
    /// @Author: Andrew Seba
    /// Increments the phase to next ENUM;
    /// </summary>
    public void NextPhase()
	{
        curPhaseIndex = (curPhaseIndex + 1) % ROTATE;
        phase = (Phases)curPhaseIndex;
        


        switch (phase)
        {
            case (Phases.GAMESTART):
                break;
            case (Phases.ROLL):
                break;
            case (Phases.TRADE):
                break;
            case (Phases.BUILD):
                break;
            case (Phases.PROCESS):
                break;
            case (Phases.ENDGAME):
                turnNumber++;
                break;
        }

        textCurPhase.text = "Current Phase: " + phase.ToString();
        textNextPhase.text = "Next Phase: " + ((Phases)((curPhaseIndex + 1) % ROTATE)).ToString();
    }



}
