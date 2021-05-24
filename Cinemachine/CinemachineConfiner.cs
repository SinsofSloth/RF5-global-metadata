[DocumentationSortingAttribute] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[AddComponentMenu] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[SaveDuringPlayAttribute] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[ExecuteAlways] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[DisallowMultipleComponent] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[HelpURLAttribute] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
public class CinemachineConfiner : CinemachineExtension // TypeDefIndex: 4746
{
	// Fields
	[TooltipAttribute] // RVA: 0x130610 Offset: 0x130711 VA: 0x130610
	public CinemachineConfiner.Mode m_ConfineMode; // 0x28
	[TooltipAttribute] // RVA: 0x130650 Offset: 0x130751 VA: 0x130650
	public Collider m_BoundingVolume; // 0x30
	[TooltipAttribute] // RVA: 0x130690 Offset: 0x130791 VA: 0x130690
	public Collider2D m_BoundingShape2D; // 0x38
	private Collider2D m_BoundingShape2DCache; // 0x40
	[TooltipAttribute] // RVA: 0x1306D0 Offset: 0x1307D1 VA: 0x1306D0
	public bool m_ConfineScreenEdges; // 0x48
	[TooltipAttribute] // RVA: 0x130710 Offset: 0x130811 VA: 0x130710
	[RangeAttribute] // RVA: 0x130710 Offset: 0x130811 VA: 0x130710
	public float m_Damping; // 0x4C
	private List<List<Vector2>> m_pathCache; // 0x50
	private int m_pathTotalPointCount; // 0x58

	// Properties
	public bool IsValid { get; }

	// Methods

