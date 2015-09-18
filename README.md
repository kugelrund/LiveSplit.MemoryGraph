LiveSplit.MemoryGraph
=====================
Shows a value of a game's memory in a graph. Probably buggy as hell atm.

Manual Installation
-------------------
Download "Components/LiveSplit.MemoryGraph.dll" and place it into the subdirectory "Components" of your LiveSplit folder. You can then add it to your layout (category "Information").

Usage
-----
You need to tell the plugin, where in the memory it can find the value that you want to display. You can find that out using for example the free program Cheat Engine. There are also some known pointer paths listed below. If you have the pointer path for a value for your game feel free to add it here via a pull request.

Some Pointer Paths
------------------
###Quake (JoeQuake)
Name of Process: joequake-gl
- Value: Speed
  - Module: *Empty*
  - Base: 64F608
  - Offsets: *Empty*
  - Type: FloatVec2 or FloatVec3

###Quake 2 (Q2PRO)
Name of Process: q2pro
- Value: Speed
  - Module: *Empty*
  - Base: 15574C
  - Offsets: *Empty*
  - Type: FloatVec2 or FloatVec3

###Star Trek: Voyager - Elite Force
Name of Process: stvoy
- Value: Speed
  - Module: *Empty*
  - Base: BB800
  - Offsets: *Empty*
  - Type: FloatVec2
