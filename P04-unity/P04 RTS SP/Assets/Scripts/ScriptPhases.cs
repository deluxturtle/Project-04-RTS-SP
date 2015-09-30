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

    /// <summary>
    /// @Author: Andrew Seba
    /// Sets nextPhase = true;
    /// </summary>
    public void _NextPhase()
	{
		nextPhase = true;
	}



	void Update () {


		//GAMESTART
		if(phase == Phases.GAMESTART && nextPhase)
		{
			nextPhase = false;
			if(turnNumber == 0)
			{
                //TODO
                phase = Phases.ROLL;
			}
			else
			{
				phase = Phases.ROLL;
				nextPhase = true;
			}
			
		}

		//ROLL
		if(phase == Phases.ROLL && nextPhase)
		{
			nextPhase = false;

            phase = Phases.TRADE;
        }

		//TRADE - for future store.
		if (phase == Phases.TRADE && nextPhase)
		{
			nextPhase = false;

			
			phase = Phases.BUILD;

            nextPhase = true;//remove this when implementing
        }

		//BUILD
		if (phase == Phases.BUILD && nextPhase)
		{
			nextPhase = false;

			phase = Phases.PROCESS;
        }


		//PROCESS - for future use.
		if(phase == Phases.PROCESS && nextPhase)
		{
			nextPhase = false;

            phase = Phases.ENDGAME;
            nextPhase = true;//remove this when implementing
        }

		//ENDGAME
		if(phase == Phases.ENDGAME && nextPhase)
		{
			nextPhase = false;
            turnNumber++;

            phase = Phases.GAMESTART;
        }


		//update text
        
		textCurPhase.text = "Current Phase: " + phase.ToString();
        int curPhaseIndex = (int)Convert.ChangeType(phase, phase.GetTypeCode());
        textNextPhase.text = "Next Phase: " + ((Phases)curPhaseIndex + 1).ToString();


	}



}
