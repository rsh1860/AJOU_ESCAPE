using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.SceneManagement;

public class SEO_Q : MonoBehaviour {
    Scene m_Scene;//added
    string sceneName;//added
    public Text Questions;

	public InputField answertxt;
	string useranswer;
	string answer;


	// Use this for initialization
	void Start () {

		Questions.text = "";



		String con = "URI = file:"+Application.dataPath + "/plugins/teamescape.db";
		IDbConnection dbconn;
		dbconn = (IDbConnection)new SqliteConnection (con);
		dbconn.Open ();
		IDbCommand dbcmd = dbconn.CreateCommand ();

		String sqlQuary = "SELECT * FROM PROBLEM WHERE TYPE_ID = 'S4' ORDER BY random()";
		dbcmd.CommandText = sqlQuary;
		IDataReader reader = dbcmd.ExecuteReader ();


		while (reader.Read ()) {

			string question = reader.GetString (3);
			answer = reader.GetString (4);
			Questions.text = "문제 : " + question;
			Debug.Log (question);
			Debug.Log (answer);

		}


		reader.Close ();
		dbcmd.Dispose ();
		dbconn.Close();

	
	}

	public void Submitbtn(){

		StartCoroutine (submit ());

	}

	IEnumerator submit()
	{

		useranswer = answertxt.text;
		Debug.Log (useranswer);
		if (useranswer == answer) {


            m_Scene = SceneManager.GetActiveScene();//added
            sceneName = m_Scene.name;//added

            if (sceneName == "SEO")
            {
                GameObject.Find("Canvas").transform.Find("Panel (1)").gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                SceneManager.LoadScene("SEO 1");
            }

            else if (sceneName == "SEO 1")
            {
                GameObject.Find("Canvas").transform.Find("Panel (1)").gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                SceneManager.LoadScene("SEO 2");
            }

            else if (sceneName == "SEO 2")
            {
                GameObject.Find("Canvas").transform.Find("Panel (1)").gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                SceneManager.LoadScene("SEO 3");
            }

            else if (sceneName == "SEO 3")
            {
                GameObject.Find("Canvas").transform.Find("Panel (1)").gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                SceneManager.LoadScene("SEO 4");
            }

            else if (sceneName == "SEO 4")
            {
                GameObject.Find("Canvas").transform.Find("Panel (1)").gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                SceneManager.LoadScene("mainhome");
            }


        } else {

			SceneManager.LoadScene ("GameOver");

		}


		yield return null;

	}
}
