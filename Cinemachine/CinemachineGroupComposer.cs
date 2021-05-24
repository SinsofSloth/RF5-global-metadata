[DocumentationSortingAttribute] // RVA: 0x12EA40 Offset: 0x12EB41 VA: 0x12EA40
[AddComponentMenu] // RVA: 0x12EA40 Offset: 0x12EB41 VA: 0x12EA40
[SaveDuringPlayAttribute] // RVA: 0x12EA40 Offset: 0x12EB41 VA: 0x12EA40
public class CinemachineGroupComposer : CinemachineComposer // TypeDefIndex: 4789
{
	// Fields
	[SpaceAttribute] // RVA: 0x133100 Offset: 0x133201 VA: 0x133100
	[TooltipAttribute] // RVA: 0x133100 Offset: 0x133201 VA: 0x133100
	public float m_GroupFramingSize; // 0x128
	[TooltipAttribute] // RVA: 0x133150 Offset: 0x133251 VA: 0x133150
	public CinemachineGroupComposer.FramingMode m_FramingMode; // 0x12C
	[RangeAttribute] // RVA: 0x133190 Offset: 0x133291 VA: 0x133190
	[TooltipAttribute] // RVA: 0x133190 Offset: 0x133291 VA: 0x133190
	public float m_FrameDamping; // 0x130
	[TooltipAttribute] // RVA: 0x1331F0 Offset: 0x1332F1 VA: 0x1331F0
	public CinemachineGroupComposer.AdjustmentMode m_AdjustmentMode; // 0x134
	[TooltipAttribute] // RVA: 0x133230 Offset: 0x133331 VA: 0x133230
	public float m_MaxDollyIn; // 0x138
	[TooltipAttribute] // RVA: 0x133270 Offset: 0x133371 VA: 0x133270
	public float m_MaxDollyOut; // 0x13C
	[TooltipAttribute] // RVA: 0x1332B0 Offset: 0x1333B1 VA: 0x1332B0
	public float m_MinimumDistance; // 0x140
	[TooltipAttribute] // RVA: 0x1332F0 Offset: 0x1333F1 VA: 0x1332F0
	public float m_MaximumDistance; // 0x144
	[RangeAttribute] // RVA: 0x133330 Offset: 0x133431 VA: 0x133330
	[TooltipAttribute] // RVA: 0x133330 Offset: 0x133431 VA: 0x133330
	public float m_MinimumFOV; // 0x148
	[RangeAttribute] // RVA: 0x133390 Offset: 0x133491 VA: 0x133390
	[TooltipAttribute] // RVA: 0x133390 Offset: 0x133491 VA: 0x133390
	public float m_MaximumFOV; // 0x14C
	[TooltipAttribute] // RVA: 0x1333F0 Offset: 0x1334F1 VA: 0x1333F0
	public float m_MinimumOrthoSize; // 0x150
	[TooltipAttribute] // RVA: 0x133430 Offset: 0x133531 VA: 0x133430
	public float m_MaximumOrthoSize; // 0x154
	private float m_prevFramingDistance; // 0x158
	private float m_prevFOV; // 0x15C
	[CompilerGeneratedAttribute] // RVA: 0x133470 Offset: 0x133571 VA: 0x133470
	private Bounds <LastBounds>k__BackingField; // 0x160
	[CompilerGeneratedAttribute] // RVA: 0x133480 Offset: 0x133581 VA: 0x133480
	private Matrix4x4 <LastBoundsMatrix>k__BackingField; // 0x178

	// Properties
	public Bounds LastBounds { get; set; }
	public Matrix4x4 LastBoundsMatrix { get; set; }

	// Methods

	// RVA: 0x1729D10 Offset: 0x1729E11 VA: 0x1729D10
	private void OnValidate() { }

