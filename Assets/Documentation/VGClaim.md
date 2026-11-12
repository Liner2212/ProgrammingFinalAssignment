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
| 3 | Your own function that takes a parameter (REQUIRED) showSoulOrbs|PlayerSoulOrbs.cs, line 21-24 |Because I built `showSoulOrbs`, the player can see the number of soul orbs they have collected. or GameManager public void SetState | GameManager.cs, line 73-78 | Because I built "setState", the player can see the game pause and all the ui updates and the different states of the game.
| 10 | A C# event with at least one listener (REQUIRED) |AudioManager background music | |
| 18 | Difficulty tuned with numbers, with before and after written down (REQUIRED) player input script;PlayerMove2D line 23 JumpCount, speed in PlayerMove2D line 7, jumpspeed | | Because I  |
|1 |Prefabs spawned and removed by code (Instantiate, Destroy) | For instantiate, cannon.cs line 2, SlimeStomp.cs Line 11 for destroy game object | Because I built instantiate in shoot of the cannon script the cannonball prefab is now spawned/created in the scene, because I built destroy in the stomp script the enemy gets removed after player jumps on their collidertagged weakpoint |
| | | | |
| | | | |

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
