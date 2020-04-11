# UnityChatLog

스크롤링 크레딧 효과가 있는 Unity 용 게임 내 로그. 채팅 메시지 및 플레이어 동작 출력에 유용함.

![demo unitychatlog](https://github.com/swparkaust/UnityChatLog/raw/master/img/demo-unitychatlog.gif)

### 설치

Unity 이외의 종속성은 필요하지 않습니다. 무슨 일이 생기면 알려주세요!

1. 빈 GameObject를 만들고 이름을 ChatLog로 지정합니다.
2. ChatLog.cs 스크립트를 다운로드하여 GameObject에 추가합니다.
3. 이제 표시하려는 문자열을 출력할 수 있습니다.

### 용법
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
