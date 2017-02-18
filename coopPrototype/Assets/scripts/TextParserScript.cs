using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TextParserScript : MonoBehaviour {

	public string fileName = "codeSnippets.txt";

	public List<string> codeBits;

	// Use this for initialization
	void Start () {

		Debug.Log ("Path: " + Application.dataPath);

		string finalFilePath = Application.dataPath + "/" + fileName;

		// read from a file
		StreamReader sr = new StreamReader(finalFilePath, false);

		int i = 0;

		while (!sr.EndOfStream) {
			string line = sr.ReadLine ();

			string[] splitLine = line.Split (';');

			string lines = splitLine [0];
			codeBits.Add (lines);

			i++;
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
