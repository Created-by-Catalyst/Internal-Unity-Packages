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

#### TweenMoveToTarget
The `TweenMoveToTarget` script is designed to animate a GameObject's movement from its initial position to a specified target position over a certain duration.

### UI Tweens
> [!note] All UI tween scripts should have a class name that starts TweenUI!

#### TweenUIImageFade
`TweenUIImageFade` is a script that controls the image's opacity, letting you animate it fading in or out over a specified duration. It includes methods to start, stop, reverse, and restart the fading animation.

