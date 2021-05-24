[RequireComponent] // RVA: 0x126F70 Offset: 0x127071 VA: 0x126F70
[ExecuteInEditMode] // RVA: 0x126F70 Offset: 0x127071 VA: 0x126F70
[AddComponentMenu] // RVA: 0x126F70 Offset: 0x127071 VA: 0x126F70
public class CopyPreferredSize : LayoutElement // TypeDefIndex: 4314
{
	// Fields
	public RectTransform CopySource; // 0x38
	public float PaddingHeight; // 0x40
	public float PaddingWidth; // 0x44

	// Properties
	public override float preferredWidth { get; }
	public override float preferredHeight { get; }
	public override int layoutPriority { get; }

	// Methods

	// RVA: 0x1A85730 Offset: 0x1A85831 VA: 0x1A85730 Slot: 35
	public override float get_preferredWidth() { }

	// RVA: 0x1A857E0 Offset: 0x1A858E1 VA: 0x1A857E0 Slot: 37
	public override float get_preferredHeight() { }

	// RVA: 0x1A85890 Offset: 0x1A85991 VA: 0x1A85890 Slot: 43
	public override int get_layoutPriority() { }

	// RVA: 0x1A858A0 Offset: 0x1A859A1 VA: 0x1A858A0
	public void .ctor() { }
}

