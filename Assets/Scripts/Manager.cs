/** Sam Carpenter
*   Week 5
*   Manager.cs
*   controls
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
	public SlimeMaker s = new SlimeMaker();
	public Slime my = new Slime();
	public Text t1;
	public Text t2;
	public Text t3;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)){
			makeSlime();
		}else if (Input.GetKeyDown(KeyCode.W)){
			makeStrongSlime();
		}
		
		
		t1.text = "health: " + my.health;
		t2.text = "attack: " + my.attack;
		t3.text = "defense: " + my.defense;
    }
	
	private void makeSlime(){
		my = s.generateSlime(false);
	}
	
	private void makeStrongSlime(){
		my = s.generateSlime(true);
	}
}
