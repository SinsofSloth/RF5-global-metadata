[ExecuteAlways] // RVA: 0x11A880 Offset: 0x11A981 VA: 0x11A880
public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier // TypeDefIndex: 4030
{
	// Fields
	private Graphic m_Graphic; // 0x18

	// Properties
	protected Graphic graphic { get; }

	// Methods

	// RVA: 0x1645860 Offset: 0x1645961 VA: 0x1645860
	protected Graphic get_graphic() { }

	// RVA: 0x1645910 Offset: 0x1645A11 VA: 0x1645910 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1645AC0 Offset: 0x1645BC1 VA: 0x1645AC0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1645C70 Offset: 0x1645D71 VA: 0x1645C70 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1645E20 Offset: 0x1645F21 VA: 0x1645E20 Slot: 19
	public virtual void ModifyMesh(Mesh mesh) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void ModifyMesh(VertexHelper vh) { }

	// RVA: 0x1645F70 Offset: 0x1646071 VA: 0x1645F70
	protected void .ctor() { }
}

