public class SText : Text // TypeDefIndex: 8931
{
	// Fields
	[SerializeField] // RVA: 0x174C10 Offset: 0x174D11 VA: 0x174C10
	private SysTextGroup textGroup; // 0xF0
	[SerializeField] // RVA: 0x174C20 Offset: 0x174D21 VA: 0x174C20
	public string textID; // 0xF8
	[SerializeField] // RVA: 0x174C30 Offset: 0x174D31 VA: 0x174C30
	public UITextDic.DICID DicId; // 0x100

	// Methods

	// RVA: 0x1D6D530 Offset: 0x1D6D631 VA: 0x1D6D530 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1D6D860 Offset: 0x1D6D961 VA: 0x1D6D860
	public void SetText(int _textGroup, int _textID) { }

	// RVA: 0x1D6D5C0 Offset: 0x1D6D6C1 VA: 0x1D6D5C0
	public void SetText(UITextDic.DICID _DicId) { }

	// RVA: 0x1D6D6D0 Offset: 0x1D6D7D1 VA: 0x1D6D6D0
	public void SetText(SysTextGroup _textGroup, string _textID) { }

	// RVA: 0x1D6D980 Offset: 0x1D6DA81 VA: 0x1D6D980
	public void SetText(SysTextGroup _textGroup, int _textID) { }

	// RVA: 0x1D6DAA0 Offset: 0x1D6DBA1 VA: 0x1D6DAA0
	public void .ctor() { }
}

