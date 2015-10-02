﻿using UnityEngine;
using System.Collections;

public class Share : MonoBehaviour {
	private const string TITLE   = "Title";
	private const string MESSAGE = "Message";

	public void shareScreenShot() {
		StartCoroutine (FrispSocial.Instance().PostScreenshot(TITLE, MESSAGE));
	}
}
