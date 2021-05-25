public class DynamicBoneH : MonoBehaviour // TypeDefIndex: 6329
{
	// Fields
	[RangeAttribute] // RVA: 0x15C200 Offset: 0x15C301 VA: 0x15C200
	public float m_Damping; // 0x18
	[RangeAttribute] // RVA: 0x15C220 Offset: 0x15C321 VA: 0x15C220
	public float m_Elasticity; // 0x1C
	[RangeAttribute] // RVA: 0x15C240 Offset: 0x15C341 VA: 0x15C240
	public float m_Stiffness; // 0x20
	public AnimationCurve m_StiffnessDistrib; // 0x28
	public Vector3 m_Force; // 0x30
	public Vector3 m_Wind; // 0x3C
	private float m_BoneTotalLength; // 0x48
	public List<DynamicBoneH.Particle> m_Particles; // 0x50
	public int m_ParticlesCount; // 0x58

	// Methods

	// RVA: 0x2014410 Offset: 0x2014511 VA: 0x2014410
	public void Setup() { }

	// RVA: 0x20145D0 Offset: 0x20146D1 VA: 0x20145D0
	private void AppendParticles(Transform a_Transform, int a_ParentIndex, float a_BoneLength) { }

	// RVA: 0x20148A0 Offset: 0x20149A1 VA: 0x20148A0
	public void InitTransforms() { }

	// RVA: 0x2014970 Offset: 0x2014A71 VA: 0x2014970
	public void ResetParticlesPosition() { }

	// RVA: 0x2014A30 Offset: 0x2014B31 VA: 0x2014A30
	public void UpdateParticles() { }

	// RVA: 0x2015170 Offset: 0x2015271 VA: 0x2015170
	public void .ctor() { }
}

