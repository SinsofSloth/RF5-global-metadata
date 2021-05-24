[RequireComponent] // RVA: 0x1489D0 Offset: 0x148AD1 VA: 0x1489D0
[AddComponentMenu] // RVA: 0x1489D0 Offset: 0x148AD1 VA: 0x1489D0
public class AimIKJ : MonoBehaviour // TypeDefIndex: 9450
{
	// Fields
	[TooltipAttribute] // RVA: 0x179FB0 Offset: 0x17A0B1 VA: 0x179FB0
	public Transform target; // 0x18
	[TooltipAttribute] // RVA: 0x179FF0 Offset: 0x17A0F1 VA: 0x179FF0
	public Transform poleTarget; // 0x20
	[TooltipAttribute] // RVA: 0x17A030 Offset: 0x17A131 VA: 0x17A030
	public Transform aimTransform; // 0x28
	[SpaceAttribute] // RVA: 0x17A070 Offset: 0x17A171 VA: 0x17A070
	[TooltipAttribute] // RVA: 0x17A070 Offset: 0x17A171 VA: 0x17A070
	public float axisX; // 0x30
	[TooltipAttribute] // RVA: 0x17A0C0 Offset: 0x17A1C1 VA: 0x17A0C0
	public float axisY; // 0x34
	[TooltipAttribute] // RVA: 0x17A100 Offset: 0x17A201 VA: 0x17A100
	public float axisZ; // 0x38
	[SpaceAttribute] // RVA: 0x17A140 Offset: 0x17A241 VA: 0x17A140
	[TooltipAttribute] // RVA: 0x17A140 Offset: 0x17A241 VA: 0x17A140
	public float poleAxisX; // 0x3C
	[TooltipAttribute] // RVA: 0x17A190 Offset: 0x17A291 VA: 0x17A190
	public float poleAxisY; // 0x40
	[TooltipAttribute] // RVA: 0x17A1D0 Offset: 0x17A2D1 VA: 0x17A1D0
	public float poleAxisZ; // 0x44
	[SpaceAttribute] // RVA: 0x17A210 Offset: 0x17A311 VA: 0x17A210
	[TooltipAttribute] // RVA: 0x17A210 Offset: 0x17A311 VA: 0x17A210
	[RangeAttribute] // RVA: 0x17A210 Offset: 0x17A311 VA: 0x17A210
	public float weight; // 0x48
	[TooltipAttribute] // RVA: 0x17A280 Offset: 0x17A381 VA: 0x17A280
	[RangeAttribute] // RVA: 0x17A280 Offset: 0x17A381 VA: 0x17A280
	public float poleWeight; // 0x4C
	[TooltipAttribute] // RVA: 0x17A2E0 Offset: 0x17A3E1 VA: 0x17A2E0
	public float tolerance; // 0x50
	[TooltipAttribute] // RVA: 0x17A320 Offset: 0x17A421 VA: 0x17A320
	public int maxIterations; // 0x54
	[TooltipAttribute] // RVA: 0x17A360 Offset: 0x17A461 VA: 0x17A360
	[RangeAttribute] // RVA: 0x17A360 Offset: 0x17A461 VA: 0x17A360
	public float clampWeight; // 0x58
	[TooltipAttribute] // RVA: 0x17A3C0 Offset: 0x17A4C1 VA: 0x17A3C0
	[RangeAttribute] // RVA: 0x17A3C0 Offset: 0x17A4C1 VA: 0x17A3C0
	public int clampSmoothing; // 0x5C
	[TooltipAttribute] // RVA: 0x17A420 Offset: 0x17A521 VA: 0x17A420
	public bool useRotationLimits; // 0x60
	[TooltipAttribute] // RVA: 0x17A460 Offset: 0x17A561 VA: 0x17A460
	public bool XY; // 0x61
	[SpaceAttribute] // RVA: 0x17A4A0 Offset: 0x17A5A1 VA: 0x17A4A0
	[TooltipAttribute] // RVA: 0x17A4A0 Offset: 0x17A5A1 VA: 0x17A4A0
	public Transform[] bones; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x17A4F0 Offset: 0x17A5F1 VA: 0x17A4F0
	private bool <initiated>k__BackingField; // 0x70
	private Animator animator; // 0x78
	private PlayableGraph graph; // 0x80
	private AnimationScriptPlayable IKPlayable; // 0x90
	private AimIKJob job; // 0xA0

