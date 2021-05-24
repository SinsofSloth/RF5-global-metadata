public class Recoil : OffsetModifier // TypeDefIndex: 9576
{
	// Fields
	[TooltipAttribute] // RVA: 0x17CE20 Offset: 0x17CF21 VA: 0x17CE20
	public AimIK aimIK; // 0x30
	[TooltipAttribute] // RVA: 0x17CE60 Offset: 0x17CF61 VA: 0x17CE60
	public bool aimIKSolvedLast; // 0x38
	[TooltipAttribute] // RVA: 0x17CEA0 Offset: 0x17CFA1 VA: 0x17CEA0
	public Recoil.Handedness handedness; // 0x3C
	[TooltipAttribute] // RVA: 0x17CEE0 Offset: 0x17CFE1 VA: 0x17CEE0
	public bool twoHanded; // 0x40
	[TooltipAttribute] // RVA: 0x17CF20 Offset: 0x17D021 VA: 0x17CF20
	public AnimationCurve recoilWeight; // 0x48
	[TooltipAttribute] // RVA: 0x17CF60 Offset: 0x17D061 VA: 0x17CF60
	public float magnitudeRandom; // 0x50
	[TooltipAttribute] // RVA: 0x17CFA0 Offset: 0x17D0A1 VA: 0x17CFA0
	public Vector3 rotationRandom; // 0x54
	[TooltipAttribute] // RVA: 0x17CFE0 Offset: 0x17D0E1 VA: 0x17CFE0
	public Vector3 handRotationOffset; // 0x60
	[TooltipAttribute] // RVA: 0x17D020 Offset: 0x17D121 VA: 0x17D020
	public float blendTime; // 0x6C
	[SpaceAttribute] // RVA: 0x17D060 Offset: 0x17D161 VA: 0x17D060
	[TooltipAttribute] // RVA: 0x17D060 Offset: 0x17D161 VA: 0x17D060
	public Recoil.RecoilOffset[] offsets; // 0x70
	[HideInInspector] // RVA: 0x17D0B0 Offset: 0x17D1B1 VA: 0x17D0B0
	public Quaternion rotationOffset; // 0x78
	private float magnitudeMlp; // 0x88
	private float endTime; // 0x8C
	private Quaternion handRotation; // 0x90
	private Quaternion secondaryHandRelativeRotation; // 0xA0
	private Quaternion randomRotation; // 0xB0
	private float length; // 0xC0
	private bool initiated; // 0xC4
	private float blendWeight; // 0xC8
	private float w; // 0xCC
	private Quaternion primaryHandRotation; // 0xD0
	private bool handRotationsSet; // 0xE0
	private Vector3 aimIKAxis; // 0xE4

	// Properties
	public bool isFinished { get; }
	private IKEffector primaryHandEffector { get; }
	private IKEffector secondaryHandEffector { get; }
	private Transform primaryHand { get; }
	private Transform secondaryHand { get; }

	// Methods

	// RVA: 0x291EB10 Offset: 0x291EC11 VA: 0x291EB10
	public bool get_isFinished() { }

	// RVA: 0x291EB40 Offset: 0x291EC41 VA: 0x291EB40
	public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation) { }

	// RVA: 0x291EB80 Offset: 0x291EC81 VA: 0x291EB80
	public void Fire(float magnitude) { }

	// RVA: 0x291EE10 Offset: 0x291EF11 VA: 0x291EE10 Slot: 4
	protected override void OnModifyOffset() { }

	// RVA: 0x291FE90 Offset: 0x291FF91 VA: 0x291FE90
	private void AfterFBBIK() { }

	// RVA: 0x2920070 Offset: 0x2920171 VA: 0x2920070
	private void AfterAimIK() { }

	// RVA: 0x291FE10 Offset: 0x291FF11 VA: 0x291FE10
	private IKEffector get_primaryHandEffector() { }

	// RVA: 0x291FE50 Offset: 0x291FF51 VA: 0x291FE50
	private IKEffector get_secondaryHandEffector() { }

	// RVA: 0x291FD70 Offset: 0x291FE71 VA: 0x291FD70
	private Transform get_primaryHand() { }

	// RVA: 0x291FDC0 Offset: 0x291FEC1 VA: 0x291FDC0
	private Transform get_secondaryHand() { }

	// RVA: 0x29200B0 Offset: 0x29201B1 VA: 0x29200B0 Slot: 6
	protected override void OnDestroy() { }

	// RVA: 0x2920280 Offset: 0x2920381 VA: 0x2920280
	public void .ctor() { }
}