	[CompilerGeneratedAttribute] // RVA: 0x136D20 Offset: 0x136E21 VA: 0x136D20
	// RVA: 0x1729E40 Offset: 0x1729F41 VA: 0x1729E40
	public Bounds get_LastBounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x136D30 Offset: 0x136E31 VA: 0x136D30
	// RVA: 0x1729E60 Offset: 0x1729F61 VA: 0x1729E60
	private void set_LastBounds(Bounds value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136D40 Offset: 0x136E41 VA: 0x136D40
	// RVA: 0x1729E80 Offset: 0x1729F81 VA: 0x1729E80
	public Matrix4x4 get_LastBoundsMatrix() { }

	[CompilerGeneratedAttribute] // RVA: 0x136D50 Offset: 0x136E51 VA: 0x136D50
	// RVA: 0x1729EB0 Offset: 0x1729FB1 VA: 0x1729EB0
	private void set_LastBoundsMatrix(Matrix4x4 value) { }

	// RVA: 0x1729ED0 Offset: 0x1729FD1 VA: 0x1729ED0 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0x1729F60 Offset: 0x172A061 VA: 0x1729F60 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x172B0E0 Offset: 0x172B1E1 VA: 0x172B0E0
	private float GetTargetHeight(Vector2 boundsSize) { }

	// RVA: 0x172AD20 Offset: 0x172AE21 VA: 0x172AD20
	private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, Matrix4x4 observer, out Vector3 newFwd) { }

	// RVA: 0x172B2B0 Offset: 0x172B3B1 VA: 0x172B2B0
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12EA40 Offset: 0x12EB41 VA: 0x12EA40
[AddComponentMenu] // RVA: 0x12EA40 Offset: 0x12EB41 VA: 0x12EA40
[SaveDuringPlayAttribute] // RVA: 0x12EA40 Offset: 0x12EB41 VA: 0x12EA40
public class CinemachineGroupComposer : CinemachineComposer // TypeDefIndex: 4789
{
	// Fields
	[SpaceAttribute] // RVA: 0x133100 Offset: 0x133201 VA: 0x133100
	[TooltipAttribute] // RVA: 0x133100 Offset: 0x133201 VA: 0x133100
	public float m_GroupFramingSize; // 0x128
	[TooltipAttribute] // RVA: 0x133150 Offset: 0x133251 VA: 0x133150
	public CinemachineGroupComposer.FramingMode m_FramingMode; // 0x12C
	[RangeAttribute] // RVA: 0x133190 Offset: 0x133291 VA: 0x133190
	[TooltipAttribute] // RVA: 0x133190 Offset: 0x133291 VA: 0x133190
	public float m_FrameDamping; // 0x130
	[TooltipAttribute] // RVA: 0x1331F0 Offset: 0x1332F1 VA: 0x1331F0
	public CinemachineGroupComposer.AdjustmentMode m_AdjustmentMode; // 0x134
	[TooltipAttribute] // RVA: 0x133230 Offset: 0x133331 VA: 0x133230
	public float m_MaxDollyIn; // 0x138
	[TooltipAttribute] // RVA: 0x133270 Offset: 0x133371 VA: 0x133270
	public float m_MaxDollyOut; // 0x13C
	[TooltipAttribute] // RVA: 0x1332B0 Offset: 0x1333B1 VA: 0x1332B0
	public float m_MinimumDistance; // 0x140
	[TooltipAttribute] // RVA: 0x1332F0 Offset: 0x1333F1 VA: 0x1332F0
	public float m_MaximumDistance; // 0x144
	[RangeAttribute] // RVA: 0x133330 Offset: 0x133431 VA: 0x133330
	[TooltipAttribute] // RVA: 0x133330 Offset: 0x133431 VA: 0x133330
	public float m_MinimumFOV; // 0x148
	[RangeAttribute] // RVA: 0x133390 Offset: 0x133491 VA: 0x133390
	[TooltipAttribute] // RVA: 0x133390 Offset: 0x133491 VA: 0x133390
	public float m_MaximumFOV; // 0x14C
	[TooltipAttribute] // RVA: 0x1333F0 Offset: 0x1334F1 VA: 0x1333F0
	public float m_MinimumOrthoSize; // 0x150
	[TooltipAttribute] // RVA: 0x133430 Offset: 0x133531 VA: 0x133430
	public float m_MaximumOrthoSize; // 0x154
	private float m_prevFramingDistance; // 0x158
	private float m_prevFOV; // 0x15C
	[CompilerGeneratedAttribute] // RVA: 0x133470 Offset: 0x133571 VA: 0x133470
	private Bounds <LastBounds>k__BackingField; // 0x160
	[CompilerGeneratedAttribute] // RVA: 0x133480 Offset: 0x133581 VA: 0x133480
	private Matrix4x4 <LastBoundsMatrix>k__BackingField; // 0x178

