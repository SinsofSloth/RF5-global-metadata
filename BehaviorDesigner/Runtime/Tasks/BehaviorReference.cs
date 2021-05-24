[HelpURLAttribute] // RVA: 0x12D1C0 Offset: 0x12D2C1 VA: 0x12D1C0
[TaskIconAttribute] // RVA: 0x12D1C0 Offset: 0x12D2C1 VA: 0x12D1C0
[TaskDescriptionAttribute] // RVA: 0x12D1C0 Offset: 0x12D2C1 VA: 0x12D1C0
public abstract class BehaviorReference : Action // TypeDefIndex: 4720
{
	// Fields
	[TooltipAttribute] // RVA: 0x12D920 Offset: 0x12DA21 VA: 0x12D920
	public ExternalBehavior[] externalBehaviors; // 0x50
	[TooltipAttribute] // RVA: 0x12D960 Offset: 0x12DA61 VA: 0x12D960
	public SharedNamedVariable[] variables; // 0x58
	[HideInInspector] // RVA: 0x12D9A0 Offset: 0x12DAA1 VA: 0x12D9A0
	public bool collapsed; // 0x60

	// Methods

	// RVA: 0x1B23C80 Offset: 0x1B23D81 VA: 0x1B23C80
	protected void .ctor() { }

	// RVA: 0x1B23D00 Offset: 0x1B23E01 VA: 0x1B23D00 Slot: 30
	public virtual ExternalBehavior[] GetExternalBehaviors() { }

	// RVA: 0x1B23D10 Offset: 0x1B23E11 VA: 0x1B23D10 Slot: 16
	public override void OnReset() { }
}