public class Recoil : OffsetModifier // TypeDefIndex: 9576
{
	// Fields
	[TooltipAttribute] // RVA: 0x17CE20 Offset: 0x17CF21 VA: 0x17CE20
	public AimIK aimIK; // 0x30
	[TooltipAttribute] // RVA: 0x17CE60 Offset: 0x17CF61 VA: 0x17CE60
	public bool aimIKSolvedLast; // 0x38
	[TooltipAttribute] // RVA: 0x17CEA0 Offset: 0x17CFA1 VA: 0x17CEA0
	public Recoil.Handedness handedness; // 0x3C
	[TooltipAttribute] // RVA: 0x17CEE0 Offset: 0x17CFE1 VA: 0x17CEE0
	public bool twoHanded; // 0x40
	[TooltipAttribute] // RVA: 0x17CF20 Offset: 0x17D021 VA: 0x17CF20
	public AnimationCurve recoilWeight; // 0x48
	[TooltipAttribute] // RVA: 0x17CF60 Offset: 0x17D061 VA: 0x17CF60
	public float magnitudeRandom; // 0x50
	[TooltipAttribute] // RVA: 0x17CFA0 Offset: 0x17D0A1 VA: 0x17CFA0
	public Vector3 rotationRandom; // 0x54
	[TooltipAttribute] // RVA: 0x17CFE0 Offset: 0x17D0E1 VA: 0x17CFE0
	public Vector3 handRotationOffset; // 0x60
	[TooltipAttribute] // RVA: 0x17D020 Offset: 0x17D121 VA: 0x17D020
	public float blendTime; // 0x6C
	[SpaceAttribute] // RVA: 0x17D060 Offset: 0x17D161 VA: 0x17D060
	[TooltipAttribute] // RVA: 0x17D060 Offset: 0x17D161 VA: 0x17D060
	public Recoil.RecoilOffset[] offsets; // 0x70
	[HideInInspector] // RVA: 0x17D0B0 Offset: 0x17D1B1 VA: 0x17D0B0
	public Quaternion rotationOffset; // 0x78
	private float magnitudeMlp; // 0x88
	private float endTime; // 0x8C
	private Quaternion handRotation; // 0x90
	private Quaternion secondaryHandRelativeRotation; // 0xA0
	private Quaternion randomRotation; // 0xB0
	private float length; // 0xC0
	private bool initiated; // 0xC4
	private float blendWeight; // 0xC8
	private float w; // 0xCC
	private Quaternion primaryHandRotation; // 0xD0
	private bool handRotationsSet; // 0xE0
	private Vector3 aimIKAxis; // 0xE4

	// Properties
	public bool isFinished { get; }
	private IKEffector primaryHandEffector { get; }
	private IKEffector secondaryHandEffector { get; }
	private Transform primaryHand { get; }
	private Transform secondaryHand { get; }

	// Methods

	// RVA: 0x291EB10 Offset: 0x291EC11 VA: 0x291EB10
	public bool get_isFinished() { }

	// RVA: 0x291EB40 Offset: 0x291EC41 VA: 0x291EB40
	public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation) { }

	// RVA: 0x291EB80 Offset: 0x291EC81 VA: 0x291EB80
	public void Fire(float magnitude) { }

	// RVA: 0x291EE10 Offset: 0x291EF11 VA: 0x291EE10 Slot: 4
	protected override void OnModifyOffset() { }

	// RVA: 0x291FE90 Offset: 0x291FF91 VA: 0x291FE90
	private void AfterFBBIK() { }

	// RVA: 0x2920070 Offset: 0x2920171 VA: 0x2920070
	private void AfterAimIK() { }

	// RVA: 0x291FE10 Offset: 0x291FF11 VA: 0x291FE10
	private IKEffector get_primaryHandEffector() { }

	// RVA: 0x291FE50 Offset: 0x291FF51 VA: 0x291FE50
	private IKEffector get_secondaryHandEffector() { }

	// RVA: 0x291FD70 Offset: 0x291FE71 VA: 0x291FD70
	private Transform get_primaryHand() { }

	// RVA: 0x291FDC0 Offset: 0x291FEC1 VA: 0x291FDC0
	private Transform get_secondaryHand() { }

	// RVA: 0x29200B0 Offset: 0x29201B1 VA: 0x29200B0 Slot: 6
	protected override void OnDestroy() { }

	// RVA: 0x2920280 Offset: 0x2920381 VA: 0x2920280
	public void .ctor() { }
}

