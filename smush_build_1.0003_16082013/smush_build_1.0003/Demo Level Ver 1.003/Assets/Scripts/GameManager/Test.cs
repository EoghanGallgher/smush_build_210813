using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		
		if( Input.GetKeyDown( KeyCode.B ) )
		{
		
			Debug.Log ( "Score" );
			Messenger.Broadcast<int>( "ManageScore" , 100 );
				
			
		}
		
		
	}
}
