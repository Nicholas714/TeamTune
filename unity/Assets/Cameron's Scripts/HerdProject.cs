﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerdProject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		TeleportalProject.Shared.RegisterCommand("hold", Hold);	
	}
	
	public void Hold(List<string> args) {
		string name = args[1];
		bool enable = args[2] == "1";

		if (TeleportalAr.Shared.Items.ContainsKey(name)) {
			XRItem xri = TeleportalAr.Shared.Items[name];
			if (xri == null) { return; }

			PlaySound script = xri.transform.GetChild(0).GetComponent<PlaySound>();
			if (script == null) { return; }

			if (enable) {
				script.enableSound();
			} else {
				script.disableSound();
			}
		}
        
    }
}
