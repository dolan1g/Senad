using UnityEngine;
using System.Collections;

public class Rezultat : MonoBehaviour {

    static int rezultat = 0;
    static int MaxRezultat = 0;
    

    static public void DodajPoen()
    {
        rezultat++;
        if(rezultat>MaxRezultat)
        {
            MaxRezultat = rezultat;
            

        }
        
    }
    void Start()
    {
     MaxRezultat=PlayerPrefs.GetInt("HighScore", MaxRezultat);


    }

    void onDestroy()
    {
        PlayerPrefs.SetInt("HighScore", MaxRezultat);

    }
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<GUIText>().text= "Score: " + rezultat + "\nHigh Score: " + MaxRezultat;



    }
}
