public class MechSpiderLeg : MonoBehaviour // TypeDefIndex: 9338
{
	// Fields
	public MechSpider mechSpider; // 0x18
	public MechSpiderLeg unSync; // 0x20
	public Vector3 offset; // 0x28
	public float minDelay; // 0x34
	public float maxOffset; // 0x38
	public float stepSpeed; // 0x3C
	public float footHeight; // 0x40
	public float velocityPrediction; // 0x44
	public float raycastFocus; // 0x48
	public AnimationCurve yOffset; // 0x50
	public Transform foot; // 0x58
	public Vector3 footUpAxis; // 0x60
	public float footRotationSpeed; // 0x6C
	public ParticleSystem sand; // 0x70
	private IK ik; // 0x78
	private float stepProgress; // 0x80
	private float lastStepTime; // 0x84
	private Vector3 defaultPosition; // 0x88
	private RaycastHit hit; // 0x94
	private Quaternion lastFootLocalRotation; // 0xC0
	private Vector3 smoothHitNormal; // 0xD0
	private Vector3 lastStepPosition; // 0xDC

	// Properties
	public bool isStepping { get; }
	public Vector3 position { get; set; }

	// Methods

	// RVA: 0x26CC640 Offset: 0x26CC741 VA: 0x26CC640
	public bool get_isStepping() { }

	// RVA: 0x26CC1D0 Offset: 0x26CC2D1 VA: 0x26CC1D0
	public Vector3 get_position() { }

	// RVA: 0x26CC660 Offset: 0x26CC761 VA: 0x26CC660
	public void set_position(Vector3 value) { }

	// RVA: 0x26CC6B0 Offset: 0x26CC7B1 VA: 0x26CC6B0
	private void Awake() { }

	// RVA: 0x26CC940 Offset: 0x26CCA41 VA: 0x26CC940
	private void AfterIK() { }

	// RVA: 0x26CCB60 Offset: 0x26CCC61 VA: 0x26CCB60
	private void Start() { }

	// RVA: 0x26CCF30 Offset: 0x26CD031 VA: 0x26CCF30
	private Vector3 GetStepTarget(out bool stepFound, float focus, float distance) { }

	// RVA: 0x26CD330 Offset: 0x26CD431 VA: 0x26CD330
	private void UpdatePosition(float distance) { }

	// RVA: 0x26CD5A0 Offset: 0x26CD6A1 VA: 0x26CD5A0
	private void Update() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A9F80 Offset: 0x1AA081 VA: 0x1A9F80
	// RVA: 0x26CCE60 Offset: 0x26CCF61 VA: 0x26CCE60
	private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition) { }

	// RVA: 0x26CD8A0 Offset: 0x26CD9A1 VA: 0x26CD8A0
	public void .ctor() { }
}

public class MechSpiderLeg : MonoBehaviour // TypeDefIndex: 9338
{
	// Fields
	public MechSpider mechSpider; // 0x18
	public MechSpiderLeg unSync; // 0x20
	public Vector3 offset; // 0x28
	public float minDelay; // 0x34
	public float maxOffset; // 0x38
	public float stepSpeed; // 0x3C
	public float footHeight; // 0x40
	public float velocityPrediction; // 0x44
	public float raycastFocus; // 0x48
	public AnimationCurve yOffset; // 0x50
	public Transform foot; // 0x58
	public Vector3 footUpAxis; // 0x60
	public float footRotationSpeed; // 0x6C
	public ParticleSystem sand; // 0x70
	private IK ik; // 0x78
	private float stepProgress; // 0x80
	private float lastStepTime; // 0x84
	private Vector3 defaultPosition; // 0x88
	private RaycastHit hit; // 0x94
	private Quaternion lastFootLocalRotation; // 0xC0
	private Vector3 smoothHitNormal; // 0xD0
	private Vector3 lastStepPosition; // 0xDC

	// Properties
	public bool isStepping { get; }
	public Vector3 position { get; set; }

	// Methods

	// RVA: 0x26CC640 Offset: 0x26CC741 VA: 0x26CC640
	public bool get_isStepping() { }

	// RVA: 0x26CC1D0 Offset: 0x26CC2D1 VA: 0x26CC1D0
	public Vector3 get_position() { }

	// RVA: 0x26CC660 Offset: 0x26CC761 VA: 0x26CC660
	public void set_position(Vector3 value) { }

	// RVA: 0x26CC6B0 Offset: 0x26CC7B1 VA: 0x26CC6B0
	private void Awake() { }

	// RVA: 0x26CC940 Offset: 0x26CCA41 VA: 0x26CC940
	private void AfterIK() { }

