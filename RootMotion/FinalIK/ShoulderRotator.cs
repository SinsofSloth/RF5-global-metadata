public class ShoulderRotator : MonoBehaviour // TypeDefIndex: 9580
{
	// Fields
	[TooltipAttribute] // RVA: 0x17D0C0 Offset: 0x17D1C1 VA: 0x17D0C0
	public float weight; // 0x18
	[TooltipAttribute] // RVA: 0x17D100 Offset: 0x17D201 VA: 0x17D100
	public float offset; // 0x1C
	private FullBodyBipedIK ik; // 0x20
	private bool skip; // 0x28

	// Methods

	// RVA: 0x2924930 Offset: 0x2924A31 VA: 0x2924930
	private void Start() { }

	// RVA: 0x2924A30 Offset: 0x2924B31 VA: 0x2924A30
	private void RotateShoulders() { }

	// RVA: 0x2924B20 Offset: 0x2924C21 VA: 0x2924B20
	private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset) { }

	// RVA: 0x2924FB0 Offset: 0x29250B1 VA: 0x2924FB0
	private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain) { }

	// RVA: 0x2924FF0 Offset: 0x29250F1 VA: 0x2924FF0
	private void OnDestroy() { }

	// RVA: 0x2925110 Offset: 0x2925211 VA: 0x2925110
	public void .ctor() { }
}

