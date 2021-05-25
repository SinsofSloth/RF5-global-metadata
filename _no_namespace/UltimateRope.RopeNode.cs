[Serializable]
public class UltimateRope.RopeNode // TypeDefIndex: 9067
{
	// Fields
	public GameObject goNode; // 0x10
	public float fLength; // 0x18
	public float fTotalLength; // 0x1C
	public int nNumLinks; // 0x20
	public int nTotalLinks; // 0x24
	public UltimateRope.EColliderType eColliderType; // 0x28
	public int nColliderSkip; // 0x2C
	public bool bFold; // 0x30
	public bool bIsCoil; // 0x31
	public bool bInitialOrientationInitialized; // 0x32
	public Vector3 v3InitialLocalPos; // 0x34
	public Quaternion qInitialLocalRot; // 0x40
	public Vector3 v3InitialLocalScale; // 0x50
	public bool m_bExtensionInitialized; // 0x5C
	public int m_nExtensionLinkIn; // 0x60
	public int m_nExtensionLinkOut; // 0x64
	public float m_fExtensionRemainingLength; // 0x68
	public float m_fExtensionRemainderIn; // 0x6C
	public float m_fExtensionRemainderOut; // 0x70
	public Vector3 m_v3LocalDirectionForward; // 0x74
	public Vector3 m_v3LocalDirectionUp; // 0x80
	public GameObject[] segmentLinks; // 0x90
	public ConfigurableJoint[] linkJoints; // 0x98
	public bool[] linkJointBreaksProcessed; // 0xA0
	public bool bSegmentBroken; // 0xA8

	// Methods

	// RVA: 0x1CFAFF0 Offset: 0x1CFB0F1 VA: 0x1CFAFF0
	public void .ctor() { }
}