	// RVA: 0x26CCB60 Offset: 0x26CCC61 VA: 0x26CCB60
	private void Start() { }

	// RVA: 0x26CCF30 Offset: 0x26CD031 VA: 0x26CCF30
	private Vector3 GetStepTarget(out bool stepFound, float focus, float distance) { }

	// RVA: 0x26CD330 Offset: 0x26CD431 VA: 0x26CD330
	private void UpdatePosition(float distance) { }

	// RVA: 0x26CD5A0 Offset: 0x26CD6A1 VA: 0x26CD5A0
	private void Update() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A9F80 Offset: 0x1AA081 VA: 0x1A9F80
	// RVA: 0x26CCE60 Offset: 0x26CCF61 VA: 0x26CCE60
	private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition) { }

	// RVA: 0x26CD8A0 Offset: 0x26CD9A1 VA: 0x26CD8A0
	public void .ctor() { }
}

public class MechSpiderLeg : MonoBehaviour // TypeDefIndex: 9338
{
	// Fields
	public MechSpider mechSpider; // 0x18
	public MechSpiderLeg unSync; // 0x20
	public Vector3 offset; // 0x28
	public float minDelay; // 0x34
	public float maxOffset; // 0x38
	public float stepSpeed; // 0x3C
	public float footHeight; // 0x40
	public float velocityPrediction; // 0x44
	public float raycastFocus; // 0x48
	public AnimationCurve yOffset; // 0x50
	public Transform foot; // 0x58
	public Vector3 footUpAxis; // 0x60
	public float footRotationSpeed; // 0x6C
	public ParticleSystem sand; // 0x70
	private IK ik; // 0x78
	private float stepProgress; // 0x80
	private float lastStepTime; // 0x84
	private Vector3 defaultPosition; // 0x88
	private RaycastHit hit; // 0x94
	private Quaternion lastFootLocalRotation; // 0xC0
	private Vector3 smoothHitNormal; // 0xD0
	private Vector3 lastStepPosition; // 0xDC

	// Properties
	public bool isStepping { get; }
	public Vector3 position { get; set; }

	// Methods

	// RVA: 0x26CC640 Offset: 0x26CC741 VA: 0x26CC640
	public bool get_isStepping() { }

	// RVA: 0x26CC1D0 Offset: 0x26CC2D1 VA: 0x26CC1D0
	public Vector3 get_position() { }

	// RVA: 0x26CC660 Offset: 0x26CC761 VA: 0x26CC660
	public void set_position(Vector3 value) { }

	// RVA: 0x26CC6B0 Offset: 0x26CC7B1 VA: 0x26CC6B0
	private void Awake() { }

	// RVA: 0x26CC940 Offset: 0x26CCA41 VA: 0x26CC940
	private void AfterIK() { }

	// RVA: 0x26CCB60 Offset: 0x26CCC61 VA: 0x26CCB60
	private void Start() { }

	// RVA: 0x26CCF30 Offset: 0x26CD031 VA: 0x26CCF30
	private Vector3 GetStepTarget(out bool stepFound, float focus, float distance) { }

	// RVA: 0x26CD330 Offset: 0x26CD431 VA: 0x26CD330
	private void UpdatePosition(float distance) { }

	// RVA: 0x26CD5A0 Offset: 0x26CD6A1 VA: 0x26CD5A0
	private void Update() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A9F80 Offset: 0x1AA081 VA: 0x1A9F80
	// RVA: 0x26CCE60 Offset: 0x26CCF61 VA: 0x26CCE60
	private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition) { }

	// RVA: 0x26CD8A0 Offset: 0x26CD9A1 VA: 0x26CD8A0
	public void .ctor() { }
}

public class MechSpiderLeg : MonoBehaviour // TypeDefIndex: 9338
{
	// Fields
	public MechSpider mechSpider; // 0x18
	public MechSpiderLeg unSync; // 0x20
	public Vector3 offset; // 0x28
	public float minDelay; // 0x34
	public float maxOffset; // 0x38
	public float stepSpeed; // 0x3C
	public float footHeight; // 0x40
	public float velocityPrediction; // 0x44
	public float raycastFocus; // 0x48
	public AnimationCurve yOffset; // 0x50
	public Transform foot; // 0x58
	public Vector3 footUpAxis; // 0x60
	public float footRotationSpeed; // 0x6C
	public ParticleSystem sand; // 0x70
	private IK ik; // 0x78
	private float stepProgress; // 0x80
	private float lastStepTime; // 0x84
	private Vector3 defaultPosition; // 0x88
	private RaycastHit hit; // 0x94
	private Quaternion lastFootLocalRotation; // 0xC0
	private Vector3 smoothHitNormal; // 0xD0
	private Vector3 lastStepPosition; // 0xDC

