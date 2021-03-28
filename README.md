# uncertain_tap
Esther is a genius at making names 

A short Unity WebGL project that maps animations and sound to keyboard input - on a certain key press, a sound will play and an animation will be displayed on a VideoTexture RawTexture attached to a Panel object (clone to see the exact layout with prefabs and such). 

Current Issues:
Recent conversion to StreamingAssets after realizing that VideoClip doesn't work with WebGL - however, some videos are frozen on first frame (and other sseem to not play, but I assume this is due to a blank first frame) whereas others play in editor. No video functionality in build, due to nonexistent path errors with current code (can provide more details as requested). Final build is to be uploaded to simmer.io, online Unity hosting service. 
