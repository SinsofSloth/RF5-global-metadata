[TaskCategoryAttribute] // RVA: 0x14B060 Offset: 0x14B161 VA: 0x14B060
public class FindTargetSearchCharacterController : Conditional // TypeDefIndex: 10920
{
	// Fields
	[TooltipAttribute] // RVA: 0x1829D0 Offset: 0x182AD1 VA: 0x1829D0
	public SharedInt SearchType; // 0x50
	public SharedBool UseMaxRange; // 0x58
	[TooltipAttribute] // RVA: 0x182A10 Offset: 0x182B11 VA: 0x182A10
	public SharedGameObject ReturnTarget; // 0x60
	private AIInput AIInput; // 0x68

	// Properties
	private SearchCharacterController SearchCharacterController { get; }

	// Methods

	// RVA: 0x20DE690 Offset: 0x20DE791 VA: 0x20DE690
	private SearchCharacterController get_SearchCharacterController() { }

	// RVA: 0x20DE6B0 Offset: 0x20DE7B1 VA: 0x20DE6B0 Slot: 4
	public override void OnAwake() { }

	// RVA: 0x20DE720 Offset: 0x20DE821 VA: 0x20DE720 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20DEA20 Offset: 0x20DEB21 VA: 0x20DEA20
	public int GetSearchCharacterType() { }

	// RVA: 0x20DEAC0 Offset: 0x20DEBC1 VA: 0x20DEAC0
	public void .ctor() { }
}