	// Properties
	public Bounds LastBounds { get; set; }
	public Matrix4x4 LastBoundsMatrix { get; set; }

	// Methods

	// RVA: 0x1729D10 Offset: 0x1729E11 VA: 0x1729D10
	private void OnValidate() { }

	[CompilerGeneratedAttribute] // RVA: 0x136D20 Offset: 0x136E21 VA: 0x136D20
	// RVA: 0x1729E40 Offset: 0x1729F41 VA: 0x1729E40
	public Bounds get_LastBounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x136D30 Offset: 0x136E31 VA: 0x136D30
	// RVA: 0x1729E60 Offset: 0x1729F61 VA: 0x1729E60
	private void set_LastBounds(Bounds value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136D40 Offset: 0x136E41 VA: 0x136D40
	// RVA: 0x1729E80 Offset: 0x1729F81 VA: 0x1729E80
	public Matrix4x4 get_LastBoundsMatrix() { }

	[CompilerGeneratedAttribute] // RVA: 0x136D50 Offset: 0x136E51 VA: 0x136D50
	// RVA: 0x1729EB0 Offset: 0x1729FB1 VA: 0x1729EB0
	private void set_LastBoundsMatrix(Matrix4x4 value) { }

	// RVA: 0x1729ED0 Offset: 0x1729FD1 VA: 0x1729ED0 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0x1729F60 Offset: 0x172A061 VA: 0x1729F60 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x172B0E0 Offset: 0x172B1E1 VA: 0x172B0E0
	private float GetTargetHeight(Vector2 boundsSize) { }

	// RVA: 0x172AD20 Offset: 0x172AE21 VA: 0x172AD20
	private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, Matrix4x4 observer, out Vector3 newFwd) { }

	// RVA: 0x172B2B0 Offset: 0x172B3B1 VA: 0x172B2B0
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12EA40 Offset: 0x12EB41 VA: 0x12EA40
[AddComponentMenu] // RVA: 0x12EA40 Offset: 0x12EB41 VA: 0x12EA40
[SaveDuringPlayAttribute] // RVA: 0x12EA40 Offset: 0x12EB41 VA: 0x12EA40
public class CinemachineGroupComposer : CinemachineComposer // TypeDefIndex: 4789
{
	// Fields
	[SpaceAttribute] // RVA: 0x133100 Offset: 0x133201 VA: 0x133100
	[TooltipAttribute] // RVA: 0x133100 Offset: 0x133201 VA: 0x133100
	public float m_GroupFramingSize; // 0x128
	[TooltipAttribute] // RVA: 0x133150 Offset: 0x133251 VA: 0x133150
	public CinemachineGroupComposer.FramingMode m_FramingMode; // 0x12C
	[RangeAttribute] // RVA: 0x133190 Offset: 0x133291 VA: 0x133190
	[TooltipAttribute] // RVA: 0x133190 Offset: 0x133291 VA: 0x133190
	public float m_FrameDamping; // 0x130
	[TooltipAttribute] // RVA: 0x1331F0 Offset: 0x1332F1 VA: 0x1331F0
	public CinemachineGroupComposer.AdjustmentMode m_AdjustmentMode; // 0x134
	[TooltipAttribute] // RVA: 0x133230 Offset: 0x133331 VA: 0x133230
	public float m_MaxDollyIn; // 0x138
	[TooltipAttribute] // RVA: 0x133270 Offset: 0x133371 VA: 0x133270
	public float m_MaxDollyOut; // 0x13C
	[TooltipAttribute] // RVA: 0x1332B0 Offset: 0x1333B1 VA: 0x1332B0
	public float m_MinimumDistance; // 0x140
	[TooltipAttribute] // RVA: 0x1332F0 Offset: 0x1333F1 VA: 0x1332F0
	public float m_MaximumDistance; // 0x144
	[RangeAttribute] // RVA: 0x133330 Offset: 0x133431 VA: 0x133330
	[TooltipAttribute] // RVA: 0x133330 Offset: 0x133431 VA: 0x133330
	public float m_MinimumFOV; // 0x148
	[RangeAttribute] // RVA: 0x133390 Offset: 0x133491 VA: 0x133390
	[TooltipAttribute] // RVA: 0x133390 Offset: 0x133491 VA: 0x133390
	public float m_MaximumFOV; // 0x14C
	[TooltipAttribute] // RVA: 0x1333F0 Offset: 0x1334F1 VA: 0x1333F0
	public float m_MinimumOrthoSize; // 0x150
	[TooltipAttribute] // RVA: 0x133430 Offset: 0x133531 VA: 0x133430
	public float m_MaximumOrthoSize; // 0x154
	private float m_prevFramingDistance; // 0x158
	private float m_prevFOV; // 0x15C
	[CompilerGeneratedAttribute] // RVA: 0x133470 Offset: 0x133571 VA: 0x133470
	private Bounds <LastBounds>k__BackingField; // 0x160
	[CompilerGeneratedAttribute] // RVA: 0x133480 Offset: 0x133581 VA: 0x133480
	private Matrix4x4 <LastBoundsMatrix>k__BackingField; // 0x178

