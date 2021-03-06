# UnityChatLog

In-game log for Unity with scrolling credit effects. Useful for outputting chat messages and player behaviour.

![demo unitychatlog](https://github.com/swparkaust/UnityChatLog/raw/master/img/demo-unitychatlog.gif)

*Read this in other languages: [English](README.md), [한국어](README.ko.md).*

### Installation

No dependencies other than Unity are required. Let me know if anything happens!

1. Create an empty GameObject and name it ChatLog.
2. Download the ChatLog.cs script and add it to the GameObject.
3. You can now print the text to display.

### Usage
```C#
	private ChatLog chatLog;

	void Start()
	{
		chatLog = GetComponent<ChatLog>();
	}

	void Update()
	{
		if (Input.GetKey(KeyCode.LeftArrow))
			chatLog.Write("Player Moves Left");

		if (Input.GetKey(KeyCode.RightArrow))
			chatLog.Write("Player Moves Right");
	}
```
