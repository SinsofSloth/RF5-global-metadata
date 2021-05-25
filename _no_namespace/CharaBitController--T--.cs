public abstract class CharaBitController<T> : BitController // TypeDefIndex: 6577
{
	// Fields
	[SerializeField] // RVA: 0x15D7E0 Offset: 0x15D8E1 VA: 0x15D7E0
	protected T chara; // 0x0
	private const EffectID m_AppearEffectID = 2017;
	private static Vector3 m_AppearOffset; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected override void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2572E80 Offset: 0x2572F81 VA: 0x2572E80
	|-CharaBitController<HumanController>.Awake
	|-CharaBitController<object>.Awake
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected virtual void OnEnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2572F50 Offset: 0x2573051 VA: 0x2572F50
	|-CharaBitController<HumanController>.OnEnable
	|-CharaBitController<object>.OnEnable
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected virtual void OnDisable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2573020 Offset: 0x2573121 VA: 0x2573020
	|-CharaBitController<HumanController>.OnDisable
	|-CharaBitController<object>.OnDisable
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override bool DoCall(BitID bitID, int level) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25730F0 Offset: 0x25731F1 VA: 0x25730F0
	|-CharaBitController<HumanController>.DoCall
	|-CharaBitController<object>.DoCall
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25734E0 Offset: 0x25735E1 VA: 0x25734E0
	|-CharaBitController<HumanController>..ctor
	|-CharaBitController<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2573500 Offset: 0x2573601 VA: 0x2573500
	|-CharaBitController<object>..cctor
	*/
}