	// Properties
	public bool initiated { get; set; }
	public Vector3 axis { get; set; }
	public Vector3 poleAxis { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AB3F0 Offset: 0x1AB4F1 VA: 0x1AB3F0
	// RVA: 0x272FEC0 Offset: 0x272FFC1 VA: 0x272FEC0
	public bool get_initiated() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB400 Offset: 0x1AB501 VA: 0x1AB400
	// RVA: 0x272FED0 Offset: 0x272FFD1 VA: 0x272FED0
	private void set_initiated(bool value) { }

	// RVA: 0x272FEE0 Offset: 0x272FFE1 VA: 0x272FEE0
	public Vector3 get_axis() { }

	// RVA: 0x272FF20 Offset: 0x2730021 VA: 0x272FF20
	public void set_axis(Vector3 value) { }

	// RVA: 0x272FF30 Offset: 0x2730031 VA: 0x272FF30
	public Vector3 get_poleAxis() { }

	// RVA: 0x272FF70 Offset: 0x2730071 VA: 0x272FF70
	public void set_poleAxis(Vector3 value) { }

	// RVA: 0x272FF80 Offset: 0x2730081 VA: 0x272FF80
	private void OnEnable() { }

	// RVA: 0x2730D80 Offset: 0x2730E81 VA: 0x2730D80
	private void Update() { }

	// RVA: 0x2731140 Offset: 0x2731241 VA: 0x2731140
	private void OnDisable() { }

	// RVA: 0x2731250 Offset: 0x2731351 VA: 0x2731250
	public void .ctor() { }
}

[RequireComponent] // RVA: 0x1489D0 Offset: 0x148AD1 VA: 0x1489D0
[AddComponentMenu] // RVA: 0x1489D0 Offset: 0x148AD1 VA: 0x1489D0
public class AimIKJ : MonoBehaviour // TypeDefIndex: 9450
{
	// Fields
	[TooltipAttribute] // RVA: 0x179FB0 Offset: 0x17A0B1 VA: 0x179FB0
	public Transform target; // 0x18
	[TooltipAttribute] // RVA: 0x179FF0 Offset: 0x17A0F1 VA: 0x179FF0
	public Transform poleTarget; // 0x20
	[TooltipAttribute] // RVA: 0x17A030 Offset: 0x17A131 VA: 0x17A030
	public Transform aimTransform; // 0x28
	[SpaceAttribute] // RVA: 0x17A070 Offset: 0x17A171 VA: 0x17A070
	[TooltipAttribute] // RVA: 0x17A070 Offset: 0x17A171 VA: 0x17A070
	public float axisX; // 0x30
	[TooltipAttribute] // RVA: 0x17A0C0 Offset: 0x17A1C1 VA: 0x17A0C0
	public float axisY; // 0x34
	[TooltipAttribute] // RVA: 0x17A100 Offset: 0x17A201 VA: 0x17A100
	public float axisZ; // 0x38
	[SpaceAttribute] // RVA: 0x17A140 Offset: 0x17A241 VA: 0x17A140
	[TooltipAttribute] // RVA: 0x17A140 Offset: 0x17A241 VA: 0x17A140
	public float poleAxisX; // 0x3C
	[TooltipAttribute] // RVA: 0x17A190 Offset: 0x17A291 VA: 0x17A190
	public float poleAxisY; // 0x40
	[TooltipAttribute] // RVA: 0x17A1D0 Offset: 0x17A2D1 VA: 0x17A1D0
	public float poleAxisZ; // 0x44
	[SpaceAttribute] // RVA: 0x17A210 Offset: 0x17A311 VA: 0x17A210
	[TooltipAttribute] // RVA: 0x17A210 Offset: 0x17A311 VA: 0x17A210
	[RangeAttribute] // RVA: 0x17A210 Offset: 0x17A311 VA: 0x17A210
	public float weight; // 0x48
	[TooltipAttribute] // RVA: 0x17A280 Offset: 0x17A381 VA: 0x17A280
	[RangeAttribute] // RVA: 0x17A280 Offset: 0x17A381 VA: 0x17A280
	public float poleWeight; // 0x4C
	[TooltipAttribute] // RVA: 0x17A2E0 Offset: 0x17A3E1 VA: 0x17A2E0
	public float tolerance; // 0x50
	[TooltipAttribute] // RVA: 0x17A320 Offset: 0x17A421 VA: 0x17A320
	public int maxIterations; // 0x54
	[TooltipAttribute] // RVA: 0x17A360 Offset: 0x17A461 VA: 0x17A360
	[RangeAttribute] // RVA: 0x17A360 Offset: 0x17A461 VA: 0x17A360
	public float clampWeight; // 0x58
	[TooltipAttribute] // RVA: 0x17A3C0 Offset: 0x17A4C1 VA: 0x17A3C0
	[RangeAttribute] // RVA: 0x17A3C0 Offset: 0x17A4C1 VA: 0x17A3C0
	public int clampSmoothing; // 0x5C
	[TooltipAttribute] // RVA: 0x17A420 Offset: 0x17A521 VA: 0x17A420
	public bool useRotationLimits; // 0x60
	[TooltipAttribute] // RVA: 0x17A460 Offset: 0x17A561 VA: 0x17A460
	public bool XY; // 0x61
	[SpaceAttribute] // RVA: 0x17A4A0 Offset: 0x17A5A1 VA: 0x17A4A0
	[TooltipAttribute] // RVA: 0x17A4A0 Offset: 0x17A5A1 VA: 0x17A4A0
	public Transform[] bones; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x17A4F0 Offset: 0x17A5F1 VA: 0x17A4F0
	private bool <initiated>k__BackingField; // 0x70
	private Animator animator; // 0x78
	private PlayableGraph graph; // 0x80
	private AnimationScriptPlayable IKPlayable; // 0x90
	private AimIKJob job; // 0xA0

