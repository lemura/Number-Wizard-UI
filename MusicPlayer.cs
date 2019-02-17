using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {
    static MusicPlayer instance = null;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            print("duplicate object destroing");
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
    void Start () {
        Debug.Log("Music Player Start " + GetInstanceID());
       
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
