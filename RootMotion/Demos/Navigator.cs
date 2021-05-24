[Serializable]
public class Navigator // TypeDefIndex: 9410
{
	// Fields
	[TooltipAttribute] // RVA: 0x178D30 Offset: 0x178E31 VA: 0x178D30
	public bool activeTargetSeeking; // 0x10
	[TooltipAttribute] // RVA: 0x178D70 Offset: 0x178E71 VA: 0x178D70
	public float cornerRadius; // 0x14
	[TooltipAttribute] // RVA: 0x178DB0 Offset: 0x178EB1 VA: 0x178DB0
	public float recalculateOnPathDistance; // 0x18
	[TooltipAttribute] // RVA: 0x178DF0 Offset: 0x178EF1 VA: 0x178DF0
	public float maxSampleDistance; // 0x1C
	[TooltipAttribute] // RVA: 0x178E30 Offset: 0x178F31 VA: 0x178E30
	public float nextPathInterval; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x178E70 Offset: 0x178F71 VA: 0x178E70
	private Vector3 <normalizedDeltaPosition>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x178E80 Offset: 0x178F81 VA: 0x178E80
	private Navigator.State <state>k__BackingField; // 0x30
	private Transform transform; // 0x38
	private int cornerIndex; // 0x40
	private Vector3[] corners; // 0x48
	private NavMeshPath path; // 0x50
	private Vector3 lastTargetPosition; // 0x58
	private bool initiated; // 0x64
	private float nextPathTime; // 0x68

