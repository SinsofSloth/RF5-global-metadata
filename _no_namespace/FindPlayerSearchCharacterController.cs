[TaskCategoryAttribute] // RVA: 0x1458D0 Offset: 0x1459D1 VA: 0x1458D0
public class FindPlayerSearchCharacterController : Conditional // TypeDefIndex: 6405
{
	// Fields
	public SharedInt SearchRangeType; // 0x50
	public SharedBool UseMaxRange; // 0x58
	private AIInput AIInput; // 0x60

	// Properties
	private SearchCharacterController SearchCharacterController { get; }
	private Character Player { get; }

	// Methods

	// RVA: 0x1EF26B0 Offset: 0x1EF27B1 VA: 0x1EF26B0
	private SearchCharacterController get_SearchCharacterController() { }

	// RVA: 0x1EF26D0 Offset: 0x1EF27D1 VA: 0x1EF26D0
	private Character get_Player() { }

	// RVA: 0x1EF2730 Offset: 0x1EF2831 VA: 0x1EF2730 Slot: 4
	public override void OnAwake() { }

	// RVA: 0x1EF27A0 Offset: 0x1EF28A1 VA: 0x1EF27A0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x1EF2A30 Offset: 0x1EF2B31 VA: 0x1EF2A30
	public int GetSearchCharacterType() { }

	// RVA: 0x1EF2AD0 Offset: 0x1EF2BD1 VA: 0x1EF2AD0
	public void .ctor() { }
}

