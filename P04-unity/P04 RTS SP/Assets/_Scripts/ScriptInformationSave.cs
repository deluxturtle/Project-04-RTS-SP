using UnityEngine;
using System.IO;

public class ScriptInformationSave : MonoBehaviour {

    string userName = null;
    string levelName = null;

    public string UserName
    {
        set
        {
            userName = value;
        }
    }

    public string LevelName
    {
        set
        {
            levelName = value;
        }
    }


    /// <summary>
    /// Takes the level name and makes a new folder.
    /// Creates a gameinformation.txt file and writes the user name and level name.
    /// </summary>
	public void _SaveInformation()
	{
		string txtInfoLocation = Application.dataPath + "/save_data/" + levelName;
        StreamWriter writer = null;


        //Check to see if both things have been entered as a safety.
        if (userName != null && levelName != null)
        {
            if (!Directory.Exists(txtInfoLocation))
            {
                Directory.CreateDirectory(
                    Application.dataPath + "/save_data/" + levelName);

            }


            //gameinformation.txt
            //UserName
            //LevelName
            using (writer = new StreamWriter(txtInfoLocation + "/gameinformation.txt"))
            {
                writer.WriteLine(userName);
                writer.WriteLine(levelName);
            }

        }
        else
        {
            Debug.Log("Either name or level name haven't been entered." +
                "\nThis is required.");
        }

	}
}