	// Properties
	public Bounds LastBounds { get; set; }
	public Matrix4x4 LastBoundsMatrix { get; set; }

	// Methods

	// RVA: 0x1729D10 Offset: 0x1729E11 VA: 0x1729D10
	private void OnValidate() { }

	[CompilerGeneratedAttribute] // RVA: 0x136D20 Offset: 0x136E21 VA: 0x136D20
	// RVA: 0x1729E40 Offset: 0x1729F41 VA: 0x1729E40
	public Bounds get_LastBounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x136D30 Offset: 0x136E31 VA: 0x136D30
	// RVA: 0x1729E60 Offset: 0x1729F61 VA: 0x1729E60
	private void set_LastBounds(Bounds value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136D40 Offset: 0x136E41 VA: 0x136D40
	// RVA: 0x1729E80 Offset: 0x1729F81 VA: 0x1729E80
	public Matrix4x4 get_LastBoundsMatrix() { }

	[CompilerGeneratedAttribute] // RVA: 0x136D50 Offset: 0x136E51 VA: 0x136D50
	// RVA: 0x1729EB0 Offset: 0x1729FB1 VA: 0x1729EB0
	private void set_LastBoundsMatrix(Matrix4x4 value) { }

	// RVA: 0x1729ED0 Offset: 0x1729FD1 VA: 0x1729ED0 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0x1729F60 Offset: 0x172A061 VA: 0x1729F60 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x172B0E0 Offset: 0x172B1E1 VA: 0x172B0E0
	private float GetTargetHeight(Vector2 boundsSize) { }

	// RVA: 0x172AD20 Offset: 0x172AE21 VA: 0x172AD20
	private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, Matrix4x4 observer, out Vector3 newFwd) { }

	// RVA: 0x172B2B0 Offset: 0x172B3B1 VA: 0x172B2B0
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12EA40 Offset: 0x12EB41 VA: 0x12EA40
[AddComponentMenu] // RVA: 0x12EA40 Offset: 0x12EB41 VA: 0x12EA40
[SaveDuringPlayAttribute] // RVA: 0x12EA40 Offset: 0x12EB41 VA: 0x12EA40
public class CinemachineGroupComposer : CinemachineComposer // TypeDefIndex: 4789
{
	// Fields
	[SpaceAttribute] // RVA: 0x133100 Offset: 0x133201 VA: 0x133100
	[TooltipAttribute] // RVA: 0x133100 Offset: 0x133201 VA: 0x133100
	public float m_GroupFramingSize; // 0x128
	[TooltipAttribute] // RVA: 0x133150 Offset: 0x133251 VA: 0x133150
	public CinemachineGroupComposer.FramingMode m_FramingMode; // 0x12C
	[RangeAttribute] // RVA: 0x133190 Offset: 0x133291 VA: 0x133190
	[TooltipAttribute] // RVA: 0x133190 Offset: 0x133291 VA: 0x133190
	public float m_FrameDamping; // 0x130
	[TooltipAttribute] // RVA: 0x1331F0 Offset: 0x1332F1 VA: 0x1331F0
	public CinemachineGroupComposer.AdjustmentMode m_AdjustmentMode; // 0x134
	[TooltipAttribute] // RVA: 0x133230 Offset: 0x133331 VA: 0x133230
	public float m_MaxDollyIn; // 0x138
	[TooltipAttribute] // RVA: 0x133270 Offset: 0x133371 VA: 0x133270
	public float m_MaxDollyOut; // 0x13C
	[TooltipAttribute] // RVA: 0x1332B0 Offset: 0x1333B1 VA: 0x1332B0
	public float m_MinimumDistance; // 0x140
	[TooltipAttribute] // RVA: 0x1332F0 Offset: 0x1333F1 VA: 0x1332F0
	public float m_MaximumDistance; // 0x144
	[RangeAttribute] // RVA: 0x133330 Offset: 0x133431 VA: 0x133330
	[TooltipAttribute] // RVA: 0x133330 Offset: 0x133431 VA: 0x133330
	public float m_MinimumFOV; // 0x148
	[RangeAttribute] // RVA: 0x133390 Offset: 0x133491 VA: 0x133390
	[TooltipAttribute] // RVA: 0x133390 Offset: 0x133491 VA: 0x133390
	public float m_MaximumFOV; // 0x14C
	[TooltipAttribute] // RVA: 0x1333F0 Offset: 0x1334F1 VA: 0x1333F0
	public float m_MinimumOrthoSize; // 0x150
	[TooltipAttribute] // RVA: 0x133430 Offset: 0x133531 VA: 0x133430
	public float m_MaximumOrthoSize; // 0x154
	private float m_prevFramingDistance; // 0x158
	private float m_prevFOV; // 0x15C
	[CompilerGeneratedAttribute] // RVA: 0x133470 Offset: 0x133571 VA: 0x133470
	private Bounds <LastBounds>k__BackingField; // 0x160
	[CompilerGeneratedAttribute] // RVA: 0x133480 Offset: 0x133581 VA: 0x133480
	private Matrix4x4 <LastBoundsMatrix>k__BackingField; // 0x178

