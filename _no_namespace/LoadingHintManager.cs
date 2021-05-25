public class LoadingHintManager : SingletonMonoBehaviour<LoadingHintManager> // TypeDefIndex: 8625
{
	// Fields
	[SerializeField] // RVA: 0x171310 Offset: 0x171411 VA: 0x171310
	private Text hintText; // 0x18
	private StringBuilder hintTextSb; // 0x20
	private const float DURATION_TIME = 10;
	private List<string> hintList; // 0x28
	private HintDataTable hintDataTable; // 0x30
	private int nowTitle; // 0x38
	private float timeCount; // 0x3C
	private LoadingHintManager.State state; // 0x40

	// Properties
	public bool IsShow { get; }

	// Methods

	// RVA: 0x1E04BA0 Offset: 0x1E04CA1 VA: 0x1E04BA0
	public bool get_IsShow() { }

	// RVA: 0x1E04BB0 Offset: 0x1E04CB1 VA: 0x1E04BB0
	private void Update() { }

	// RVA: 0x1E05600 Offset: 0x1E05701 VA: 0x1E05600
	public void StartShow() { }

	// RVA: 0x1E05580 Offset: 0x1E05681 VA: 0x1E05580
	public void StopShow() { }

	// RVA: 0x1E054F0 Offset: 0x1E055F1 VA: 0x1E054F0
	private void ShowText() { }

	// RVA: 0x1E04FF0 Offset: 0x1E050F1 VA: 0x1E04FF0
	private string TextSetup(int _no) { }

	// RVA: 0x1E05700 Offset: 0x1E05801 VA: 0x1E05700
	public void .ctor() { }
}

