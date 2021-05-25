[Serializable]
public class Amplifier.Body // TypeDefIndex: 9546
{
	// Fields
	[TooltipAttribute] // RVA: 0x1986F0 Offset: 0x1987F1 VA: 0x1986F0
	public Transform transform; // 0x10
	[TooltipAttribute] // RVA: 0x198730 Offset: 0x198831 VA: 0x198730
	public Transform relativeTo; // 0x18
	[TooltipAttribute] // RVA: 0x198770 Offset: 0x198871 VA: 0x198770
	public Amplifier.Body.EffectorLink[] effectorLinks; // 0x20
	[TooltipAttribute] // RVA: 0x1987B0 Offset: 0x1988B1 VA: 0x1987B0
	public float verticalWeight; // 0x28
	[TooltipAttribute] // RVA: 0x1987F0 Offset: 0x1988F1 VA: 0x1987F0
	public float horizontalWeight; // 0x2C
	[TooltipAttribute] // RVA: 0x198830 Offset: 0x198931 VA: 0x198830
	public float speed; // 0x30
	private Vector3 lastRelativePos; // 0x34
	private Vector3 smoothDelta; // 0x40
	private bool firstUpdate; // 0x4C

	// Methods

	// RVA: 0x27343A0 Offset: 0x27344A1 VA: 0x27343A0
	public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime) { }

	// RVA: 0x2734830 Offset: 0x2734931 VA: 0x2734830
	private static Vector3 Multiply(Vector3 v1, Vector3 v2) { }

	// RVA: 0x2734840 Offset: 0x2734941 VA: 0x2734840
	public void .ctor() { }
}