	// Properties
	public bool initiated { get; set; }
	public Vector3 axis { get; set; }
	public Vector3 poleAxis { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AB3F0 Offset: 0x1AB4F1 VA: 0x1AB3F0
	// RVA: 0x272FEC0 Offset: 0x272FFC1 VA: 0x272FEC0
	public bool get_initiated() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB400 Offset: 0x1AB501 VA: 0x1AB400
	// RVA: 0x272FED0 Offset: 0x272FFD1 VA: 0x272FED0
	private void set_initiated(bool value) { }

	// RVA: 0x272FEE0 Offset: 0x272FFE1 VA: 0x272FEE0
	public Vector3 get_axis() { }

	// RVA: 0x272FF20 Offset: 0x2730021 VA: 0x272FF20
	public void set_axis(Vector3 value) { }

	// RVA: 0x272FF30 Offset: 0x2730031 VA: 0x272FF30
	public Vector3 get_poleAxis() { }

	// RVA: 0x272FF70 Offset: 0x2730071 VA: 0x272FF70
	public void set_poleAxis(Vector3 value) { }

	// RVA: 0x272FF80 Offset: 0x2730081 VA: 0x272FF80
	private void OnEnable() { }

	// RVA: 0x2730D80 Offset: 0x2730E81 VA: 0x2730D80
	private void Update() { }

	// RVA: 0x2731140 Offset: 0x2731241 VA: 0x2731140
	private void OnDisable() { }

	// RVA: 0x2731250 Offset: 0x2731351 VA: 0x2731250
	public void .ctor() { }
}

[RequireComponent] // RVA: 0x1489D0 Offset: 0x148AD1 VA: 0x1489D0
[AddComponentMenu] // RVA: 0x1489D0 Offset: 0x148AD1 VA: 0x1489D0
public class AimIKJ : MonoBehaviour // TypeDefIndex: 9450
{
	// Fields
	[TooltipAttribute] // RVA: 0x179FB0 Offset: 0x17A0B1 VA: 0x179FB0
	public Transform target; // 0x18
	[TooltipAttribute] // RVA: 0x179FF0 Offset: 0x17A0F1 VA: 0x179FF0
	public Transform poleTarget; // 0x20
	[TooltipAttribute] // RVA: 0x17A030 Offset: 0x17A131 VA: 0x17A030
	public Transform aimTransform; // 0x28
	[SpaceAttribute] // RVA: 0x17A070 Offset: 0x17A171 VA: 0x17A070
	[TooltipAttribute] // RVA: 0x17A070 Offset: 0x17A171 VA: 0x17A070
	public float axisX; // 0x30
	[TooltipAttribute] // RVA: 0x17A0C0 Offset: 0x17A1C1 VA: 0x17A0C0
	public float axisY; // 0x34
	[TooltipAttribute] // RVA: 0x17A100 Offset: 0x17A201 VA: 0x17A100
	public float axisZ; // 0x38
	[SpaceAttribute] // RVA: 0x17A140 Offset: 0x17A241 VA: 0x17A140
	[TooltipAttribute] // RVA: 0x17A140 Offset: 0x17A241 VA: 0x17A140
	public float poleAxisX; // 0x3C
	[TooltipAttribute] // RVA: 0x17A190 Offset: 0x17A291 VA: 0x17A190
	public float poleAxisY; // 0x40
	[TooltipAttribute] // RVA: 0x17A1D0 Offset: 0x17A2D1 VA: 0x17A1D0
	public float poleAxisZ; // 0x44
	[SpaceAttribute] // RVA: 0x17A210 Offset: 0x17A311 VA: 0x17A210
	[TooltipAttribute] // RVA: 0x17A210 Offset: 0x17A311 VA: 0x17A210
	[RangeAttribute] // RVA: 0x17A210 Offset: 0x17A311 VA: 0x17A210
	public float weight; // 0x48
	[TooltipAttribute] // RVA: 0x17A280 Offset: 0x17A381 VA: 0x17A280
	[RangeAttribute] // RVA: 0x17A280 Offset: 0x17A381 VA: 0x17A280
	public float poleWeight; // 0x4C
	[TooltipAttribute] // RVA: 0x17A2E0 Offset: 0x17A3E1 VA: 0x17A2E0
	public float tolerance; // 0x50
	[TooltipAttribute] // RVA: 0x17A320 Offset: 0x17A421 VA: 0x17A320
	public int maxIterations; // 0x54
	[TooltipAttribute] // RVA: 0x17A360 Offset: 0x17A461 VA: 0x17A360
	[RangeAttribute] // RVA: 0x17A360 Offset: 0x17A461 VA: 0x17A360
	public float clampWeight; // 0x58
	[TooltipAttribute] // RVA: 0x17A3C0 Offset: 0x17A4C1 VA: 0x17A3C0
	[RangeAttribute] // RVA: 0x17A3C0 Offset: 0x17A4C1 VA: 0x17A3C0
	public int clampSmoothing; // 0x5C
	[TooltipAttribute] // RVA: 0x17A420 Offset: 0x17A521 VA: 0x17A420
	public bool useRotationLimits; // 0x60
	[TooltipAttribute] // RVA: 0x17A460 Offset: 0x17A561 VA: 0x17A460
	public bool XY; // 0x61
	[SpaceAttribute] // RVA: 0x17A4A0 Offset: 0x17A5A1 VA: 0x17A4A0
	[TooltipAttribute] // RVA: 0x17A4A0 Offset: 0x17A5A1 VA: 0x17A4A0
	public Transform[] bones; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x17A4F0 Offset: 0x17A5F1 VA: 0x17A4F0
	private bool <initiated>k__BackingField; // 0x70
	private Animator animator; // 0x78
	private PlayableGraph graph; // 0x80
	private AnimationScriptPlayable IKPlayable; // 0x90
	private AimIKJob job; // 0xA0

