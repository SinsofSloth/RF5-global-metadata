public class ButtonLinker : CursorLinker // TypeDefIndex: 8445
{
	// Fields
	[SerializeField] // RVA: 0x16F970 Offset: 0x16FA71 VA: 0x16F970
	private List<ButtonLinker.LinkObject> LinkObjectList; // 0x50
	[SerializeField] // RVA: 0x16F980 Offset: 0x16FA81 VA: 0x16F980
	private ButtonGuideId ButtonGuideId; // 0x58

	// Methods

	// RVA: 0x206DCC0 Offset: 0x206DDC1 VA: 0x206DCC0
	public void ClearLink() { }

	// RVA: 0x206DD20 Offset: 0x206DE21 VA: 0x206DD20
	public void AddLink(CursorLinker.InputMoveType _type, GameObject _moveToButton) { }

	// RVA: 0x206DE70 Offset: 0x206DF71 VA: 0x206DE70 Slot: 6
	public override CursorLinker GetNextObject(CursorLinker.InputMoveType _InType) { }

	// RVA: 0x206E090 Offset: 0x206E191 VA: 0x206E090 Slot: 10
	public override void OnFocus() { }

	// RVA: 0x206E110 Offset: 0x206E211 VA: 0x206E110
	public void .ctor() { }
}

