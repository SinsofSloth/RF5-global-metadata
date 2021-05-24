[TaskCategoryAttribute] // RVA: 0x14F1B0 Offset: 0x14F2B1 VA: 0x14F1B0
[TaskDescriptionAttribute] // RVA: 0x14F1B0 Offset: 0x14F2B1 VA: 0x14F1B0
public class SharedGameObjectsToGameObjectList : Action // TypeDefIndex: 11093
{
	// Fields
	[TooltipAttribute] // RVA: 0x188C50 Offset: 0x188D51 VA: 0x188C50
	public SharedGameObject[] gameObjects; // 0x50
	[RequiredFieldAttribute] // RVA: 0x188C90 Offset: 0x188D91 VA: 0x188C90
	[TooltipAttribute] // RVA: 0x188C90 Offset: 0x188D91 VA: 0x188C90
	public SharedGameObjectList storedGameObjectList; // 0x58

	// Methods

	// RVA: 0x278D130 Offset: 0x278D231 VA: 0x278D130 Slot: 4
	public override void OnAwake() { }

	// RVA: 0x278D1C0 Offset: 0x278D2C1 VA: 0x278D1C0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x278D2F0 Offset: 0x278D3F1 VA: 0x278D2F0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x278D330 Offset: 0x278D431 VA: 0x278D330
	public void .ctor() { }
}

