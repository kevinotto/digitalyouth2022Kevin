using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public int coins;
	public AudioSource mainmusic;
	public int enemyscount;

	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start() {
		coins = 0;
		enemyscount = 0;
		mainmusic.Play();
		
	}

	// OnTriggerEnter is called when the Collider "collided" enters the trigger.
	protected void OnTriggerEnter(Collider collided) {

		// Check for collision with coins
		if (collided.gameObject.tag == "Coin") {  
			
			Destroy(collided.gameObject);
            if (coins == 0)
            {
				HUD.Message("You got first coin!");
            }
            else
            {
				HUD.Message("You got another coin!");
            }

			coins++;
			HUD.UpdateCoinCount(coins);

		}

        if (collided.gameObject.name == "Powerup Object 1")
        {
			Destroy(collided.gameObject);
			Abilities.doubleJumpEnabled = true;
			HUD.Message("Double jump activated!");
        }

	}
}