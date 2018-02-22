# Changelog
## 2018-02-22
### Changes
- Created Session info object

### FIXMEs: 
In no particular order:
- When pushing a box off a platform, Faye runs on top of it as it rotates
- Light spell does not properly fade out on despawn; the prefab works fine on it's own, but the instantiated object is not behaving properly (z-position?)
- If you swap characters while Red is jumping and keep pressing jump, Red will keep jumping
- Blob does not move with platforms on the sides
- Up and down platforms don't work right. Characters are thrown around
- Jynx is way too slippery when pushed by a blower when not active
- If you transition on the corner of a pushable box repeatedly with Blob, it pops up the box
- The destroy on impact script doesn't work. It seems to be looking at the wrong "force" on impact . . .
- Enemy facing not always accurate
- The buttons register the rigidbody attached to each collider touching the trigger --- even if that rigidbody has been counted before


### TODOs:
- Gremlin animates objects / golems
- Handle when a character dies (camera, death animation)
- Implement hierarchy
- How does passing info between scenes work?
- Implement a cycling list object for powers and characters and menu items (since these all share the same behaviour)
- Track powers and swap powers.
- Track coins collected in a level. They need to be id'd? Since if they've been collected in one play through of a level they shouldn't be there on later ones. However this should be dynamically generated (using level name / ID?)
- Utilize OnValidate() to resolve dependancies
- Lighting in well-lit areas
- Reduce light in dark areas when near another source? To prevent it from being "too bright"
- Light spell should stop upon contact
- Simplify scripting to use order of scripts on object
- Pushing Animation
- Carrying Animation
- Blower's Sprite
- Blob transition between angles
- Jinx's throw needs to be tweeked, so up rotates toward up, etc. 
- More enemies
- Rotating objects
- Switches( only Jinx can trigger )
- Enemies, projectiles
- Further refine Blob movement

## 2018-02-13
### Changes
- Moved BreakUp() to MyUtilities (Not yet tested)
- Added a supertype for objects that have their own movement (really, charachters), but need to be moved by external forces
- Moving Platforms implemented
- Blower Implemented
- Planned out a hierarchy for dependancies during level building
- Factored drag into the equation for drawing throw traces
- Implemented a light spell object, the first of Faye's special powers
- Sprites are now affected by light, replacing sprite masks for dark areas (will need to figure out well-lit areas)
- Started work on an Ice Spell


## 2018-02-01
### Changes
- "Finalized" a prototype version, available at raymondgrumney.com/WinProto.zip
- Intro and Outro screens
- Added coins
- Scene now reloads on character death; this will need to re-examined in the future.


## 2018-01-28
### Changes
- Worked on a menu system to bookend the demo
- Worked on intro and outro screens


## 2018-01-23
### Changes
- The demo level is now playable / beatable / almost properly puzzled
- Extracted Player and MessageController objects from Game Controller. 
- Concept art


### Fixes 
- Fixed Moving platforms (mostly)
- Hearts break up properly and properly display damage
- Level now reloads on death
- Game Events now pause input appropriately, except for the starting event?
- Fixed UI scaling issue in build


## 2018-01-18
### Changes
- Dialog Events implemented! 
- Blob pulseates

## 2018-01-09
### Changes
- More Asset work. nothing finished
- Worked on implementing a cockroach, a pretty stupid enemy
- Created bait for enemies.


## 2018-01-07
### Changes
- Worked on an event system for displaying messages and triggering other "plot" event, including:
	- a triggering event, the only way to start a chain of events
	- dialog events
	- dialog objects


## 2018-01-05
### Changes
- Eliminated secondary colored buttons / gems, to be color-blind friendly.
- Added a spiked ball, which Jynx can use as an attack

### Fixes: 
- Blob's transitions between walls/doors is handled by diagonal colliders on wall. Note that to prevent sticking while falling beside these walls, they must be a single collider with the wall


## 2018-01-02
### Changes
- Added Floaty wings to Jynx's gameobject
- Worked to create Jynx graphical assets. still have a lot to do
- Implemented a blower 
- Further refined Blob's movement


## 2017-12-24
### Changes
- Overhauled Blob's sticking phyics.

### Fixed
- Jinx can jump again


## 2017-12-21
### Changes:
- Blob sort-of works around corners. For some reason it can't handle little bumps on a right facing wall?

