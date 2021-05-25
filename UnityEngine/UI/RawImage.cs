[AddComponentMenu] // RVA: 0x11A3C0 Offset: 0x11A4C1 VA: 0x11A3C0
public class RawImage : MaskableGraphic // TypeDefIndex: 3991
{
	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x11C2B0 Offset: 0x11C3B1 VA: 0x11C2B0
	[SerializeField] // RVA: 0x11C2B0 Offset: 0x11C3B1 VA: 0x11C2B0
	private Texture m_Texture; // 0xC0
	[SerializeField] // RVA: 0x11C300 Offset: 0x11C401 VA: 0x11C300
	private Rect m_UVRect; // 0xC8

	// Properties
	public override Texture mainTexture { get; }
	public Texture texture { get; set; }
	public Rect uvRect { get; set; }

	// Methods

	// RVA: 0x18C34D0 Offset: 0x18C35D1 VA: 0x18C34D0
	protected void .ctor() { }

	// RVA: 0x18C3530 Offset: 0x18C3631 VA: 0x18C3530 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x18C36C0 Offset: 0x18C37C1 VA: 0x18C36C0
	public Texture get_texture() { }

	// RVA: 0x18C36D0 Offset: 0x18C37D1 VA: 0x18C36D0
	public void set_texture(Texture value) { }

	// RVA: 0x18C37A0 Offset: 0x18C38A1 VA: 0x18C37A0
	public Rect get_uvRect() { }

	// RVA: 0x18C37B0 Offset: 0x18C38B1 VA: 0x18C37B0
	public void set_uvRect(Rect value) { }

	// RVA: 0x18C3840 Offset: 0x18C3941 VA: 0x18C3840 Slot: 45
	public override void SetNativeSize() { }

	// RVA: 0x18C3A10 Offset: 0x18C3B11 VA: 0x18C3A10 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x18C3E50 Offset: 0x18C3F51 VA: 0x18C3E50 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }
}