	// Properties
	public bool initiated { get; set; }
	public Vector3 axis { get; set; }
	public Vector3 poleAxis { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AB3F0 Offset: 0x1AB4F1 VA: 0x1AB3F0
	// RVA: 0x272FEC0 Offset: 0x272FFC1 VA: 0x272FEC0
	public bool get_initiated() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB400 Offset: 0x1AB501 VA: 0x1AB400
	// RVA: 0x272FED0 Offset: 0x272FFD1 VA: 0x272FED0
	private void set_initiated(bool value) { }

	// RVA: 0x272FEE0 Offset: 0x272FFE1 VA: 0x272FEE0
	public Vector3 get_axis() { }

	// RVA: 0x272FF20 Offset: 0x2730021 VA: 0x272FF20
	public void set_axis(Vector3 value) { }

	// RVA: 0x272FF30 Offset: 0x2730031 VA: 0x272FF30
	public Vector3 get_poleAxis() { }

	// RVA: 0x272FF70 Offset: 0x2730071 VA: 0x272FF70
	public void set_poleAxis(Vector3 value) { }

	// RVA: 0x272FF80 Offset: 0x2730081 VA: 0x272FF80
	private void OnEnable() { }

	// RVA: 0x2730D80 Offset: 0x2730E81 VA: 0x2730D80
	private void Update() { }

	// RVA: 0x2731140 Offset: 0x2731241 VA: 0x2731140
	private void OnDisable() { }

	// RVA: 0x2731250 Offset: 0x2731351 VA: 0x2731250
	public void .ctor() { }
}

[RequireComponent] // RVA: 0x1489D0 Offset: 0x148AD1 VA: 0x1489D0
[AddComponentMenu] // RVA: 0x1489D0 Offset: 0x148AD1 VA: 0x1489D0
public class AimIKJ : MonoBehaviour // TypeDefIndex: 9450
{
	// Fields
	[TooltipAttribute] // RVA: 0x179FB0 Offset: 0x17A0B1 VA: 0x179FB0
	public Transform target; // 0x18
	[TooltipAttribute] // RVA: 0x179FF0 Offset: 0x17A0F1 VA: 0x179FF0
	public Transform poleTarget; // 0x20
	[TooltipAttribute] // RVA: 0x17A030 Offset: 0x17A131 VA: 0x17A030
	public Transform aimTransform; // 0x28
	[SpaceAttribute] // RVA: 0x17A070 Offset: 0x17A171 VA: 0x17A070
	[TooltipAttribute] // RVA: 0x17A070 Offset: 0x17A171 VA: 0x17A070
	public float axisX; // 0x30
	[TooltipAttribute] // RVA: 0x17A0C0 Offset: 0x17A1C1 VA: 0x17A0C0
	public float axisY; // 0x34
	[TooltipAttribute] // RVA: 0x17A100 Offset: 0x17A201 VA: 0x17A100
	public float axisZ; // 0x38
	[SpaceAttribute] // RVA: 0x17A140 Offset: 0x17A241 VA: 0x17A140
	[TooltipAttribute] // RVA: 0x17A140 Offset: 0x17A241 VA: 0x17A140
	public float poleAxisX; // 0x3C
	[TooltipAttribute] // RVA: 0x17A190 Offset: 0x17A291 VA: 0x17A190
	public float poleAxisY; // 0x40
	[TooltipAttribute] // RVA: 0x17A1D0 Offset: 0x17A2D1 VA: 0x17A1D0
	public float poleAxisZ; // 0x44
	[SpaceAttribute] // RVA: 0x17A210 Offset: 0x17A311 VA: 0x17A210
	[TooltipAttribute] // RVA: 0x17A210 Offset: 0x17A311 VA: 0x17A210
	[RangeAttribute] // RVA: 0x17A210 Offset: 0x17A311 VA: 0x17A210
	public float weight; // 0x48
	[TooltipAttribute] // RVA: 0x17A280 Offset: 0x17A381 VA: 0x17A280
	[RangeAttribute] // RVA: 0x17A280 Offset: 0x17A381 VA: 0x17A280
	public float poleWeight; // 0x4C
	[TooltipAttribute] // RVA: 0x17A2E0 Offset: 0x17A3E1 VA: 0x17A2E0
	public float tolerance; // 0x50
	[TooltipAttribute] // RVA: 0x17A320 Offset: 0x17A421 VA: 0x17A320
	public int maxIterations; // 0x54
	[TooltipAttribute] // RVA: 0x17A360 Offset: 0x17A461 VA: 0x17A360
	[RangeAttribute] // RVA: 0x17A360 Offset: 0x17A461 VA: 0x17A360
	public float clampWeight; // 0x58
	[TooltipAttribute] // RVA: 0x17A3C0 Offset: 0x17A4C1 VA: 0x17A3C0
	[RangeAttribute] // RVA: 0x17A3C0 Offset: 0x17A4C1 VA: 0x17A3C0
	public int clampSmoothing; // 0x5C
	[TooltipAttribute] // RVA: 0x17A420 Offset: 0x17A521 VA: 0x17A420
	public bool useRotationLimits; // 0x60
	[TooltipAttribute] // RVA: 0x17A460 Offset: 0x17A561 VA: 0x17A460
	public bool XY; // 0x61
	[SpaceAttribute] // RVA: 0x17A4A0 Offset: 0x17A5A1 VA: 0x17A4A0
	[TooltipAttribute] // RVA: 0x17A4A0 Offset: 0x17A5A1 VA: 0x17A4A0
	public Transform[] bones; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x17A4F0 Offset: 0x17A5F1 VA: 0x17A4F0
	private bool <initiated>k__BackingField; // 0x70
	private Animator animator; // 0x78
	private PlayableGraph graph; // 0x80
	private AnimationScriptPlayable IKPlayable; // 0x90
	private AimIKJob job; // 0xA0

