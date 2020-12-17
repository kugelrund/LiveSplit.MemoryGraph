LiveSplit.MemoryGraph
=====================
Shows a value of a game's memory in a graph.

![preview.png](/images/preview.png)

Manual Installation
-------------------
Download "Components/LiveSplit.MemoryGraph.dll" and place it into the subdirectory "Components" of your LiveSplit folder. You can then add it to your layout (category "Information").

Usage
-----
You need to tell the plugin, where in the game's memory it can find the value that you want to display.
For many games, some kind people have already looked for values worth displaying and added them to our [XML file](https://github.com/kugelrund/LiveSplit.MemoryGraph/blob/master/XML/LiveSplit.MemoryGraph.Games.xml).
The settings of the component can be used to download that XML file, which then allows to select a game and one of its known values via the dropdown menu.

If the address for the value that you want to display is not there yes, you can try to find it by yourself using for example the free program Cheat Engine.
The process is very similar to that when writing your own [AutoSplitter](https://github.com/LiveSplit/LiveSplit.AutoSplitters/blob/master/README.md) for LiveSplit, so it might be worth to check out some of that documentation. If you were successful in finding your value, consider adding it to our [XML file](https://github.com/kugelrund/LiveSplit.MemoryGraph/blob/master/XML/LiveSplit.MemoryGraph.Games.xml) via a pull request, so that other people can use it in the future.

Credits
-----
* [SphereMJ / kugelrund](https://www.twitch.tv/spheremj)
* [SuicideMachine](https://www.twitch.tv/suicidemachine)
* [TravisDaily](https://github.com/TravisDaily)
