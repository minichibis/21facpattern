/** Sam Carpenter
*   Week 5
*   Slime.cs
*   stats
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime 
{
	public int defense = 0;
	public int attack = 0;
	public int health = 0;
	
    public Slime(){
		
	}
	
	public Slime(int a, int b, int c){
		health = a;
		attack = b;
		defense = c;
	}
}
