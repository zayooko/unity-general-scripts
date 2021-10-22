# Editable Score & Levels 
> with custom events optionals



## AddScore.cs
>Add scoring system in asset by ColliderTriggerEvents.cs

  - Nº of points editable
  - Add one point goal event (optional)


## PanelScore.cs
>Display scores in canvas panel

  - Editable "Score" text



## AddLevel.cs
>System of levels

  - Editable interval
  - Add event for each level up (option)
  - Add three special level goal events (optional)


## PanelLevel.cs
>Display level in canvas panel.

  - Editable "Level" text




### Notes
 Used OnTriggerExit because it seems to work better, but this part could be improved and also add tags. 
 
 Maybe also add tags to canvas panels.
 
 Use TextMesh Pro because I think it works better in AR, but it should be indifferent to use this one or the normal canvas text.