public class Recoil : OffsetModifier // TypeDefIndex: 9576
{
	// Fields
	[TooltipAttribute] // RVA: 0x17CE20 Offset: 0x17CF21 VA: 0x17CE20
	public AimIK aimIK; // 0x30
	[TooltipAttribute] // RVA: 0x17CE60 Offset: 0x17CF61 VA: 0x17CE60
	public bool aimIKSolvedLast; // 0x38
	[TooltipAttribute] // RVA: 0x17CEA0 Offset: 0x17CFA1 VA: 0x17CEA0
	public Recoil.Handedness handedness; // 0x3C
	[TooltipAttribute] // RVA: 0x17CEE0 Offset: 0x17CFE1 VA: 0x17CEE0
	public bool twoHanded; // 0x40
	[TooltipAttribute] // RVA: 0x17CF20 Offset: 0x17D021 VA: 0x17CF20
	public AnimationCurve recoilWeight; // 0x48
	[TooltipAttribute] // RVA: 0x17CF60 Offset: 0x17D061 VA: 0x17CF60
	public float magnitudeRandom; // 0x50
	[TooltipAttribute] // RVA: 0x17CFA0 Offset: 0x17D0A1 VA: 0x17CFA0
	public Vector3 rotationRandom; // 0x54
	[TooltipAttribute] // RVA: 0x17CFE0 Offset: 0x17D0E1 VA: 0x17CFE0
	public Vector3 handRotationOffset; // 0x60
	[TooltipAttribute] // RVA: 0x17D020 Offset: 0x17D121 VA: 0x17D020
	public float blendTime; // 0x6C
	[SpaceAttribute] // RVA: 0x17D060 Offset: 0x17D161 VA: 0x17D060
	[TooltipAttribute] // RVA: 0x17D060 Offset: 0x17D161 VA: 0x17D060
	public Recoil.RecoilOffset[] offsets; // 0x70
	[HideInInspector] // RVA: 0x17D0B0 Offset: 0x17D1B1 VA: 0x17D0B0
	public Quaternion rotationOffset; // 0x78
	private float magnitudeMlp; // 0x88
	private float endTime; // 0x8C
	private Quaternion handRotation; // 0x90
	private Quaternion secondaryHandRelativeRotation; // 0xA0
	private Quaternion randomRotation; // 0xB0
	private float length; // 0xC0
	private bool initiated; // 0xC4
	private float blendWeight; // 0xC8
	private float w; // 0xCC
	private Quaternion primaryHandRotation; // 0xD0
	private bool handRotationsSet; // 0xE0
	private Vector3 aimIKAxis; // 0xE4

	// Properties
	public bool isFinished { get; }
	private IKEffector primaryHandEffector { get; }
	private IKEffector secondaryHandEffector { get; }
	private Transform primaryHand { get; }
	private Transform secondaryHand { get; }

	// Methods

	// RVA: 0x291EB10 Offset: 0x291EC11 VA: 0x291EB10
	public bool get_isFinished() { }

	// RVA: 0x291EB40 Offset: 0x291EC41 VA: 0x291EB40
	public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation) { }

	// RVA: 0x291EB80 Offset: 0x291EC81 VA: 0x291EB80
	public void Fire(float magnitude) { }

	// RVA: 0x291EE10 Offset: 0x291EF11 VA: 0x291EE10 Slot: 4
	protected override void OnModifyOffset() { }

	// RVA: 0x291FE90 Offset: 0x291FF91 VA: 0x291FE90
	private void AfterFBBIK() { }

	// RVA: 0x2920070 Offset: 0x2920171 VA: 0x2920070
	private void AfterAimIK() { }

	// RVA: 0x291FE10 Offset: 0x291FF11 VA: 0x291FE10
	private IKEffector get_primaryHandEffector() { }

	// RVA: 0x291FE50 Offset: 0x291FF51 VA: 0x291FE50
	private IKEffector get_secondaryHandEffector() { }

	// RVA: 0x291FD70 Offset: 0x291FE71 VA: 0x291FD70
	private Transform get_primaryHand() { }

	// RVA: 0x291FDC0 Offset: 0x291FEC1 VA: 0x291FDC0
	private Transform get_secondaryHand() { }

	// RVA: 0x29200B0 Offset: 0x29201B1 VA: 0x29200B0 Slot: 6
	protected override void OnDestroy() { }

	// RVA: 0x2920280 Offset: 0x2920381 VA: 0x2920280
	public void .ctor() { }
}

