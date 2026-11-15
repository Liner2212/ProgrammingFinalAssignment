# VG Claim - Final Project

**Name:**
**Game title:**
**GitHub repo:**
**Final build link:**

Commit this file to `Assets/Documentation/` by Sunday Nov 15.
Then send Brian a Teams message: "I'm requesting a VG review."

---

## The Rules

- At least **6** Toolbox items in total
- At least **4** of the 6 from the Code list (items 1 to 14)
- The **3 required items** are already in the table: 3, 10 and 18
- An item counts when the player experiences it in your game
- Your code is commented in your own words

## Where to Find It

- **Code items:** the script, the function, and the line number. Example: `PlayerHealth.cs`, `TakeDamage()`, line 24
- **Design items:** the scene and the object. Add a screenshot in `Assets/Documentation/` and write its file name
- **Item 18 (difficulty):** the date of your DesignLog.md entry with the before and after numbers

## My Items

| # | Item | Where to find it | Because I built ___, the player ___. |
|---|---|---|---|
| 3 | Your own function that takes a parameter (REQUIRED) | PlayerHealth.cs, public void TakeDamage (int amount) line 19.  | Because I built playerhealth and used the int amount parameter for take damage The player takes a specific amount of damage from enemies and certain obstacles | 
| 10 | A C# event with at least one listener (REQUIRED) | Game Manager and menus scripts : GameManager.cs line 15 set event + public void SetState(GameState NewState) Invoke line 77, Menus2D.cs Lines 24 and 25 refercing GameManager and listening to the event, and line 28| Because I built the GameManager and game state event the menus2D listens to it and shows the right menu at the start and the right panels when the player presses the corresponding buttons. Without it the panels would not know when to be triggered and go as smoothly |
| 18 | Difficulty tuned with numbers, with before and after written down (REQUIRED) | PlayerMove2D.cs lines 9 & 25–27 where JumpCount changed from 2 to 1 plus the note on line 9 about the change, Designlog.md, date 2026-11-15 line 46 | Because I tweaked the numbers the difficulty has changed a bit and doesn´t let the player fly away too much but also has the player move faster throughout the level, the jump count being changed lets the player double jump instead of triple jump to heighten difficulty.  |
| 1 |Prefabs spawned and removed by code (Instantiate, Destroy) | For instantiate, cannon.cs, Void Shoot(), line 20, SlimeStomp.cs, private void OnCollisionEnter2D(Collision2D collision) Line 11 for destroy game object | Because I built instantiate in shoot of the cannon script the cannonball prefab is now spawned/created in the scene, because I built destroy in the stomp script the enemy gets removed after player jumps on their collider tagged weakpoint | Without it the player does not have the choice to destroy the slime and will keep only trying to avoid them.
| 2| Loop over many things | GhostAbility.cs, Private void update() line 22 | Because I built it so that each ghost wall sprite renderer disappears when the player presses G they can easier find secret rooms and if they can pass through a wall|Without it, it would be hard to find the secret soul orbs and the player would have to try to run into a bunch of different walls. 
| 5| physics movement or forces| Player controller, uses linear velocity and physics2D, script PlayerMove2D.cs void update() line 48| Because I used physics movement with linearvelocity and rigidbody the player responds to gravity and can fall down naturally as well as can jump, run and interact with the platforms and environment. Without using it the player would not respond to gravity and go through walls and floor. |
| 6|  Respawn and Checkpoints| Checkpoint.cs OnTriggerEnter2D(Collider 2D collision)  line 11 + PlayerRespawn.cs public void Respawn() line 11 and public void SetCheckpoint(Vector3 position) line 20| Because I built checkpoints and respawn the player does not have to start all the way from the beginning after dying and can try again fairly quickly.| 
| 11| A game manager that tracks game states| GameManager.cs, SetState() line 75 |Because I built a game manager, the player can smoothly move between the start screen, hit pause for the pause screen, exit and get the winning screen. Without the gamemanager it would feel clunky and not move as smoothly.  |
|15 | Guiding the player |In the ProgrammingFinalAssignment scene, in the beginning the blue lights that are near the ghost walls and in an arrow during the last section to show the player to go downwards for the exit. Look in assets/documentation/ToolBox15Light and assets/documentation/ToolBox15Arrow | Because I built the blue lights and the arrow in the level the player has a clearer indication of what is ahead and the path to mainly take. Without it the player could find it hard to find what the main path is and where secret rooms could be.|
| 8| An Animator state machine driven by a parameter| PlayerMove2D.cs, void update (), lines 70,76, 90 | Because I built the animator state machine that is driven by isJumping, the player will have a jumping animation playing when they jump which makes it feel more realistic, however it is the same as the running animation so a more accurate parameter would be isMoving.  |

Add more rows if you used more items. More is fine, but 6 is enough.

## The Sentence

"Because I built ___, the player ___."
- **The first blank:** the choice, by name. A script and a function, a component, or a setting.
- **The second blank:** what the player sees, hears or does that would change without it.

> Example: "Because I built `OnShipSaved`, an event the HUD and the foghorn both listen to, the player hears and sees every rescue at the same moment."

## Check Before You Send
- [ ] At least 6 rows filled in
- [ ] At least 4 of them are Code items (1 to 14)
- [ ] Items 3, 10 and 18 are filled in
- [ ] Every Code item has a file and a line number
- [ ] Brian is added to my GitHub repo
- [ ] Teams message sent
