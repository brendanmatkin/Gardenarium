using UnityEngine;

[RequireComponent(typeof(PlatformerCharacter2D_MOD))]
public class Platformer2DUserControl_MOD : MonoBehaviour 
{
	private PlatformerCharacter2D_MOD character;
    private bool jump;


	void Awake()
	{
		character = GetComponent<PlatformerCharacter2D_MOD>();
	}

    void Update ()
    {
        // Read the jump input in Update so button presses aren't missed.
#if CROSS_PLATFORM_INPUT
        if (CrossPlatformInput.GetButtonDown("Jump")) jump = true;
#else
		if (Input.GetButtonDown("Jump")) jump = true;
#endif

    }

	void FixedUpdate()
	{
		// Read the inputs.
		bool crouch = Input.GetKey(KeyCode.LeftControl);
		#if CROSS_PLATFORM_INPUT
		float h = CrossPlatformInput.GetAxis("Horizontal");
		float v = CrossPlatformInput.GetAxis ("Vertical");
		#else
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		#endif

		// Pass all parameters to the character control script.
		character.Move( v, h, crouch , jump );

        // Reset the jump input once it has been used.
	    jump = false;
	}
}
