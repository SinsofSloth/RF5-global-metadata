public class FriendJudgmentManager.FriendJudgmentMonster // TypeDefIndex: 8155
{
	// Fields
	private const float SuccessEffectTime = 1.53;
	private const float JudgmentEmotionTime = 1.864;
	private FriendJudgmentManager.FriendJudgmentMonster.State CurrentState; // 0x10
	private float Timer; // 0x14
	private bool IsSuccess; // 0x18
	private MonsterControllerBase Monster; // 0x20
	private Action<bool, string> CallBack; // 0x28

	// Properties
	public bool IsEnd { get; }
	public bool IsPlayJudgmentEmotion { get; }
	public bool IsEndPlayJudgmentEmotion { get; }
	public bool IsPlayResultEmotion { get; }
	public bool IsEndPlayResultEmotion { get; }
	public bool IsPlaySuccessEffect { get; }
	public bool IsOpenNamingWindow { get; }
	public bool IsEndJudgmentEmotionTimer { get; }
	public bool IsEndSuccessEffectTimer { get; }

	// Methods

	// RVA: 0x1D61D10 Offset: 0x1D61E11 VA: 0x1D61D10
	public bool get_IsEnd() { }

	// RVA: 0x1D616E0 Offset: 0x1D617E1 VA: 0x1D616E0
	public bool get_IsPlayJudgmentEmotion() { }

	// RVA: 0x1D61D60 Offset: 0x1D61E61 VA: 0x1D61D60
	public bool get_IsEndPlayJudgmentEmotion() { }

	// RVA: 0x1D61D70 Offset: 0x1D61E71 VA: 0x1D61D70
	public bool get_IsPlayResultEmotion() { }

	// RVA: 0x1D61D80 Offset: 0x1D61E81 VA: 0x1D61D80
	public bool get_IsEndPlayResultEmotion() { }

	// RVA: 0x1D61D90 Offset: 0x1D61E91 VA: 0x1D61D90
	public bool get_IsPlaySuccessEffect() { }

	// RVA: 0x1D61DA0 Offset: 0x1D61EA1 VA: 0x1D61DA0
	public bool get_IsOpenNamingWindow() { }

	// RVA: 0x1D61DB0 Offset: 0x1D61EB1 VA: 0x1D61DB0
	public bool get_IsEndJudgmentEmotionTimer() { }

	// RVA: 0x1D61530 Offset: 0x1D61631 VA: 0x1D61530
	public bool get_IsEndSuccessEffectTimer() { }

	// RVA: 0x1D60F80 Offset: 0x1D61081 VA: 0x1D60F80
	public void .ctor(MonsterControllerBase monster, Action<bool, string> callBack) { }

	// RVA: 0x1D614C0 Offset: 0x1D615C1 VA: 0x1D614C0
	public bool IsValid() { }

	// RVA: 0x1D61260 Offset: 0x1D61361 VA: 0x1D61260
	public void UpdateTimer() { }

	// RVA: 0x1D616F0 Offset: 0x1D617F1 VA: 0x1D616F0
	public void PlayResultEmotion() { }

	// RVA: 0x1D61B20 Offset: 0x1D61C21 VA: 0x1D61B20
	public void PlayFailureEmotion() { }

	// RVA: 0x1D61560 Offset: 0x1D61661 VA: 0x1D61560
	public void OpenNamingWindow(UnityAction<string> closeEvent) { }

	// RVA: 0x1D61AA0 Offset: 0x1D61BA1 VA: 0x1D61AA0
	public void CloseNamingWindow(string nickName) { }

	// RVA: 0x1D61F50 Offset: 0x1D62051 VA: 0x1D61F50
	private void EndResultEmotionEvent() { }
}

