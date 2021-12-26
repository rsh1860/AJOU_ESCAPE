using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.SceneManagement;


public class state : MonoBehaviour {

	string Build_id;
	public GameObject yulgok;
	public GameObject jonghap;
	public GameObject dasan;
	public GameObject seongho;
	public GameObject woncheon;
	public GameObject eastguan;
	public GameObject westguan;
	public GameObject paldal;
	public GameObject sanhak;


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

			Build_id = reader.GetString (3);

			Debug.Log(Build_id);


		}
			
		reader.Close ();
		dbcmd.Dispose ();
		dbconn.Close();

        


		if (Build_id == "YU1" || Build_id == "YU2" || Build_id == "YU3" || Build_id == "YU4") {

			yulgok.gameObject.SetActive (true);
		}

        if (Build_id == "JO0" || Build_id == "JO1" || Build_id == "JO2" || Build_id == "JO3" || Build_id == "JO4" || Build_id == "JO5" || Build_id == "JO6" || Build_id == "JO7" || Build_id == "JO8" || Build_id == "JO9")
        {

            yulgok.gameObject.SetActive(true);
            jonghap.gameObject.SetActive(true);
            
        }
        if (Build_id == "DA4" || Build_id == "DA3" || Build_id == "DA2" || Build_id == "DA1")
        {

            yulgok.gameObject.SetActive(true);
            jonghap.gameObject.SetActive(true);
            dasan.gameObject.SetActive(true);
        }
        if (Build_id == "SE1" || Build_id == "SE2" || Build_id == "SE3")
        {

            yulgok.gameObject.SetActive(true);
            seongho.gameObject.SetActive(true);
            jonghap.gameObject.SetActive(true);
            dasan.gameObject.SetActive(true);
        }
        if (Build_id == "WO1" || Build_id == "WO2" || Build_id == "WO3" || Build_id == "WO4" || Build_id == "WO5")
        {

            yulgok.gameObject.SetActive(true);
            seongho.gameObject.SetActive(true);
            woncheon.gameObject.SetActive(true);
            jonghap.gameObject.SetActive(true);
            dasan.gameObject.SetActive(true);
        }
        if (Build_id == "EA5" || Build_id == "EA4" || Build_id == "EA3" || Build_id == "EA2" || Build_id == "EA1")
        {

            yulgok.gameObject.SetActive(true);
            seongho.gameObject.SetActive(true);
            woncheon.gameObject.SetActive(true);
            jonghap.gameObject.SetActive(true);
            eastguan.gameObject.SetActive(true);
            dasan.gameObject.SetActive(true);
        }
        if (Build_id == "WE5" || Build_id == "WE4" || Build_id == "WE3" || Build_id == "WE2" || Build_id == "WE1")
        {

            yulgok.gameObject.SetActive(true);
            seongho.gameObject.SetActive(true);
            woncheon.gameObject.SetActive(true);
            jonghap.gameObject.SetActive(true);
            eastguan.gameObject.SetActive(true);
            westguan.gameObject.SetActive(true);
            dasan.gameObject.SetActive(true);
        }
        if (Build_id == "PA1" || Build_id == "PA2" || Build_id == "PA3" || Build_id == "PA4"|| Build_id == "PA5"|| Build_id == "PA6"|| Build_id == "PA7"|| Build_id == "PA8"|| Build_id == "PA9"|| Build_id == "PA10") {

			yulgok.gameObject.SetActive (true);
			paldal.gameObject.SetActive (true);
			seongho.gameObject.SetActive (true);
			woncheon.gameObject.SetActive (true);
			jonghap.gameObject.SetActive (true);
			eastguan.gameObject.SetActive (true);
			westguan.gameObject.SetActive (true);
			dasan.gameObject.SetActive (true);
		}
		
		if (Build_id == "SA8" || Build_id == "SA7" || Build_id == "SA6" || Build_id == "SA5"|| Build_id == "SA4"|| Build_id == "SA3"|| Build_id == "SA2"|| Build_id == "SA1") {

			sanhak.gameObject.SetActive (true);
			yulgok.gameObject.SetActive (true);
			paldal.gameObject.SetActive (true);
			seongho.gameObject.SetActive (true);
			woncheon.gameObject.SetActive (true);
			jonghap.gameObject.SetActive (true);
			eastguan.gameObject.SetActive (true);
			westguan.gameObject.SetActive (true);
			dasan.gameObject.SetActive (true);
		}
		
		
		
		
		
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