public class Recoil : OffsetModifier // TypeDefIndex: 9576
{
	// Fields
	[TooltipAttribute] // RVA: 0x17CE20 Offset: 0x17CF21 VA: 0x17CE20
	public AimIK aimIK; // 0x30
	[TooltipAttribute] // RVA: 0x17CE60 Offset: 0x17CF61 VA: 0x17CE60
	public bool aimIKSolvedLast; // 0x38
	[TooltipAttribute] // RVA: 0x17CEA0 Offset: 0x17CFA1 VA: 0x17CEA0
	public Recoil.Handedness handedness; // 0x3C
	[TooltipAttribute] // RVA: 0x17CEE0 Offset: 0x17CFE1 VA: 0x17CEE0
	public bool twoHanded; // 0x40
	[TooltipAttribute] // RVA: 0x17CF20 Offset: 0x17D021 VA: 0x17CF20
	public AnimationCurve recoilWeight; // 0x48
	[TooltipAttribute] // RVA: 0x17CF60 Offset: 0x17D061 VA: 0x17CF60
	public float magnitudeRandom; // 0x50
	[TooltipAttribute] // RVA: 0x17CFA0 Offset: 0x17D0A1 VA: 0x17CFA0
	public Vector3 rotationRandom; // 0x54
	[TooltipAttribute] // RVA: 0x17CFE0 Offset: 0x17D0E1 VA: 0x17CFE0
	public Vector3 handRotationOffset; // 0x60
	[TooltipAttribute] // RVA: 0x17D020 Offset: 0x17D121 VA: 0x17D020
	public float blendTime; // 0x6C
	[SpaceAttribute] // RVA: 0x17D060 Offset: 0x17D161 VA: 0x17D060
	[TooltipAttribute] // RVA: 0x17D060 Offset: 0x17D161 VA: 0x17D060
	public Recoil.RecoilOffset[] offsets; // 0x70
	[HideInInspector] // RVA: 0x17D0B0 Offset: 0x17D1B1 VA: 0x17D0B0
	public Quaternion rotationOffset; // 0x78
	private float magnitudeMlp; // 0x88
	private float endTime; // 0x8C
	private Quaternion handRotation; // 0x90
	private Quaternion secondaryHandRelativeRotation; // 0xA0
	private Quaternion randomRotation; // 0xB0
	private float length; // 0xC0
	private bool initiated; // 0xC4
	private float blendWeight; // 0xC8
	private float w; // 0xCC
	private Quaternion primaryHandRotation; // 0xD0
	private bool handRotationsSet; // 0xE0
	private Vector3 aimIKAxis; // 0xE4

	// Properties
	public bool isFinished { get; }
	private IKEffector primaryHandEffector { get; }
	private IKEffector secondaryHandEffector { get; }
	private Transform primaryHand { get; }
	private Transform secondaryHand { get; }

	// Methods

	// RVA: 0x291EB10 Offset: 0x291EC11 VA: 0x291EB10
	public bool get_isFinished() { }

	// RVA: 0x291EB40 Offset: 0x291EC41 VA: 0x291EB40
	public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation) { }

	// RVA: 0x291EB80 Offset: 0x291EC81 VA: 0x291EB80
	public void Fire(float magnitude) { }

	// RVA: 0x291EE10 Offset: 0x291EF11 VA: 0x291EE10 Slot: 4
	protected override void OnModifyOffset() { }

	// RVA: 0x291FE90 Offset: 0x291FF91 VA: 0x291FE90
	private void AfterFBBIK() { }

	// RVA: 0x2920070 Offset: 0x2920171 VA: 0x2920070
	private void AfterAimIK() { }

	// RVA: 0x291FE10 Offset: 0x291FF11 VA: 0x291FE10
	private IKEffector get_primaryHandEffector() { }

	// RVA: 0x291FE50 Offset: 0x291FF51 VA: 0x291FE50
	private IKEffector get_secondaryHandEffector() { }

	// RVA: 0x291FD70 Offset: 0x291FE71 VA: 0x291FD70
	private Transform get_primaryHand() { }

	// RVA: 0x291FDC0 Offset: 0x291FEC1 VA: 0x291FDC0
	private Transform get_secondaryHand() { }

	// RVA: 0x29200B0 Offset: 0x29201B1 VA: 0x29200B0 Slot: 6
	protected override void OnDestroy() { }

	// RVA: 0x2920280 Offset: 0x2920381 VA: 0x2920280
	public void .ctor() { }
}