	// Properties
	public bool initiated { get; set; }
	public Vector3 axis { get; set; }
	public Vector3 poleAxis { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AB3F0 Offset: 0x1AB4F1 VA: 0x1AB3F0
	// RVA: 0x272FEC0 Offset: 0x272FFC1 VA: 0x272FEC0
	public bool get_initiated() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB400 Offset: 0x1AB501 VA: 0x1AB400
	// RVA: 0x272FED0 Offset: 0x272FFD1 VA: 0x272FED0
	private void set_initiated(bool value) { }

	// RVA: 0x272FEE0 Offset: 0x272FFE1 VA: 0x272FEE0
	public Vector3 get_axis() { }

	// RVA: 0x272FF20 Offset: 0x2730021 VA: 0x272FF20
	public void set_axis(Vector3 value) { }

	// RVA: 0x272FF30 Offset: 0x2730031 VA: 0x272FF30
	public Vector3 get_poleAxis() { }

	// RVA: 0x272FF70 Offset: 0x2730071 VA: 0x272FF70
	public void set_poleAxis(Vector3 value) { }

	// RVA: 0x272FF80 Offset: 0x2730081 VA: 0x272FF80
	private void OnEnable() { }

	// RVA: 0x2730D80 Offset: 0x2730E81 VA: 0x2730D80
	private void Update() { }

	// RVA: 0x2731140 Offset: 0x2731241 VA: 0x2731140
	private void OnDisable() { }

	// RVA: 0x2731250 Offset: 0x2731351 VA: 0x2731250
	public void .ctor() { }
}

[RequireComponent] // RVA: 0x1489D0 Offset: 0x148AD1 VA: 0x1489D0
[AddComponentMenu] // RVA: 0x1489D0 Offset: 0x148AD1 VA: 0x1489D0
public class AimIKJ : MonoBehaviour // TypeDefIndex: 9450
{
	// Fields
	[TooltipAttribute] // RVA: 0x179FB0 Offset: 0x17A0B1 VA: 0x179FB0
	public Transform target; // 0x18
	[TooltipAttribute] // RVA: 0x179FF0 Offset: 0x17A0F1 VA: 0x179FF0
	public Transform poleTarget; // 0x20
	[TooltipAttribute] // RVA: 0x17A030 Offset: 0x17A131 VA: 0x17A030
	public Transform aimTransform; // 0x28
	[SpaceAttribute] // RVA: 0x17A070 Offset: 0x17A171 VA: 0x17A070
	[TooltipAttribute] // RVA: 0x17A070 Offset: 0x17A171 VA: 0x17A070
	public float axisX; // 0x30
	[TooltipAttribute] // RVA: 0x17A0C0 Offset: 0x17A1C1 VA: 0x17A0C0
	public float axisY; // 0x34
	[TooltipAttribute] // RVA: 0x17A100 Offset: 0x17A201 VA: 0x17A100
	public float axisZ; // 0x38
	[SpaceAttribute] // RVA: 0x17A140 Offset: 0x17A241 VA: 0x17A140
	[TooltipAttribute] // RVA: 0x17A140 Offset: 0x17A241 VA: 0x17A140
	public float poleAxisX; // 0x3C
	[TooltipAttribute] // RVA: 0x17A190 Offset: 0x17A291 VA: 0x17A190
	public float poleAxisY; // 0x40
	[TooltipAttribute] // RVA: 0x17A1D0 Offset: 0x17A2D1 VA: 0x17A1D0
	public float poleAxisZ; // 0x44
	[SpaceAttribute] // RVA: 0x17A210 Offset: 0x17A311 VA: 0x17A210
	[TooltipAttribute] // RVA: 0x17A210 Offset: 0x17A311 VA: 0x17A210
	[RangeAttribute] // RVA: 0x17A210 Offset: 0x17A311 VA: 0x17A210
	public float weight; // 0x48
	[TooltipAttribute] // RVA: 0x17A280 Offset: 0x17A381 VA: 0x17A280
	[RangeAttribute] // RVA: 0x17A280 Offset: 0x17A381 VA: 0x17A280
	public float poleWeight; // 0x4C
	[TooltipAttribute] // RVA: 0x17A2E0 Offset: 0x17A3E1 VA: 0x17A2E0
	public float tolerance; // 0x50
	[TooltipAttribute] // RVA: 0x17A320 Offset: 0x17A421 VA: 0x17A320
	public int maxIterations; // 0x54
	[TooltipAttribute] // RVA: 0x17A360 Offset: 0x17A461 VA: 0x17A360
	[RangeAttribute] // RVA: 0x17A360 Offset: 0x17A461 VA: 0x17A360
	public float clampWeight; // 0x58
	[TooltipAttribute] // RVA: 0x17A3C0 Offset: 0x17A4C1 VA: 0x17A3C0
	[RangeAttribute] // RVA: 0x17A3C0 Offset: 0x17A4C1 VA: 0x17A3C0
	public int clampSmoothing; // 0x5C
	[TooltipAttribute] // RVA: 0x17A420 Offset: 0x17A521 VA: 0x17A420
	public bool useRotationLimits; // 0x60
	[TooltipAttribute] // RVA: 0x17A460 Offset: 0x17A561 VA: 0x17A460
	public bool XY; // 0x61
	[SpaceAttribute] // RVA: 0x17A4A0 Offset: 0x17A5A1 VA: 0x17A4A0
	[TooltipAttribute] // RVA: 0x17A4A0 Offset: 0x17A5A1 VA: 0x17A4A0
	public Transform[] bones; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x17A4F0 Offset: 0x17A5F1 VA: 0x17A4F0
	private bool <initiated>k__BackingField; // 0x70
	private Animator animator; // 0x78
	private PlayableGraph graph; // 0x80
	private AnimationScriptPlayable IKPlayable; // 0x90
	private AimIKJob job; // 0xA0

