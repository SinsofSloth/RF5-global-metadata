[ExecuteInEditMode] // RVA: 0x1271E0 Offset: 0x1272E1 VA: 0x1271E0
[RequireComponent] // RVA: 0x1271E0 Offset: 0x1272E1 VA: 0x1271E0
public abstract class ResponsiveBase : SRMonoBehaviour // TypeDefIndex: 4320
{
	// Fields
	private bool _queueRefresh; // 0x48

	// Properties
	protected RectTransform RectTransform { get; }

	// Methods

	// RVA: 0x1A89B40 Offset: 0x1A89C41 VA: 0x1A89B40
	protected RectTransform get_RectTransform() { }

	// RVA: 0x1A89C30 Offset: 0x1A89D31 VA: 0x1A89C30
	protected void OnEnable() { }

	// RVA: 0x1A89C40 Offset: 0x1A89D41 VA: 0x1A89C40
	protected void OnRectTransformDimensionsChange() { }

	// RVA: 0x1A89C50 Offset: 0x1A89D51 VA: 0x1A89C50
	protected void Update() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void Refresh() { }

	[ContextMenu] // RVA: 0x128120 Offset: 0x128221 VA: 0x128120
	// RVA: 0x1A89C90 Offset: 0x1A89D91 VA: 0x1A89C90
	private void DoRefresh() { }

	// RVA: 0x1A89CA0 Offset: 0x1A89DA1 VA: 0x1A89CA0
	protected void .ctor() { }
}

