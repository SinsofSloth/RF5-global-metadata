[DocumentationSortingAttribute] // RVA: 0x12F050 Offset: 0x12F151 VA: 0x12F050
[SaveDuringPlayAttribute] // RVA: 0x12F050 Offset: 0x12F151 VA: 0x12F050
[HelpURLAttribute] // RVA: 0x12F050 Offset: 0x12F151 VA: 0x12F050
public class CinemachineCollisionImpulseSource : CinemachineImpulseSource // TypeDefIndex: 4877
{
	// Fields
	[HeaderAttribute] // RVA: 0x135100 Offset: 0x135201 VA: 0x135100
	[TooltipAttribute] // RVA: 0x135100 Offset: 0x135201 VA: 0x135100
	public LayerMask m_LayerMask; // 0x20
	[TagFieldAttribute] // RVA: 0x135160 Offset: 0x135261 VA: 0x135160
	[TooltipAttribute] // RVA: 0x135160 Offset: 0x135261 VA: 0x135160
	public string m_IgnoreTag; // 0x28
	[HeaderAttribute] // RVA: 0x1351B0 Offset: 0x1352B1 VA: 0x1351B0
	[TooltipAttribute] // RVA: 0x1351B0 Offset: 0x1352B1 VA: 0x1351B0
	public bool m_UseImpactDirection; // 0x30
	[TooltipAttribute] // RVA: 0x135210 Offset: 0x135311 VA: 0x135210
	public bool m_ScaleImpactWithMass; // 0x31
	[TooltipAttribute] // RVA: 0x135250 Offset: 0x135351 VA: 0x135250
	public bool m_ScaleImpactWithSpeed; // 0x32
	private Rigidbody mRigidBody; // 0x38
	private Rigidbody2D mRigidBody2D; // 0x40

	// Methods

	// RVA: 0x1896140 Offset: 0x1896241 VA: 0x1896140
	private void Start() { }

	// RVA: 0x18961D0 Offset: 0x18962D1 VA: 0x18961D0
	private void OnEnable() { }

	// RVA: 0x18961E0 Offset: 0x18962E1 VA: 0x18961E0
	private void OnCollisionEnter(Collision c) { }

	// RVA: 0x1896460 Offset: 0x1896561 VA: 0x1896460
	private void OnTriggerEnter(Collider c) { }

	// RVA: 0x18964E0 Offset: 0x18965E1 VA: 0x18964E0
	private float GetMassAndVelocity(Collider other, ref Vector3 vel) { }

	// RVA: 0x1896240 Offset: 0x1896341 VA: 0x1896240
	private void GenerateImpactEvent(Collider other, Vector3 vel) { }

	// RVA: 0x18967A0 Offset: 0x18968A1 VA: 0x18967A0
	private void OnCollisionEnter2D(Collision2D c) { }

	// RVA: 0x1896A80 Offset: 0x1896B81 VA: 0x1896A80
	private void OnTriggerEnter2D(Collider2D c) { }

	// RVA: 0x1896B00 Offset: 0x1896C01 VA: 0x1896B00
	private float GetMassAndVelocity2D(Collider2D other2d, ref Vector3 vel) { }

	// RVA: 0x1896860 Offset: 0x1896961 VA: 0x1896860
	private void GenerateImpactEvent2D(Collider2D other2d, Vector3 vel) { }

	// RVA: 0x1896E00 Offset: 0x1896F01 VA: 0x1896E00
	public void .ctor() { }
}

