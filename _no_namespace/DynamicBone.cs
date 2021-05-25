[AddComponentMenu] // RVA: 0x1477C0 Offset: 0x1478C1 VA: 0x1477C0
public class DynamicBone : MonoBehaviour // TypeDefIndex: 8969
{
	// Fields
	public Transform m_Root; // 0x18
	public float m_UpdateRate; // 0x20
	public DynamicBone.UpdateMode m_UpdateMode; // 0x24
	[RangeAttribute] // RVA: 0x175030 Offset: 0x175131 VA: 0x175030
	public float m_Damping; // 0x28
	public AnimationCurve m_DampingDistrib; // 0x30
	[RangeAttribute] // RVA: 0x175050 Offset: 0x175151 VA: 0x175050
	public float m_Elasticity; // 0x38
	public AnimationCurve m_ElasticityDistrib; // 0x40
	[RangeAttribute] // RVA: 0x175070 Offset: 0x175171 VA: 0x175070
	public float m_Stiffness; // 0x48
	public AnimationCurve m_StiffnessDistrib; // 0x50
	[RangeAttribute] // RVA: 0x175090 Offset: 0x175191 VA: 0x175090
	public float m_Inert; // 0x58
	public AnimationCurve m_InertDistrib; // 0x60
	public float m_Radius; // 0x68
	public AnimationCurve m_RadiusDistrib; // 0x70
	public float m_EndLength; // 0x78
	public Vector3 m_EndOffset; // 0x7C
	public Vector3 m_Gravity; // 0x88
	public Vector3 m_Force; // 0x94
	public List<DynamicBoneColliderBase> m_Colliders; // 0xA0
	public List<Transform> m_Exclusions; // 0xA8
	public DynamicBone.FreezeAxis m_FreezeAxis; // 0xB0
	public bool m_DistantDisable; // 0xB4
	public Transform m_ReferenceObject; // 0xB8
	public float m_DistanceToObject; // 0xC0
	private Vector3 m_LocalGravity; // 0xC4
	private Vector3 m_ObjectMove; // 0xD0
	private Vector3 m_ObjectPrevPosition; // 0xDC
	private float m_BoneTotalLength; // 0xE8
	private float m_ObjectScale; // 0xEC
	private float m_Time; // 0xF0
	private float m_Weight; // 0xF4
	private bool m_DistantDisabled; // 0xF8
	private List<DynamicBone.Particle> m_Particles; // 0x100

	// Methods

	// RVA: 0x20100C0 Offset: 0x20101C1 VA: 0x20100C0
	private void Start() { }

	// RVA: 0x2010250 Offset: 0x2010351 VA: 0x2010250
	private void FixedUpdate() { }

	// RVA: 0x20102B0 Offset: 0x20103B1 VA: 0x20102B0
	private void Update() { }

	// RVA: 0x20102E0 Offset: 0x20103E1 VA: 0x20102E0
	private void LateUpdate() { }

	// RVA: 0x2010280 Offset: 0x2010381 VA: 0x2010280
	private void PreUpdate() { }

	// RVA: 0x2010370 Offset: 0x2010471 VA: 0x2010370
	private void CheckDistance() { }

	// RVA: 0x2010A20 Offset: 0x2010B21 VA: 0x2010A20
	private void OnEnable() { }

	// RVA: 0x2010A30 Offset: 0x2010B31 VA: 0x2010A30
	private void OnDisable() { }

	// RVA: 0x2010A40 Offset: 0x2010B41 VA: 0x2010A40
	private void OnValidate() { }

	// RVA: 0x2010B50 Offset: 0x2010C51 VA: 0x2010B50
	private void OnDrawGizmosSelected() { }

	// RVA: 0x2010D00 Offset: 0x2010E01 VA: 0x2010D00
	public void SetWeight(float w) { }

	// RVA: 0x2010D60 Offset: 0x2010E61 VA: 0x2010D60
	public float GetWeight() { }

	// RVA: 0x2010570 Offset: 0x2010671 VA: 0x2010570
	private void UpdateDynamicBones(float t) { }

	// RVA: 0x20100D0 Offset: 0x20101D1 VA: 0x20100D0
	private void SetupParticles() { }

	// RVA: 0x2012110 Offset: 0x2012211 VA: 0x2012110
	private void AppendParticles(Transform b, int parentIndex, float boneLength) { }

	// RVA: 0x2012790 Offset: 0x2012891 VA: 0x2012790
	public void UpdateParameters() { }

	// RVA: 0x20107C0 Offset: 0x20108C1 VA: 0x20107C0
	private void InitTransforms() { }

	// RVA: 0x20108C0 Offset: 0x20109C1 VA: 0x20108C0
	private void ResetParticlesPosition() { }

	// RVA: 0x2010D70 Offset: 0x2010E71 VA: 0x2010D70
	private void UpdateParticles1() { }

	// RVA: 0x2011080 Offset: 0x2011181 VA: 0x2011080
	private void UpdateParticles2() { }

	// RVA: 0x2011820 Offset: 0x2011921 VA: 0x2011820
	private void SkipUpdateParticles() { }

	// RVA: 0x2012B70 Offset: 0x2012C71 VA: 0x2012B70
	private static Vector3 MirrorVector(Vector3 v, Vector3 axis) { }

	// RVA: 0x2011E30 Offset: 0x2011F31 VA: 0x2011E30
	private void ApplyParticlesToTransforms() { }

	// RVA: 0x2012C50 Offset: 0x2012D51 VA: 0x2012C50
	public void .ctor() { }
}

