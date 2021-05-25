[NativeClassAttribute] // RVA: 0x103030 Offset: 0x103131 VA: 0x103030
[NativeHeaderAttribute] // RVA: 0x103030 Offset: 0x103131 VA: 0x103030
public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter // TypeDefIndex: 3694
{
	// Properties
	[NativePropertyAttribute] // RVA: 0x103610 Offset: 0x103711 VA: 0x103610
	public float alpha { get; set; }
	[NativePropertyAttribute] // RVA: 0x103650 Offset: 0x103751 VA: 0x103650
	public bool interactable { get; set; }
	[NativePropertyAttribute] // RVA: 0x103690 Offset: 0x103791 VA: 0x103690
	public bool blocksRaycasts { get; set; }
	[NativePropertyAttribute] // RVA: 0x1036D0 Offset: 0x1037D1 VA: 0x1036D0
	public bool ignoreParentGroups { get; set; }

	// Methods

	// RVA: 0x1BBFF20 Offset: 0x1BC0021 VA: 0x1BBFF20
	public float get_alpha() { }

	// RVA: 0x1BBFF70 Offset: 0x1BC0071 VA: 0x1BBFF70
	public void set_alpha(float value) { }

	// RVA: 0x1BBFFC0 Offset: 0x1BC00C1 VA: 0x1BBFFC0
	public bool get_interactable() { }

	// RVA: 0x1BC0010 Offset: 0x1BC0111 VA: 0x1BC0010
	public void set_interactable(bool value) { }

	// RVA: 0x1BC0060 Offset: 0x1BC0161 VA: 0x1BC0060
	public bool get_blocksRaycasts() { }

	// RVA: 0x1BC00B0 Offset: 0x1BC01B1 VA: 0x1BC00B0
	public void set_blocksRaycasts(bool value) { }

	// RVA: 0x1BC0100 Offset: 0x1BC0201 VA: 0x1BC0100
	public bool get_ignoreParentGroups() { }

	// RVA: 0x1BC0150 Offset: 0x1BC0251 VA: 0x1BC0150
	public void set_ignoreParentGroups(bool value) { }

	// RVA: 0x1BC01A0 Offset: 0x1BC02A1 VA: 0x1BC01A0 Slot: 4
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x1BC01F0 Offset: 0x1BC02F1 VA: 0x1BC01F0
	public void .ctor() { }
}

