using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.SceneManagement;


public class Gamemanager : MonoBehaviour {

	[Header("loginPanel")]
	public InputField IDInputField;
	public InputField NameInputField;
	[Header("CreateAccountPanel")]
	public InputField New_IDInputField;
	public InputField New_NameInputField;
	public InputField New_BirthInputField;
	string userID;
	string loginID;
	string userName;
	string loginName;
	string N_ID;
	string N_NAME;
	string N_BIRTH;


	// Use this for initialization
	void Start () {


		String con = "URI = file:"+Application.dataPath + "/plugins/teamescape.db";
		IDbConnection dbconn;
		dbconn = (IDbConnection)new SqliteConnection (con);
		dbconn.Open ();
		IDbCommand dbcmd = dbconn.CreateCommand ();

		String sqlQuary = "SELECT * FROM USER ORDER BY random()";
		dbcmd.CommandText = sqlQuary;
		IDataReader reader = dbcmd.ExecuteReader ();


		while (reader.Read ()) {


			loginID = reader.GetString (0);
			loginName = reader.GetString (1);
			Debug.Log (loginID);
			Debug.Log (loginName);

		}


		reader.Close ();
		dbcmd.Dispose ();
		dbconn.Close();

	}
	
	public void LoginBtn()
	{
		StartCoroutine (LoginCo ());
	}

	IEnumerator LoginCo()
	{
		userID = IDInputField.text;
		userName = NameInputField.text;

		if (userID == loginID && userName == loginName) {
			SceneManager.LoadScene ("mainhome");
		} else {

			GameObject.Find ("Canvas").transform.Find ("errortext").gameObject.SetActive (true);

		}




		yield return null;

	}

	public void CreatAccountBtn()
	{
		GameObject.Find ("Canvas").transform.Find ("errortext").gameObject.SetActive (false);
		GameObject.Find ("Canvas").transform.Find ("CreateAccountPanel").gameObject.SetActive (true);
		//StartCoroutine (AccountCo());

	}

	/*IEnumerator AccountCo(){


		N_ID = New_IDInputField.text;
		N_NAME = New_NameInputField.text;
		N_BIRTH = New_BirthInputField.text;

		String con = "URI = file:"+Application.dataPath + "/plugins/teamescape.db";
		IDbConnection dbconn;
		dbconn = (IDbConnection)new SqliteConnection (con);
		dbconn.Open ();
		IDbCommand dbcmd = dbconn.CreateCommand ();

		String sqlQuary = "INSERT INTO USER(USER_ID, NAME, BIRTH, BUILD_ID)";
		sqlQuary += "VALUES('"+N_ID+"','"+N_NAME+"','"+N_BIRTH+"'SO1');";
		dbcmd.CommandText = sqlQuary;
		dbcmd.ExecuteNonQuery ();

		dbcmd.Dispose ();
		dbconn.Close();

		yield return null;

	}*/

	public void AccountBtn()
	{
		N_ID = New_IDInputField.text;
		N_NAME = New_NameInputField.text;
		N_BIRTH = New_BirthInputField.text;

		String con = "URI = file:"+Application.dataPath + "/plugins/teamescape.db";
		IDbConnection dbconn;
		dbconn = (IDbConnection)new SqliteConnection (con);
		dbconn.Open ();
		IDbCommand dbcmd = dbconn.CreateCommand ();

		String sqlQuary = "INSERT INTO USER(USER_ID, NAME, BIRTH)";
		sqlQuary += "VALUES('"+N_ID+"','"+N_NAME+"','"+N_BIRTH+"');";
		dbcmd.CommandText = sqlQuary;
		dbcmd.ExecuteNonQuery ();

		dbcmd.Dispose ();
		dbconn.Close();

		if (N_ID == loginID || N_NAME == loginName) {

			GameObject.Find ("Canvas").transform.Find ("errorText2").gameObject.SetActive (true);

		} else {

			New_IDInputField.text = null;
			New_BirthInputField.text = null;
			New_NameInputField.text = null;

			IDInputField.text = null;
			NameInputField.text = null;

			GameObject.Find ("Canvas").transform.Find ("CreateAccountPanel").gameObject.SetActive (false);
			GameObject.Find ("Canvas").transform.Find ("errorText2").gameObject.SetActive (false);
			GameObject.Find ("Canvas").transform.Find ("errortext").gameObject.SetActive (false);
		}
	}

}
