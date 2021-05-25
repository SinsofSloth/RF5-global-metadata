[DefaultMemberAttribute] // RVA: 0x11DF80 Offset: 0x11E081 VA: 0x11DF80
public class VisualElement : Focusable, ITransform, IResolvedStyle // TypeDefIndex: 4136
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x11E6E0 Offset: 0x11E7E1 VA: 0x11E6E0
	[CompilerGeneratedAttribute] // RVA: 0x11E6E0 Offset: 0x11E7E1 VA: 0x11E6E0
	private bool <isCompositeRoot>k__BackingField; // 0x1A
	private static List<string> s_EmptyClassList; // 0x0
	internal static readonly PropertyName userDataPropertyKey; // 0x8
	public static readonly string disabledUssClassName; // 0x10
	private Vector3 m_Position; // 0x1C
	private Quaternion m_Rotation; // 0x28
	private Vector3 m_Scale; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x11E720 Offset: 0x11E821 VA: 0x11E720
	[DebuggerBrowsableAttribute] // RVA: 0x11E720 Offset: 0x11E821 VA: 0x11E720
	private bool <isLayoutManual>k__BackingField; // 0x44
	private Rect m_Layout; // 0x48
	internal bool isBoundingBoxDirty; // 0x58
	private Rect m_BoundingBox; // 0x5C
	internal bool isWorldBoundingBoxDirty; // 0x6C
	private Rect m_WorldBoundingBox; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x11E760 Offset: 0x11E861 VA: 0x11E760
	[DebuggerBrowsableAttribute] // RVA: 0x11E760 Offset: 0x11E861 VA: 0x11E760
	private bool <isWorldTransformDirty>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x11E7A0 Offset: 0x11E8A1 VA: 0x11E7A0
	[DebuggerBrowsableAttribute] // RVA: 0x11E7A0 Offset: 0x11E8A1 VA: 0x11E7A0
	private bool <isWorldTransformInverseDirty>k__BackingField; // 0x81
	private Matrix4x4 m_WorldTransformCache; // 0x84
	private Matrix4x4 m_WorldTransformInverseCache; // 0xC4
	private static readonly Rect s_InfiniteRect; // 0x18
	private PseudoStates m_PseudoStates; // 0x104
	[CompilerGeneratedAttribute] // RVA: 0x11E7E0 Offset: 0x11E8E1 VA: 0x11E7E0
	[DebuggerBrowsableAttribute] // RVA: 0x11E7E0 Offset: 0x11E8E1 VA: 0x11E7E0
	private PickingMode <pickingMode>k__BackingField; // 0x108
	[CompilerGeneratedAttribute] // RVA: 0x11E820 Offset: 0x11E921 VA: 0x11E820
	[DebuggerBrowsableAttribute] // RVA: 0x11E820 Offset: 0x11E921 VA: 0x11E820
	private YogaNode <yogaNode>k__BackingField; // 0x110
	internal VisualElementStylesData m_Style; // 0x118
	private InheritedStylesData m_InheritedStylesData; // 0x120
	[CompilerGeneratedAttribute] // RVA: 0x11E860 Offset: 0x11E961 VA: 0x11E860
	[DebuggerBrowsableAttribute] // RVA: 0x11E860 Offset: 0x11E961 VA: 0x11E860
	private ComputedStyle <computedStyle>k__BackingField; // 0x128
	internal int imguiContainerDescendantCount; // 0x130
	[DebuggerBrowsableAttribute] // RVA: 0x11E8A0 Offset: 0x11E9A1 VA: 0x11E8A0
	[CompilerGeneratedAttribute] // RVA: 0x11E8A0 Offset: 0x11E9A1 VA: 0x11E8A0
	private VisualElement.Hierarchy <hierarchy>k__BackingField; // 0x138
	private VisualElement m_PhysicalParent; // 0x140
	private static readonly List<VisualElement> s_EmptyList; // 0x28
	private List<VisualElement> m_Children; // 0x148
	[CompilerGeneratedAttribute] // RVA: 0x11E8E0 Offset: 0x11E9E1 VA: 0x11E8E0
	[DebuggerBrowsableAttribute] // RVA: 0x11E8E0 Offset: 0x11E9E1 VA: 0x11E8E0
	private BaseVisualElementPanel <elementPanel>k__BackingField; // 0x150

	// Properties
	internal bool isCompositeRoot { get; }
	public override FocusController focusController { get; }
	public ITransform transform { get; }
	private Matrix4x4 UnityEngine.UIElements.ITransform.matrix { get; }
	internal bool isLayoutManual { get; }
	public Rect layout { get; }
	internal Rect boundingBox { get; }
	internal Rect worldBoundingBox { get; }
	public Rect worldBound { get; }
	internal Rect rect { get; }
	internal bool isWorldTransformDirty { get; set; }
	internal bool isWorldTransformInverseDirty { get; set; }
	public Matrix4x4 worldTransform { get; }
	internal Matrix4x4 worldTransformInverse { get; }
	internal PseudoStates pseudoStates { get; }
	public PickingMode pickingMode { get; }
	internal YogaNode yogaNode { get; }
	internal VisualElementStylesData specifiedStyle { get; }
	internal InheritedStylesData inheritedStyle { get; }
	internal ComputedStyle computedStyle { get; }
	public bool enabledInHierarchy { get; }
	public bool visible { get; }
	public VisualElement.Hierarchy hierarchy { get; }
	internal BaseVisualElementPanel elementPanel { get; }
	public IPanel panel { get; }
	public IResolvedStyle resolvedStyle { get; }
	private Visibility UnityEngine.UIElements.IResolvedStyle.visibility { get; }
	private DisplayStyle UnityEngine.UIElements.IResolvedStyle.display { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x11F950 Offset: 0x11FA51 VA: 0x11F950
	// RVA: 0x15CE140 Offset: 0x15CE241 VA: 0x15CE140
	internal bool get_isCompositeRoot() { }

	// RVA: 0x15CE150 Offset: 0x15CE251 VA: 0x15CE150 Slot: 12
	public override FocusController get_focusController() { }

	// RVA: 0x15CE210 Offset: 0x15CE311 VA: 0x15CE210
	public ITransform get_transform() { }

	// RVA: 0x15CE220 Offset: 0x15CE321 VA: 0x15CE220 Slot: 14
	private Matrix4x4 UnityEngine.UIElements.ITransform.get_matrix() { }

	[CompilerGeneratedAttribute] // RVA: 0x11F960 Offset: 0x11FA61 VA: 0x11F960
	// RVA: 0x15CE350 Offset: 0x15CE451 VA: 0x15CE350
	internal bool get_isLayoutManual() { }

	// RVA: 0x15C0DA0 Offset: 0x15C0EA1 VA: 0x15C0DA0
	public Rect get_layout() { }

	// RVA: 0x15CE360 Offset: 0x15CE461 VA: 0x15CE360
	internal static Rect TransformAlignedRect(Matrix4x4 lhc, Rect rect) { }

	// RVA: 0x15CE4F0 Offset: 0x15CE5F1 VA: 0x15CE4F0
	internal static Vector2 MultiplyMatrix44Point2(Matrix4x4 lhs, Vector2 point) { }

	// RVA: 0x15CE530 Offset: 0x15CE631 VA: 0x15CE530
	internal Rect get_boundingBox() { }

	// RVA: 0x15C4760 Offset: 0x15C4861 VA: 0x15C4760
	internal Rect get_worldBoundingBox() { }

	// RVA: 0x15CE570 Offset: 0x15CE671 VA: 0x15CE570
	internal void UpdateBoundingBox() { }

	// RVA: 0x15CEA60 Offset: 0x15CEB61 VA: 0x15CEA60
	internal void UpdateWorldBoundingBox() { }

	// RVA: 0x15C0F70 Offset: 0x15C1071 VA: 0x15C0F70
	public Rect get_worldBound() { }

	// RVA: 0x15CEB80 Offset: 0x15CEC81 VA: 0x15CEB80
	internal Rect get_rect() { }

	[CompilerGeneratedAttribute] // RVA: 0x11F970 Offset: 0x11FA71 VA: 0x11F970
	// RVA: 0x15CEC10 Offset: 0x15CED11 VA: 0x15CEC10
	internal bool get_isWorldTransformDirty() { }

	[CompilerGeneratedAttribute] // RVA: 0x11F980 Offset: 0x11FA81 VA: 0x11F980
	// RVA: 0x15CEC20 Offset: 0x15CED21 VA: 0x15CEC20
	internal void set_isWorldTransformDirty(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11F990 Offset: 0x11FA91 VA: 0x11F990
	// RVA: 0x15CEC30 Offset: 0x15CED31 VA: 0x15CEC30
	internal bool get_isWorldTransformInverseDirty() { }

	[CompilerGeneratedAttribute] // RVA: 0x11F9A0 Offset: 0x11FAA1 VA: 0x11F9A0
	// RVA: 0x15CEC40 Offset: 0x15CED41 VA: 0x15CEC40
	internal void set_isWorldTransformInverseDirty(bool value) { }

	// RVA: 0x15C10D0 Offset: 0x15C11D1 VA: 0x15C10D0
	public Matrix4x4 get_worldTransform() { }

	// RVA: 0x15CF0C0 Offset: 0x15CF1C1 VA: 0x15CF0C0
	internal Matrix4x4 get_worldTransformInverse() { }

	// RVA: 0x15CEC50 Offset: 0x15CED51 VA: 0x15CEC50
	private void UpdateWorldTransform() { }

	// RVA: 0x15CF200 Offset: 0x15CF301 VA: 0x15CF200
	internal PseudoStates get_pseudoStates() { }

	[CompilerGeneratedAttribute] // RVA: 0x11F9B0 Offset: 0x11FAB1 VA: 0x11F9B0
	// RVA: 0x15CF210 Offset: 0x15CF311 VA: 0x15CF210
	public PickingMode get_pickingMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x11F9C0 Offset: 0x11FAC1 VA: 0x11F9C0
	// RVA: 0x15CF220 Offset: 0x15CF321 VA: 0x15CF220
	internal YogaNode get_yogaNode() { }

	// RVA: 0x15B9560 Offset: 0x15B9661 VA: 0x15B9560
	internal VisualElementStylesData get_specifiedStyle() { }

	// RVA: 0x15B9590 Offset: 0x15B9691 VA: 0x15B9590
	internal InheritedStylesData get_inheritedStyle() { }

	[CompilerGeneratedAttribute] // RVA: 0x11F9D0 Offset: 0x11FAD1 VA: 0x11F9D0
	// RVA: 0x15CF230 Offset: 0x15CF331 VA: 0x15CF230
	internal ComputedStyle get_computedStyle() { }

	// RVA: 0x15CF240 Offset: 0x15CF341 VA: 0x15CF240 Slot: 6
	public sealed override void SendEvent(EventBase e) { }

	// RVA: 0x15B67D0 Offset: 0x15B68D1 VA: 0x15B67D0
	internal void IncrementVersion(VersionChangeType changeType) { }

	// RVA: 0x15C4940 Offset: 0x15C4A41 VA: 0x15C4940
	public bool get_enabledInHierarchy() { }

	// RVA: 0x15C4880 Offset: 0x15C4981 VA: 0x15C4880
	public bool get_visible() { }

	// RVA: 0x15CF260 Offset: 0x15CF361 VA: 0x15CF260 Slot: 17
	public virtual bool ContainsPoint(Vector2 localPoint) { }

	[CompilerGeneratedAttribute] // RVA: 0x11F9E0 Offset: 0x11FAE1 VA: 0x11F9E0
	// RVA: 0x15CF320 Offset: 0x15CF421 VA: 0x15CF320
	public VisualElement.Hierarchy get_hierarchy() { }

	// RVA: 0x15C47A0 Offset: 0x15C48A1 VA: 0x15C47A0
	internal bool ShouldClip() { }

	[CompilerGeneratedAttribute] // RVA: 0x11F9F0 Offset: 0x11FAF1 VA: 0x11F9F0
	// RVA: 0x15CF330 Offset: 0x15CF431 VA: 0x15CF330
	internal BaseVisualElementPanel get_elementPanel() { }

	// RVA: 0x15C03C0 Offset: 0x15C04C1 VA: 0x15C03C0
	public IPanel get_panel() { }

	// RVA: 0x15BE730 Offset: 0x15BE831 VA: 0x15BE730
	internal VisualElement RetargetElement(VisualElement retargetAgainst) { }

	// RVA: 0x15C4750 Offset: 0x15C4851 VA: 0x15C4750
	public IResolvedStyle get_resolvedStyle() { }

	// RVA: 0x15CF340 Offset: 0x15CF441 VA: 0x15CF340 Slot: 15
	private Visibility UnityEngine.UIElements.IResolvedStyle.get_visibility() { }

	// RVA: 0x15CF3C0 Offset: 0x15CF4C1 VA: 0x15CF3C0 Slot: 16
	private DisplayStyle UnityEngine.UIElements.IResolvedStyle.get_display() { }

	// RVA: 0x15CF490 Offset: 0x15CF591 VA: 0x15CF490
	private static void .cctor() { }
}

