[Serializable]
public class OffsetPose.EffectorLink // TypeDefIndex: 9572
{
	// Fields
	public FullBodyBipedEffector effector; // 0x10
	public Vector3 offset; // 0x14
	public Vector3 pin; // 0x20
	public Vector3 pinWeight; // 0x2C

	// Methods

	// RVA: 0x291C110 Offset: 0x291C211 VA: 0x291C110
	public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation) { }

	// RVA: 0x291C580 Offset: 0x291C681 VA: 0x291C580
	public void .ctor() { }
}

