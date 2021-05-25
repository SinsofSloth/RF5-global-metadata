[TaskDescriptionAttribute] // RVA: 0x14B4D0 Offset: 0x14B5D1 VA: 0x14B4D0
[TaskCategoryAttribute] // RVA: 0x14B4D0 Offset: 0x14B5D1 VA: 0x14B4D0
[TaskIconAttribute] // RVA: 0x14B4D0 Offset: 0x14B5D1 VA: 0x14B4D0
public class SetPropertyValue : Action // TypeDefIndex: 10930
{
	// Fields
	[TooltipAttribute] // RVA: 0x1830B0 Offset: 0x1831B1 VA: 0x1830B0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1830F0 Offset: 0x1831F1 VA: 0x1830F0
	public SharedString componentName; // 0x58
	[TooltipAttribute] // RVA: 0x183130 Offset: 0x183231 VA: 0x183130
	public SharedString propertyName; // 0x60
	[TooltipAttribute] // RVA: 0x183170 Offset: 0x183271 VA: 0x183170
	public SharedVariable propertyValue; // 0x68

	// Methods

	// RVA: 0x20E8430 Offset: 0x20E8531 VA: 0x20E8430 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20E86C0 Offset: 0x20E87C1 VA: 0x20E86C0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20E8720 Offset: 0x20E8821 VA: 0x20E8720
	public void .ctor() { }
}

