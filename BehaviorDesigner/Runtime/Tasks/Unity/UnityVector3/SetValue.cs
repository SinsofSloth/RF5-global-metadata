[TaskCategoryAttribute] // RVA: 0x14C9F0 Offset: 0x14CAF1 VA: 0x14C9F0
[TaskDescriptionAttribute] // RVA: 0x14C9F0 Offset: 0x14CAF1 VA: 0x14C9F0
public class SetValue : Action // TypeDefIndex: 10986
{
	// Fields
	[TooltipAttribute] // RVA: 0x184E90 Offset: 0x184F91 VA: 0x184E90
	public SharedVector3 vector3Value; // 0x50
	[TooltipAttribute] // RVA: 0x184ED0 Offset: 0x184FD1 VA: 0x184ED0
	public SharedVector3 vector3Variable; // 0x58

	// Methods

	// RVA: 0x22DA0F0 Offset: 0x22DA1F1 VA: 0x22DA0F0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x22DA170 Offset: 0x22DA271 VA: 0x22DA170 Slot: 16
	public override void OnReset() { }

	// RVA: 0x22DA210 Offset: 0x22DA311 VA: 0x22DA210
	public void .ctor() { }
}

