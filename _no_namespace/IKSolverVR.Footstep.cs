[Serializable]
public class IKSolverVR.Footstep // TypeDefIndex: 9499
{
	// Fields
	public float stepSpeed; // 0x10
	public Vector3 characterSpaceOffset; // 0x14
	public Vector3 position; // 0x20
	public Quaternion rotation; // 0x2C
	public Quaternion stepToRootRot; // 0x3C
	public bool isSupportLeg; // 0x4C
	[CompilerGeneratedAttribute] // RVA: 0x196C80 Offset: 0x196D81 VA: 0x196C80
	private float <stepProgress>k__BackingField; // 0x50
	public Vector3 stepFrom; // 0x54
	public Vector3 stepTo; // 0x60
	public Quaternion stepFromRot; // 0x6C
	public Quaternion stepToRot; // 0x7C
	private Quaternion footRelativeToRoot; // 0x8C
	private float supportLegW; // 0x9C
	private float supportLegWV; // 0xA0

	// Properties
	public bool isStepping { get; }
	public float stepProgress { get; set; }

	// Methods

	// RVA: 0x2BE4B90 Offset: 0x2BE4C91 VA: 0x2BE4B90
	public bool get_isStepping() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B55A0 Offset: 0x1B56A1 VA: 0x1B55A0
	// RVA: 0x2BE4BB0 Offset: 0x2BE4CB1 VA: 0x2BE4BB0
	public float get_stepProgress() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B55B0 Offset: 0x1B56B1 VA: 0x1B55B0
	// RVA: 0x2BE4BC0 Offset: 0x2BE4CC1 VA: 0x2BE4BC0
	private void set_stepProgress(float value) { }

	// RVA: 0x2BE4BD0 Offset: 0x2BE4CD1 VA: 0x2BE4BD0
	public void .ctor(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset) { }

	// RVA: 0x2BE4DE0 Offset: 0x2BE4EE1 VA: 0x2BE4DE0
	public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation) { }

	// RVA: 0x2BE4E60 Offset: 0x2BE4F61 VA: 0x2BE4E60
	public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold) { }

	// RVA: 0x2BE5030 Offset: 0x2BE5131 VA: 0x2BE5030
	public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed) { }

	// RVA: 0x2BE5210 Offset: 0x2BE5311 VA: 0x2BE5210
	public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed) { }

	// RVA: 0x2BE5400 Offset: 0x2BE5501 VA: 0x2BE5400
	public void Update(InterpolationMode interpolation, UnityEvent onStep) { }
}

