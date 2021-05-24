[RequireComponent] // RVA: 0x126ED0 Offset: 0x126FD1 VA: 0x126ED0
[ExecuteInEditMode] // RVA: 0x126ED0 Offset: 0x126FD1 VA: 0x126ED0
[AddComponentMenu] // RVA: 0x126ED0 Offset: 0x126FD1 VA: 0x126ED0
public class CopyLayoutElement : UIBehaviour, ILayoutElement // TypeDefIndex: 4313
{
	// Fields
	public bool CopyMinHeight; // 0x18
	public bool CopyMinWidth; // 0x19
	public bool CopyPreferredHeight; // 0x1A
	public bool CopyPreferredWidth; // 0x1B
	public RectTransform CopySource; // 0x20
	public float PaddingMinHeight; // 0x28
	public float PaddingMinWidth; // 0x2C
	public float PaddingPreferredHeight; // 0x30
	public float PaddingPreferredWidth; // 0x34

	// Properties
	public float preferredWidth { get; }
	public float preferredHeight { get; }
	public float minWidth { get; }
	public float minHeight { get; }
	public int layoutPriority { get; }
	public float flexibleHeight { get; }
	public float flexibleWidth { get; }

	// Methods

	// RVA: 0x1A853D0 Offset: 0x1A854D1 VA: 0x1A853D0 Slot: 20
	public float get_preferredWidth() { }

	// RVA: 0x1A85490 Offset: 0x1A85591 VA: 0x1A85490 Slot: 23
	public float get_preferredHeight() { }

	// RVA: 0x1A85550 Offset: 0x1A85651 VA: 0x1A85550 Slot: 19
	public float get_minWidth() { }

	// RVA: 0x1A85610 Offset: 0x1A85711 VA: 0x1A85610 Slot: 22
	public float get_minHeight() { }

	// RVA: 0x1A856D0 Offset: 0x1A857D1 VA: 0x1A856D0 Slot: 25
	public int get_layoutPriority() { }

	// RVA: 0x1A856E0 Offset: 0x1A857E1 VA: 0x1A856E0 Slot: 24
	public float get_flexibleHeight() { }

	// RVA: 0x1A856F0 Offset: 0x1A857F1 VA: 0x1A856F0 Slot: 21
	public float get_flexibleWidth() { }

	// RVA: 0x1A85700 Offset: 0x1A85801 VA: 0x1A85700 Slot: 17
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1A85710 Offset: 0x1A85811 VA: 0x1A85710 Slot: 18
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x1A85720 Offset: 0x1A85821 VA: 0x1A85720
	public void .ctor() { }
}

