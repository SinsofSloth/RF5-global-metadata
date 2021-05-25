public class UIMonsterNaming : CursorLinkConnector // TypeDefIndex: 8765
{
	// Fields
	public static string NamingStr; // 0x0
	private static UnityAction<string> callback; // 0x8
	private static MonsterDataID MonsterDataID; // 0x10
	[SerializeField] // RVA: 0x173450 Offset: 0x173551 VA: 0x173450
	private Text HeadText; // 0x58
	[SerializeField] // RVA: 0x173460 Offset: 0x173561 VA: 0x173460
	private Text NameText; // 0x60

	// Methods

	// RVA: 0x1EE2D50 Offset: 0x1EE2E51 VA: 0x1EE2D50
	private void Start() { }

	// RVA: 0x1EE2FB0 Offset: 0x1EE30B1 VA: 0x1EE2FB0
	public void OpenInputText() { }

	// RVA: 0x1EE3050 Offset: 0x1EE3151 VA: 0x1EE3050
	public static void OpenMonsterNamingWindow(MonsterDataID monsterDataID, UnityAction<string> _callback, string defaultNameStr = "") { }

	// RVA: 0x1EE31A0 Offset: 0x1EE32A1 VA: 0x1EE31A0
	public void Close() { }

	// RVA: 0x1EE3680 Offset: 0x1EE3781 VA: 0x1EE3680
	private bool CheckNGWord(string word) { }

	// RVA: 0x1EE36F0 Offset: 0x1EE37F1 VA: 0x1EE36F0
	private void SetClose() { }

	// RVA: 0x1EE38B0 Offset: 0x1EE39B1 VA: 0x1EE38B0
	private void OnDestroy() { }

	// RVA: 0x1EE3920 Offset: 0x1EE3A21 VA: 0x1EE3920
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8510 Offset: 0x1A8611 VA: 0x1A8510
	// RVA: 0x1EE3930 Offset: 0x1EE3A31 VA: 0x1EE3930
	private void <Close>b__8_0(bool a) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8520 Offset: 0x1A8621 VA: 0x1A8520
	// RVA: 0x1EE39B0 Offset: 0x1EE3AB1 VA: 0x1EE39B0
	private void <Close>b__8_2(bool a) { }
}

