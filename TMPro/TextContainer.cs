[RequireComponent] // RVA: 0x13F080 Offset: 0x13F181 VA: 0x13F080
public class TextContainer : UIBehaviour // TypeDefIndex: 5904
{
	// Fields
	private bool m_hasChanged; // 0x18
	[SerializeField] // RVA: 0x140390 Offset: 0x140491 VA: 0x140390
	private Vector2 m_pivot; // 0x1C
	[SerializeField] // RVA: 0x1403A0 Offset: 0x1404A1 VA: 0x1403A0
	private TextContainerAnchors m_anchorPosition; // 0x24
	[SerializeField] // RVA: 0x1403B0 Offset: 0x1404B1 VA: 0x1403B0
	private Rect m_rect; // 0x28
	private bool m_isDefaultWidth; // 0x38
	private bool m_isDefaultHeight; // 0x39
	private bool m_isAutoFitting; // 0x3A
	private Vector3[] m_corners; // 0x40
	private Vector3[] m_worldCorners; // 0x48
	[SerializeField] // RVA: 0x1403C0 Offset: 0x1404C1 VA: 0x1403C0
	private Vector4 m_margins; // 0x50
	private RectTransform m_rectTransform; // 0x60
	private static Vector2 k_defaultSize; // 0x0
	private TextMeshPro m_textMeshPro; // 0x68

	// Properties
	public bool hasChanged { get; set; }
	public Vector2 pivot { get; set; }
	public TextContainerAnchors anchorPosition { get; set; }
	public Rect rect { get; set; }
	public Vector2 size { get; set; }
	public float width { get; set; }
	public float height { get; set; }
	public bool isDefaultWidth { get; }
	public bool isDefaultHeight { get; }
	public bool isAutoFitting { get; set; }
	public Vector3[] corners { get; }
	public Vector3[] worldCorners { get; }
	public Vector4 margins { get; set; }
	public RectTransform rectTransform { get; }
	public TextMeshPro textMeshPro { get; }

	// Methods

	// RVA: 0x15A4A00 Offset: 0x15A4B01 VA: 0x15A4A00
	public bool get_hasChanged() { }

	// RVA: 0x15A4A10 Offset: 0x15A4B11 VA: 0x15A4A10
	public void set_hasChanged(bool value) { }

	// RVA: 0x15A4A20 Offset: 0x15A4B21 VA: 0x15A4A20
	public Vector2 get_pivot() { }

	// RVA: 0x15A4A30 Offset: 0x15A4B31 VA: 0x15A4A30
	public void set_pivot(Vector2 value) { }

	// RVA: 0x15A5070 Offset: 0x15A5171 VA: 0x15A5070
	public TextContainerAnchors get_anchorPosition() { }

	// RVA: 0x15A5080 Offset: 0x15A5181 VA: 0x15A5080
	public void set_anchorPosition(TextContainerAnchors value) { }

	// RVA: 0x15A51E0 Offset: 0x15A52E1 VA: 0x15A51E0
	public Rect get_rect() { }

	// RVA: 0x15A51F0 Offset: 0x15A52F1 VA: 0x15A51F0
	public void set_rect(Rect value) { }

	// RVA: 0x15A5280 Offset: 0x15A5381 VA: 0x15A5280
	public Vector2 get_size() { }

	// RVA: 0x15A52F0 Offset: 0x15A53F1 VA: 0x15A52F0
	public void set_size(Vector2 value) { }

	// RVA: 0x15A54B0 Offset: 0x15A55B1 VA: 0x15A54B0
	public float get_width() { }

	// RVA: 0x15A54C0 Offset: 0x15A55C1 VA: 0x15A54C0
	public void set_width(float value) { }

	// RVA: 0x15A5590 Offset: 0x15A5691 VA: 0x15A5590
	public float get_height() { }

	// RVA: 0x15A55A0 Offset: 0x15A56A1 VA: 0x15A55A0
	public void set_height(float value) { }

	// RVA: 0x15A5660 Offset: 0x15A5761 VA: 0x15A5660
	public bool get_isDefaultWidth() { }

	// RVA: 0x15A5670 Offset: 0x15A5771 VA: 0x15A5670
	public bool get_isDefaultHeight() { }

	// RVA: 0x15A5680 Offset: 0x15A5781 VA: 0x15A5680
	public bool get_isAutoFitting() { }

	// RVA: 0x15A5690 Offset: 0x15A5791 VA: 0x15A5690
	public void set_isAutoFitting(bool value) { }

	// RVA: 0x15A56A0 Offset: 0x15A57A1 VA: 0x15A56A0
	public Vector3[] get_corners() { }

	// RVA: 0x15A56B0 Offset: 0x15A57B1 VA: 0x15A56B0
	public Vector3[] get_worldCorners() { }

	// RVA: 0x15A56C0 Offset: 0x15A57C1 VA: 0x15A56C0
	public Vector4 get_margins() { }

	// RVA: 0x15A56D0 Offset: 0x15A57D1 VA: 0x15A56D0
	public void set_margins(Vector4 value) { }

	// RVA: 0x15A57D0 Offset: 0x15A58D1 VA: 0x15A57D0
	public RectTransform get_rectTransform() { }

	// RVA: 0x15A5880 Offset: 0x15A5981 VA: 0x15A5880
	public TextMeshPro get_textMeshPro() { }

	// RVA: 0x15A5930 Offset: 0x15A5A31 VA: 0x15A5930 Slot: 4
	protected override void Awake() { }

	// RVA: 0x15A59E0 Offset: 0x15A5AE1 VA: 0x15A59E0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x15A59F0 Offset: 0x15A5AF1 VA: 0x15A59F0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x15A4E90 Offset: 0x15A4F91 VA: 0x15A4E90
	private void OnContainerChanged() { }

	// RVA: 0x15A5C70 Offset: 0x15A5D71 VA: 0x15A5C70 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x15A5420 Offset: 0x15A5521 VA: 0x15A5420
	private void SetRect(Vector2 size) { }

	// RVA: 0x15A5A00 Offset: 0x15A5B01 VA: 0x15A5A00
	private void UpdateCorners() { }

	// RVA: 0x15A50D0 Offset: 0x15A51D1 VA: 0x15A50D0
	private Vector2 GetPivot(TextContainerAnchors anchor) { }

	// RVA: 0x15A4B00 Offset: 0x15A4C01 VA: 0x15A4B00
	private TextContainerAnchors GetAnchorPosition(Vector2 pivot) { }

	// RVA: 0x15A5E70 Offset: 0x15A5F71 VA: 0x15A5E70
	public void .ctor() { }

	// RVA: 0x15A5F00 Offset: 0x15A6001 VA: 0x15A5F00
	private static void .cctor() { }
}

