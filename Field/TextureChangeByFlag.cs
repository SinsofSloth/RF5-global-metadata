public class TextureChangeByFlag : ObjectLoader // TypeDefIndex: 10467
{
	// Fields
	protected int MainTexPropertyId; // 0x2C
	protected bool _IsInit; // 0x30

	// Properties
	public bool IsInit { get; }

	// Methods

	// RVA: 0x1EEF9A0 Offset: 0x1EEFAA1 VA: 0x1EEF9A0
	public bool get_IsInit() { }

	// RVA: 0x1EEF9B0 Offset: 0x1EEFAB1 VA: 0x1EEF9B0
	public bool NeedsLoad() { }

	// RVA: 0x1EEF9C0 Offset: 0x1EEFAC1 VA: 0x1EEF9C0 Slot: 5
	protected virtual void OnDestroy() { }

	// RVA: 0x1EEFB20 Offset: 0x1EEFC21 VA: 0x1EEFB20 Slot: 6
	protected virtual void Awake() { }

	// RVA: 0x1EEFC90 Offset: 0x1EEFD91 VA: 0x1EEFC90 Slot: 7
	public virtual void UpdateObjectVisible() { }

	// RVA: 0x1EEFCA0 Offset: 0x1EEFDA1 VA: 0x1EEFCA0
	protected void SetTargetActive(bool setValue) { }

	// RVA: 0x1EEFCB0 Offset: 0x1EEFDB1 VA: 0x1EEFCB0 Slot: 8
	protected virtual void SetTexture(Renderer[] renderers, Material material, Texture texture, int propertyId) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF630 Offset: 0x1AF731 VA: 0x1AF630
	// RVA: 0x1EEFEC0 Offset: 0x1EEFFC1 VA: 0x1EEFEC0 Slot: 4
	public override IEnumerator Load() { }

	// RVA: 0x1EEFF50 Offset: 0x1EF0051 VA: 0x1EEFF50
	public void .ctor() { }
}