### Fixed:
- Blob now moves up and down walls
- Movement on ceilings / right walls no longer reversed

### Notes: 
- [Addressed] It looks like it's flipped when he's stuck on the Right side of a wall
- [Addressed] Looks like it's only moving him DOWN, despite the up movement thingy seemingly working just fine
- [Addressed] Although movement is reverse, movement works fine on ceilings


## 2017-12-20
### Changes
- Trying an algorthim for blob based on contact points rather than castings.

### Fixed:
- Blob v3 does not warp to (0,0,0) on stick

### Notes
- Trying a scheme for blob where, excepting where going around a corner, blob sticks on collision enter.
- *stickOnCorner* not currently implemented. Working on angle change / hitting a surface (from being thrown / dropping) first.

- On the subject of Blob (Slime? Ooze?) being thrown, Jinx's jump compared to throw distance of Blob needs to be tweaked so she can jump (double jump) further than she can throw, but not HIGHER. Or since blob sticks, blah blah.


## 2017-12-19
### Changes
- Life Displays are now dynamically generated. 
- Rewrote Blob to glide along surfaces rather than fall towards. Once I get this working, it should hopefully fix a lot of Blob's problems. Still have a lot of work to do to get it working.


### Fixes
- Life Displays now display properly at begining of game
- New Blob script should now move in the correct direction


## 2017-12-18
### Changes
- Renamed Blue "Jinx"
- Added gems for all primary / secondary colors
- Skinned Entire demo level
- Wrote the script to pulse and update individual hearts


## 2017-12-17
### Changes
- Created some graphical assets, including basic items and some level stuff
- Buttons now depress to indicate you've pressed them
- Added colored objects / buttons
- Buttons can now trigger multiple targets


### Fixed
- Camera is now bounded properly
- Life display is working again





## 2017-12-16
### Changes
- Did some work implementing multiplayer, including split screen, dropping in and out of players, etc. Haven't had a chance to troubleshoot / debug it.
- Worked to implement a new throwing system for Blue, allowing you to either toss quickly at a default trajectory, or take your time to throw 
- Worked on Bat's flying curve and further refined his AI
- Added simple rotating object
- Added pushable object ( broken for Blob currently)
- Added a trap door


### Fixed:
- Blue can now throw Blob onto platforms
- Red no longer jumps infinitely
- Fixed the angles the Blob can drop off a surface at
- Buttons are no longer triggered by enemy sensory colliders


## 2017-12-14
### Changes
- Put a lot of work into getting an enemy with a basic AI working. This enemy has a home position, wanders away or back to it randomly, turns to face the opposite direction occassionally, and pursues the character.
- Started to work on a bat enemy 
- Implemened a falling spike trap	
- Bullets are now fired exactly at the character
- Basic level timer display. This was more for debug purposes

### Fixed: 
- Enemy now pursues and mostly works
- Bullet now moves

# Changelog
## 2017-12-13
### Changes
- Continued work on an enemy. 
- Created a bullet
- New proto level


## 2017-12-12
### Implemented:
- Started work on first enemy.
- Level exit works! Added Exit sign.
- Created assets for keyboard keys
- Changed button mechanic to be based on combined mass of objects on the button

### Fixed:
- Fixed help text
- Change the Blob's sticking ability to the [Jump] button, so it can now carry objects while sticking to walls
- Fixed an issue where the Blob though it was dropping on flat ground and wouldn't stick around the next downward angle change.
- Cleaned up GameController. Now switches to the currentCharacter of the first player on start up instead of setting default active character by character.



## 2017-12-11 (2)
(Update) The Blob's stickiness around corners is working acceptably as long as the ceiling of the space isn't too close to the corner.

## 2017-12-11 (1)
Currently working on getting Blob's ability to stick to walls / ceilings to perform around angles. It's possible I might not implement this, as it's been a pain to implement, plus the control change from horizontal controls to vertical controls isn't very intuitive so might detract from the gameplay. A UI element might be the solution regarding the control transition.


Implemented a number of features:
- Basic movement
- Buttons / Doors
- Ladders
- Jumping
- Damage / Life / Life Display
- Lasers w/ flickering colors
- Carriable Objects
- Character Swapping
- Some sound triggers
- Groundwork for multiplayer support; the Game Controller maintains a list of players and assigns unputs from different joysticks to these players and controls which players are assigned to which character. Player's dropping in and out are not implemented, nor split screen, etc. etc.