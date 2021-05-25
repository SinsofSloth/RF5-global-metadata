public abstract class SRMonoBehaviour : MonoBehaviour // TypeDefIndex: 4298
{
	// Fields
	private Collider _collider; // 0x18
	private Transform _transform; // 0x20
	private Rigidbody _rigidBody; // 0x28
	private GameObject _gameObject; // 0x30
	private Rigidbody2D _rigidbody2D; // 0x38
	private Collider2D _collider2D; // 0x40

	// Properties
	public Transform CachedTransform { get; }
	public Collider CachedCollider { get; }
	public Collider2D CachedCollider2D { get; }
	public Rigidbody CachedRigidBody { get; }
	public Rigidbody2D CachedRigidBody2D { get; }
	public GameObject CachedGameObject { get; }
	public Transform transform { get; }

	// Methods

	[DebuggerStepThroughAttribute] // RVA: 0x127C30 Offset: 0x127D31 VA: 0x127C30
	[DebuggerNonUserCodeAttribute] // RVA: 0x127C30 Offset: 0x127D31 VA: 0x127C30
	// RVA: 0x1A81040 Offset: 0x1A81141 VA: 0x1A81040
	public Transform get_CachedTransform() { }

	[DebuggerStepThroughAttribute] // RVA: 0x127C70 Offset: 0x127D71 VA: 0x127C70
	[DebuggerNonUserCodeAttribute] // RVA: 0x127C70 Offset: 0x127D71 VA: 0x127C70
	// RVA: 0x1A810F0 Offset: 0x1A811F1 VA: 0x1A810F0
	public Collider get_CachedCollider() { }

	[DebuggerStepThroughAttribute] // RVA: 0x127CB0 Offset: 0x127DB1 VA: 0x127CB0
	[DebuggerNonUserCodeAttribute] // RVA: 0x127CB0 Offset: 0x127DB1 VA: 0x127CB0
	// RVA: 0x1A811A0 Offset: 0x1A812A1 VA: 0x1A811A0
	public Collider2D get_CachedCollider2D() { }

	[DebuggerStepThroughAttribute] // RVA: 0x127CF0 Offset: 0x127DF1 VA: 0x127CF0
	[DebuggerNonUserCodeAttribute] // RVA: 0x127CF0 Offset: 0x127DF1 VA: 0x127CF0
	// RVA: 0x1A81250 Offset: 0x1A81351 VA: 0x1A81250
	public Rigidbody get_CachedRigidBody() { }

	[DebuggerStepThroughAttribute] // RVA: 0x127D30 Offset: 0x127E31 VA: 0x127D30
	[DebuggerNonUserCodeAttribute] // RVA: 0x127D30 Offset: 0x127E31 VA: 0x127D30
	// RVA: 0x1A81300 Offset: 0x1A81401 VA: 0x1A81300
	public Rigidbody2D get_CachedRigidBody2D() { }

	[DebuggerStepThroughAttribute] // RVA: 0x127D70 Offset: 0x127E71 VA: 0x127D70
	[DebuggerNonUserCodeAttribute] // RVA: 0x127D70 Offset: 0x127E71 VA: 0x127D70
	// RVA: 0x1A813B0 Offset: 0x1A814B1 VA: 0x1A813B0
	public GameObject get_CachedGameObject() { }

	// RVA: 0x1A81460 Offset: 0x1A81561 VA: 0x1A81460
	public Transform get_transform() { }

	[DebuggerNonUserCodeAttribute] // RVA: 0x127DB0 Offset: 0x127EB1 VA: 0x127DB0
	[DebuggerStepThroughAttribute] // RVA: 0x127DB0 Offset: 0x127EB1 VA: 0x127DB0
	// RVA: 0x1A81510 Offset: 0x1A81611 VA: 0x1A81510
	protected void AssertNotNull(object value, string fieldName) { }

	[DebuggerNonUserCodeAttribute] // RVA: 0x127DF0 Offset: 0x127EF1 VA: 0x127DF0
	[DebuggerStepThroughAttribute] // RVA: 0x127DF0 Offset: 0x127EF1 VA: 0x127DF0
	// RVA: 0x1A81530 Offset: 0x1A81631 VA: 0x1A81530
	protected void Assert(bool condition, string message) { }

	[ConditionalAttribute] // RVA: 0x127E30 Offset: 0x127F31 VA: 0x127E30
	[DebuggerNonUserCodeAttribute] // RVA: 0x127E30 Offset: 0x127F31 VA: 0x127E30
	[DebuggerStepThroughAttribute] // RVA: 0x127E30 Offset: 0x127F31 VA: 0x127E30
	// RVA: 0x1A81550 Offset: 0x1A81651 VA: 0x1A81550
	protected void EditorAssertNotNull(object value, string fieldName) { }

	[ConditionalAttribute] // RVA: 0x127E90 Offset: 0x127F91 VA: 0x127E90
	[DebuggerNonUserCodeAttribute] // RVA: 0x127E90 Offset: 0x127F91 VA: 0x127E90
	[DebuggerStepThroughAttribute] // RVA: 0x127E90 Offset: 0x127F91 VA: 0x127E90
	// RVA: 0x1A81570 Offset: 0x1A81671 VA: 0x1A81570
	protected void EditorAssert(bool condition, string message) { }

	// RVA: 0x1A81590 Offset: 0x1A81691 VA: 0x1A81590
	protected void .ctor() { }
}

