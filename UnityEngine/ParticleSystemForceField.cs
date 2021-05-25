[NativeHeaderAttribute] // RVA: 0x111F00 Offset: 0x112001 VA: 0x111F00
[NativeHeaderAttribute] // RVA: 0x111F00 Offset: 0x112001 VA: 0x111F00
[NativeHeaderAttribute] // RVA: 0x111F00 Offset: 0x112001 VA: 0x111F00
[NativeHeaderAttribute] // RVA: 0x111F00 Offset: 0x112001 VA: 0x111F00
[NativeHeaderAttribute] // RVA: 0x111F00 Offset: 0x112001 VA: 0x111F00
[RequireComponent] // RVA: 0x111F00 Offset: 0x112001 VA: 0x111F00
public class ParticleSystemForceField : Component // TypeDefIndex: 3868
{
	// Properties
	[NativeNameAttribute] // RVA: 0x113C70 Offset: 0x113D71 VA: 0x113C70
	public ParticleSystemForceFieldShape shape { get; set; }
	public float startRange { get; set; }
	public float endRange { get; set; }
	public float length { get; set; }
	public float gravityFocus { get; set; }
	public Vector2 rotationRandomness { get; set; }
	public bool multiplyDragByParticleSize { get; set; }
	public bool multiplyDragByParticleVelocity { get; set; }
	public Texture3D vectorField { get; set; }
	public ParticleSystem.MinMaxCurve directionX { get; set; }
	public ParticleSystem.MinMaxCurve directionY { get; set; }
	public ParticleSystem.MinMaxCurve directionZ { get; set; }
	public ParticleSystem.MinMaxCurve gravity { get; set; }
	public ParticleSystem.MinMaxCurve rotationSpeed { get; set; }
	public ParticleSystem.MinMaxCurve rotationAttraction { get; set; }
	public ParticleSystem.MinMaxCurve drag { get; set; }
	public ParticleSystem.MinMaxCurve vectorFieldSpeed { get; set; }
	public ParticleSystem.MinMaxCurve vectorFieldAttraction { get; set; }

	// Methods

	// RVA: 0x1B638B0 Offset: 0x1B639B1 VA: 0x1B638B0
	public ParticleSystemForceFieldShape get_shape() { }

	// RVA: 0x1B63900 Offset: 0x1B63A01 VA: 0x1B63900
	public void set_shape(ParticleSystemForceFieldShape value) { }

	// RVA: 0x1B63950 Offset: 0x1B63A51 VA: 0x1B63950
	public float get_startRange() { }

	// RVA: 0x1B639A0 Offset: 0x1B63AA1 VA: 0x1B639A0
	public void set_startRange(float value) { }

	// RVA: 0x1B639F0 Offset: 0x1B63AF1 VA: 0x1B639F0
	public float get_endRange() { }

	// RVA: 0x1B63A40 Offset: 0x1B63B41 VA: 0x1B63A40
	public void set_endRange(float value) { }

	// RVA: 0x1B63A90 Offset: 0x1B63B91 VA: 0x1B63A90
	public float get_length() { }

	// RVA: 0x1B63AE0 Offset: 0x1B63BE1 VA: 0x1B63AE0
	public void set_length(float value) { }

	// RVA: 0x1B63B30 Offset: 0x1B63C31 VA: 0x1B63B30
	public float get_gravityFocus() { }

	// RVA: 0x1B63B80 Offset: 0x1B63C81 VA: 0x1B63B80
	public void set_gravityFocus(float value) { }

	// RVA: 0x1B63BD0 Offset: 0x1B63CD1 VA: 0x1B63BD0
	public Vector2 get_rotationRandomness() { }

	// RVA: 0x1B63C80 Offset: 0x1B63D81 VA: 0x1B63C80
	public void set_rotationRandomness(Vector2 value) { }

	// RVA: 0x1B63D30 Offset: 0x1B63E31 VA: 0x1B63D30
	public bool get_multiplyDragByParticleSize() { }

	// RVA: 0x1B63D80 Offset: 0x1B63E81 VA: 0x1B63D80
	public void set_multiplyDragByParticleSize(bool value) { }

	// RVA: 0x1B63DD0 Offset: 0x1B63ED1 VA: 0x1B63DD0
	public bool get_multiplyDragByParticleVelocity() { }

	// RVA: 0x1B63E20 Offset: 0x1B63F21 VA: 0x1B63E20
	public void set_multiplyDragByParticleVelocity(bool value) { }

	// RVA: 0x1B63E70 Offset: 0x1B63F71 VA: 0x1B63E70
	public Texture3D get_vectorField() { }

	// RVA: 0x1B63EC0 Offset: 0x1B63FC1 VA: 0x1B63EC0
	public void set_vectorField(Texture3D value) { }

	// RVA: 0x1B63F10 Offset: 0x1B64011 VA: 0x1B63F10
	public ParticleSystem.MinMaxCurve get_directionX() { }

