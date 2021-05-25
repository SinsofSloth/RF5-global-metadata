[Serializable]
public class MotionAbsorb.Absorber // TypeDefIndex: 9366
{
	// Fields
	[TooltipAttribute] // RVA: 0x1961D0 Offset: 0x1962D1 VA: 0x1961D0
	public FullBodyBipedEffector effector; // 0x10
	[TooltipAttribute] // RVA: 0x196210 Offset: 0x196311 VA: 0x196210
	public float weight; // 0x14
	private Vector3 position; // 0x18
	private Quaternion rotation; // 0x24
	private IKEffector e; // 0x38

	// Methods

	// RVA: 0x2725510 Offset: 0x2725611 VA: 0x2725510
	public void SetToBone(IKSolverFullBodyBiped solver, MotionAbsorb.Mode mode) { }

	// RVA: 0x2725610 Offset: 0x2725711 VA: 0x2725610
	public void UpdateEffectorWeights(float w) { }

	// RVA: 0x2725650 Offset: 0x2725751 VA: 0x2725650
	public void SetPosition(float w) { }

	// RVA: 0x2725780 Offset: 0x2725881 VA: 0x2725780
	public void SetRotation(float w) { }

	// RVA: 0x2725890 Offset: 0x2725991 VA: 0x2725890
	public void .ctor() { }
}

