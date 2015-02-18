﻿using UnityEngine;
using System.Collections;

public class PlayerWizard : Wizard {


	void Update(){
		if (Input.GetKeyDown (KeyCode.Q)) {
			magicState = WizardMagicState.fireBall;
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			magicState = WizardMagicState.iceBall;
		}
		if (Input.GetKeyDown (KeyCode.E)) {
			magicState = WizardMagicState.meteor;
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			magicState = WizardMagicState.reflect;
		}
		if (Input.GetKeyDown (KeyCode.Escape)) {
			magicState = WizardMagicState.idle;
		}
		if (Input.GetMouseButton(0)){
			magicState = WizardMagicState.idle;
		}
		if (Input.GetMouseButtonDown (1)) {
			magicState = WizardMagicState.idle;
		}

	}

}
