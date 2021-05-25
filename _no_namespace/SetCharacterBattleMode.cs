[TaskCategoryAttribute] // RVA: 0x145890 Offset: 0x145991 VA: 0x145890
public class SetCharacterBattleMode : Action // TypeDefIndex: 6403
{
	// Fields
	private AIInput AIInput; // 0x50
	public SharedBool IsBattleMode; // 0x58

	// Properties
	private Character Character { get; }
	private HateController HateController { get; }

	// Methods

	// RVA: 0x1C8A4D0 Offset: 0x1C8A5D1 VA: 0x1C8A4D0
	private Character get_Character() { }

	// RVA: 0x1C8A4F0 Offset: 0x1C8A5F1 VA: 0x1C8A4F0
	private HateController get_HateController() { }

	// RVA: 0x1C8A590 Offset: 0x1C8A691 VA: 0x1C8A590 Slot: 4
	public override void OnAwake() { }

	// RVA: 0x1C8A5F0 Offset: 0x1C8A6F1 VA: 0x1C8A5F0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x1C8A600 Offset: 0x1C8A701 VA: 0x1C8A600 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x1C8A7E0 Offset: 0x1C8A8E1 VA: 0x1C8A7E0
	public void .ctor() { }
}