	// Properties
	public Bounds LastBounds { get; set; }
	public Matrix4x4 LastBoundsMatrix { get; set; }

	// Methods

	// RVA: 0x1729D10 Offset: 0x1729E11 VA: 0x1729D10
	private void OnValidate() { }

	[CompilerGeneratedAttribute] // RVA: 0x136D20 Offset: 0x136E21 VA: 0x136D20
	// RVA: 0x1729E40 Offset: 0x1729F41 VA: 0x1729E40
	public Bounds get_LastBounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x136D30 Offset: 0x136E31 VA: 0x136D30
	// RVA: 0x1729E60 Offset: 0x1729F61 VA: 0x1729E60
	private void set_LastBounds(Bounds value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136D40 Offset: 0x136E41 VA: 0x136D40
	// RVA: 0x1729E80 Offset: 0x1729F81 VA: 0x1729E80
	public Matrix4x4 get_LastBoundsMatrix() { }

	[CompilerGeneratedAttribute] // RVA: 0x136D50 Offset: 0x136E51 VA: 0x136D50
	// RVA: 0x1729EB0 Offset: 0x1729FB1 VA: 0x1729EB0
	private void set_LastBoundsMatrix(Matrix4x4 value) { }

	// RVA: 0x1729ED0 Offset: 0x1729FD1 VA: 0x1729ED0 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0x1729F60 Offset: 0x172A061 VA: 0x1729F60 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x172B0E0 Offset: 0x172B1E1 VA: 0x172B0E0
	private float GetTargetHeight(Vector2 boundsSize) { }

	// RVA: 0x172AD20 Offset: 0x172AE21 VA: 0x172AD20
	private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, Matrix4x4 observer, out Vector3 newFwd) { }

