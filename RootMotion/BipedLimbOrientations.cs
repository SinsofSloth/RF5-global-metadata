[Serializable]
public class BipedLimbOrientations // TypeDefIndex: 9308
{
	// Fields
	public BipedLimbOrientations.LimbOrientation leftArm; // 0x10
	public BipedLimbOrientations.LimbOrientation rightArm; // 0x18
	public BipedLimbOrientations.LimbOrientation leftLeg; // 0x20
	public BipedLimbOrientations.LimbOrientation rightLeg; // 0x28

	// Properties
	public static BipedLimbOrientations UMA { get; }
	public static BipedLimbOrientations MaxBiped { get; }

	// Methods

	// RVA: 0x26B5570 Offset: 0x26B5671 VA: 0x26B5570
	public void .ctor(BipedLimbOrientations.LimbOrientation leftArm, BipedLimbOrientations.LimbOrientation rightArm, BipedLimbOrientations.LimbOrientation leftLeg, BipedLimbOrientations.LimbOrientation rightLeg) { }

	// RVA: 0x26B55F0 Offset: 0x26B56F1 VA: 0x26B55F0
	public static BipedLimbOrientations get_UMA() { }

	// RVA: 0x26B5920 Offset: 0x26B5A21 VA: 0x26B5920
	public static BipedLimbOrientations get_MaxBiped() { }
}

