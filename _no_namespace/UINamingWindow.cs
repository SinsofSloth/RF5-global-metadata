public class UINamingWindow : CursorLinkConnector // TypeDefIndex: 8767
{
	// Fields
	private readonly int[] NameLength; // 0x58
	private static string NamingStr; // 0x0
	private static UnityAction<string> callback; // 0x8
	private static UINamingWindow.NamingId namingId; // 0x10
	private static string defaultNameStr; // 0x18
	[SerializeField] // RVA: 0x173470 Offset: 0x173571 VA: 0x173470
	private Text HeadText; // 0x60
	[SerializeField] // RVA: 0x173480 Offset: 0x173581 VA: 0x173480
	private Text NameText; // 0x68

	// Methods

	// RVA: 0x1EE3E80 Offset: 0x1EE3F81 VA: 0x1EE3E80
	private void Start() { }

	// RVA: 0x1EE4540 Offset: 0x1EE4641 VA: 0x1EE4540
	public void OpenInputText() { }

	// RVA: 0x1EE4640 Offset: 0x1EE4741 VA: 0x1EE4640
	public static string GetNameStr(UINamingWindow.NamingId id) { }

	// RVA: 0x1EE47D0 Offset: 0x1EE48D1 VA: 0x1EE47D0
	public static string GetSceneNameStr(string SceneName) { }

	// RVA: 0x1EE4D30 Offset: 0x1EE4E31 VA: 0x1EE4D30
	public static string GetDefaultNameStr(UINamingWindow.NamingId id) { }

	// RVA: 0x1EE4240 Offset: 0x1EE4341 VA: 0x1EE4240
	public static string GetNowNameStr(UINamingWindow.NamingId id) { }

	// RVA: 0x1EE52D0 Offset: 0x1EE53D1 VA: 0x1EE52D0
	public static void OpenNamingWindow(UINamingWindow.NamingId _namingId, UnityAction<string> _callback, string _defaultNameStr = "") { }

	// RVA: 0x1EE5410 Offset: 0x1EE5511 VA: 0x1EE5410
	public void Close() { }

	// RVA: 0x1EE59C0 Offset: 0x1EE5AC1 VA: 0x1EE59C0
	private bool CheckNGWord(string word) { }

	// RVA: 0x1EE5A30 Offset: 0x1EE5B31 VA: 0x1EE5A30
	private void SetClose() { }

	// RVA: 0x1EE5BF0 Offset: 0x1EE5CF1 VA: 0x1EE5BF0
	private void OnDestroy() { }

	// RVA: 0x1EE5CB0 Offset: 0x1EE5DB1 VA: 0x1EE5CB0
	public void .ctor() { }

	// RVA: 0x1EE5D40 Offset: 0x1EE5E41 VA: 0x1EE5D40
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8530 Offset: 0x1A8631 VA: 0x1A8530
	// RVA: 0x1EE5DB0 Offset: 0x1EE5EB1 VA: 0x1EE5DB0
	private void <Close>b__15_0(bool a) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8540 Offset: 0x1A8641 VA: 0x1A8540
	// RVA: 0x1EE5E60 Offset: 0x1EE5F61 VA: 0x1EE5E60
	private void <Close>b__15_2(bool a) { }
}