	// RVA: 0x172B2B0 Offset: 0x172B3B1 VA: 0x172B2B0
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12EA40 Offset: 0x12EB41 VA: 0x12EA40
[AddComponentMenu] // RVA: 0x12EA40 Offset: 0x12EB41 VA: 0x12EA40
[SaveDuringPlayAttribute] // RVA: 0x12EA40 Offset: 0x12EB41 VA: 0x12EA40
public class CinemachineGroupComposer : CinemachineComposer // TypeDefIndex: 4789
{
	// Fields
	[SpaceAttribute] // RVA: 0x133100 Offset: 0x133201 VA: 0x133100
	[TooltipAttribute] // RVA: 0x133100 Offset: 0x133201 VA: 0x133100
	public float m_GroupFramingSize; // 0x128
	[TooltipAttribute] // RVA: 0x133150 Offset: 0x133251 VA: 0x133150
	public CinemachineGroupComposer.FramingMode m_FramingMode; // 0x12C
	[RangeAttribute] // RVA: 0x133190 Offset: 0x133291 VA: 0x133190
	[TooltipAttribute] // RVA: 0x133190 Offset: 0x133291 VA: 0x133190
	public float m_FrameDamping; // 0x130
	[TooltipAttribute] // RVA: 0x1331F0 Offset: 0x1332F1 VA: 0x1331F0
	public CinemachineGroupComposer.AdjustmentMode m_AdjustmentMode; // 0x134
	[TooltipAttribute] // RVA: 0x133230 Offset: 0x133331 VA: 0x133230
	public float m_MaxDollyIn; // 0x138
	[TooltipAttribute] // RVA: 0x133270 Offset: 0x133371 VA: 0x133270
	public float m_MaxDollyOut; // 0x13C
	[TooltipAttribute] // RVA: 0x1332B0 Offset: 0x1333B1 VA: 0x1332B0
	public float m_MinimumDistance; // 0x140
	[TooltipAttribute] // RVA: 0x1332F0 Offset: 0x1333F1 VA: 0x1332F0
	public float m_MaximumDistance; // 0x144
	[RangeAttribute] // RVA: 0x133330 Offset: 0x133431 VA: 0x133330
	[TooltipAttribute] // RVA: 0x133330 Offset: 0x133431 VA: 0x133330
	public float m_MinimumFOV; // 0x148
	[RangeAttribute] // RVA: 0x133390 Offset: 0x133491 VA: 0x133390
	[TooltipAttribute] // RVA: 0x133390 Offset: 0x133491 VA: 0x133390
	public float m_MaximumFOV; // 0x14C
	[TooltipAttribute] // RVA: 0x1333F0 Offset: 0x1334F1 VA: 0x1333F0
	public float m_MinimumOrthoSize; // 0x150
	[TooltipAttribute] // RVA: 0x133430 Offset: 0x133531 VA: 0x133430
	public float m_MaximumOrthoSize; // 0x154
	private float m_prevFramingDistance; // 0x158
	private float m_prevFOV; // 0x15C
	[CompilerGeneratedAttribute] // RVA: 0x133470 Offset: 0x133571 VA: 0x133470
	private Bounds <LastBounds>k__BackingField; // 0x160
	[CompilerGeneratedAttribute] // RVA: 0x133480 Offset: 0x133581 VA: 0x133480
	private Matrix4x4 <LastBoundsMatrix>k__BackingField; // 0x178

	// Properties
	public Bounds LastBounds { get; set; }
	public Matrix4x4 LastBoundsMatrix { get; set; }

	// Methods

	// RVA: 0x1729D10 Offset: 0x1729E11 VA: 0x1729D10
	private void OnValidate() { }

	[CompilerGeneratedAttribute] // RVA: 0x136D20 Offset: 0x136E21 VA: 0x136D20
	// RVA: 0x1729E40 Offset: 0x1729F41 VA: 0x1729E40
	public Bounds get_LastBounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x136D30 Offset: 0x136E31 VA: 0x136D30
	// RVA: 0x1729E60 Offset: 0x1729F61 VA: 0x1729E60
	private void set_LastBounds(Bounds value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136D40 Offset: 0x136E41 VA: 0x136D40
	// RVA: 0x1729E80 Offset: 0x1729F81 VA: 0x1729E80
	public Matrix4x4 get_LastBoundsMatrix() { }

	[CompilerGeneratedAttribute] // RVA: 0x136D50 Offset: 0x136E51 VA: 0x136D50
	// RVA: 0x1729EB0 Offset: 0x1729FB1 VA: 0x1729EB0
	private void set_LastBoundsMatrix(Matrix4x4 value) { }

	// RVA: 0x1729ED0 Offset: 0x1729FD1 VA: 0x1729ED0 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0x1729F60 Offset: 0x172A061 VA: 0x1729F60 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x172B0E0 Offset: 0x172B1E1 VA: 0x172B0E0
	private float GetTargetHeight(Vector2 boundsSize) { }

	// RVA: 0x172AD20 Offset: 0x172AE21 VA: 0x172AD20
	private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, Matrix4x4 observer, out Vector3 newFwd) { }

	// RVA: 0x172B2B0 Offset: 0x172B3B1 VA: 0x172B2B0
	public void .ctor() { }
}

