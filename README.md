# CustomTweens
- [Home](https://github.com/Created-by-Catalyst/Internal-Unity-Packages/tree/development)

## Requirements
### DOTween
DOTween (short for "Do Tween") is a fast, efficient, fully type-safe object-oriented animation engine for Unity, optimized for C# users. It's an evolution of HOTween, another popular tween engine.

> [!note] Tweening is a term that comes from "in-betweening" and is used in animation to describe the process of generating intermediate frames between two images to give the appearance of the first image evolving smoothly into the second one.

## Core
### CustomTween
Built on top of DOTween, the CustomTween script adds a interaction layer to any number of tween scripts. 

The script provides functions to start the animation (`Play()`), reverse it (`Reverse()`), stop it (`Stop()`), restart it (`Restart()`) and play it from the beginning (`PlayFromStart()`). It also includes methods to set (`SetOrigin()`) and reset to (`ResetToOrigin()`) the initial state of the animation.


### CustomTweenTemplate
`CustomTweenTemplate` is an abstract class serving as a base for creating specific tween behaviors in Unity using the DOTween library. It defines the essential methods and properties for tweening, including play, reverse, stop, and restart methods, along with setting and resetting to the origin state. Any class inheriting from this template should provide implementation for these functionalities.

---
## Library

#### General Tweens

#### TweenMoveToPoint
This script implements a movement tween animation, allowing the target position to be set and the animation to be played, reversed, stopped, and reset to its original position.

#### TweenMoveToTarget
The `TweenMoveToTarget` script is designed to animate a GameObject's movement from its initial position to a specified target position over a certain duration.

#### TweenRotation
Apply a rotation tween to a game object, with the option to specify local or global rotations, the rotation angles, duration, and easing.

#### TweenScale
Apply a scale tween to a game object, allowing you to define the target scale and duration, and it works primarily with local scale due to limitations in DOTween's support for pseudo-world scale.

#### TweenPunchPosition
A punch position tween animation, allowing the target direction, vibrato, and elasticity to be set, and the animation to be played, reversed, stopped, and reset to its original position.

#### TweenPunchRotation
A punch rotation tween animation, allowing the rotation strength, vibrato, and elasticity to be set, and the animation to be played, reversed, stopped, and reset to its original rotation.

#### TweenPunchScale
A punch scale tween animation, allowing the target scale, vibrato, and elasticity to be set, and the animation to be played, stopped, reversed, and reset to its original scale.

#### TweenShakeRotation
Create a shake effect on the rotation of a game object, letting you define the strength, duration, vibrato, and randomness of the shaking effect.

#### TweenColorBlend
This script implements a color blending tween animation, allowing the target color to be set and the animation to be played, reversed, stopped, and reset to its original state.

### UI Tweens
> [!note] All UI tween scripts should have a class name that starts TweenUI!

#### TweenUIMoveToPoint
Move a UI element from its initial position to a defined target position over time.

#### TweenUIPunchPosition
Make a UI element "punch" its position - it moves the element by a certain amount and then returns it to its original position, creating a punch-like effect. The "strength" of the punch (how far the element moves) can be set, as can the "vibrato" (how many times the punch is performed) and "elasticity" (how much the punch motion overshoots its target before settling).

#### TweenUIPunchRotation
Similar to `TweenUIPunchPosition`, but it's for rotation instead of position. It "punches" the rotation of a UI element, meaning it rotates the element by a certain amount and then returns it to its original rotation.

#### TweenUIPunchScale
Similar to `TweenUIPunchPosition`, but it's for scale instead of position. It "punches" the scale of a UI element, meaning it scales the element by a certain amount and then returns it to its original scale.

#### TweenUIScale
Change the size of a UI element over time, from its initial size to a target size. This is similar to TweenUIMoveToPoint, but for scale instead of position.

#### TweenUIColourBlend
Modify the color of a UI Image element over time, blending from the current color to a target color, with customizable duration and looping.

#### TweenUIImageFade
`TweenUIImageFade` is a script that controls the image's opacity, letting you animate it fading in or out over a specified duration. It includes methods to start, stop, reverse, and restart the fading animation.

#### TweenUICanvasGroupFade
Enables a CanvasGroup's opacity to be tweened between its original state and a target opacity.