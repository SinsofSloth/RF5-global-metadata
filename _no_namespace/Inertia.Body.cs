[Serializable]
public class Inertia.Body // TypeDefIndex: 9563
{
	// Fields
	[TooltipAttribute] // RVA: 0x198D10 Offset: 0x198E11 VA: 0x198D10
	public Transform transform; // 0x10
	[TooltipAttribute] // RVA: 0x198D50 Offset: 0x198E51 VA: 0x198D50
	public Inertia.Body.EffectorLink[] effectorLinks; // 0x18
	[TooltipAttribute] // RVA: 0x198D90 Offset: 0x198E91 VA: 0x198D90
	public float speed; // 0x20
	[TooltipAttribute] // RVA: 0x198DD0 Offset: 0x198ED1 VA: 0x198DD0
	public float acceleration; // 0x24
	[TooltipAttribute] // RVA: 0x198E10 Offset: 0x198F11 VA: 0x198E10
	[RangeAttribute] // RVA: 0x198E10 Offset: 0x198F11 VA: 0x198E10
	public float matchVelocity; // 0x28
	[TooltipAttribute] // RVA: 0x198E70 Offset: 0x198F71 VA: 0x198E70
	public float gravity; // 0x2C
	private Vector3 delta; // 0x30
	private Vector3 lazyPoint; // 0x3C
	private Vector3 direction; // 0x48
	private Vector3 lastPosition; // 0x54
	private bool firstUpdate; // 0x60

	// Methods

	// RVA: 0x2BEC350 Offset: 0x2BEC451 VA: 0x2BEC350
	public void Reset() { }

	// RVA: 0x2BEC4F0 Offset: 0x2BEC5F1 VA: 0x2BEC4F0
	public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime) { }

	// RVA: 0x2BEC890 Offset: 0x2BEC991 VA: 0x2BEC890
	public void .ctor() { }
}

