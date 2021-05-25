[TaskCategoryAttribute] // RVA: 0x1454D0 Offset: 0x1455D1 VA: 0x1454D0
public class PartnerNPCGrantAttribute : Action // TypeDefIndex: 6368
{
	// Fields
	public SharedPartnerNPCBehaviorController SharedPartnerBehaviorController; // 0x50
	public SharedAttackAttribute Attribute; // 0x58
	public SharedFloat Duration; // 0x60

	// Properties
	private PartnerNPCController PartnerNPCController { get; }

	// Methods

	// RVA: 0x1FDD7A0 Offset: 0x1FDD8A1 VA: 0x1FDD7A0
	private PartnerNPCController get_PartnerNPCController() { }

	// RVA: 0x1FDD800 Offset: 0x1FDD901 VA: 0x1FDD800 Slot: 5
	public override void OnStart() { }

	// RVA: 0x1FDDA30 Offset: 0x1FDDB31 VA: 0x1FDDA30 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x1FDDA40 Offset: 0x1FDDB41 VA: 0x1FDDA40
	public void .ctor() { }
}

