![minesense](https://github.com/nukiz/minesense/blob/main/githubrsc/minesenses.png?raw=true)

![codefactor](https://img.shields.io/codefactor/grade/github/nukiz/minesense?color=royalblue)
![Lines of code](https://img.shields.io/tokei/lines/github/nukiz/minesense?color=lightcoral&label=lines%20of%20code)

[![forthebadge](https://forthebadge.com/images/badges/compatibility-club-penguin.svg)](https://forthebadge.com)
[![forthebadge](https://forthebadge.com/images/badges/contains-tasty-spaghetti-code.svg)](https://forthebadge.com)
[![forthebadge](https://forthebadge.com/images/badges/reading-6th-grade-level.svg)](https://forthebadge.com)


<h1 align="center">minesense. be you from within.</h1>

## <h1 align="center">What is this?</h1>

Minesense is an unfinished external ghost client for Minecraft: Bedrock Edition. Features include:
- FakeLag
- Reach
- Autoclicker
- Airjump and other miscellaneous movement features
- Customizable velocity with chance%, H% and V% and anticombo.
- Comeback Assist (cranks settings to max when under hp threshold, and returns them shortly after)
- Customization for the client, with intended Lua scripting API for customizable modules
- Discord RPC

However most of these features are very primitive (fakelag..) and some dont even exist yet (velocity etc)
Client is very customizable.

## <h1 align="center">Dependencies</h1>

Minesense uses many dependencies. These include: 
- DiscordRPC.dll | Used for the Discord Rich Presence used by the client
- KeraLua, NLua etc. | To be used for the upcoming Lua API
- Newtonsoft.Json | To be used for the upcoming configs system, also a dependency of DiscordRPC.dll.
- Memory.dll | Library used to read/write the game's memory for the cheats (very primitive... but easy to use!)

## <h1 align="center">Development & Contributions</h1>

Main developer & maintainer of this project will remain nukiz.
Other developers include Zyph. (Dimwitted-Developer)

Contributions are simple. Make your changes/updates/refactors and whatnot, and submit a pull request. I (nukiz) will review your changes and act accordingly.

We hope to have as many contributors as possible!

## <h1 align="center">Don't know what to do? Here's some starters</h1>

- [ ] Implement velocity, chance & anti-combo
- [ ] Autoclicker fix (Doesn't work for some reason, builds fine and should work but apparently doesn't)
- [ ] Movement features (Airjump etc.)
- [ ] Arraylist (Used to exist but caused a random build error for some reason.
- [ ] Make reach better
- [ ] Fix autoclicker randomizer
- [ ] Make FakeLag better (not this primitive...)

Autoclicker and reach used to work fine btw, after a few updates they just broke!


