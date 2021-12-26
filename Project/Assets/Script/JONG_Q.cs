using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.SceneManagement;

public class JONG_Q : MonoBehaviour {
    Scene m_Scene;//added
    string sceneName;//added
    public Text Questions;
	public Text floor;
	public InputField answertxt;
	string useranswer;
	string answer;
	int count=10;

	// Use this for initialization
	void Start () {

		Questions.text = "";



		String con = "URI = file:"+Application.dataPath + "/plugins/teamescape.db";
		IDbConnection dbconn;
		dbconn = (IDbConnection)new SqliteConnection (con);
		dbconn.Open ();
		IDbCommand dbcmd = dbconn.CreateCommand ();

		String sqlQuary = "SELECT * FROM PROBLEM ORDER BY random()";
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

		count = count--;
		floor.text = "floor : "+count;
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

            if (sceneName == "JONG")
            {
                GameObject.Find("Canvas").transform.Find("Panel (1)").gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                SceneManager.LoadScene("JONG 1");
            }

            else if (sceneName == "JONG 1")
            {
                GameObject.Find("Canvas").transform.Find("Panel (1)").gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                SceneManager.LoadScene("JONG 2");
            }

            else if (sceneName == "JONG 2")
            {
                GameObject.Find("Canvas").transform.Find("Panel (1)").gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                SceneManager.LoadScene("JONG 3");
            }

            else if (sceneName == "JONG 3")
            {
                GameObject.Find("Canvas").transform.Find("Panel (1)").gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                SceneManager.LoadScene("JONG 4");
            }

            else if (sceneName == "JONG 4")
            {
                GameObject.Find("Canvas").transform.Find("Panel (1)").gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                SceneManager.LoadScene("JONG 5");
            }

            else if (sceneName == "JONG 5")
            {
                GameObject.Find("Canvas").transform.Find("Panel (1)").gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                SceneManager.LoadScene("JONG 6");
            }

            else if (sceneName == "JONG 6")
            {
                GameObject.Find("Canvas").transform.Find("Panel (1)").gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                SceneManager.LoadScene("JONG 7");
            }

            else if (sceneName == "JONG 7")
            {
                GameObject.Find("Canvas").transform.Find("Panel (1)").gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                SceneManager.LoadScene("JONG 8");
            }

            else if (sceneName == "JONG 8")
            {
                GameObject.Find("Canvas").transform.Find("Panel (1)").gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                SceneManager.LoadScene("JONG 9");
            }

            else if (sceneName == "JONG 9")
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
