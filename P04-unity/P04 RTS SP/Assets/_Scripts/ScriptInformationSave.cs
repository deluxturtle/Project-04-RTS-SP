using UnityEngine;
using System.Collections;
using System.IO;

public class ScriptInformationSave : MonoBehaviour {


	public void _SaveInformation(string pName, string pLevelName)
	{
		StreamWriter writer = null;
		string txtInfoLocation = null;


		txtInfoLocation = Application.dataPath + "/save_data/" + pLevelName + "/gameinformation.txt";

		using (writer = new StreamWriter(txtInfoLocation))
		{
			writer.WriteLine("Name: " + pName);
			writer.WriteLine("LevelName: " + pLevelName);
		}

	}
}