	// RVA: 0x1B63FE0 Offset: 0x1B640E1 VA: 0x1B63FE0
	public void set_directionX(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1B64080 Offset: 0x1B64181 VA: 0x1B64080
	public ParticleSystem.MinMaxCurve get_directionY() { }

	// RVA: 0x1B64150 Offset: 0x1B64251 VA: 0x1B64150
	public void set_directionY(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1B641F0 Offset: 0x1B642F1 VA: 0x1B641F0
	public ParticleSystem.MinMaxCurve get_directionZ() { }

	// RVA: 0x1B642C0 Offset: 0x1B643C1 VA: 0x1B642C0
	public void set_directionZ(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1B64360 Offset: 0x1B64461 VA: 0x1B64360
	public ParticleSystem.MinMaxCurve get_gravity() { }

	// RVA: 0x1B64430 Offset: 0x1B64531 VA: 0x1B64430
	public void set_gravity(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1B644D0 Offset: 0x1B645D1 VA: 0x1B644D0
	public ParticleSystem.MinMaxCurve get_rotationSpeed() { }

	// RVA: 0x1B645A0 Offset: 0x1B646A1 VA: 0x1B645A0
	public void set_rotationSpeed(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1B64640 Offset: 0x1B64741 VA: 0x1B64640
	public ParticleSystem.MinMaxCurve get_rotationAttraction() { }

	// RVA: 0x1B64710 Offset: 0x1B64811 VA: 0x1B64710
	public void set_rotationAttraction(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1B647B0 Offset: 0x1B648B1 VA: 0x1B647B0
	public ParticleSystem.MinMaxCurve get_drag() { }

	// RVA: 0x1B64880 Offset: 0x1B64981 VA: 0x1B64880
	public void set_drag(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1B64920 Offset: 0x1B64A21 VA: 0x1B64920
	public ParticleSystem.MinMaxCurve get_vectorFieldSpeed() { }

	// RVA: 0x1B649F0 Offset: 0x1B64AF1 VA: 0x1B649F0
	public void set_vectorFieldSpeed(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1B64A90 Offset: 0x1B64B91 VA: 0x1B64A90
	public ParticleSystem.MinMaxCurve get_vectorFieldAttraction() { }

	// RVA: 0x1B64B60 Offset: 0x1B64C61 VA: 0x1B64B60
	public void set_vectorFieldAttraction(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1B64C00 Offset: 0x1B64D01 VA: 0x1B64C00
	public void .ctor() { }

	// RVA: 0x1B63C30 Offset: 0x1B63D31 VA: 0x1B63C30
	private void get_rotationRandomness_Injected(out Vector2 ret) { }

	// RVA: 0x1B63CE0 Offset: 0x1B63DE1 VA: 0x1B63CE0
	private void set_rotationRandomness_Injected(ref Vector2 value) { }

	// RVA: 0x1B63F90 Offset: 0x1B64091 VA: 0x1B63F90
	private void get_directionX_Injected(out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x1B64030 Offset: 0x1B64131 VA: 0x1B64030
	private void set_directionX_Injected(ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1B64100 Offset: 0x1B64201 VA: 0x1B64100
	private void get_directionY_Injected(out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x1B641A0 Offset: 0x1B642A1 VA: 0x1B641A0
	private void set_directionY_Injected(ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1B64270 Offset: 0x1B64371 VA: 0x1B64270
	private void get_directionZ_Injected(out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x1B64310 Offset: 0x1B64411 VA: 0x1B64310
	private void set_directionZ_Injected(ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1B643E0 Offset: 0x1B644E1 VA: 0x1B643E0
	private void get_gravity_Injected(out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x1B64480 Offset: 0x1B64581 VA: 0x1B64480
	private void set_gravity_Injected(ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1B64550 Offset: 0x1B64651 VA: 0x1B64550
	private void get_rotationSpeed_Injected(out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x1B645F0 Offset: 0x1B646F1 VA: 0x1B645F0
	private void set_rotationSpeed_Injected(ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1B646C0 Offset: 0x1B647C1 VA: 0x1B646C0
	private void get_rotationAttraction_Injected(out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x1B64760 Offset: 0x1B64861 VA: 0x1B64760
	private void set_rotationAttraction_Injected(ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1B64830 Offset: 0x1B64931 VA: 0x1B64830
	private void get_drag_Injected(out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x1B648D0 Offset: 0x1B649D1 VA: 0x1B648D0
	private void set_drag_Injected(ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1B649A0 Offset: 0x1B64AA1 VA: 0x1B649A0
	private void get_vectorFieldSpeed_Injected(out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x1B64A40 Offset: 0x1B64B41 VA: 0x1B64A40
	private void set_vectorFieldSpeed_Injected(ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1B64B10 Offset: 0x1B64C11 VA: 0x1B64B10
	private void get_vectorFieldAttraction_Injected(out ParticleSystem.MinMaxCurve ret) { }

	// RVA: 0x1B64BB0 Offset: 0x1B64CB1 VA: 0x1B64BB0
	private void set_vectorFieldAttraction_Injected(ref ParticleSystem.MinMaxCurve value) { }
}

