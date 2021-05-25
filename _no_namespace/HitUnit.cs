[Serializable]
public class HitUnit // TypeDefIndex: 7623
{
	// Fields
	[SerializeField] // RVA: 0x168690 Offset: 0x168791 VA: 0x168690
	public HitSystem HitSystem; // 0x10
	[SerializeField] // RVA: 0x1686A0 Offset: 0x1687A1 VA: 0x1686A0
	public HitData HitData; // 0x18
	[SerializeField] // RVA: 0x1686B0 Offset: 0x1687B1 VA: 0x1686B0
	public float StartSec; // 0x20
	[SerializeField] // RVA: 0x1686C0 Offset: 0x1687C1 VA: 0x1686C0
	public float EndSec; // 0x24
	[SerializeField] // RVA: 0x1686D0 Offset: 0x1687D1 VA: 0x1686D0
	[RangeAttribute] // RVA: 0x1686D0 Offset: 0x1687D1 VA: 0x1686D0
	public int HitGroup; // 0x28
	[SerializeField] // RVA: 0x168710 Offset: 0x168811 VA: 0x168710
	public float EnableSec; // 0x2C
	[SerializeField] // RVA: 0x168720 Offset: 0x168821 VA: 0x168720
	public HitOptionParamID HitOptionParamID; // 0x30
	[SerializeField] // RVA: 0x168730 Offset: 0x168831 VA: 0x168730
	public HitOption hitOption; // 0x38
	[SerializeField] // RVA: 0x168740 Offset: 0x168841 VA: 0x168740
	public HitEffectBase[] HitEffects; // 0x40
	public HitUnit.STATE State; // 0x48
	public float Scale; // 0x4C

	// Methods

	// RVA: 0x1E7FB10 Offset: 0x1E7FC11 VA: 0x1E7FB10
	public void .ctor(HitSystem hitSystem) { }

	// RVA: 0x1E7FD80 Offset: 0x1E7FE81 VA: 0x1E7FD80
	public void CheckTime() { }

	// RVA: 0x1E7FD90 Offset: 0x1E7FE91 VA: 0x1E7FD90
	public void Copy(HitUnit unit) { }

	// RVA: 0x1E7FF50 Offset: 0x1E80051 VA: 0x1E7FF50
	public void OnHitTriggerEnter(Collider collider) { }

	[ContextMenu] // RVA: 0x1A2240 Offset: 0x1A2341 VA: 0x1A2240
	// RVA: 0x1E7FBE0 Offset: 0x1E7FCE1 VA: 0x1E7FBE0
	public void ResetHitUnit() { }
}