	// Properties
	public Vector3 normalizedDeltaPosition { get; set; }
	public Navigator.State state { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AA1F0 Offset: 0x1AA2F1 VA: 0x1AA1F0
	// RVA: 0x2725BE0 Offset: 0x2725CE1 VA: 0x2725BE0
	public Vector3 get_normalizedDeltaPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA200 Offset: 0x1AA301 VA: 0x1AA200
	// RVA: 0x2725BF0 Offset: 0x2725CF1 VA: 0x2725BF0
	private void set_normalizedDeltaPosition(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA210 Offset: 0x1AA311 VA: 0x1AA210
	// RVA: 0x2725C00 Offset: 0x2725D01 VA: 0x2725C00
	public Navigator.State get_state() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA220 Offset: 0x1AA321 VA: 0x1AA220
	// RVA: 0x2725C10 Offset: 0x2725D11 VA: 0x2725C10
	private void set_state(Navigator.State value) { }

	// RVA: 0x2725C20 Offset: 0x2725D21 VA: 0x2725C20
	public void Initiate(Transform transform) { }

	// RVA: 0x2725D20 Offset: 0x2725E21 VA: 0x2725D20
	public void Update(Vector3 targetPosition) { }

	// RVA: 0x2726330 Offset: 0x2726431 VA: 0x2726330
	private void CalculatePath(Vector3 targetPosition) { }

	// RVA: 0x2726400 Offset: 0x2726501 VA: 0x2726400
	private bool Find(Vector3 targetPosition) { }

	// RVA: 0x27261E0 Offset: 0x27262E1 VA: 0x27261E0
	private void Stop() { }

	// RVA: 0x2726260 Offset: 0x2726361 VA: 0x2726260
	private float HorDistance(Vector3 p1, Vector3 p2) { }

	// RVA: 0x2726540 Offset: 0x2726641 VA: 0x2726540
	public void Visualize() { }

	// RVA: 0x2726710 Offset: 0x2726811 VA: 0x2726710
	public void .ctor() { }
}

[Serializable]
public class Navigator // TypeDefIndex: 9410
{
	// Fields
	[TooltipAttribute] // RVA: 0x178D30 Offset: 0x178E31 VA: 0x178D30
	public bool activeTargetSeeking; // 0x10
	[TooltipAttribute] // RVA: 0x178D70 Offset: 0x178E71 VA: 0x178D70
	public float cornerRadius; // 0x14
	[TooltipAttribute] // RVA: 0x178DB0 Offset: 0x178EB1 VA: 0x178DB0
	public float recalculateOnPathDistance; // 0x18
	[TooltipAttribute] // RVA: 0x178DF0 Offset: 0x178EF1 VA: 0x178DF0
	public float maxSampleDistance; // 0x1C
	[TooltipAttribute] // RVA: 0x178E30 Offset: 0x178F31 VA: 0x178E30
	public float nextPathInterval; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x178E70 Offset: 0x178F71 VA: 0x178E70
	private Vector3 <normalizedDeltaPosition>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x178E80 Offset: 0x178F81 VA: 0x178E80
	private Navigator.State <state>k__BackingField; // 0x30
	private Transform transform; // 0x38
	private int cornerIndex; // 0x40
	private Vector3[] corners; // 0x48
	private NavMeshPath path; // 0x50
	private Vector3 lastTargetPosition; // 0x58
	private bool initiated; // 0x64
	private float nextPathTime; // 0x68

	// Properties
	public Vector3 normalizedDeltaPosition { get; set; }
	public Navigator.State state { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AA1F0 Offset: 0x1AA2F1 VA: 0x1AA1F0
	// RVA: 0x2725BE0 Offset: 0x2725CE1 VA: 0x2725BE0
	public Vector3 get_normalizedDeltaPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA200 Offset: 0x1AA301 VA: 0x1AA200
	// RVA: 0x2725BF0 Offset: 0x2725CF1 VA: 0x2725BF0
	private void set_normalizedDeltaPosition(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA210 Offset: 0x1AA311 VA: 0x1AA210
	// RVA: 0x2725C00 Offset: 0x2725D01 VA: 0x2725C00
	public Navigator.State get_state() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA220 Offset: 0x1AA321 VA: 0x1AA220
	// RVA: 0x2725C10 Offset: 0x2725D11 VA: 0x2725C10
	private void set_state(Navigator.State value) { }

	// RVA: 0x2725C20 Offset: 0x2725D21 VA: 0x2725C20
	public void Initiate(Transform transform) { }

	// RVA: 0x2725D20 Offset: 0x2725E21 VA: 0x2725D20
	public void Update(Vector3 targetPosition) { }

	// RVA: 0x2726330 Offset: 0x2726431 VA: 0x2726330
	private void CalculatePath(Vector3 targetPosition) { }

	// RVA: 0x2726400 Offset: 0x2726501 VA: 0x2726400
	private bool Find(Vector3 targetPosition) { }

	// RVA: 0x27261E0 Offset: 0x27262E1 VA: 0x27261E0
	private void Stop() { }

	// RVA: 0x2726260 Offset: 0x2726361 VA: 0x2726260
	private float HorDistance(Vector3 p1, Vector3 p2) { }

	// RVA: 0x2726540 Offset: 0x2726641 VA: 0x2726540
	public void Visualize() { }

	// RVA: 0x2726710 Offset: 0x2726811 VA: 0x2726710
	public void .ctor() { }
}

[Serializable]
public class Navigator // TypeDefIndex: 9410
{
	// Fields
	[TooltipAttribute] // RVA: 0x178D30 Offset: 0x178E31 VA: 0x178D30
	public bool activeTargetSeeking; // 0x10
	[TooltipAttribute] // RVA: 0x178D70 Offset: 0x178E71 VA: 0x178D70
	public float cornerRadius; // 0x14
	[TooltipAttribute] // RVA: 0x178DB0 Offset: 0x178EB1 VA: 0x178DB0
	public float recalculateOnPathDistance; // 0x18
	[TooltipAttribute] // RVA: 0x178DF0 Offset: 0x178EF1 VA: 0x178DF0
	public float maxSampleDistance; // 0x1C
	[TooltipAttribute] // RVA: 0x178E30 Offset: 0x178F31 VA: 0x178E30
	public float nextPathInterval; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x178E70 Offset: 0x178F71 VA: 0x178E70
	private Vector3 <normalizedDeltaPosition>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x178E80 Offset: 0x178F81 VA: 0x178E80
	private Navigator.State <state>k__BackingField; // 0x30
	private Transform transform; // 0x38
	private int cornerIndex; // 0x40
	private Vector3[] corners; // 0x48
	private NavMeshPath path; // 0x50
	private Vector3 lastTargetPosition; // 0x58
	private bool initiated; // 0x64
	private float nextPathTime; // 0x68

	// Properties
	public Vector3 normalizedDeltaPosition { get; set; }
	public Navigator.State state { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AA1F0 Offset: 0x1AA2F1 VA: 0x1AA1F0
	// RVA: 0x2725BE0 Offset: 0x2725CE1 VA: 0x2725BE0
	public Vector3 get_normalizedDeltaPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA200 Offset: 0x1AA301 VA: 0x1AA200
	// RVA: 0x2725BF0 Offset: 0x2725CF1 VA: 0x2725BF0
	private void set_normalizedDeltaPosition(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA210 Offset: 0x1AA311 VA: 0x1AA210
	// RVA: 0x2725C00 Offset: 0x2725D01 VA: 0x2725C00
	public Navigator.State get_state() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA220 Offset: 0x1AA321 VA: 0x1AA220
	// RVA: 0x2725C10 Offset: 0x2725D11 VA: 0x2725C10
	private void set_state(Navigator.State value) { }

	// RVA: 0x2725C20 Offset: 0x2725D21 VA: 0x2725C20
	public void Initiate(Transform transform) { }

	// RVA: 0x2725D20 Offset: 0x2725E21 VA: 0x2725D20
	public void Update(Vector3 targetPosition) { }

	// RVA: 0x2726330 Offset: 0x2726431 VA: 0x2726330
	private void CalculatePath(Vector3 targetPosition) { }

	// RVA: 0x2726400 Offset: 0x2726501 VA: 0x2726400
	private bool Find(Vector3 targetPosition) { }

	// RVA: 0x27261E0 Offset: 0x27262E1 VA: 0x27261E0
	private void Stop() { }

	// RVA: 0x2726260 Offset: 0x2726361 VA: 0x2726260
	private float HorDistance(Vector3 p1, Vector3 p2) { }

	// RVA: 0x2726540 Offset: 0x2726641 VA: 0x2726540
	public void Visualize() { }

	// RVA: 0x2726710 Offset: 0x2726811 VA: 0x2726710
	public void .ctor() { }
}

[Serializable]
public class Navigator // TypeDefIndex: 9410
{
	// Fields
	[TooltipAttribute] // RVA: 0x178D30 Offset: 0x178E31 VA: 0x178D30
	public bool activeTargetSeeking; // 0x10
	[TooltipAttribute] // RVA: 0x178D70 Offset: 0x178E71 VA: 0x178D70
	public float cornerRadius; // 0x14
	[TooltipAttribute] // RVA: 0x178DB0 Offset: 0x178EB1 VA: 0x178DB0
	public float recalculateOnPathDistance; // 0x18
	[TooltipAttribute] // RVA: 0x178DF0 Offset: 0x178EF1 VA: 0x178DF0
	public float maxSampleDistance; // 0x1C
	[TooltipAttribute] // RVA: 0x178E30 Offset: 0x178F31 VA: 0x178E30
	public float nextPathInterval; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x178E70 Offset: 0x178F71 VA: 0x178E70
	private Vector3 <normalizedDeltaPosition>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x178E80 Offset: 0x178F81 VA: 0x178E80
	private Navigator.State <state>k__BackingField; // 0x30
	private Transform transform; // 0x38
	private int cornerIndex; // 0x40
	private Vector3[] corners; // 0x48
	private NavMeshPath path; // 0x50
	private Vector3 lastTargetPosition; // 0x58
	private bool initiated; // 0x64
	private float nextPathTime; // 0x68

	// Properties
	public Vector3 normalizedDeltaPosition { get; set; }
	public Navigator.State state { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AA1F0 Offset: 0x1AA2F1 VA: 0x1AA1F0
	// RVA: 0x2725BE0 Offset: 0x2725CE1 VA: 0x2725BE0
	public Vector3 get_normalizedDeltaPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA200 Offset: 0x1AA301 VA: 0x1AA200
	// RVA: 0x2725BF0 Offset: 0x2725CF1 VA: 0x2725BF0
	private void set_normalizedDeltaPosition(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA210 Offset: 0x1AA311 VA: 0x1AA210
	// RVA: 0x2725C00 Offset: 0x2725D01 VA: 0x2725C00
	public Navigator.State get_state() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA220 Offset: 0x1AA321 VA: 0x1AA220
	// RVA: 0x2725C10 Offset: 0x2725D11 VA: 0x2725C10
	private void set_state(Navigator.State value) { }

	// RVA: 0x2725C20 Offset: 0x2725D21 VA: 0x2725C20
	public void Initiate(Transform transform) { }

	// RVA: 0x2725D20 Offset: 0x2725E21 VA: 0x2725D20
	public void Update(Vector3 targetPosition) { }

	// RVA: 0x2726330 Offset: 0x2726431 VA: 0x2726330
	private void CalculatePath(Vector3 targetPosition) { }

	// RVA: 0x2726400 Offset: 0x2726501 VA: 0x2726400
	private bool Find(Vector3 targetPosition) { }

	// RVA: 0x27261E0 Offset: 0x27262E1 VA: 0x27261E0
	private void Stop() { }

	// RVA: 0x2726260 Offset: 0x2726361 VA: 0x2726260
	private float HorDistance(Vector3 p1, Vector3 p2) { }

	// RVA: 0x2726540 Offset: 0x2726641 VA: 0x2726540
	public void Visualize() { }

	// RVA: 0x2726710 Offset: 0x2726811 VA: 0x2726710
	public void .ctor() { }
}

[Serializable]
public class Navigator // TypeDefIndex: 9410
{
	// Fields
	[TooltipAttribute] // RVA: 0x178D30 Offset: 0x178E31 VA: 0x178D30
	public bool activeTargetSeeking; // 0x10
	[TooltipAttribute] // RVA: 0x178D70 Offset: 0x178E71 VA: 0x178D70
	public float cornerRadius; // 0x14
	[TooltipAttribute] // RVA: 0x178DB0 Offset: 0x178EB1 VA: 0x178DB0
	public float recalculateOnPathDistance; // 0x18
	[TooltipAttribute] // RVA: 0x178DF0 Offset: 0x178EF1 VA: 0x178DF0
	public float maxSampleDistance; // 0x1C
	[TooltipAttribute] // RVA: 0x178E30 Offset: 0x178F31 VA: 0x178E30
	public float nextPathInterval; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x178E70 Offset: 0x178F71 VA: 0x178E70
	private Vector3 <normalizedDeltaPosition>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x178E80 Offset: 0x178F81 VA: 0x178E80
	private Navigator.State <state>k__BackingField; // 0x30
	private Transform transform; // 0x38
	private int cornerIndex; // 0x40
	private Vector3[] corners; // 0x48
	private NavMeshPath path; // 0x50
	private Vector3 lastTargetPosition; // 0x58
	private bool initiated; // 0x64
	private float nextPathTime; // 0x68

	// Properties
	public Vector3 normalizedDeltaPosition { get; set; }
	public Navigator.State state { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AA1F0 Offset: 0x1AA2F1 VA: 0x1AA1F0
	// RVA: 0x2725BE0 Offset: 0x2725CE1 VA: 0x2725BE0
	public Vector3 get_normalizedDeltaPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA200 Offset: 0x1AA301 VA: 0x1AA200
	// RVA: 0x2725BF0 Offset: 0x2725CF1 VA: 0x2725BF0
	private void set_normalizedDeltaPosition(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA210 Offset: 0x1AA311 VA: 0x1AA210
	// RVA: 0x2725C00 Offset: 0x2725D01 VA: 0x2725C00
	public Navigator.State get_state() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA220 Offset: 0x1AA321 VA: 0x1AA220
	// RVA: 0x2725C10 Offset: 0x2725D11 VA: 0x2725C10
	private void set_state(Navigator.State value) { }

	// RVA: 0x2725C20 Offset: 0x2725D21 VA: 0x2725C20
	public void Initiate(Transform transform) { }

	// RVA: 0x2725D20 Offset: 0x2725E21 VA: 0x2725D20
	public void Update(Vector3 targetPosition) { }

	// RVA: 0x2726330 Offset: 0x2726431 VA: 0x2726330
	private void CalculatePath(Vector3 targetPosition) { }

	// RVA: 0x2726400 Offset: 0x2726501 VA: 0x2726400
	private bool Find(Vector3 targetPosition) { }

	// RVA: 0x27261E0 Offset: 0x27262E1 VA: 0x27261E0
	private void Stop() { }

	// RVA: 0x2726260 Offset: 0x2726361 VA: 0x2726260
	private float HorDistance(Vector3 p1, Vector3 p2) { }

	// RVA: 0x2726540 Offset: 0x2726641 VA: 0x2726540
	public void Visualize() { }

	// RVA: 0x2726710 Offset: 0x2726811 VA: 0x2726710
	public void .ctor() { }
}