	// RVA: 0x1899D80 Offset: 0x1899E81 VA: 0x1899D80
	public bool CameraWasDisplaced(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x1899E00 Offset: 0x1899F01 VA: 0x1899E00
	public float GetCameraDisplacementDistance(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x1899E70 Offset: 0x1899F71 VA: 0x1899E70
	private void OnValidate() { }

	// RVA: 0x1899EF0 Offset: 0x1899FF1 VA: 0x1899EF0 Slot: 7
	protected override void ConnectToVcam(bool connect) { }

	// RVA: 0x1899F00 Offset: 0x189A001 VA: 0x1899F00
	public bool get_IsValid() { }

	// RVA: 0x1899FE0 Offset: 0x189A0E1 VA: 0x1899FE0 Slot: 13
	public override float GetMaxDampTime() { }

	// RVA: 0x1899FF0 Offset: 0x189A0F1 VA: 0x1899FF0 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x189ACF0 Offset: 0x189ADF1 VA: 0x189ACF0
	public void InvalidatePathCache() { }

	// RVA: 0x189AD30 Offset: 0x189AE31 VA: 0x189AD30
	private bool ValidatePathCache() { }

	// RVA: 0x189A850 Offset: 0x189A951 VA: 0x189A850
	private Vector3 ConfinePoint(Vector3 camPos) { }

	// RVA: 0x189A2A0 Offset: 0x189A3A1 VA: 0x189A2A0
	private Vector3 ConfineScreenEdges(CinemachineVirtualCameraBase vcam, ref CameraState state) { }

	// RVA: 0x189B360 Offset: 0x189B461 VA: 0x189B360
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[AddComponentMenu] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[SaveDuringPlayAttribute] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[ExecuteAlways] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[DisallowMultipleComponent] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[HelpURLAttribute] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
public class CinemachineConfiner : CinemachineExtension // TypeDefIndex: 4746
{
	// Fields
	[TooltipAttribute] // RVA: 0x130610 Offset: 0x130711 VA: 0x130610
	public CinemachineConfiner.Mode m_ConfineMode; // 0x28
	[TooltipAttribute] // RVA: 0x130650 Offset: 0x130751 VA: 0x130650
	public Collider m_BoundingVolume; // 0x30
	[TooltipAttribute] // RVA: 0x130690 Offset: 0x130791 VA: 0x130690
	public Collider2D m_BoundingShape2D; // 0x38
	private Collider2D m_BoundingShape2DCache; // 0x40
	[TooltipAttribute] // RVA: 0x1306D0 Offset: 0x1307D1 VA: 0x1306D0
	public bool m_ConfineScreenEdges; // 0x48
	[TooltipAttribute] // RVA: 0x130710 Offset: 0x130811 VA: 0x130710
	[RangeAttribute] // RVA: 0x130710 Offset: 0x130811 VA: 0x130710
	public float m_Damping; // 0x4C
	private List<List<Vector2>> m_pathCache; // 0x50
	private int m_pathTotalPointCount; // 0x58

	// Properties
	public bool IsValid { get; }

	// Methods

	// RVA: 0x1899D80 Offset: 0x1899E81 VA: 0x1899D80
	public bool CameraWasDisplaced(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x1899E00 Offset: 0x1899F01 VA: 0x1899E00
	public float GetCameraDisplacementDistance(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x1899E70 Offset: 0x1899F71 VA: 0x1899E70
	private void OnValidate() { }

	// RVA: 0x1899EF0 Offset: 0x1899FF1 VA: 0x1899EF0 Slot: 7
	protected override void ConnectToVcam(bool connect) { }

	// RVA: 0x1899F00 Offset: 0x189A001 VA: 0x1899F00
	public bool get_IsValid() { }

	// RVA: 0x1899FE0 Offset: 0x189A0E1 VA: 0x1899FE0 Slot: 13
	public override float GetMaxDampTime() { }

	// RVA: 0x1899FF0 Offset: 0x189A0F1 VA: 0x1899FF0 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x189ACF0 Offset: 0x189ADF1 VA: 0x189ACF0
	public void InvalidatePathCache() { }

	// RVA: 0x189AD30 Offset: 0x189AE31 VA: 0x189AD30
	private bool ValidatePathCache() { }

	// RVA: 0x189A850 Offset: 0x189A951 VA: 0x189A850
	private Vector3 ConfinePoint(Vector3 camPos) { }

	// RVA: 0x189A2A0 Offset: 0x189A3A1 VA: 0x189A2A0
	private Vector3 ConfineScreenEdges(CinemachineVirtualCameraBase vcam, ref CameraState state) { }

	// RVA: 0x189B360 Offset: 0x189B461 VA: 0x189B360
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[AddComponentMenu] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[SaveDuringPlayAttribute] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[ExecuteAlways] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[DisallowMultipleComponent] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[HelpURLAttribute] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
public class CinemachineConfiner : CinemachineExtension // TypeDefIndex: 4746
{
	// Fields
	[TooltipAttribute] // RVA: 0x130610 Offset: 0x130711 VA: 0x130610
	public CinemachineConfiner.Mode m_ConfineMode; // 0x28
	[TooltipAttribute] // RVA: 0x130650 Offset: 0x130751 VA: 0x130650
	public Collider m_BoundingVolume; // 0x30
	[TooltipAttribute] // RVA: 0x130690 Offset: 0x130791 VA: 0x130690
	public Collider2D m_BoundingShape2D; // 0x38
	private Collider2D m_BoundingShape2DCache; // 0x40
	[TooltipAttribute] // RVA: 0x1306D0 Offset: 0x1307D1 VA: 0x1306D0
	public bool m_ConfineScreenEdges; // 0x48
	[TooltipAttribute] // RVA: 0x130710 Offset: 0x130811 VA: 0x130710
	[RangeAttribute] // RVA: 0x130710 Offset: 0x130811 VA: 0x130710
	public float m_Damping; // 0x4C
	private List<List<Vector2>> m_pathCache; // 0x50
	private int m_pathTotalPointCount; // 0x58

	// Properties
	public bool IsValid { get; }

	// Methods

	// RVA: 0x1899D80 Offset: 0x1899E81 VA: 0x1899D80
	public bool CameraWasDisplaced(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x1899E00 Offset: 0x1899F01 VA: 0x1899E00
	public float GetCameraDisplacementDistance(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x1899E70 Offset: 0x1899F71 VA: 0x1899E70
	private void OnValidate() { }

	// RVA: 0x1899EF0 Offset: 0x1899FF1 VA: 0x1899EF0 Slot: 7
	protected override void ConnectToVcam(bool connect) { }

	// RVA: 0x1899F00 Offset: 0x189A001 VA: 0x1899F00
	public bool get_IsValid() { }

	// RVA: 0x1899FE0 Offset: 0x189A0E1 VA: 0x1899FE0 Slot: 13
	public override float GetMaxDampTime() { }

	// RVA: 0x1899FF0 Offset: 0x189A0F1 VA: 0x1899FF0 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x189ACF0 Offset: 0x189ADF1 VA: 0x189ACF0
	public void InvalidatePathCache() { }

	// RVA: 0x189AD30 Offset: 0x189AE31 VA: 0x189AD30
	private bool ValidatePathCache() { }

	// RVA: 0x189A850 Offset: 0x189A951 VA: 0x189A850
	private Vector3 ConfinePoint(Vector3 camPos) { }

	// RVA: 0x189A2A0 Offset: 0x189A3A1 VA: 0x189A2A0
	private Vector3 ConfineScreenEdges(CinemachineVirtualCameraBase vcam, ref CameraState state) { }

	// RVA: 0x189B360 Offset: 0x189B461 VA: 0x189B360
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[AddComponentMenu] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[SaveDuringPlayAttribute] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[ExecuteAlways] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[DisallowMultipleComponent] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[HelpURLAttribute] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
public class CinemachineConfiner : CinemachineExtension // TypeDefIndex: 4746
{
	// Fields
	[TooltipAttribute] // RVA: 0x130610 Offset: 0x130711 VA: 0x130610
	public CinemachineConfiner.Mode m_ConfineMode; // 0x28
	[TooltipAttribute] // RVA: 0x130650 Offset: 0x130751 VA: 0x130650
	public Collider m_BoundingVolume; // 0x30
	[TooltipAttribute] // RVA: 0x130690 Offset: 0x130791 VA: 0x130690
	public Collider2D m_BoundingShape2D; // 0x38
	private Collider2D m_BoundingShape2DCache; // 0x40
	[TooltipAttribute] // RVA: 0x1306D0 Offset: 0x1307D1 VA: 0x1306D0
	public bool m_ConfineScreenEdges; // 0x48
	[TooltipAttribute] // RVA: 0x130710 Offset: 0x130811 VA: 0x130710
	[RangeAttribute] // RVA: 0x130710 Offset: 0x130811 VA: 0x130710
	public float m_Damping; // 0x4C
	private List<List<Vector2>> m_pathCache; // 0x50
	private int m_pathTotalPointCount; // 0x58

	// Properties
	public bool IsValid { get; }

	// Methods

	// RVA: 0x1899D80 Offset: 0x1899E81 VA: 0x1899D80
	public bool CameraWasDisplaced(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x1899E00 Offset: 0x1899F01 VA: 0x1899E00
	public float GetCameraDisplacementDistance(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x1899E70 Offset: 0x1899F71 VA: 0x1899E70
	private void OnValidate() { }

	// RVA: 0x1899EF0 Offset: 0x1899FF1 VA: 0x1899EF0 Slot: 7
	protected override void ConnectToVcam(bool connect) { }

	// RVA: 0x1899F00 Offset: 0x189A001 VA: 0x1899F00
	public bool get_IsValid() { }

	// RVA: 0x1899FE0 Offset: 0x189A0E1 VA: 0x1899FE0 Slot: 13
	public override float GetMaxDampTime() { }

	// RVA: 0x1899FF0 Offset: 0x189A0F1 VA: 0x1899FF0 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x189ACF0 Offset: 0x189ADF1 VA: 0x189ACF0
	public void InvalidatePathCache() { }

	// RVA: 0x189AD30 Offset: 0x189AE31 VA: 0x189AD30
	private bool ValidatePathCache() { }

	// RVA: 0x189A850 Offset: 0x189A951 VA: 0x189A850
	private Vector3 ConfinePoint(Vector3 camPos) { }

	// RVA: 0x189A2A0 Offset: 0x189A3A1 VA: 0x189A2A0
	private Vector3 ConfineScreenEdges(CinemachineVirtualCameraBase vcam, ref CameraState state) { }

	// RVA: 0x189B360 Offset: 0x189B461 VA: 0x189B360
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[AddComponentMenu] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[SaveDuringPlayAttribute] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[ExecuteAlways] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[DisallowMultipleComponent] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[HelpURLAttribute] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
public class CinemachineConfiner : CinemachineExtension // TypeDefIndex: 4746
{
	// Fields
	[TooltipAttribute] // RVA: 0x130610 Offset: 0x130711 VA: 0x130610
	public CinemachineConfiner.Mode m_ConfineMode; // 0x28
	[TooltipAttribute] // RVA: 0x130650 Offset: 0x130751 VA: 0x130650
	public Collider m_BoundingVolume; // 0x30
	[TooltipAttribute] // RVA: 0x130690 Offset: 0x130791 VA: 0x130690
	public Collider2D m_BoundingShape2D; // 0x38
	private Collider2D m_BoundingShape2DCache; // 0x40
	[TooltipAttribute] // RVA: 0x1306D0 Offset: 0x1307D1 VA: 0x1306D0
	public bool m_ConfineScreenEdges; // 0x48
	[TooltipAttribute] // RVA: 0x130710 Offset: 0x130811 VA: 0x130710
	[RangeAttribute] // RVA: 0x130710 Offset: 0x130811 VA: 0x130710
	public float m_Damping; // 0x4C
	private List<List<Vector2>> m_pathCache; // 0x50
	private int m_pathTotalPointCount; // 0x58

	// Properties
	public bool IsValid { get; }

	// Methods

	// RVA: 0x1899D80 Offset: 0x1899E81 VA: 0x1899D80
	public bool CameraWasDisplaced(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x1899E00 Offset: 0x1899F01 VA: 0x1899E00
	public float GetCameraDisplacementDistance(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x1899E70 Offset: 0x1899F71 VA: 0x1899E70
	private void OnValidate() { }

	// RVA: 0x1899EF0 Offset: 0x1899FF1 VA: 0x1899EF0 Slot: 7
	protected override void ConnectToVcam(bool connect) { }

	// RVA: 0x1899F00 Offset: 0x189A001 VA: 0x1899F00
	public bool get_IsValid() { }

	// RVA: 0x1899FE0 Offset: 0x189A0E1 VA: 0x1899FE0 Slot: 13
	public override float GetMaxDampTime() { }

	// RVA: 0x1899FF0 Offset: 0x189A0F1 VA: 0x1899FF0 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x189ACF0 Offset: 0x189ADF1 VA: 0x189ACF0
	public void InvalidatePathCache() { }

	// RVA: 0x189AD30 Offset: 0x189AE31 VA: 0x189AD30
	private bool ValidatePathCache() { }

	// RVA: 0x189A850 Offset: 0x189A951 VA: 0x189A850
	private Vector3 ConfinePoint(Vector3 camPos) { }

	// RVA: 0x189A2A0 Offset: 0x189A3A1 VA: 0x189A2A0
	private Vector3 ConfineScreenEdges(CinemachineVirtualCameraBase vcam, ref CameraState state) { }

	// RVA: 0x189B360 Offset: 0x189B461 VA: 0x189B360
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[AddComponentMenu] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[SaveDuringPlayAttribute] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[ExecuteAlways] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[DisallowMultipleComponent] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
[HelpURLAttribute] // RVA: 0x12E030 Offset: 0x12E131 VA: 0x12E030
public class CinemachineConfiner : CinemachineExtension // TypeDefIndex: 4746
{
	// Fields
	[TooltipAttribute] // RVA: 0x130610 Offset: 0x130711 VA: 0x130610
	public CinemachineConfiner.Mode m_ConfineMode; // 0x28
	[TooltipAttribute] // RVA: 0x130650 Offset: 0x130751 VA: 0x130650
	public Collider m_BoundingVolume; // 0x30
	[TooltipAttribute] // RVA: 0x130690 Offset: 0x130791 VA: 0x130690
	public Collider2D m_BoundingShape2D; // 0x38
	private Collider2D m_BoundingShape2DCache; // 0x40
	[TooltipAttribute] // RVA: 0x1306D0 Offset: 0x1307D1 VA: 0x1306D0
	public bool m_ConfineScreenEdges; // 0x48
	[TooltipAttribute] // RVA: 0x130710 Offset: 0x130811 VA: 0x130710
	[RangeAttribute] // RVA: 0x130710 Offset: 0x130811 VA: 0x130710
	public float m_Damping; // 0x4C
	private List<List<Vector2>> m_pathCache; // 0x50
	private int m_pathTotalPointCount; // 0x58

	// Properties
	public bool IsValid { get; }

	// Methods

	// RVA: 0x1899D80 Offset: 0x1899E81 VA: 0x1899D80
	public bool CameraWasDisplaced(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x1899E00 Offset: 0x1899F01 VA: 0x1899E00
	public float GetCameraDisplacementDistance(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x1899E70 Offset: 0x1899F71 VA: 0x1899E70
	private void OnValidate() { }

	// RVA: 0x1899EF0 Offset: 0x1899FF1 VA: 0x1899EF0 Slot: 7
	protected override void ConnectToVcam(bool connect) { }

	// RVA: 0x1899F00 Offset: 0x189A001 VA: 0x1899F00
	public bool get_IsValid() { }

	// RVA: 0x1899FE0 Offset: 0x189A0E1 VA: 0x1899FE0 Slot: 13
	public override float GetMaxDampTime() { }

	// RVA: 0x1899FF0 Offset: 0x189A0F1 VA: 0x1899FF0 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x189ACF0 Offset: 0x189ADF1 VA: 0x189ACF0
	public void InvalidatePathCache() { }

	// RVA: 0x189AD30 Offset: 0x189AE31 VA: 0x189AD30
	private bool ValidatePathCache() { }

	// RVA: 0x189A850 Offset: 0x189A951 VA: 0x189A850
	private Vector3 ConfinePoint(Vector3 camPos) { }

	// RVA: 0x189A2A0 Offset: 0x189A3A1 VA: 0x189A2A0
	private Vector3 ConfineScreenEdges(CinemachineVirtualCameraBase vcam, ref CameraState state) { }

	// RVA: 0x189B360 Offset: 0x189B461 VA: 0x189B360
	public void .ctor() { }
}

