[RequireComponent] // RVA: 0x127010 Offset: 0x127111 VA: 0x127010
[ExecuteInEditMode] // RVA: 0x127010 Offset: 0x127111 VA: 0x127010
[AddComponentMenu] // RVA: 0x127010 Offset: 0x127111 VA: 0x127010
public class CopySizeIntoLayoutElement : LayoutElement // TypeDefIndex: 4315
{
	// Fields
	public RectTransform CopySource; // 0x38
	public float PaddingHeight; // 0x40
	public float PaddingWidth; // 0x44
	public bool SetPreferredSize; // 0x48
	public bool SetMinimumSize; // 0x49

	// Properties
	public override float preferredWidth { get; }
	public override float preferredHeight { get; }
	public override float minWidth { get; }
	public override float minHeight { get; }
	public override int layoutPriority { get; }

	// Methods

	// RVA: 0x1A858B0 Offset: 0x1A859B1 VA: 0x1A858B0 Slot: 35
	public override float get_preferredWidth() { }

	// RVA: 0x1A85990 Offset: 0x1A85A91 VA: 0x1A85990 Slot: 37
	public override float get_preferredHeight() { }

	// RVA: 0x1A85A70 Offset: 0x1A85B71 VA: 0x1A85A70 Slot: 31
	public override float get_minWidth() { }

	// RVA: 0x1A85B50 Offset: 0x1A85C51 VA: 0x1A85B50 Slot: 33
	public override float get_minHeight() { }

	// RVA: 0x1A85C30 Offset: 0x1A85D31 VA: 0x1A85C30 Slot: 43
	public override int get_layoutPriority() { }

	// RVA: 0x1A85C40 Offset: 0x1A85D41 VA: 0x1A85C40
	public void .ctor() { }
}