public class Recoil : OffsetModifier // TypeDefIndex: 9576
{
	// Fields
	[TooltipAttribute] // RVA: 0x17CE20 Offset: 0x17CF21 VA: 0x17CE20
	public AimIK aimIK; // 0x30
	[TooltipAttribute] // RVA: 0x17CE60 Offset: 0x17CF61 VA: 0x17CE60
	public bool aimIKSolvedLast; // 0x38
	[TooltipAttribute] // RVA: 0x17CEA0 Offset: 0x17CFA1 VA: 0x17CEA0
	public Recoil.Handedness handedness; // 0x3C
	[TooltipAttribute] // RVA: 0x17CEE0 Offset: 0x17CFE1 VA: 0x17CEE0
	public bool twoHanded; // 0x40
	[TooltipAttribute] // RVA: 0x17CF20 Offset: 0x17D021 VA: 0x17CF20
	public AnimationCurve recoilWeight; // 0x48
	[TooltipAttribute] // RVA: 0x17CF60 Offset: 0x17D061 VA: 0x17CF60
	public float magnitudeRandom; // 0x50
	[TooltipAttribute] // RVA: 0x17CFA0 Offset: 0x17D0A1 VA: 0x17CFA0
	public Vector3 rotationRandom; // 0x54
	[TooltipAttribute] // RVA: 0x17CFE0 Offset: 0x17D0E1 VA: 0x17CFE0
	public Vector3 handRotationOffset; // 0x60
	[TooltipAttribute] // RVA: 0x17D020 Offset: 0x17D121 VA: 0x17D020
	public float blendTime; // 0x6C
	[SpaceAttribute] // RVA: 0x17D060 Offset: 0x17D161 VA: 0x17D060
	[TooltipAttribute] // RVA: 0x17D060 Offset: 0x17D161 VA: 0x17D060
	public Recoil.RecoilOffset[] offsets; // 0x70
	[HideInInspector] // RVA: 0x17D0B0 Offset: 0x17D1B1 VA: 0x17D0B0
	public Quaternion rotationOffset; // 0x78
	private float magnitudeMlp; // 0x88
	private float endTime; // 0x8C
	private Quaternion handRotation; // 0x90
	private Quaternion secondaryHandRelativeRotation; // 0xA0
	private Quaternion randomRotation; // 0xB0
	private float length; // 0xC0
	private bool initiated; // 0xC4
	private float blendWeight; // 0xC8
	private float w; // 0xCC
	private Quaternion primaryHandRotation; // 0xD0
	private bool handRotationsSet; // 0xE0
	private Vector3 aimIKAxis; // 0xE4

	// Properties
	public bool isFinished { get; }
	private IKEffector primaryHandEffector { get; }
	private IKEffector secondaryHandEffector { get; }
	private Transform primaryHand { get; }
	private Transform secondaryHand { get; }

	// Methods

	// RVA: 0x291EB10 Offset: 0x291EC11 VA: 0x291EB10
	public bool get_isFinished() { }

	// RVA: 0x291EB40 Offset: 0x291EC41 VA: 0x291EB40
	public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation) { }

	// RVA: 0x291EB80 Offset: 0x291EC81 VA: 0x291EB80
	public void Fire(float magnitude) { }

	// RVA: 0x291EE10 Offset: 0x291EF11 VA: 0x291EE10 Slot: 4
	protected override void OnModifyOffset() { }

	// RVA: 0x291FE90 Offset: 0x291FF91 VA: 0x291FE90
	private void AfterFBBIK() { }

	// RVA: 0x2920070 Offset: 0x2920171 VA: 0x2920070
	private void AfterAimIK() { }

	// RVA: 0x291FE10 Offset: 0x291FF11 VA: 0x291FE10
	private IKEffector get_primaryHandEffector() { }

	// RVA: 0x291FE50 Offset: 0x291FF51 VA: 0x291FE50
	private IKEffector get_secondaryHandEffector() { }

	// RVA: 0x291FD70 Offset: 0x291FE71 VA: 0x291FD70
	private Transform get_primaryHand() { }

	// RVA: 0x291FDC0 Offset: 0x291FEC1 VA: 0x291FDC0
	private Transform get_secondaryHand() { }

	// RVA: 0x29200B0 Offset: 0x29201B1 VA: 0x29200B0 Slot: 6
	protected override void OnDestroy() { }

	// RVA: 0x2920280 Offset: 0x2920381 VA: 0x2920280
	public void .ctor() { }
}

