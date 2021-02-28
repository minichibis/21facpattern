/** Sam Carpenter
*   Week 5
*   SlimeMaker.cs
*   makes
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeMaker
{
	
    public SlimeMaker(){
		
	}
	
	public Slime generateSlime(bool hard){
		if(!hard){
			return new Slime(Random.Range(3, 8), Random.Range(1,3), Random.Range(0,2));
		} else{
			return new Slime(Random.Range(30, 45), Random.Range(5, 7),Random.Range(3, 5));
		}
	}
}