	// Properties
	public bool initiated { get; set; }
	public Vector3 axis { get; set; }
	public Vector3 poleAxis { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AB3F0 Offset: 0x1AB4F1 VA: 0x1AB3F0
	// RVA: 0x272FEC0 Offset: 0x272FFC1 VA: 0x272FEC0
	public bool get_initiated() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB400 Offset: 0x1AB501 VA: 0x1AB400
	// RVA: 0x272FED0 Offset: 0x272FFD1 VA: 0x272FED0
	private void set_initiated(bool value) { }

	// RVA: 0x272FEE0 Offset: 0x272FFE1 VA: 0x272FEE0
	public Vector3 get_axis() { }

	// RVA: 0x272FF20 Offset: 0x2730021 VA: 0x272FF20
	public void set_axis(Vector3 value) { }

	// RVA: 0x272FF30 Offset: 0x2730031 VA: 0x272FF30
	public Vector3 get_poleAxis() { }

	// RVA: 0x272FF70 Offset: 0x2730071 VA: 0x272FF70
	public void set_poleAxis(Vector3 value) { }

	// RVA: 0x272FF80 Offset: 0x2730081 VA: 0x272FF80
	private void OnEnable() { }

	// RVA: 0x2730D80 Offset: 0x2730E81 VA: 0x2730D80
	private void Update() { }

	// RVA: 0x2731140 Offset: 0x2731241 VA: 0x2731140
	private void OnDisable() { }

	// RVA: 0x2731250 Offset: 0x2731351 VA: 0x2731250
	public void .ctor() { }
}

