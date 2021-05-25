public class HumanGrappleController : CharaGrappleController<HumanController> // TypeDefIndex: 6648
{
	// Fields
	private const float m_ThrowRecoilPower = 1;
	protected int m_poundCount; // 0x50

	// Methods

	// RVA: 0x1E95670 Offset: 0x1E95771 VA: 0x1E95670 Slot: 5
	public override void Setup() { }

	// RVA: 0x1E95C00 Offset: 0x1E95D01 VA: 0x1E95C00
	private void AddHandTransform(Transform hand) { }

	// RVA: 0x1E95CB0 Offset: 0x1E95DB1 VA: 0x1E95CB0 Slot: 10
	public override void DoRelease() { }

	// RVA: 0x1E95D40 Offset: 0x1E95E41 VA: 0x1E95D40 Slot: 7
	public override void DoCancel() { }

	// RVA: 0x1E95DD0 Offset: 0x1E95ED1 VA: 0x1E95DD0 Slot: 11
	public override bool DoGrap(GrapInterface target) { }

	// RVA: 0x1E95EB0 Offset: 0x1E95FB1 VA: 0x1E95EB0 Slot: 12
	public override void DoThrow(float angle, float power, MagicParamID id1, MagicParamID id2 = 0) { }

	// RVA: 0x1E96120 Offset: 0x1E96221 VA: 0x1E96120
	private float GetMotionPower(int level) { }

	// RVA: 0x1E96200 Offset: 0x1E96301 VA: 0x1E96200 Slot: 15
	public override void DoFlung() { }

	// RVA: 0x1E96360 Offset: 0x1E96461 VA: 0x1E96360 Slot: 13
	public override void DoPound() { }

	// RVA: 0x1E96560 Offset: 0x1E96661 VA: 0x1E96560 Slot: 16
	public override void DoSwing() { }

	// RVA: 0x1E96760 Offset: 0x1E96861 VA: 0x1E96760 Slot: 17
	public override void DoSlam() { }

	// RVA: 0x1E96960 Offset: 0x1E96A61 VA: 0x1E96960 Slot: 21
	protected override DamageInfo CreateDamageInfo(MagicParamID id) { }

	// RVA: 0x1E96B70 Offset: 0x1E96C71 VA: 0x1E96B70 Slot: 20
	protected override void OnTakeDamage(DamageInfo damageInfo, DamageResult damageResult) { }

	// RVA: 0x1E96D00 Offset: 0x1E96E01 VA: 0x1E96D00
	public void .ctor() { }
}