	// Properties
	public bool isStepping { get; }
	public Vector3 position { get; set; }

	// Methods

	// RVA: 0x26CC640 Offset: 0x26CC741 VA: 0x26CC640
	public bool get_isStepping() { }

	// RVA: 0x26CC1D0 Offset: 0x26CC2D1 VA: 0x26CC1D0
	public Vector3 get_position() { }

	// RVA: 0x26CC660 Offset: 0x26CC761 VA: 0x26CC660
	public void set_position(Vector3 value) { }

	// RVA: 0x26CC6B0 Offset: 0x26CC7B1 VA: 0x26CC6B0
	private void Awake() { }

	// RVA: 0x26CC940 Offset: 0x26CCA41 VA: 0x26CC940
	private void AfterIK() { }

	// RVA: 0x26CCB60 Offset: 0x26CCC61 VA: 0x26CCB60
	private void Start() { }

	// RVA: 0x26CCF30 Offset: 0x26CD031 VA: 0x26CCF30
	private Vector3 GetStepTarget(out bool stepFound, float focus, float distance) { }

	// RVA: 0x26CD330 Offset: 0x26CD431 VA: 0x26CD330
	private void UpdatePosition(float distance) { }

	// RVA: 0x26CD5A0 Offset: 0x26CD6A1 VA: 0x26CD5A0
	private void Update() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A9F80 Offset: 0x1AA081 VA: 0x1A9F80
	// RVA: 0x26CCE60 Offset: 0x26CCF61 VA: 0x26CCE60
	private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition) { }

	// RVA: 0x26CD8A0 Offset: 0x26CD9A1 VA: 0x26CD8A0
	public void .ctor() { }
}

public class MechSpiderLeg : MonoBehaviour // TypeDefIndex: 9338
{
	// Fields
	public MechSpider mechSpider; // 0x18
	public MechSpiderLeg unSync; // 0x20
	public Vector3 offset; // 0x28
	public float minDelay; // 0x34
	public float maxOffset; // 0x38
	public float stepSpeed; // 0x3C
	public float footHeight; // 0x40
	public float velocityPrediction; // 0x44
	public float raycastFocus; // 0x48
	public AnimationCurve yOffset; // 0x50
	public Transform foot; // 0x58
	public Vector3 footUpAxis; // 0x60
	public float footRotationSpeed; // 0x6C
	public ParticleSystem sand; // 0x70
	private IK ik; // 0x78
	private float stepProgress; // 0x80
	private float lastStepTime; // 0x84
	private Vector3 defaultPosition; // 0x88
	private RaycastHit hit; // 0x94
	private Quaternion lastFootLocalRotation; // 0xC0
	private Vector3 smoothHitNormal; // 0xD0
	private Vector3 lastStepPosition; // 0xDC

	// Properties
	public bool isStepping { get; }
	public Vector3 position { get; set; }

	// Methods

	// RVA: 0x26CC640 Offset: 0x26CC741 VA: 0x26CC640
	public bool get_isStepping() { }

	// RVA: 0x26CC1D0 Offset: 0x26CC2D1 VA: 0x26CC1D0
	public Vector3 get_position() { }

	// RVA: 0x26CC660 Offset: 0x26CC761 VA: 0x26CC660
	public void set_position(Vector3 value) { }

	// RVA: 0x26CC6B0 Offset: 0x26CC7B1 VA: 0x26CC6B0
	private void Awake() { }

	// RVA: 0x26CC940 Offset: 0x26CCA41 VA: 0x26CC940
	private void AfterIK() { }

	// RVA: 0x26CCB60 Offset: 0x26CCC61 VA: 0x26CCB60
	private void Start() { }

	// RVA: 0x26CCF30 Offset: 0x26CD031 VA: 0x26CCF30
	private Vector3 GetStepTarget(out bool stepFound, float focus, float distance) { }

	// RVA: 0x26CD330 Offset: 0x26CD431 VA: 0x26CD330
	private void UpdatePosition(float distance) { }

	// RVA: 0x26CD5A0 Offset: 0x26CD6A1 VA: 0x26CD5A0
	private void Update() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A9F80 Offset: 0x1AA081 VA: 0x1A9F80
	// RVA: 0x26CCE60 Offset: 0x26CCF61 VA: 0x26CCE60
	private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition) { }

	// RVA: 0x26CD8A0 Offset: 0x26CD9A1 VA: 0x26CD8A0
	public void .ctor() { }
}

