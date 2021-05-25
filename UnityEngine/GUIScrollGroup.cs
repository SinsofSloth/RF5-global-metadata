internal sealed class GUIScrollGroup : GUILayoutGroup // TypeDefIndex: 3616
{
	// Fields
	public float calcMinWidth; // 0x90
	public float calcMaxWidth; // 0x94
	public float calcMinHeight; // 0x98
	public float calcMaxHeight; // 0x9C
	public float clientWidth; // 0xA0
	public float clientHeight; // 0xA4
	public bool allowHorizontalScroll; // 0xA8
	public bool allowVerticalScroll; // 0xA9
	public bool needsHorizontalScrollbar; // 0xAA
	public bool needsVerticalScrollbar; // 0xAB
	public GUIStyle horizontalScrollbar; // 0xB0
	public GUIStyle verticalScrollbar; // 0xB8

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0xF7CC0 Offset: 0xF7DC1 VA: 0xF7CC0
	// RVA: 0x2D1B3D0 Offset: 0x2D1B4D1 VA: 0x2D1B3D0
	public void .ctor() { }

	// RVA: 0x2D1B3E0 Offset: 0x2D1B4E1 VA: 0x2D1B3E0 Slot: 8
	public override void CalcWidth() { }

	// RVA: 0x2D1B470 Offset: 0x2D1B571 VA: 0x2D1B470 Slot: 10
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x2D1B640 Offset: 0x2D1B741 VA: 0x2D1B640 Slot: 9
	public override void CalcHeight() { }

	// RVA: 0x2D1B800 Offset: 0x2D1B901 VA: 0x2D1B800 Slot: 11
	public override void SetVertical(float y, float height) { }
}

